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
    public partial class ArtistEdit : Form
    {
        private SqlConnection? cn;
        private bool isLoading = false;
        private int UserId;
        public ArtistEdit(int userID)
        {
            InitializeComponent();
            UserId = userID;
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

        private void loadArtist()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;
                isLoading = true;
                SqlCommand cmd = new SqlCommand("SELECT * FROM uamplify.artistView WHERE id = @id", cn);
                cmd.Parameters.AddWithValue("@id", artistId.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    artistId.Text = reader["id"]?.ToString() ?? "";
                    artistName.Text = reader["name"]?.ToString() ?? "";
                    artistDescription.Text = reader["description"]?.ToString() ?? "";
                    artistVerified.Text = reader["verified"]?.ToString() ?? "";
                    artistGenreId.Text = reader["idgenre"]?.ToString() ?? "";
                    artistGenreName.Text = reader["genreType"]?.ToString() ?? "";
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

        public void loadGenreType()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;
                SqlCommand cmd = new SqlCommand("SELECT genreType FROM uamplify.genreType WHERE idGenre = @id", cn);
                cmd.Parameters.AddWithValue("@id", artistGenreId.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                string genretype = "";

                if (reader.Read())
                {
                    genretype = reader["genretype"]?.ToString() ?? "";
                }

                reader.Close();

                artistGenreName.Text = genretype;


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

        private void insertArtist()
        {
            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("ua_insertArtist", cn);
            cmd.CommandType = CommandType.StoredProcedure; // Define que é uma SP
            cmd.Parameters.AddWithValue("@idMod", UserId);
            cmd.Parameters.AddWithValue("@artistName", artistName.Text);
            cmd.Parameters.AddWithValue("@description", artistDescription.Text);
            cmd.Parameters.AddWithValue("@idGenre", artistGenreId);
            string inputVerified = artistVerified.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(inputVerified))
            {
                int valorVerified = (inputVerified == "sim") ? 1 : 0;
                cmd.Parameters.AddWithValue("@verified", valorVerified);
            }

            try
            {
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("Artista inserida com sucesso!");
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

        private void updateArtist()
        {
            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("ua_updateArtist", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idModerator", UserId);
            cmd.Parameters.AddWithValue("@artistId", artistId.Text);
            cmd.Parameters.AddWithValue("@artistName", artistName.Text);
            cmd.Parameters.AddWithValue("@description", artistDescription.Text);
            cmd.Parameters.AddWithValue("@idGenre", artistGenreId.Text);
            string inputVerified = artistVerified.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(inputVerified))
            {
                int valorVerified = (inputVerified == "true") ? 1 : 0;
                cmd.Parameters.AddWithValue("@verified", valorVerified);
            }

            try
            {
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("Artista atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void deleteArtist()
        {
            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("ua_deleteArtist", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@artistId", artistId.Text);

            try
            {
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("Artista atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadArtist();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            loadGenreType();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateArtist();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            insertArtist();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteArtist();
        }
    }
}
