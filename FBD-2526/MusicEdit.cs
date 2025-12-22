using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FBD_2526
{
    public partial class MusicEdit : Form
    {
        private bool isLoading = false;

        public MusicEdit()
        {
            InitializeComponent();
            chkIsAlbum.CheckedChanged += ChkIsAlbum_CheckedChanged;
            UpdateFieldsVisibility();
            ToggleFormState(false);
        }

        private void UpdateFieldsVisibility()
        {
            bool isAlbum = chkIsAlbum.Checked;
            label5.Visible = isAlbum;         
            musicAlbumId.Visible = isAlbum;   
            musicAlbumName.Visible = isAlbum; 
            labelPrimaryArtist.Visible = !isAlbum; 
            musicArtistId.Visible = !isAlbum;     
            musicArtistName.Visible = !isAlbum;   
        }

        private void ChkIsAlbum_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFieldsVisibility();

            if (chkIsAlbum.Checked)
            {
                musicArtistId.Text = "";
                musicArtistName.Text = "";
            }
            else
            {
                musicAlbumId.Text = "";
                musicAlbumName.Text = "";
            }
        }

        private void ToggleFormState(bool isEditMode)
        {
            button3.Visible = !isEditMode;
            button4.Visible = isEditMode;
            button2.Visible = isEditMode;

            labelFeats.Visible = isEditMode;
            featArtistId.Visible = isEditMode;
            btnAddFeat.Visible = isEditMode;
            listFeats.Visible = isEditMode;
            button5.Visible = isEditMode;
        }

        private void ClearFields()
        {
            IdMusic.Text = "";
            musicName.Text = "";
            musicDuration.Text = "";
            musicAlbumId.Text = "";
            musicAlbumName.Text = "";
            musicIdGenre.Text = "";
            musicGenreName.Text = "";
            musicLanguage.Text = "";
            musicLyrics.Text = "";
            musicArtistId.Text = "";
            musicArtistName.Text = "";
            listFeats.Items.Clear();
            featArtistId.Text = "";
            chkIsAlbum.Checked = false;
            UpdateFieldsVisibility();
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
            bool found = false;
            try
            {
                using (SqlConnection cn = getSGBDConnection())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM uamplify.musicView WHERE id = @id", cn);
                    cmd.Parameters.AddWithValue("@id", IdMusic.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            found = true;
                            IdMusic.Text = reader["id"].ToString();
                            musicName.Text = reader["name"].ToString();
                            musicDuration.Text = reader["duration"].ToString();
                            string albumId = reader["idalbum"].ToString();
                            string artistId = reader["idArtist"].ToString();
                            if (reader["releaseDate"] != DBNull.Value)
                            {
                                musicReleaseDate.Value = Convert.ToDateTime(reader["releaseDate"]);
                            }

                            musicAlbumId.Text = albumId;
                            musicAlbumName.Text = reader["albumName"].ToString();

                            musicArtistId.Text = artistId;
                            if (!string.IsNullOrEmpty(albumId))
                            {
                                chkIsAlbum.Checked = true;
                            }
                            else
                            {
                                chkIsAlbum.Checked = false;
                            }
                            UpdateFieldsVisibility();

                            musicIdGenre.Text = reader["idGenre"].ToString();
                            musicGenreName.Text = reader["genreType"].ToString();
                            musicLanguage.Text = reader["language"].ToString();
                            musicLyrics.Text = reader["lyrics"].ToString();
                        }
                    }
                }

                if (found)
                {
                    if (!chkIsAlbum.Checked && !string.IsNullOrEmpty(musicArtistId.Text))
                    {
                        getPrimaryArtist();
                    }
                    ToggleFormState(true);
                }
                else
                {
                    MessageBox.Show("Música não encontrada com esse ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar musica: ");
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
                    if (reader.Read()) musicAlbumName.Text = reader["name"].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao carregar álbum: "); }
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
                    if (result != null) musicGenreName.Text = result.ToString();
                    else musicGenreName.Text = "";
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao carregar género: "); }
        }

        private DataTable GetFeatsFromListView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            foreach (var obj in listFeats.Items)
            {
                if (obj is ArtistItem item)
                {
                    dt.Rows.Add(item.Id);
                }
            }
            return dt;
        }

        private void InsertMusicLog(String operation)
        {
            try
            {
                using (SqlConnection cn = getSGBDConnection())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("ua_registInsertLog", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@operation", operation);
                    cmd.Parameters.AddWithValue("@musicId", IdMusic.Text);
                    cmd.Parameters.AddWithValue("@musicName", musicName.Text);
                    cmd.Parameters.AddWithValue("@musicDuration", musicDuration.Text);

                    if (musicReleaseDate.Value > DateTime.Now)
                    {
                        MessageBox.Show("A data da musica não pode ser no futuro.");
                        return;
                    }
                    cmd.Parameters.AddWithValue("@musicReleaseDate", musicReleaseDate.Value);
                    if (chkIsAlbum.Checked)
                    {
                        if (string.IsNullOrEmpty(musicAlbumId.Text))
                            cmd.Parameters.AddWithValue("@musicIdAlbum", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@musicIdAlbum", musicAlbumId.Text);

                        cmd.Parameters.AddWithValue("@primaryArtistId", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@musicIdAlbum", DBNull.Value);

                        if (string.IsNullOrEmpty(musicArtistId.Text))
                            cmd.Parameters.AddWithValue("@primaryArtistId", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@primaryArtistId", musicArtistId.Text);
                    }

                    cmd.Parameters.AddWithValue("@musicIdGenre", musicIdGenre.Text);
                    cmd.Parameters.AddWithValue("@musicLanguage", musicLanguage.Text);
                    cmd.Parameters.AddWithValue("@musicLyrics", musicLyrics.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Log atualizado com sucesso na tabela temporária!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao inserir: "); }
        }


        private void UpdateMusicLog(String operation)
        {
            try
            {
                using (SqlConnection cn = getSGBDConnection())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("uamplify.ua_registUpdateLog", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@operation", operation);
                    cmd.Parameters.AddWithValue("@musicId", IdMusic.Text);
                    cmd.Parameters.AddWithValue("@musicName", musicName.Text);
                    cmd.Parameters.AddWithValue("@musicDuration", musicDuration.Text);

                    if (musicReleaseDate.Value > DateTime.Now)
                    {
                        MessageBox.Show("A data da musica não pode ser no futuro.");
                        return;
                    }
                    cmd.Parameters.AddWithValue("@musicReleaseDate", musicReleaseDate.Value);
                    if (chkIsAlbum.Checked)
                    {
                        if (string.IsNullOrEmpty(musicAlbumId.Text))
                            cmd.Parameters.AddWithValue("@musicIdAlbum", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@musicIdAlbum", musicAlbumId.Text);

                        cmd.Parameters.AddWithValue("@primaryArtistId", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@musicIdAlbum", DBNull.Value);

                        if (string.IsNullOrEmpty(musicArtistId.Text))
                            cmd.Parameters.AddWithValue("@primaryArtistId", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@primaryArtistId", musicArtistId.Text);
                    }

                    cmd.Parameters.AddWithValue("@musicIdGenre", musicIdGenre.Text);
                    cmd.Parameters.AddWithValue("@musicLanguage", musicLanguage.Text);
                    cmd.Parameters.AddWithValue("@musicLyrics", musicLyrics.Text);

                    DataTable tabelaFeats = GetFeatsFromListView();

                    SqlParameter tvpParam = cmd.Parameters.AddWithValue("@featArtistIds", tabelaFeats);
                    tvpParam.SqlDbType = SqlDbType.Structured;  
                    tvpParam.TypeName = "uamplify.ArtistIdList";

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Log atualizado com sucesso na tabela temporária!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao inserir: "); }
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
            catch (Exception ex) { MessageBox.Show("Erro ao eliminar: "); }
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
            catch (Exception ex) { MessageBox.Show("Erro ao carregar feats: "); }
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
                    else MessageBox.Show("Artista não encontrado.");
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao buscar artista: "); }
        }

        private void getPrimaryArtist()
        {
            if (isLoading) return;
            if (musicArtistId.Visible == false) return;

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
            catch (Exception ex) { MessageBox.Show("Erro ao carregar artista principal: "); }
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

        private void textBox5_TextChanged(object sender, EventArgs e) { loadAlbumName(); }
        private void textBox6_TextChanged(object sender, EventArgs e) { loadGenreType(); }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertMusicLog("INSERT");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteMusicLog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateMusicLog("UPDATE");
        }

        private void btnAddFeat_Click(object sender, EventArgs e) { addMusicFeat(); }
        private void button5_Click(object sender, EventArgs e) { removeMusicFeats(); }
        private void musicArtistId_TextChanged_1(object sender, EventArgs e) { getPrimaryArtist(); }

        private void removeGet_Click(object sender, EventArgs e)
        {
            ClearFields();
            ToggleFormState(false);
        }
    }

    public class ArtistItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
    }
}