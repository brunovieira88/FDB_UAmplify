using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Xml.Linq;

namespace FBD_2526
{
    public partial class Registo : Form
    {
        private SqlConnection? cn;
        private bool isLoading = false;
        public Registo()
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

        private void Register()
        {
            string userType = "Listener";
            if (string.IsNullOrWhiteSpace(textUserName.Text) ||
            string.IsNullOrWhiteSpace(textPassword.Text) ||
            string.IsNullOrWhiteSpace(textEmail.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("A data de nascimento não pode ser no futuro.");
                return;
            }
            DateTime dataNascimento = dateTimePicker1.Value;

            try
            {
                if (!verifySGBDConnection()) return;

                SqlCommand cmd = new SqlCommand("ua_registerUser", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Passar os parâmetros
                cmd.Parameters.AddWithValue("@username", textUserName.Text);
                cmd.Parameters.AddWithValue("@password", textPassword.Text);
                cmd.Parameters.AddWithValue("@email", textEmail.Text);
                cmd.Parameters.AddWithValue("@name", textName.Text);
                cmd.Parameters.AddWithValue("@country", registerCountry.Text);
                cmd.Parameters.AddWithValue("@birthDate", dataNascimento);

                cmd.ExecuteNonQuery();
                MessageBox.Show($"Registado com sucesso como {userType}!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Register();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Register_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
