using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class EditUser : Form
    {
        private SqlConnection? cn;
        private int UserId;
        private int _targetUserId = -1;
        public EditUser(int userId)
        {
            InitializeComponent();
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

        private void loadUser()
        {
            try
            {
                if (!verifySGBDConnection())
                    return;
                SqlCommand cmd = new SqlCommand("ua_loadUser", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", userUsername.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userName.Text = reader["name"]?.ToString() ?? "";
                    userEmail.Text = reader["email"]?.ToString() ?? "";
                    _targetUserId = Convert.ToInt32(reader["userId"]?.ToString());

                    if (reader["birthDate"] != DBNull.Value)
                    {
                        userBirthDate.Value = Convert.ToDateTime(reader["birthDate"]);
                    }
                    ;
                }
                else
                {
                    MessageBox.Show("Utilizador não encontrado.");
                    _targetUserId = -1;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar user: ");
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }


        private void updateUser()
        {
            if (!verifySGBDConnection()) return;

            if (_targetUserId == -1)
            {
                MessageBox.Show("Por favor carregue um utilizador primeiro.");
                return;
            }

            SqlCommand cmd = new SqlCommand("ua_updateUser", cn);
            cmd.CommandType = CommandType.StoredProcedure; // Define que é uma SP
            cmd.Parameters.AddWithValue("@idModerator", UserId);
            cmd.Parameters.AddWithValue("@idUser", _targetUserId);
            cmd.Parameters.AddWithValue("@username", userUsername.Text);
            cmd.Parameters.AddWithValue("@name", userName.Text);
            cmd.Parameters.AddWithValue("@email", userEmail.Text);
            cmd.Parameters.AddWithValue("@password", userPassword.Text);

            if (userBirthDate.Value > DateTime.Now)
            {
                MessageBox.Show("A data do album não pode ser no futuro.");
                return;
            }

            cmd.Parameters.AddWithValue("@birthDate", userBirthDate.Value);
            try
            {
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("User atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o user");
            }
            finally
            {
                cn.Close();
            }
        }

        private void deleteUser()
        {
            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("ua_deleteUser", cn);
            cmd.CommandType = CommandType.StoredProcedure; // Define que é uma SP
            cmd.Parameters.AddWithValue("@idModerator", UserId);
            cmd.Parameters.AddWithValue("@username", userUsername.Text);
            try
            {
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show("User removido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover o User");
            }
            finally
            {
                cn.Close();
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            loadUser();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateUser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteUser();
        }
    }
}
