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
    public partial class Albums : Form
    {
        private int UserId;
        public Albums(int userId)
        {
            this.UserId = userId;
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(UserId);
            home.Show();
            this.Hide();
        }

        private void btnMusics_Click(object sender, EventArgs e)
        {
            Musics musicPage = new Musics(UserId);
            musicPage.Show();
            this.Hide();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(UserId);
            editProfile.Show();
            this.Hide();
        }

        private void Albums_Load(object sender, EventArgs e)
        {

        }

        private void Albums_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
