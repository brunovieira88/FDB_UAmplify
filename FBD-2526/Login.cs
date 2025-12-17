using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FBD_2526
{
    public partial class Login : Form
    {
        private int UserId;
        private string UserName;
        private string connectionString =
            "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;" +
            "Initial Catalog=p1g3;" +
            "User ID=p1g3;" +
            "Password=AD9CRu)XY8K;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;";
        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private bool ValidarLogin(string username, string password)
        {
            bool loginValido = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("uamplify.login", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@PassWord", password);

                    conn.Open();
                    //variaveis para o output
                    SqlParameter paramUserId = new SqlParameter("@UserId", SqlDbType.Int);
                    paramUserId.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramUserId);

                    SqlParameter paramName = new SqlParameter("@Name", SqlDbType.VarChar, 50);
                    paramName.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramName);

                    //return para ver se valid0 ou nao
                    SqlParameter paramReturn = new SqlParameter();
                    paramReturn.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(paramReturn);

                    cmd.ExecuteNonQuery();
                    int resultado = (int)paramReturn.Value;

                    if (resultado == 1)
                    {
                        loginValido = true;
                        UserId = (int)paramUserId.Value;
                        UserName = paramName.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar à base de dados:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return loginValido;
        }
        private bool isMod()
        {
            string query = "SELECT * FROM uamplify.moderator as m WHERE m.userId = @Id";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Id", UserId);
                    object res = cmd.ExecuteScalar();

                    return res != null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar à base de dados:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Introduz o username e a password.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarLogin(username, password))
            {
                MessageBox.Show($"Bem-vindo, {UserName}!\n(ID de Utilizador: {UserId})",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (isMod())
                {
                    ModeratorPage mp = new ModeratorPage();
                    this.Hide();
                    mp.Show();
                }
                else
                {
                    Home home = new Home(UserId);
                    this.Hide();
                    home.Show();
                }

            }
            else
            {
                MessageBox.Show("Username ou password incorretos.", "Erro de login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisto_Click(object sender, EventArgs e)
        {
            Registo registoForm = new Registo();
            this.Hide();
            registoForm.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
