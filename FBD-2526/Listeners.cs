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
    public partial class Listeners : Form
    {
        private SqlConnection? cn;
        private int UserId;
        public Listeners(int userId)
        {
            InitializeComponent();
            UserId = userId;
            SearchListeners("");
            LoadPending();
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            dgvListeners.CellFormatting += dgvMusics_CellFormatting;
            dgvPending.CellContentClick += dgvPending_CellContentClick;
        }

        private SqlConnection getSGBDConnection()
        {
            // Adicionado TrustServerCertificate=True para evitar erro de SSL
            return new SqlConnection("Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;" +
                "Initial Catalog=" + "p1g3;" +
                "User ID=" + "p1g3;" +
                "Password=" + "AD9CRu)XY8K;" +
                "Encrypt=false;");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == "Search for songs...")
            {
                SearchListeners("");
            }
            else
            {
                SearchListeners(txtSearch.Text);
            }
        }


        private void SearchListeners(string txtSearch)
        {
            try
            {
                if (txtSearch != "" && txtSearch.Length < 3) //para nao estourar com a BD
                {
                    return;
                }
                using (SqlConnection conn = getSGBDConnection())
                using (SqlCommand cmd = new SqlCommand("uamplify.searchListener", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@txt", txtSearch);
                    cmd.Parameters.AddWithValue("@userId", UserId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Load(reader);

                    dgvListeners.Columns.Clear();
                    dgvListeners.DataSource = dt;
                    dgvListeners.Columns["userid"].Visible = false;

                    //criar botao de play
                    DataGridViewButtonColumn profBtn = new DataGridViewButtonColumn();
                    profBtn.Name = "OpenProfile";
                    profBtn.HeaderText = "Profile";
                    profBtn.Text = "👤";
                    profBtn.UseColumnTextForButtonValue = true;
                    dgvListeners.Columns.Add(profBtn);
                    dgvListeners.Columns["OpenProfile"].Width = 60;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar à base de dados:\n",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadPending()
        {
            try
            {
                using (SqlConnection conn = getSGBDConnection())
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM uamplify.getPendingRequests(@idUser)", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@idUser", UserId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Load(reader);

                    dgvPending.Columns.Clear();
                    dgvPending.DataSource = dt;
                    dgvPending.Columns["userId"].Visible = false;

                    DataGridViewButtonColumn profAcceptBtn = new DataGridViewButtonColumn();
                    profAcceptBtn.Name = "Add";
                    profAcceptBtn.Text = "+";
                    profAcceptBtn.UseColumnTextForButtonValue = true;
                    dgvPending.Columns.Add(profAcceptBtn);
                    dgvPending.Columns["Add"].Width = 50;

                    DataGridViewButtonColumn profRecuseBtn = new DataGridViewButtonColumn();
                    profRecuseBtn.Name = "Del";
                    profRecuseBtn.Text = "🗑️";
                    profRecuseBtn.UseColumnTextForButtonValue = true;
                    dgvPending.Columns.Add(profRecuseBtn);
                    dgvPending.Columns["Del"].Width = 50;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar à base de dados:\n",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void dgvMusics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvListeners.Columns[e.ColumnIndex].Name == "OpenProfile")
            {
                int targetListenerId = Convert.ToInt32(dgvListeners.Rows[e.RowIndex].Cells["userid"].Value);
                ListenerPage profilePage = new ListenerPage(this.UserId, targetListenerId);
                profilePage.Show();
                this.Hide();
            }
        }


        private void dgvMusics_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListeners.Columns[e.ColumnIndex].Name == "Duration" && e.Value != null)
            {
                int seconds = Convert.ToInt32(e.Value);
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                e.Value = time.ToString(@"mm\:ss");
                e.FormattingApplied = true;
            }

            if (dgvListeners.Columns[e.ColumnIndex].Name == "Release Date" && e.Value != null)
            {
                DateTime date = Convert.ToDateTime(e.Value);
                e.Value = date.ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
        }

        private void dgvPending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 

            try
            {
                int targetListenerId = Convert.ToInt32(dgvPending.Rows[e.RowIndex].Cells["userId"].Value);
                if (dgvPending.Columns[e.ColumnIndex].Name == "Add")
                {
                    AcceptRequest(targetListenerId);
                }
                else if (dgvPending.Columns[e.ColumnIndex].Name == "Del")
                {
                    RecuseRequest(targetListenerId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar o pedido: ");
            }
        }


        private void AcceptRequest(int targetListenerId)
        {
            try
            {
                using (SqlConnection conn = getSGBDConnection())
                using (SqlCommand cmd = new SqlCommand("uamplify.acceptPendingRequest", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", UserId);
                    cmd.Parameters.AddWithValue("@idListener", targetListenerId);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pedido aceite com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadPending();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aceitar pedido:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecuseRequest(int targetListenerId)
        {
            try
            {
                using (SqlConnection conn = getSGBDConnection())
                using (SqlCommand cmd = new SqlCommand("uamplify.recusePendingRequest", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", UserId);
                    cmd.Parameters.AddWithValue("@idListener", targetListenerId);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pedido recusado/removido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPending();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recusar pedido:\n", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            Playlists playlists = new Playlists(UserId);
            playlists.Show();
            this.Hide();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(UserId);
            editProfile.Show();
            this.Hide();
        }


        private void Listener_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
