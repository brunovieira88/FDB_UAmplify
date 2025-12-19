using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FBD_2526
{
    public partial class MusicEdit : Form
    {
        private bool isLoading = false;

        public MusicEdit()
        {
            InitializeComponent();
        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;" +
                "Initial Catalog=" + "p1g3;" +
                "User ID=" + "p1g3;" +
                "Password=" + "AD9CRu)XY8K;" +
                "Encrypt=false;"); 
        }


        private void loadMusic()
        {
            isLoading = true; 
            try
            {
                using (SqlConnection cn = getSGBDConnection())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM uamplify.musicView WHERE id = @id", cn);
                    cmd.Parameters.AddWithValue("@id", IdMusic.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            IdMusic.Text = reader["id"].ToString();
                            musicName.Text = reader["name"].ToString();
                            musicDuration.Text = reader["duration"].ToString();
                            musicReleaseDate.Text = reader["releaseDate"].ToString();
                            musicAlbumId.Text = reader["idalbum"].ToString();
                            musicAlbumName.Text = reader["albumName"].ToString();
                            musicArtistId.Text = reader["idArtist"].ToString();
                            musicIdGenre.Text = reader["idGenre"].ToString();
                            musicGenreName.Text = reader["genreType"].ToString();
                            musicLanguage.Text = reader["language"].ToString();
                            musicLyrics.Text = reader["lyrics"].ToString();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar musica: " + ex.Message);
            }
            finally
            {
                isLoading = false;
            }
        }

        public void loadAlbumName()
        {
            if (isLoading) return;

            try
            {
                using (SqlConnection cn = getSGBDConnection())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT name FROM uamplify.album WHERE id = @id", cn);
                    cmd.Parameters.AddWithValue("@id", musicAlbumId.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        musicAlbumName.Text = reader["name"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar álbum: " + ex.Message);
            }
        }

        public void loadGenreType()
        {
            if (isLoading) return;

            try
            {
                using (SqlConnection cn = getSGBDConnection())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT genreType FROM uamplify.genreType WHERE idGenre = @id", cn);
                    cmd.Parameters.AddWithValue("@id", musicIdGenre.Text);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        musicGenreName.Text = result.ToString();
                    else
                        musicGenreName.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar género: " + ex.Message);
            }
        }

        private void InsertUpdateMusicLog(String operation)
        {
            try
            {
                using (SqlConnection cn = getSGBDConnection())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("ua_registInsertUpdateLog", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@operation", operation);
                    cmd.Parameters.AddWithValue("@musicId", IdMusic.Text);
                    cmd.Parameters.AddWithValue("@musicName", musicName.Text);
                    cmd.Parameters.AddWithValue("@musicDuration", musicDuration.Text);
                    cmd.Parameters.AddWithValue("@musicReleaseDate", Convert.ToDateTime(musicReleaseDate.Text));
                    cmd.Parameters.AddWithValue("@musicIdAlbum", musicAlbumId.Text);
                    cmd.Parameters.AddWithValue("@musicIdGenre", musicIdGenre.Text);
                    cmd.Parameters.AddWithValue("@musicLanguage", musicLanguage.Text);
                    cmd.Parameters.AddWithValue("@musicLyrics", musicLyrics.Text);
                    cmd.Parameters.AddWithValue("@primaryArtistId", musicArtistId.Text);

                    DataTable featTable = new DataTable();
                    featTable.Columns.Add("id", typeof(int));

                    foreach (var item in listFeats.Items)
                    {
                        if (item is ArtistItem artist)
                        {
                            featTable.Rows.Add(artist.Id);
                        }
                    }
                    SqlParameter tvpParam = cmd.Parameters.AddWithValue("@featArtistIds", featTable);
                    tvpParam.SqlDbType = SqlDbType.Structured;
                    tvpParam.TypeName = "uamplify.ArtistIdList";

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Log atualizado com sucesso na tabela temporária!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir: " + ex.Message);
            }
        }

        private void DeleteMusicLog()
        {
            try
            {
                using (SqlConnection cn = getSGBDConnection())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("ua_registDeleteLog", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@operation", "DELETE");
                    cmd.Parameters.AddWithValue("@musicId", IdMusic.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Música marcada para remoção");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar: " + ex.Message);
            }
        }

        private void loadPrimaryFeats()
        {
            try
            {
                using (SqlConnection cn = getSGBDConnection())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT id, name FROM uamplify.musicFeats(@id)", cn);
                    cmd.Parameters.AddWithValue("@id", IdMusic.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listFeats.Items.Clear();
                        while (reader.Read())
                        {
                            ArtistItem item = new ArtistItem();
                            item.Id = Convert.ToInt32(reader["id"]);
                            item.Name = reader["name"].ToString();
                            listFeats.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar feats: " + ex.Message);
            }
        }

        private void addMusicFeat()
        {
            string idToSearch = featArtistId.Text;
            if (string.IsNullOrEmpty(idToSearch)) return;
            foreach (var item in listFeats.Items)
            {
                if (item is ArtistItem ai && ai.Id.ToString() == idToSearch)
                {
                    MessageBox.Show("Este artista já está na lista.");
                    return;
                }
            }

            try
            {
                using (SqlConnection cn = getSGBDConnection())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT name FROM uamplify.artist WHERE id = @id", cn);
                    cmd.Parameters.AddWithValue("@id", idToSearch);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        ArtistItem newItem = new ArtistItem { Id = int.Parse(idToSearch), Name = result.ToString() };
                        listFeats.Items.Add(newItem);
                        featArtistId.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Artista não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar artista: " + ex.Message);
            }
        }

        private void getPrimaryArtist()
        {
            if (isLoading) return;

            try
            {
                using (SqlConnection cn = getSGBDConnection())
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM uamplify.artistView WHERE id = @id", cn);
                    cmd.Parameters.AddWithValue("@id", musicArtistId.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            musicArtistId.Text = reader["id"].ToString();
                            musicArtistName.Text = reader["name"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar artista principal: " + ex.Message);
            }
        }

        private void removeMusicFeats()
        {
            if (listFeats.SelectedIndex != -1)
                listFeats.Items.RemoveAt(listFeats.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadMusic();
            loadPrimaryFeats();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            loadAlbumName();
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
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

        private void btnAddFeat_Click(object sender, EventArgs e)
        {
            addMusicFeat();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            removeMusicFeats();
        }
        private void musicArtistId_TextChanged_1(object sender, EventArgs e)
        {
            getPrimaryArtist();
        }
    }

    public class ArtistItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
    }
}