using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Usando a biblioteca moderna

namespace FBD_2526
{
    public partial class ModeratorPage : Form
    {
        private SqlConnection? cn;
        private bool adding;
        private int UserId;

        public ModeratorPage(int userId)
        {
            InitializeComponent();
            createTempMusicTable();
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

        private void createTempMusicTable()
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("ua_createMusicLog", cn);
            cmd.ExecuteNonQuery();
        }

        private void loadMusics()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;

                SqlCommand cmd = new SqlCommand("SELECT * FROM uamplify.musicView", cn);
                SqlDataReader reader = cmd.ExecuteReader();

                listView1.Items.Clear();
                listView1.Columns.Clear();

                // Adiciona os cabeçalhos das colunas
                listView1.Columns.Add("ID", 50);
                listView1.Columns.Add("Nome", 200);
                listView1.Columns.Add("Duração", 80);
                listView1.Columns.Add("Data", 100);
                listView1.Columns.Add("Album", 70);
                listView1.Columns.Add("Gênero", 70);
                listView1.Columns.Add("Idioma", 80);

                while (reader.Read())
                {
                    String musicID = reader["id"]?.ToString() ?? "";
                    String Name = reader["name"]?.ToString() ?? "";
                    String Duration = reader["duration"]?.ToString() ?? "";
                    String ReleaseDate = reader["releaseDate"]?.ToString() ?? "";
                    String IdAlbum = reader["albumName"]?.ToString() ?? "";
                    String IdGenre = reader["genreType"]?.ToString() ?? "";
                    String Language = reader["language"]?.ToString() ?? "";
                    String Lyrics = reader["lyrics"]?.ToString() ?? "";

                    ListViewItem item = new ListViewItem(musicID);
                    item.SubItems.Add(Name);
                    item.SubItems.Add(Duration);
                    item.SubItems.Add(ReleaseDate);
                    item.SubItems.Add(IdAlbum);
                    item.SubItems.Add(IdGenre);
                    item.SubItems.Add(Language);

                    listView1.Items.Add(item);
                }

                // Fechamos o reader explicitamente
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }
        private void loadArtists()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;

                SqlCommand cmd = new SqlCommand("SELECT * FROM uamplify.artistView", cn);
                SqlDataReader reader = cmd.ExecuteReader();

                listView1.Items.Clear();
                listView1.Columns.Clear();

                listView1.Columns.Add("ID", 50);
                listView1.Columns.Add("Nome", 200);
                listView1.Columns.Add("Gênero", 80);
                listView1.Columns.Add("Verificado", 80);

                while (reader.Read())
                {
                    String artistID = reader["id"]?.ToString() ?? "";
                    String Name = reader["name"]?.ToString() ?? "";
                    String IdGenre = reader["genretype"]?.ToString() ?? "";
                    String Verified = reader["verified"]?.ToString() ?? "";

                    ListViewItem item = new ListViewItem(artistID);
                    item.SubItems.Add(Name);
                    item.SubItems.Add(IdGenre);
                    item.SubItems.Add(Verified); // O GET retorna "Sim"/"Não"


                    listView1.Items.Add(item);
                }

                // Fechamos o reader explicitamente
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        private void loadAlbums()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;

                SqlCommand cmd = new SqlCommand("SELECT * FROM uamplify.albumView", cn);
                SqlDataReader reader = cmd.ExecuteReader();

                listView1.Items.Clear();
                listView1.Columns.Clear();

                listView1.Columns.Add("ID", 50);
                listView1.Columns.Add("Nome", 200);
                listView1.Columns.Add("Artista", 130);
                listView1.Columns.Add("Duração", 80);


                while (reader.Read())
                {
                    String albumID = reader["id"]?.ToString() ?? "";
                    String Name = reader["name"]?.ToString() ?? "";
                    String AlbumIdArtist = reader["artistName"]?.ToString() ?? "";
                    String Duration = reader["duration"]?.ToString() ?? "";
                    ListViewItem item = new ListViewItem(albumID);
                    item.SubItems.Add(Name);
                    item.SubItems.Add(AlbumIdArtist);
                    item.SubItems.Add(Duration);

                    listView1.Items.Add(item);
                }

                // Fechamos o reader explicitamente
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }
        private void loadUsers()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;

                SqlCommand cmd = new SqlCommand("SELECT * FROM uamplify.appuser", cn);
                SqlDataReader reader = cmd.ExecuteReader();

                listView1.Items.Clear();
                listView1.Columns.Clear();

                listView1.Columns.Add("Username", 200);
                listView1.Columns.Add("Name", 200);
                listView1.Columns.Add("E-mail", 200);


                while (reader.Read())
                {
                    String Name = reader["name"]?.ToString() ?? "";
                    String userName = reader["username"]?.ToString() ?? "";
                    String userEmail = reader["email"]?.ToString() ?? "";
                    ListViewItem item = new ListViewItem(userName);
                    item.SubItems.Add(Name);
                    item.SubItems.Add(userName);
                    item.SubItems.Add(userEmail);

                    listView1.Items.Add(item);
                }

                // Fechamos o reader explicitamente
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        private void loadMusicLogs()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;

                SqlCommand cmd = new SqlCommand("ua_loadMusicLog", cn);
                SqlDataReader reader = cmd.ExecuteReader();

                listView1.Items.Clear();
                listView1.Columns.Clear();

                listView1.Columns.Add("operation", 80);
                listView1.Columns.Add("Nome", 200);
                listView1.Columns.Add("Duração", 80);
                listView1.Columns.Add("Data", 100);
                listView1.Columns.Add("Album", 70);
                listView1.Columns.Add("Gênero", 70);
                listView1.Columns.Add("Idioma", 80);

                while (reader.Read())
                {
                    String operation = reader["operation"]?.ToString() ?? "";
                    String musicName = reader["musicName"]?.ToString() ?? "";
                    String musicDuration = reader["musicDuration"]?.ToString() ?? "";
                    String musicReleaseDate = reader["musicReleaseDate"]?.ToString() ?? "";
                    String musicAlbum = reader["musicIdAlbum"]?.ToString() ?? "";
                    String musicGenre = reader["musicIdGenre"]?.ToString() ?? "";
                    String musicLanguage = reader["musicLanguage"]?.ToString() ?? "";
                    ListViewItem item = new ListViewItem(operation);
                    item.SubItems.Add(musicName);
                    item.SubItems.Add(musicDuration);
                    item.SubItems.Add(musicReleaseDate);
                    item.SubItems.Add(musicAlbum);
                    item.SubItems.Add(musicGenre);
                    item.SubItems.Add(musicLanguage);
                    listView1.Items.Add(item);
                }

                // Fechamos o reader explicitamente
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }

        }
        private void pushToOriginalTable()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;

                SqlCommand cmd = new SqlCommand("ua_pushToOriginalTable", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idModerator", UserId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Processo de sincronização terminado.");
                loadMusicLogs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a dar push: " + ex.Message);
            }
        }


        // Método auxiliar para preencher a tela
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cn.Close(); //apenas fecha a conexao quando se fecha a janela
            Application.Exit(); // Encerra o programa

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadMusics();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadArtists();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadAlbums();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MusicEdit ed = new MusicEdit();
            ed.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ArtistEdit edArtist = new ArtistEdit(UserId);
            edArtist.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AlbumEdit edAlbum = new AlbumEdit(UserId);
            edAlbum.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadMusicLogs();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pushToOriginalTable();
        }

        private void ModeratorPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cn != null && cn.State == ConnectionState.Open)
            {
                cn.Close();
                cn.Dispose();
            }

            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser(UserId);
            editUser.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}