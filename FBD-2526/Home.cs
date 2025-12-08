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
    public partial class Home : Form
    {
        private int UserId;
        public Home(int userId)
        {
            UserId = userId;
            InitializeComponent();

        }

        private void btnMusics_Click(object sender, EventArgs e)
        {

        }

        private void toolbarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardTopHits_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listRecentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(UserId);
            editProfile.Show();
            this.Close();
        }
    }
}
