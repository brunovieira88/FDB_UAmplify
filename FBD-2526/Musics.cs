using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBD_2526
{
    public partial class Musics : Form
    {
        private int UserId;
        private string connectionString =
            "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;" +
            "Initial Catalog=p1g3;" +
            "User ID=p1g3;" +
            "Password=AD9CRu)XY8K;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";

        public Musics(int userId)
        {
            this.UserId = userId;
            InitializeComponent();
            this.Load += Musics_Load;
            dgvMusics.CellFormatting += dgvMusics_CellFormatting;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            dgvMusics.CellContentClick += dgvMusics_CellContentClick;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == "Search for songs...")
            {
                SearchMusics("");
            }
            else
            {
                SearchMusics(txtSearch.Text);
            }
        }

        private void SearchMusics(string txtSearch)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("uamplify.SearchMusic", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@txt", txtSearch);
                    SqlDataReader reader = cmd.ExecuteReader();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Load(reader);

                    dgvMusics.Columns.Clear();
                    dgvMusics.DataSource = dt;
                    dgvMusics.Columns["id"].Visible = false;

                    //criar botao de play
                    DataGridViewButtonColumn playBtn = new DataGridViewButtonColumn();
                    playBtn.Name = "PlayAction";
                    playBtn.HeaderText = "Play";
                    playBtn.Text = "▶";
                    playBtn.UseColumnTextForButtonValue = true;
                    dgvMusics.Columns.Add(playBtn);
                    dgvMusics.Columns["PlayAction"].Width = 50;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar à base de dados:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void dgvMusics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMusics.Columns[e.ColumnIndex].Name == "PlayAction")
            {
                int musicId = Convert.ToInt32(dgvMusics.Rows[e.RowIndex].Cells["id"].Value);
                string musicName = dgvMusics.Rows[e.RowIndex].Cells["Music"].Value.ToString();

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
                MessageBox.Show("erro ao registar play: " + ex.Message);
            }
        }
        private void Musics_Load(object sender, EventArgs e)
        {
            SearchMusics("");
        }

        private void dgvMusics_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMusics.Columns[e.ColumnIndex].Name == "Duration" && e.Value != null)
            {
                int seconds = Convert.ToInt32(e.Value);
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                e.Value = time.ToString(@"mm\:ss");
                e.FormattingApplied = true;
            }

            if (dgvMusics.Columns[e.ColumnIndex].Name == "Release Date" && e.Value != null)
            {
                DateTime date = Convert.ToDateTime(e.Value);
                e.Value = date.ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search for songs...") txtSearch.Text = "";
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") txtSearch.Text = "Search for songs...";
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(UserId);
            editProfile.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(UserId);
            home.Show();
            this.Hide();
        }

        private void Musics_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Musics_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            Albums albums = new Albums(UserId);
            albums.Show();
            this.Hide();
        }

        private void dgvMusics_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            Playlists playlists = new Playlists(UserId);
            playlists.Show();
            this.Hide();
        }

        private void btnCommunity_Click(object sender, EventArgs e)
        {
            Listeners listeners = new Listeners(UserId);
            listeners.Show();
            this.Hide();
        }
    }
}
