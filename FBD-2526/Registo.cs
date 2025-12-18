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

        /*

        private void Register()
        {
            
        }
        */


        private string getTableContent(SqlConnection CN)
        {
            string str = "";

            try
            {
                CN.Open();
                if (CN.State == ConnectionState.Open)
                {
                    int cnt = 1;
                    SqlCommand sqlcmd = new SqlCommand("SELECT * FROM Hello", CN);
                    SqlDataReader reader;
                    reader = sqlcmd.ExecuteReader();

                    while (reader.Read())
                    {
                        str += cnt.ToString() + " - " + reader.GetInt32(reader.GetOrdinal("MsgID")) + ", ";
                        str += reader.GetString(reader.GetOrdinal("MsgSubject"));
                        str += "\n";
                        cnt += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open connection to database due to the error \r\n" + ex.Message, "Connection Error", MessageBoxButtons.OK);
            }

            if (CN.State == ConnectionState.Open)
                CN.Close();

            return str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userType = "Listener"; // Valor por defeito

            // Se o código estiver correto, muda para Moderator
            if (AccessCode.Text == "ADMIN123")
            {
                userType = "Moderator";
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

                cmd.Parameters.AddWithValue("@birthDate", dataNascimento);

                // Envia o tipo que decidimos acima
                cmd.Parameters.AddWithValue("@userType", userType);

                cmd.ExecuteNonQuery();
                MessageBox.Show($"Registado com sucesso como {userType}!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
