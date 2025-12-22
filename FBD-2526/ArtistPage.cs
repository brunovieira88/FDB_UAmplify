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
    public partial class ArtistPage : Form
    {

        private int UserId;
        private int ArtistId;
        private SqlConnection? cn;
        private bool isFollowing = false;

        public ArtistPage(int userId, int artistId)
        {
            InitializeComponent();
            this.UserId = userId;
            this.ArtistId = artistId;
            dgvArtistMusics.CellFormatting += dgvMusics_CellFormatting;
            dgvArtistMusics.CellContentClick += dgvMusics_CellContentClick;
            loadArtist();
            ArtistTopMusics();
            getArtistAlbums();
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

                {
                    using (SqlConnection conn = getSGBDConnection())
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM uamplify.artistView WHERE id = @id", conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@id", ArtistId);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lblArtistName.Text = reader["name"]?.ToString() ?? "";
                            lblDescription.Text = reader["description"]?.ToString() ?? "";
                            lblGenre.Text = reader["genreType"]?.ToString() ?? "";

                            bool isVerified = false;
                            if (reader["verified"] != DBNull.Value)
                            {
                                isVerified = Convert.ToBoolean(reader["verified"]);
                            }

                            if (isVerified)
                            {
                                lblVerified.Text = "✓ Verified Artist";
                                lblVerified.ForeColor = Color.FromArgb(30, 215, 96);
                            }
                            else
                            {
                                lblVerified.Text = "Not Verified";
                                lblVerified.ForeColor = Color.Gray;
                            }
                            ;
                        }

                        reader.Close();
                        isListennerFollowing();

                    }
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
            if (e.RowIndex >= 0 && dgvArtistMusics.Columns[e.ColumnIndex].Name == "PlayAction")
            {
                int musicId = Convert.ToInt32(dgvArtistMusics.Rows[e.RowIndex].Cells["id"].Value);
                string musicName = dgvArtistMusics.Rows[e.RowIndex].Cells["Music"].Value.ToString();

                RegistarPlayNaBaseDeDados(musicId);

                MessageBox.Show($"A tocar: {musicName}");
            }
        }
        private void RegistarPlayNaBaseDeDados(int musicId)
        {
            try
            {
                using (SqlConnection conn = getSGBDConnection())
                using (SqlCommand cmd = new SqlCommand("uamplify.RegisterPlay", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", this.UserId);
                    cmd.Parameters.AddWithValue("@MusicId", musicId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro ao registar play: ");
            }
        }

        private void ArtistTopMusics()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;

                {
                    using (SqlConnection conn = getSGBDConnection())
                    using (SqlCommand cmd = new SqlCommand("getTopArtistHits", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idArtist", ArtistId);
                        SqlDataReader reader = cmd.ExecuteReader();
                        System.Data.DataTable dt = new System.Data.DataTable();
                        dt.Load(reader);

                        dgvArtistMusics.Columns.Clear();
                        dgvArtistMusics.DataSource = dt;
                        dgvArtistMusics.Columns["id"].Visible = false;

                        //criar botao de play
                        DataGridViewButtonColumn playBtn = new DataGridViewButtonColumn();
                        playBtn.Name = "PlayAction";
                        playBtn.HeaderText = "Play";
                        playBtn.Text = "▶";
                        playBtn.UseColumnTextForButtonValue = true;
                        dgvArtistMusics.Columns.Add(playBtn);
                        dgvArtistMusics.Columns["PlayAction"].Width = 50;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar à base de dados:\n",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void getArtistAlbums()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;

                {
                    using (SqlConnection conn = getSGBDConnection())
                    using (SqlCommand cmd = new SqlCommand("getArtistAlbums", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idArtist", ArtistId);
                        SqlDataReader reader = cmd.ExecuteReader();
                        System.Data.DataTable dt = new System.Data.DataTable();
                        dt.Load(reader);

                        dgvArtistAlbums.Columns.Clear();
                        dgvArtistAlbums.DataSource = dt;
                        dgvArtistAlbums.Columns["id"].Visible = false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar à base de dados:\n",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void dgvMusics_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvArtistMusics.Columns[e.ColumnIndex].Name == "Duration" && e.Value != null)
            {
                int seconds = Convert.ToInt32(e.Value);
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                e.Value = time.ToString(@"mm\:ss");
                e.FormattingApplied = true;
            }

            if (dgvArtistMusics.Columns[e.ColumnIndex].Name == "Release Date" && e.Value != null)
            {
                DateTime date = Convert.ToDateTime(e.Value);
                e.Value = date.ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
        }


        private void followArtist()
        {
            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("ua_followOrUnfollowArtist", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idListener", UserId);
            cmd.Parameters.AddWithValue("@idArtist", ArtistId);
            try
            {
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("Seguiu/Deixou de Seguir com sucesso!");
                isListennerFollowing();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a dar follow");
            }
            finally
            {
                cn.Close();
            }
        }

        private void isListennerFollowing()
        {
            try
            {
                if (!verifySGBDConnection()) return;

                using (SqlConnection conn = getSGBDConnection())
                {
                    string query = "SELECT uamplify.isFollowingArtist(@idListenner, @idArtist)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@idListenner", UserId);
                        cmd.Parameters.AddWithValue("@idArtist", ArtistId);

                        object result = cmd.ExecuteScalar();
                        isFollowing = Convert.ToBoolean(result);
                    }
                }
                UpdateFollowButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar estado de seguidor:\n");
            }
        }

        private void UpdateFollowButton()
        {
            if (isFollowing)
            {
                btnFollow.Text = "Following";
                btnFollow.ForeColor = Color.White;

            }
            else
            {
                btnFollow.Text = "Follow";
                btnFollow.ForeColor = Color.FromArgb(30, 215, 96);
            }
        }


        private void btnFollow_Click(object sender, EventArgs e)
        {
            followArtist();
        }

        private void btnMusics_Click(object sender, EventArgs e)
        {
            Musics musicPage = new Musics(UserId);
            musicPage.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(UserId);
            home.Show();
            this.Hide();
        }

        private void Listener_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCommunity_Click(object sender, EventArgs e)
        {
            Listeners listeners = new Listeners(UserId);
            listeners.Show();
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
            EditProfile profile = new EditProfile(UserId);
            profile.Show();
            this.Hide();
        }
    }
}
