using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FBD_2526
{
    public partial class PlaylistDetails : Form
    {
        private int UserId;
        private int PlaylistId;
        private string connectionString =
                    "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;" +
                    "Initial Catalog=p1g3;" +
                    "User ID=p1g3;" +
                    "Password=AD9CRu)XY8K;" +
                    "Encrypt=True;" +
                    "TrustServerCertificate=True;";

        public PlaylistDetails(int userId, int playlistId, string playlistName, string ownerName)
        {
            this.UserId = userId;
            this.PlaylistId = playlistId;
            InitializeComponent();

            lblTitle.Text = playlistName;
            lblOwner.Text = "Created by " + ownerName;

            dgvSongs.CellFormatting += DgvSongs_CellFormatting;
            dgvSongs.CellContentClick += dgvSongs_CellContentClick;


            LoadSongs();
        }

        private void dgvSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSongs.Columns[e.ColumnIndex].Name == "PlayAction")
            {
                int musicId = Convert.ToInt32(dgvSongs.Rows[e.RowIndex].Cells["id"].Value);
                string musicName = dgvSongs.Rows[e.RowIndex].Cells["Track Title"].Value.ToString();

                RegistarPlayNaBaseDeDados(musicId);

                MessageBox.Show($"A tocar: {musicName}");
            }
        }
        private void RegistarPlayNaBaseDeDados(int musicId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("uamplify.RegisterPlay", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", this.UserId);
                    cmd.Parameters.AddWithValue("@MusicId", musicId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao registar play: ");
            }
        }

        private void LoadSongs()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("uamplify.GetPlaylistSongs", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PlaylistId", this.PlaylistId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dgvSongs.Columns.Clear();
                    dgvSongs.DataSource = dt;
                    dgvSongs.Columns["id"].Visible = false;

                    //criar botao de play
                    DataGridViewButtonColumn playBtn = new DataGridViewButtonColumn();
                    playBtn.Name = "PlayAction";
                    playBtn.HeaderText = "Play";
                    playBtn.Text = "▶";
                    playBtn.UseColumnTextForButtonValue = true;
                    dgvSongs.Columns.Add(playBtn);
                    dgvSongs.Columns["PlayAction"].Width = 50;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error loading playlist tracks: ");
            }
        }

        private void DgvSongs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSongs.Columns[e.ColumnIndex].Name == "Duration" && e.Value != null)
            {
                int seconds = Convert.ToInt32(e.Value);
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                e.Value = time.ToString(@"mm\:ss");
                e.FormattingApplied = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}