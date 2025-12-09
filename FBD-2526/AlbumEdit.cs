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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FBD_2526
{
    public partial class AlbumEdit : Form
    {
        private SqlConnection? cn;
        private bool isLoading = false;
        public AlbumEdit()
        {
            InitializeComponent();
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
        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private void loadAlbum()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;

                SqlCommand cmd = new SqlCommand("SELECT * FROM uamplify.albumView WHERE id = @id", cn);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                Album A = new Album();
                while (reader.Read())
                {
                    A.albumID = reader["id"]?.ToString() ?? "";
                    A.Name = reader["name"]?.ToString() ?? "";
                    A.Duration = reader["duration"]?.ToString() ?? "";
                    A.ReleaseDate = reader["releaseDate"]?.ToString() ?? "";
                    A.AlbumNameArtist = reader["artistName"]?.ToString() ?? "";
                    ;
                }

                reader.Close();
                ShowAlbum(A);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }


        private void loadMusics()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;

                SqlCommand cmd = new SqlCommand("SELECT * FROM uamplify.albumMusics (@id)", cn);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                listView1.Items.Clear();
                listView1.Columns.Clear();

                listView1.Columns.Add("ID", 50);
                listView1.Columns.Add("Nome", 150);
                listView1.Columns.Add("Duração", 80);
                listView1.Columns.Add("Data", 100);
                listView1.Columns.Add("Idioma", 80);

                while (reader.Read())
                {
                    Music M = new Music();
                    M.musicID = reader["id"]?.ToString() ?? "";
                    M.Name = reader["name"]?.ToString() ?? "";
                    M.Duration = reader["duration"]?.ToString() ?? "";
                    M.ReleaseDate = reader["releaseDate"]?.ToString() ?? "";
                    M.Language = reader["language"]?.ToString() ?? "";

                    ListViewItem item = new ListViewItem(M.musicID);
                    item.SubItems.Add(M.Name);
                    item.SubItems.Add(M.Duration);
                    item.SubItems.Add(M.ReleaseDate);
                    item.SubItems.Add(M.Language);

                    item.Tag = M;

                    listView1.Items.Add(item);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
            finally
            {
                // Garante que a conexão feche mesmo se der erro
                if (cn != null && cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }


        public void ShowAlbum(Album album)
        {
            isLoading = true;
            textBox2.Text = album.Name;
            textBox3.Text = album.Duration;
            textBox4.Text = album.ReleaseDate;
            textBox5.Text = album.AlbumNameArtist;
            isLoading = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadAlbum();
            loadMusics();
        }
    }
}
