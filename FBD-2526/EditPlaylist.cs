using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FBD_2526
{
    public partial class EditPlaylist : Form
    {
        private int PlaylistId;
        private string connectionString =
                            "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;" +
                            "Initial Catalog=p1g3;" +
                            "User ID=p1g3;" +
                            "Password=AD9CRu)XY8K;" +
                            "Encrypt=True;" +
                            "TrustServerCertificate=True;";
        public EditPlaylist(int playlistId, string currentName, string currentDesc)
        {
            this.PlaylistId = playlistId;
            InitializeComponent();
            txtName.Text = currentName;
            txtDescription.Text = currentDesc;
            LoadPlaylistSongs();
            SearchAllMusics("");
            dgvAllMusics.CellFormatting += DgvAllMusics_CellFormatting;
            dgvInPlaylist.CellFormatting += DgvInPlaylist_CellFormatting;
            
        }

        private void LoadPlaylistSongs()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("uamplify.GetPlaylistSongs", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PlaylistId", this.PlaylistId);

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    dgvInPlaylist.Columns.Clear();
                    dgvInPlaylist.DataSource = dt;
                    if (dgvInPlaylist.Columns.Contains("id")) dgvInPlaylist.Columns["id"].Visible = false;

                    DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
                    btnRemove.Name = "RemoveAction";
                    btnRemove.HeaderText = "";
                    btnRemove.Text = "🗑️";
                    btnRemove.UseColumnTextForButtonValue = true;
                    dgvInPlaylist.Columns.Add(btnRemove);
                    dgvInPlaylist.Columns["RemoveAction"].Width = 50;
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }

        private void SearchAllMusics(string txt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("uamplify.SearchMusic", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@txt", txt);

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    dgvAllMusics.Columns.Clear();
                    dgvAllMusics.DataSource = dt;
                    if (dgvAllMusics.Columns.Contains("id")) dgvAllMusics.Columns["id"].Visible = false;

                    DataGridViewButtonColumn btnAdd = new DataGridViewButtonColumn();
                    btnAdd.Name = "AddAction";
                    btnAdd.HeaderText = "";
                    btnAdd.Text = "➕";
                    btnAdd.UseColumnTextForButtonValue = true;
                    dgvAllMusics.Columns.Add(btnAdd);
                    dgvAllMusics.Columns["AddAction"].Width = 50;
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }

        private void dgvAllMusics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAllMusics.Columns[e.ColumnIndex].Name == "AddAction")
            {
                int idMusic = Convert.ToInt32(dgvAllMusics.Rows[e.RowIndex].Cells["id"].Value);
                ExecuteSP("uamplify.AddMusicToPlaylist", idMusic);
                LoadPlaylistSongs();
            }
        }

        private void dgvInPlaylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvInPlaylist.Columns[e.ColumnIndex].Name == "RemoveAction")
            {
                int idMusic = Convert.ToInt32(dgvInPlaylist.Rows[e.RowIndex].Cells["id"].Value);
                ExecuteSP("uamplify.RemoveMusicFromPlaylist", idMusic);
                LoadPlaylistSongs();
            }
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("uamplify.UpdatePlaylistDetails", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PlaylistId", this.PlaylistId);
                    cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                    cmd.Parameters.AddWithValue("@NewDescription", txtDescription.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details updated successfully!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure?", "Delete Playlist", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("uamplify.DeletePlaylist", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PlaylistId", this.PlaylistId);
                        cmd.ExecuteNonQuery();
                        this.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void ExecuteSP(string spName, int idMusic)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(spName, conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PlaylistId", this.PlaylistId);
                    cmd.Parameters.AddWithValue("@MusicId", idMusic);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void DgvAllMusics_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAllMusics.Columns[e.ColumnIndex].Name == "Duration" && e.Value != null)
            {
                int seconds = Convert.ToInt32(e.Value);
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                e.Value = time.ToString(@"mm\:ss");
                e.FormattingApplied = true;
            }
        }

        private void DgvInPlaylist_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvInPlaylist.Columns[e.ColumnIndex].Name == "Duration" && e.Value != null)
            {
                int seconds = Convert.ToInt32(e.Value);
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                e.Value = time.ToString(@"mm\:ss");
                e.FormattingApplied = true;
            }
        }

        private void txtSearchMusic_TextChanged(object sender, EventArgs e) => SearchAllMusics(txtSearchMusic.Text);
        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

    }
}