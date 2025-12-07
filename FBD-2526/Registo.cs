using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Xml.Linq;

namespace FBD_2526
{
    public partial class Registo : Form
    {
        public Registo()
        {
            InitializeComponent();
        }

        private void Register(string name, string userName, string email, string userPass, DateTime birthday)
        {
            // Verificação dos campos obrigatórios
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(userName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(userPass))
            {
                MessageBox.Show("Por favor, preencha todos os campos.",
                                "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Ligação ao SQL Server
            string connectionString =
                "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;" +
                "Initial Catalog=" + "p1g3;" +
                "User ID=" + "p1g3;" +
                "Password=" + "AD9CRu)XY8K;" +
                "Encrypt=false;";

            using (SqlConnection CN = new SqlConnection(connectionString))
            {
                try
                {
                    CN.Open();

                    if (CN.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Não foi possível ligar à base de dados!",
                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string sql =
                        "INSERT INTO uamplify.appuser (name, username, email, password, birthDate)" +
                        "VALUES (@name, @username, @email, @password, @birth);";

                    using (SqlCommand cmd = new SqlCommand(sql, CN))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@username", userName);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", userPass);
                        cmd.Parameters.AddWithValue("@birth", birthday);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registo efetuado com sucesso!",
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro SQL:\n" + ex.Message,
                                    "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado:\n" + ex.Message,
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



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
            Register(textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text, dtpNascimento.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
