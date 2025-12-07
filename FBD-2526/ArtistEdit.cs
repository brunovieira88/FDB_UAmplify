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
        public ArtistEdit()
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

        private void loadArtist()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;

                SqlCommand cmd = new SqlCommand("SELECT * FROM uamplify.artistView WHERE id = @id", cn);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                Artist A = new Artist();
                while (reader.Read())
                {
                    A.artistID = reader["id"]?.ToString() ?? "";
                    A.Name = reader["name"]?.ToString() ?? "";
                    A.Description = reader["description"]?.ToString() ?? "";
                    A.Verified = reader["verified"]?.ToString() ?? "";
                    A.IdGenre = reader["idgenre"]?.ToString() ?? "";
                    A.NameGenre = reader["genreType"]?.ToString() ?? "";
                    ;
                }

                // Fechamos o reader explicitamente
                reader.Close();
                ShowArtist(A);
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
                cmd.Parameters.AddWithValue("@id", textBox6.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                string genretype = "";

                if (reader.Read())
                {
                    genretype = reader["genretype"]?.ToString() ?? "";
                }

                reader.Close();

                textBox9.Text = genretype;


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

        public void ShowArtist(Artist artist)
        {
            isLoading = true;
            textBox2.Text = artist.Name;
            richTextBox1.Text = artist.Description;
            textBox3.Text = artist.Verified;
            textBox6.Text = artist.IdGenre;
            textBox9.Text = artist.NameGenre;
            isLoading = false;

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
    }
}
