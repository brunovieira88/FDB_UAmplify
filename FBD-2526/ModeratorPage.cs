using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Usando a biblioteca moderna

namespace FBD_2526
{
    public partial class ModeratorPage : Form
    {
        private SqlConnection? cn;
        private int currentContact;
        private bool adding;

        public ModeratorPage()
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
                    Music M = new Music();
                    M.musicID = reader["id"]?.ToString() ?? "";
                    M.Name = reader["name"]?.ToString() ?? "";
                    M.Duration = reader["duration"]?.ToString() ?? "";
                    M.ReleaseDate = reader["releaseDate"]?.ToString() ?? "";
                    M.IdAlbum = reader["albumName"]?.ToString() ?? "";
                    M.IdGenre = reader["genreType"]?.ToString() ?? "";
                    M.Language = reader["language"]?.ToString() ?? "";
                    M.Lyrics = reader["lyrics"]?.ToString() ?? "";

                    ListViewItem item = new ListViewItem(M.musicID);
                    item.SubItems.Add(M.Name);
                    item.SubItems.Add(M.Duration);
                    item.SubItems.Add(M.ReleaseDate);
                    item.SubItems.Add(M.IdAlbum);
                    item.SubItems.Add(M.IdGenre);
                    item.SubItems.Add(M.Language);

                    item.Tag = M;

                    listView1.Items.Add(item);
                }

                // Fechamos o reader explicitamente
                reader.Close();
                currentContact = 0;
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
                    Artist A = new Artist();
                    A.artistID = reader["id"]?.ToString() ?? "";
                    A.Name = reader["name"]?.ToString() ?? "";
                    A.IdGenre = reader["genretype"]?.ToString() ?? "";
                    A.Verified = reader["verified"]?.ToString() ?? "";

                    ListViewItem item = new ListViewItem(A.artistID);
                    item.SubItems.Add(A.Name);
                    item.SubItems.Add(A.IdGenre);
                    item.SubItems.Add(A.Verified); // O GET retorna "Sim"/"Não"

                    item.Tag = A; // Guarda o objeto

                    listView1.Items.Add(item);
                }

                // Fechamos o reader explicitamente
                reader.Close();
                currentContact = 0;
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
                listView1.Columns.Add("Artista", 80);

                while (reader.Read())
                {
                    Album A = new Album();
                    A.albumID = reader["id"]?.ToString() ?? "";
                    A.Name = reader["name"]?.ToString() ?? "";
                    A.AlbumIdArtist = reader["artistName"]?.ToString() ?? "";
                    ListViewItem item = new ListViewItem(A.albumID);
                    item.SubItems.Add(A.Name);
                    item.SubItems.Add(A.AlbumIdArtist);

                    item.Tag = A; // Guarda o objeto

                    listView1.Items.Add(item);
                }

                // Fechamos o reader explicitamente
                reader.Close();
                currentContact = 0;
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

                listView1.Columns.Add("ID", 50);
                listView1.Columns.Add("Nome", 200);
                listView1.Columns.Add("Username", 200);
                listView1.Columns.Add("E-mail", 200);


                while (reader.Read())
                {
                    User U = new User();
                    U.userID = reader["userId"]?.ToString() ?? "";
                    U.Name = reader["name"]?.ToString() ?? "";
                    U.userName = reader["username"]?.ToString() ?? "";
                    U.userEmail = reader["email"]?.ToString() ?? "";
                    ListViewItem item = new ListViewItem(U.userID);
                    item.SubItems.Add(U.Name);
                    item.SubItems.Add(U.userName);
                    item.SubItems.Add(U.userEmail);

                    item.Tag = U; // Guarda o objeto

                    listView1.Items.Add(item);
                }

                // Fechamos o reader explicitamente
                reader.Close();
                currentContact = 0;
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
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var tag = listView1.SelectedItems[0].Tag;

                if (tag is Music music)
                {
                    MessageBox.Show($"Música selecionada: {music.Name}");
                }
                else if (tag is Artist artist)
                {
                    MessageBox.Show($"Artista selecionado: {artist.Name}");
                }
                else if (tag is Album album)
                {
                    MessageBox.Show($"Álbum selecionado: {album.Name}");
                }
            }
        }

        // Método auxiliar para preencher a tela
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            ArtistEdit edArtist = new ArtistEdit();
            edArtist.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AlbumEdit edAlbum = new AlbumEdit();
            edAlbum.Show();

        }
    }
}