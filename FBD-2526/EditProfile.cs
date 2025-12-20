using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FBD_2526
{
    public partial class EditProfile : Form
    {
        private int UserId;
        private string connectionString =
            "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;" +
            "Initial Catalog=p1g3;" +
            "User ID=p1g3;" +
            "Password=AD9CRu)XY8K;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";
        //para guardar o estado original 
        private string ogName;
        private string ogUserName;
        private string ogEmail;
        //private string ogPassword;
        private string ogCountry;
        private DateTime ogBornDate = DateTime.Now;

        public EditProfile(int userId)
        {
            UserId = userId;
            InitializeComponent();
            //para debug
            MessageBox.Show("ID recebido: " + UserId);
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            FetchData();
            SetEditingMode(false);

        }
        private void SetEditingMode(bool enable)
        {
            ToggleField(txtName, enable);
            ToggleField(txtUserName, enable);
            ToggleField(txtEmail, enable);
            ToggleField(txtCountry, enable);
            ToggleField(txtPassword, enable);
            dateBorn.Enabled = enable;
            btnEdit.Visible = !enable;
            btnDone.Visible = enable;
            btnCancel.Visible = enable;
        }

        private void ToggleField(TextBox txt, bool enable)
        {
            txt.ReadOnly = !enable;
            txt.BackColor = enable ? Color.White : Color.White;
            txt.BorderStyle = enable ? BorderStyle.FixedSingle : BorderStyle.None;
        }
        private bool changesMade()
        {
            if (txtName.Text != ogName) return true;
            if (txtUserName.Text != ogUserName) return true;
            if (txtEmail.Text != ogEmail) return true;
            if (txtCountry.Text != ogCountry) return true;
            if (txtPassword.Text != " ") return true;
            if (dateBorn.Value.Date != ogBornDate.Date) return true;

            return false;
        }
        private void FetchData()
        {

            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("uamplify.getUserData", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", UserId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtName.Text = reader["name"].ToString();
                            txtUserName.Text = reader["username"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            dateBorn.Value = (DateTime)(reader["birthDate"]);
                            //txtPassword.Text = reader["password"].ToString();
                            txtCountry.Text = reader["country"].ToString();

                            lblXP.Text = "Total XP: " + reader["xp"].ToString();
                            lblStatus.Text = reader["Status"].ToString();
                            string status = lblStatus.Text;
                            if (status.Contains("Gold")) lblStatus.ForeColor = Color.Gold;
                            else if (status.Contains("Silver")) lblStatus.ForeColor = Color.Silver;
                            else lblStatus.ForeColor = Color.SandyBrown;
                            ogName = txtName.Text;
                            ogUserName = txtUserName.Text;
                            ogEmail = txtEmail.Text;
                            ogBornDate = dateBorn.Value;
                            //ogPassword = txtPassword.Text;
                            ogCountry = txtCountry.Text;


                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR" +
                Constants.vbCrLf + ex.Message, MsgBoxStyle.Critical, "Connection Test");
            }
            cn.Close();
        }

        private void Save()
        {
            if (!changesMade())
            {
                MessageBox.Show("Não foram detetadas alterações.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetEditingMode(false);
                return;
            }

            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("uamplify.updateUserData", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", UserId);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", dateBorn.Value);
                    cmd.Parameters.AddWithValue("@Country", txtCountry.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Profile changes saved with success!");

                    ogName = txtName.Text;
                    ogEmail = txtEmail.Text;
                    //ogPassword = txtPassword.Text;
                    ogCountry = txtCountry.Text;
                    ogUserName = txtUserName.Text;
                    ogBornDate = dateBorn.Value;

                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR" +
                Constants.vbCrLf + ex.Message, MsgBoxStyle.Critical, "Connection Test");
            }
            cn.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnDone.Visible)
            {

                txtName.Text = ogName;
                txtEmail.Text = ogEmail;
                //txtPassword.Text = ogPassword;
                txtCountry.Text = ogCountry;
                txtUserName.Text = ogUserName;
                dateBorn.Value = ogBornDate;

                SetEditingMode(false);
            }
            else
            {
                this.Close();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateBorn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(UserId);
            home.Show();
            this.Hide();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            SetEditingMode(true);
        }

        private void EditProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            Albums albums = new Albums(UserId);
            albums.Show();
            this.Hide();
        }

        private void btnMusics_Click(object sender, EventArgs e)
        {
            Musics musicPage = new Musics(UserId);
            musicPage.Show();
            this.Hide();
        }

        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            Playlists playlists = new Playlists(UserId);
            playlists.Show();
            this.Hide();
        }

        private void btnCommunity_Click(object sender, EventArgs e)
        {
            Listeners listeners = new Listeners(UserId);
            listeners.Show();
            this.Hide();
        }
    }
}
