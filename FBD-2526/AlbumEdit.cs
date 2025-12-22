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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FBD_2526
{
    public partial class AlbumEdit : Form
    {
        private SqlConnection? cn;
        private bool isLoading = false;
        private int UserId;
        public AlbumEdit(int userId)
        {
            InitializeComponent();
            UserId = userId;
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
                isLoading = true;
                SqlCommand cmd = new SqlCommand("SELECT * FROM uamplify.albumView WHERE id = @id", cn);
                cmd.Parameters.AddWithValue("@id", albumId.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    albumId.Text = reader["id"]?.ToString() ?? "";
                    albumName.Text = reader["name"]?.ToString() ?? "";
                    albumDuration.Text = reader["duration"]?.ToString() ?? "";
                    albumArtistId.Text = reader["idArtist"]?.ToString() ?? "";
                    albumArtistName.Text = reader["artistName"]?.ToString() ?? "";

                    if (reader["releaseDate"] != DBNull.Value)
                    {
                        albumReleaseDate.Value = Convert.ToDateTime(reader["releaseDate"]);
                    }
                    ;
                }

                reader.Close();
                isLoading = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar album: " + ex.Message);
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
                cmd.Parameters.AddWithValue("@id", albumId.Text);
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
                    String musicID = reader["id"]?.ToString() ?? "";
                    String Name = reader["name"]?.ToString() ?? "";
                    String Duration = reader["duration"]?.ToString() ?? "";
                    String ReleaseDate = reader["releaseDate"]?.ToString() ?? "";
                    String Language = reader["language"]?.ToString() ?? "";

                    ListViewItem item = new ListViewItem(musicID);
                    item.SubItems.Add(Name);
                    item.SubItems.Add(Duration);
                    item.SubItems.Add(ReleaseDate);
                    item.SubItems.Add(Language);


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

        private void insertNewAlbum()
        {
            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("ua_insertAlbum", cn);
            cmd.CommandType = CommandType.StoredProcedure; // Define que é uma SP
            cmd.Parameters.AddWithValue("@idModerator", UserId);
            cmd.Parameters.AddWithValue("@albumName", albumName.Text);
            cmd.Parameters.AddWithValue("@idArtist", albumArtistId.Text);
            if (albumReleaseDate.Value > DateTime.Now)
            {
                MessageBox.Show("A data do album não pode ser no futuro.");
                return;
            }
            cmd.Parameters.AddWithValue("@albumReleaseDate", albumReleaseDate.Value);

            try
            {
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("Album inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o Album");
            }
            finally
            {
                cn.Close();
            }
        }

        private void updateAlbum()
        {
            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("ua_updateAlbum", cn);
            cmd.CommandType = CommandType.StoredProcedure; // Define que é uma SP
            cmd.Parameters.AddWithValue("@idModerator", UserId);
            cmd.Parameters.AddWithValue("@albumId", albumId.Text);
            cmd.Parameters.AddWithValue("@albumName", albumName.Text);
            cmd.Parameters.AddWithValue("@albumReleaseDate", albumReleaseDate.Value);
            cmd.Parameters.AddWithValue("@idArtist", albumArtistId.Text);
            try
            {
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("Album atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o Album ");
            }
            finally
            {
                cn.Close();
            }
        }


        private void deleteAlbum()
        {
            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("ua_deleteAlbum", cn);
            cmd.CommandType = CommandType.StoredProcedure; // Define que é uma SP
            cmd.Parameters.AddWithValue("@idAlbum", albumId.Text);
            try
            {
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("Album removido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover o Album");
            }
            finally
            {
                cn.Close();
            }
        }

        private void loadArtist()
        {
            try { 
                if (!verifySGBDConnection()) return;

                SqlCommand cmd = new SqlCommand("ua_searchArtistById", cn);
                cmd.CommandType = CommandType.StoredProcedure; // Define que é uma SP
                cmd.Parameters.AddWithValue("@idArtist", albumArtistId.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) // Tenta ler a primeira linha
                {
                    albumArtistName.Text = reader["name"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não encontrado");
            }
            finally
            {
                cn.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadAlbum();
            loadMusics();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateAlbum();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            insertNewAlbum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteAlbum();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadArtist();
        }
    }
}
