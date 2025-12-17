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
    public partial class Home : Form
    {
        private int UserId;
        private string connectionString =
            "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;" +
            "Initial Catalog=p1g3;" +
            "User ID=p1g3;" +
            "Password=AD9CRu)XY8K;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";
        public Home(int userId)
        {
            UserId = userId;
            InitializeComponent();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            loadTop();
            loadRecentMusics();
            loadRecentlyPlayed(UserId);
        }

        private void loadTop()
        {
            string query = "SELECT * FROM uamplify.MusicViews";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //mandar tudo para uma table
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Load(reader);
                    lblTop1.Text = dt.Rows[0]["Music_Artist"].ToString() + " - " + dt.Rows[0]["Music_Name"].ToString();
                    lblTop2.Text = dt.Rows[1]["Music_Artist"].ToString() + " - " + dt.Rows[1]["Music_Name"].ToString();
                    lblTop3.Text = dt.Rows[2]["Music_Artist"].ToString() + " - " + dt.Rows[2]["Music_Name"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar à base de dados:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void loadRecentMusics()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("uamplify.getRecentMusics", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    //mandar tudo para uma table
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Load(reader);
                    lblNew1.Text = dt.Rows[0]["Music_Artist"].ToString() + " - " + dt.Rows[0]["Music_Name"].ToString();
                    lblNew2.Text = dt.Rows[1]["Music_Artist"].ToString() + " - " + dt.Rows[1]["Music_Name"].ToString();
                    lblNew3.Text = dt.Rows[2]["Music_Artist"].ToString() + " - " + dt.Rows[2]["Music_Name"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar à base de dados:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void loadRecentlyPlayed(int userId)
        {
            listRecentes.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("uamplify.GetUserHistory", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUser", userId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string nomeMusica = reader["Music_Name"].ToString();
                        string nomeArtista = reader["Music_Artist"].ToString();

                        DateTime data = Convert.ToDateTime(reader["LastPlayed"]);
                        string dataFormatada = data.ToString("dd/MM HH:mm");
                        string linha = $"{nomeMusica} - {nomeArtista}  [{dataFormatada}]";
                        listRecentes.Items.Add(linha);
                    }

                    if (listRecentes.Items.Count == 0)
                    {
                        listRecentes.Items.Add("Start listening to smth");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar à base de dados:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        private void cardTopHits_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listRecentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(UserId);
            editProfile.Show();
            this.Close();
        }

        private void btnMusics_Click(object sender, EventArgs e)
        {
            Musics musicPage = new Musics(UserId);
            musicPage.Show();
            this.Close();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
