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
    public partial class ListenerPage : Form
    {
        private int UserId;
        private int ListennerProfileId;
        private SqlConnection? cn;
        private bool isFollowing = false;

        public ListenerPage(int userId, int listennerProfileId)
        {
            InitializeComponent();
            this.UserId = userId;
            this.ListennerProfileId = listennerProfileId;
            loadListenner();
            loadListennerPlaylists();
            loadListennerFollowingArtists();
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

        private void loadListenner()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;

                {
                    using (SqlConnection conn = getSGBDConnection())
                    using (SqlCommand cmd = new SqlCommand("uamplify.getListener", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userId", ListennerProfileId);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lblListenerName.Text = reader["name"]?.ToString() ?? "";
                            lblTag.Text = reader["username"]?.ToString() ?? "";
                            lblCountry.Text = reader["country"]?.ToString() ?? "";
                            ;
                        }

                        reader.Close();
                        isListennerFollowing();
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

        private void loadListennerPlaylists()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;

                {
                    using (SqlConnection conn = getSGBDConnection())
                    using (SqlCommand cmd = new SqlCommand("uamplify.getListenerPlaylists", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idUser", UserId);
                        cmd.Parameters.AddWithValue("@idListener", ListennerProfileId);
                        SqlDataReader reader = cmd.ExecuteReader();
                        System.Data.DataTable dt = new System.Data.DataTable();
                        dt.Load(reader);

                        dgvPlaylists.Columns.Clear();
                        dgvPlaylists.DataSource = dt;
                        dgvPlaylists.Columns["idPlaylist"].Visible = false;

                        //criar botao de play
                        DataGridViewButtonColumn playBtn = new DataGridViewButtonColumn();
                        playBtn.Name = "Add";
                        playBtn.Text = "+";
                        playBtn.UseColumnTextForButtonValue = true;
                        dgvPlaylists.Columns.Add(playBtn);
                        dgvPlaylists.Columns["Add"].Width = 50;
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


        private void loadListennerFollowingArtists()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;

                {
                    using (SqlConnection conn = getSGBDConnection())
                    using (SqlCommand cmd = new SqlCommand("uamplify.getListenerFollowingArtists", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idUser", UserId);
                        cmd.Parameters.AddWithValue("@idListener", ListennerProfileId);
                        SqlDataReader reader = cmd.ExecuteReader();
                        System.Data.DataTable dt = new System.Data.DataTable();
                        dt.Load(reader);

                        dgvFollowing.Columns.Clear();
                        dgvFollowing.DataSource = dt;
                        dgvFollowing.Columns["id"].Visible = false;
                        dgvFollowing.Columns["verified"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dgvFollowing.Columns["verified"].Width = 100;

                        DataGridViewButtonColumn openArtistBtn = new DataGridViewButtonColumn();
                        openArtistBtn.Name = "Open";
                        openArtistBtn.Text = "📂";
                        openArtistBtn.UseColumnTextForButtonValue = true;
                        dgvFollowing.Columns.Add(openArtistBtn);
                        dgvFollowing.Columns["Open"].Width = 50;
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


        private void followListener()
        {
            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("uamplify.ua_followOrUnfollowListener", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iduser", UserId);
            cmd.Parameters.AddWithValue("@idListener", ListennerProfileId);
            try
            {
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("Seguiu/Deixou de Seguir com sucesso!");
                isListennerFollowing();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a dar follow" + ex.Message);
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
                    string query = "SELECT uamplify.isFollowingListener(@idUser, @idListener)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@idUser", UserId);
                        cmd.Parameters.AddWithValue("@idListener", ListennerProfileId);

                        object result = cmd.ExecuteScalar();
                        isFollowing = Convert.ToBoolean(result);
                    }
                }
                UpdateFollowButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar estado de seguidor:\n" + ex.Message);
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

        private void dgvFollowing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvFollowing.Columns[e.ColumnIndex].Name == "Open")
            {
                int artistId = Convert.ToInt32(dgvFollowing.Rows[e.RowIndex].Cells["id"].Value);
                ArtistPage artistPage = new ArtistPage(this.UserId, artistId);
                artistPage.Show();
                this.Hide();
            }
        }


        private void btnFollow_Click(object sender, EventArgs e)
        {
            followListener();
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

        private void btnRETURN_Click(object sender, EventArgs e)
        {
            Listeners listeners = new Listeners(UserId);
            listeners.Show();
            this.Hide();
        }
    }
}
