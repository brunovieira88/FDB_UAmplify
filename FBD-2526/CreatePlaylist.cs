using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FBD_2526
{
    public partial class CreatePlaylist : Form
    {
        private int UserId;
        private string connectionString =
                           "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;" +
                           "Initial Catalog=p1g3;" +
                           "User ID=p1g3;" +
                           "Password=AD9CRu)XY8K;" +
                           "Encrypt=True;" +
                           "TrustServerCertificate=True;";
        public CreatePlaylist(int userId)
        {
            this.UserId = userId;
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("enter a playlist name.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("uamplify.CreateNewPlaylist", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserId", this.UserId);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@IsPrivate", chkPrivate.Checked);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("playlist created");
                    this.Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error creating playlist: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}