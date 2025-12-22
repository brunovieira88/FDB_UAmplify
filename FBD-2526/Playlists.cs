using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FBD_2526
{
    public partial class Playlists : Form
    {
        private int UserId;
        private string connectionString =
                    "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;" +
                    "Initial Catalog=p1g3;" +
                    "User ID=p1g3;" +
                    "Password=AD9CRu)XY8K;" +
                    "Encrypt=True;" +
                    "TrustServerCertificate=True;";

        public Playlists(int userId)
        {
            this.UserId = userId;
            InitializeComponent();
            dgvMyPlaylists.CellFormatting += dgvMyPlaylists_CellFormatting;
            dgvMyPlaylists.CellPainting += dgvMyPlaylists_CellPainting;
        }

        private void Playlists_Load(object sender, EventArgs e)
        {
            AlternarAbas(true);
        }

        private void btnTabLibrary_Click(object sender, EventArgs e)
        {
            AlternarAbas(true);
        }

        private void btnTabSearch_Click(object sender, EventArgs e)
        {
            AlternarAbas(false);
        }

        private void AlternarAbas(bool mostrarMinhas)
        {
            if (mostrarMinhas)
            {
                EstilizarBotaoAba(btnTabLibrary, true);
                EstilizarBotaoAba(btnTabSearch, false);

                dgvMyPlaylists.Visible = true;
                dgvSearch.Visible = false;

                LoadMyLibrary();
            }
            else
            {
                EstilizarBotaoAba(btnTabLibrary, false);
                EstilizarBotaoAba(btnTabSearch, true);

                dgvSearch.Visible = true;
                dgvMyPlaylists.Visible = false;

                if (txtSearch.Text != "Search playlists..." && txtSearch.Text != "")
                    SearchGlobalPlaylists(txtSearch.Text);
            }
        }
        private void EstilizarBotaoAba(Button btn, bool ativo)
        {
            if (ativo)
            {
                btn.BackColor = Color.FromArgb(40, 40, 40);
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            }
            else
            {
                btn.BackColor = Color.FromArgb(24, 24, 24);
                btn.ForeColor = Color.Gray;
                btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            }
        }
        private void LoadMyLibrary()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("uamplify.GetUserPlaylists", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", this.UserId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Load(reader);

                    dgvMyPlaylists.Columns.Clear();
                    dgvMyPlaylists.DataSource = dt;
                    dgvMyPlaylists.Columns["id"].Visible = false;

                    DataGridViewButtonColumn btnOpen = new DataGridViewButtonColumn();
                    btnOpen.Name = "OpenAction";
                    btnOpen.HeaderText = "Action";
                    btnOpen.Text = "Open";
                    btnOpen.UseColumnTextForButtonValue = true;
                    dgvMyPlaylists.Columns.Add(btnOpen);
                    dgvMyPlaylists.Columns["OpenAction"].Width = 80;

                    DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                    btnEdit.Name = "EditAction";
                    btnEdit.HeaderText = "Edit";
                    btnEdit.Text = "Edit";
                    btnEdit.UseColumnTextForButtonValue = true;
                    dgvMyPlaylists.Columns.Add(btnEdit);
                    dgvMyPlaylists.Columns["EditAction"].Width = 80;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar à base de dados:\n",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void SearchGlobalPlaylists(string texto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("uamplify.SearchPlaylist", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@txt", texto);
                    SqlDataReader reader = cmd.ExecuteReader();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Load(reader);

                    dgvSearch.Columns.Clear();
                    dgvSearch.DataSource = dt;
                    dgvSearch.Columns["id"].Visible = false;

                    DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
                    btnView.Name = "ViewAction";
                    btnView.HeaderText = "Details";
                    btnView.Text = "View";
                    btnView.UseColumnTextForButtonValue = true;
                    dgvSearch.Columns.Add(btnView);
                    dgvSearch.Columns["ViewAction"].Width = 70;

                    DataGridViewButtonColumn btnSave = new DataGridViewButtonColumn();
                    btnSave.Name = "SaveAction";
                    btnSave.HeaderText = "Action";
                    btnSave.Text = "Save";
                    btnSave.UseColumnTextForButtonValue = true;
                    dgvSearch.Columns.Add(btnSave);
                    dgvSearch.Columns["ViewAction"].Width = 70;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar à base de dados:\n",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvSearch.Visible)
            {
                if (txtSearch.Text != "" && txtSearch.Text != "Search playlists...")
                {
                    SearchGlobalPlaylists(txtSearch.Text);
                }
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search playlists...") txtSearch.Text = "";
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") txtSearch.Text = "Search playlists...";
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreatePlaylist createForm = new CreatePlaylist(this.UserId);
            createForm.ShowDialog();

            if (dgvMyPlaylists.Visible)
            {
                LoadMyLibrary();
            }
        }

        private void dgvPlaylists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(dgvMyPlaylists.Rows[e.RowIndex].Cells["id"].Value);
            string name = dgvMyPlaylists.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            string owner = dgvMyPlaylists.Rows[e.RowIndex].Cells["Owner"].Value.ToString();

            if (dgvMyPlaylists.Columns[e.ColumnIndex].Name == "OpenAction")
            {
                PlaylistDetails details = new PlaylistDetails(this.UserId, id, name, owner);
                details.ShowDialog();
            }

            else if (dgvMyPlaylists.Columns[e.ColumnIndex].Name == "EditAction")
            {
                string type = dgvMyPlaylists.Rows[e.RowIndex].Cells["Type"].Value.ToString();

                if (type == "Created")
                {
                    string desc = dgvMyPlaylists.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                    EditPlaylist editPage = new EditPlaylist(id, name, desc);
                    editPage.Show();
                }
            }
        }
        private void dgvMyPlaylists_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
        private void dgvMyPlaylists_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvMyPlaylists.Columns[e.ColumnIndex].Name == "EditAction")
            {
                var typeCell = dgvMyPlaylists.Rows[e.RowIndex].Cells["Type"];

                if (typeCell.Value != null && typeCell.Value.ToString() == "Saved")
                {

                    e.PaintBackground(e.CellBounds, true);
                    e.Handled = true;
                }
            }
        }
        private void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idPlaylist = Convert.ToInt32(dgvSearch.Rows[e.RowIndex].Cells["id"].Value);
            string name = dgvSearch.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            string owner = dgvSearch.Rows[e.RowIndex].Cells["Owner"].Value.ToString();

            //se clicou em view
            if (dgvSearch.Columns[e.ColumnIndex].Name == "ViewAction")
            {
                PlaylistDetails details = new PlaylistDetails(this.UserId, idPlaylist, name, owner);
                details.ShowDialog();
            }
            //se clicou em save
            else if (dgvSearch.Columns[e.ColumnIndex].Name == "SaveAction")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand("uamplify.FollowPlaylist", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserId", this.UserId);
                        cmd.Parameters.AddWithValue("@PlaylistId", idPlaylist);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Playlist saved!");
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                        MessageBox.Show("you've already saved it");
                    else
                        MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error: ");
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(UserId);
            home.Show();
            this.Hide();
        }

        private void btnMusics_Click(object sender, EventArgs e)
        {
            Musics musics = new Musics(UserId);
            musics.Show();
            this.Hide();
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            Albums albums = new Albums(UserId);
            albums.Show();
            this.Hide();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            EditProfile profile = new EditProfile(UserId);
            profile.Show();
            this.Hide();
        }

        private void Playlists_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCommunity_Click(object sender, EventArgs e)
        {
            Listeners listeners = new Listeners(UserId);
            listeners.Show();
            this.Hide();
        }
    }
}