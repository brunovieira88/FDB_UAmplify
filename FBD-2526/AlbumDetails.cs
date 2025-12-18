using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FBD_2526
{
    public partial class AlbumDetails : Form
    {
        private int AlbumId;
        private string connectionString =
                    "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;" +
                    "Initial Catalog=p1g3;" +
                    "User ID=p1g3;" +
                    "Password=AD9CRu)XY8K;" +
                    "Encrypt=True;" +
                    "TrustServerCertificate=True;";
        public AlbumDetails(int albumId, string albumName, string artistName)
        {
            this.AlbumId = albumId;
            InitializeComponent(); 
            lblTitle.Text = albumName;
            lblArtist.Text = "by " + artistName;
            dgvSongs.CellFormatting += DgvSongs_CellFormatting;

            LoadSongs();
        }

        private void LoadSongs()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("uamplify.GetAlbumSongs", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AlbumId", this.AlbumId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dgvSongs.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error loading album tracks: " + ex.Message);
            }
        }

        private void DgvSongs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Formatar segundos em mm:ss
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