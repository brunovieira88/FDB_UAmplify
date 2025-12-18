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
    public partial class MusicEdit : Form
    {

        private SqlConnection? cn;
        private bool isLoading = false;
        public MusicEdit()
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


        private void loadMusic()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;
                isLoading = true;
                SqlCommand cmd = new SqlCommand("SELECT * FROM uamplify.musicView WHERE id = @id", cn);
                cmd.Parameters.AddWithValue("@id", IdMusic.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IdMusic.Text = reader["id"]?.ToString() ?? "";
                    musicName.Text = reader["name"]?.ToString() ?? "";
                    musicDuration.Text = reader["duration"]?.ToString() ?? "";
                    musicReleaseDate.Text = reader["releaseDate"]?.ToString() ?? "";
                    musicAlbumId.Text = reader["idalbum"]?.ToString() ?? "";
                    musicAlbumName.Text = reader["albumName"]?.ToString() ?? "";
                    musicIdGenre.Text = reader["idGenre"]?.ToString() ?? "";
                    musicGenreName.Text = reader["genreType"]?.ToString() ?? "";
                    musicLanguage.Text = reader["language"]?.ToString() ?? "";
                    musicLyrics.Text = reader["lyrics"]?.ToString() ?? "";
                    ;
                }

                // Fechamos o reader explicitamente
                reader.Close();
                isLoading = false;
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

        public void loadAlbumName()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;
                SqlCommand cmd = new SqlCommand("SELECT name FROM uamplify.album WHERE id = @id", cn);
                cmd.Parameters.AddWithValue("@id", musicAlbumId.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                string albumName = "";

                if (reader.Read())
                {
                    albumName = reader["name"]?.ToString() ?? "";
                }

                reader.Close();

                musicAlbumName.Text = albumName;


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

        private void InsertUpdateMusicLog(String operation)
        {
            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("ua_registInsertUpdateLog", cn);
            cmd.CommandType = CommandType.StoredProcedure; // Define que é uma SP

            cmd.Parameters.AddWithValue("@operation", operation);
            cmd.Parameters.AddWithValue("@musicId", IdMusic.Text);
            cmd.Parameters.AddWithValue("@musicName", musicName.Text);
            cmd.Parameters.AddWithValue("@musicDuration", musicDuration.Text);
            cmd.Parameters.AddWithValue("@musicReleaseDate", Convert.ToDateTime(musicReleaseDate.Text));
            cmd.Parameters.AddWithValue("@musicIdAlbum", musicAlbumId.Text);
            cmd.Parameters.AddWithValue("@musicIdGenre", musicIdGenre.Text);
            cmd.Parameters.AddWithValue("@musicLanguage", musicLanguage.Text);
            cmd.Parameters.AddWithValue("@musicLyrics", musicLyrics.Text);

            try
            {
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("Música inserida com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void DeleteMusicLog()
        {
            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("ua_registDeleteLog", cn);
            cmd.CommandType = CommandType.StoredProcedure; // Define que é uma SP

            cmd.Parameters.AddWithValue("@operation", "DELETE");
            cmd.Parameters.AddWithValue("@musicId", IdMusic.Text);

            try
            {
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("Música removida");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void loadGenreType()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;
                SqlCommand cmd = new SqlCommand("SELECT genreType FROM uamplify.genreType WHERE idGenre = @id", cn);
                cmd.Parameters.AddWithValue("@id", musicIdGenre.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                string albumName = "";

                if (reader.Read())
                {
                    albumName = reader["genretype"]?.ToString() ?? "";
                }

                reader.Close();

                musicGenreName.Text = albumName;


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


        private void button1_Click(object sender, EventArgs e)
        {
            if (isLoading) return;
            loadMusic();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            loadAlbumName();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            loadGenreType();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertUpdateMusicLog("INSERT");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteMusicLog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            InsertUpdateMusicLog("UPDATE");
        }
    }
}
