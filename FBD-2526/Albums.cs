using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Albums : Form
    {
        private int UserId;
        private string connectionString =
            "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;" +
            "Initial Catalog=p1g3;" +
            "User ID=p1g3;" +
            "Password=AD9CRu)XY8K;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";
        public Albums(int userId)
        {
            this.UserId = userId;
            InitializeComponent();
            this.Load += Albums_Load;
            dgvAlbums.CellFormatting += dgvAlbums_CellFormatting;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == "Search for songs...")
            {
                SearchAlbums("");
            }
            else
            {
                SearchAlbums(txtSearch.Text);
            }
        }
        private void SearchAlbums(string txtSearch)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("uamplify.SearchAlbum", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@txt", txtSearch);
                    SqlDataReader reader = cmd.ExecuteReader();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Load(reader);

                    dgvAlbums.Columns.Clear();
                    dgvAlbums.DataSource = dt;
                    dgvAlbums.Columns["id"].Visible = false;
                    DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
                    btnView.Name = "ViewDetails";
                    btnView.HeaderText = "Details";
                    btnView.Text = "👁️"; 
                    btnView.UseColumnTextForButtonValue = true;
                    dgvAlbums.Columns.Add(btnView);
                    dgvAlbums.Columns["ViewDetails"].Width = 50;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar à base de dados:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void Albums_Load(object sender, EventArgs e)
        {
            SearchAlbums("");
        }
        private void dgvAlbums_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAlbums.Columns[e.ColumnIndex].Name == "Duration" && e.Value != null)
            {
                int seconds = Convert.ToInt32(e.Value);
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                e.Value = time.ToString(@"mm\:ss");
                e.FormattingApplied = true;
            }

            if (dgvAlbums.Columns[e.ColumnIndex].Name == "Release Date" && e.Value != null)
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
        private void dgvAlbums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAlbums.Columns[e.ColumnIndex].Name == "ViewDetails")
            {
                int idAlbum = Convert.ToInt32(dgvAlbums.Rows[e.RowIndex].Cells["id"].Value);
                string nomeAlbum = dgvAlbums.Rows[e.RowIndex].Cells["Album"].Value.ToString();
                string nomeArtista = dgvAlbums.Rows[e.RowIndex].Cells["Artist"].Value.ToString();
                AlbumDetails detailsForm = new AlbumDetails(idAlbum, nomeAlbum, nomeArtista);
                detailsForm.ShowDialog();
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
            Musics musicPage = new Musics(UserId);
            musicPage.Show();
            this.Hide();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(UserId);
            editProfile.Show();
            this.Hide();
        }

        private void Albums_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
