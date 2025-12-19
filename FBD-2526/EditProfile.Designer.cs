namespace FBD_2526
{
    partial class EditProfile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            this.toolbarPanel = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnPlaylists = new System.Windows.Forms.Button();
            this.btnAlbums = new System.Windows.Forms.Button();
            this.btnMusics = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblXP = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateBorn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolbarPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // 
            // toolbarPanel
            // 
            this.toolbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toolbarPanel.Controls.Add(this.btnPerfil);
            this.toolbarPanel.Controls.Add(this.btnPlaylists);
            this.toolbarPanel.Controls.Add(this.btnAlbums);
            this.toolbarPanel.Controls.Add(this.btnMusics);
            this.toolbarPanel.Controls.Add(this.btnHome);
            this.toolbarPanel.Controls.Add(this.lblLogo);
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Size = new System.Drawing.Size(1333, 92);
            this.toolbarPanel.TabIndex = 0;
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnPerfil.Location = new System.Drawing.Point(893, 23);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(120, 46);
            this.btnPerfil.TabIndex = 5;
            this.btnPerfil.Text = "Profile";
            this.btnPerfil.UseVisualStyleBackColor = false;

            this.btnPlaylists.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylists.FlatAppearance.BorderSize = 0;
            this.btnPlaylists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylists.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPlaylists.ForeColor = System.Drawing.Color.White;
            this.btnPlaylists.Location = new System.Drawing.Point(733, 23);
            this.btnPlaylists.Name = "btnPlaylists";
            this.btnPlaylists.Size = new System.Drawing.Size(120, 46);
            this.btnPlaylists.TabIndex = 4;
            this.btnPlaylists.Text = "Playlists";
            this.btnPlaylists.UseVisualStyleBackColor = false;
            this.btnPlaylists.Click += new System.EventHandler(this.btnPlaylists_Click);

            this.btnAlbums.BackColor = System.Drawing.Color.Transparent;
            this.btnAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlbums.FlatAppearance.BorderSize = 0;
            this.btnAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlbums.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAlbums.ForeColor = System.Drawing.Color.White;
            this.btnAlbums.Location = new System.Drawing.Point(600, 23);
            this.btnAlbums.Name = "btnAlbums";
            this.btnAlbums.Size = new System.Drawing.Size(120, 46);
            this.btnAlbums.TabIndex = 3;
            this.btnAlbums.Text = "Albums";
            this.btnAlbums.UseVisualStyleBackColor = false;
            this.btnAlbums.Click += new System.EventHandler(this.btnAlbums_Click);

            this.btnMusics.BackColor = System.Drawing.Color.Transparent;
            this.btnMusics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusics.FlatAppearance.BorderSize = 0;
            this.btnMusics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusics.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMusics.ForeColor = System.Drawing.Color.White;
            this.btnMusics.Location = new System.Drawing.Point(467, 23);
            this.btnMusics.Name = "btnMusics";
            this.btnMusics.Size = new System.Drawing.Size(120, 46);
            this.btnMusics.TabIndex = 2;
            this.btnMusics.Text = "Musics";
            this.btnMusics.UseVisualStyleBackColor = false;
            this.btnMusics.Click += new System.EventHandler(this.btnMusics_Click);

            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(333, 23);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 46);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);

            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.lblLogo.Location = new System.Drawing.Point(27, 23);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(153, 41);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "UAmplify";

            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));

      
            this.contentPanel.Controls.Add(this.lblStatus);
            this.contentPanel.Controls.Add(this.lblXP);

            this.contentPanel.Controls.Add(this.btnEdit);
            this.contentPanel.Controls.Add(this.lblTitle);
            this.contentPanel.Controls.Add(this.panelDivider);
            this.contentPanel.Controls.Add(this.btnCancel);
            this.contentPanel.Controls.Add(this.btnDone);
            this.contentPanel.Controls.Add(this.txtPassword);
            this.contentPanel.Controls.Add(this.label6);
            this.contentPanel.Controls.Add(this.txtCountry);
            this.contentPanel.Controls.Add(this.label5);
            this.contentPanel.Controls.Add(this.dateBorn);
            this.contentPanel.Controls.Add(this.label4);
            this.contentPanel.Controls.Add(this.txtEmail);
            this.contentPanel.Controls.Add(this.label3);
            this.contentPanel.Controls.Add(this.txtUserName);
            this.contentPanel.Controls.Add(this.label2);
            this.contentPanel.Controls.Add(this.txtName);
            this.contentPanel.Controls.Add(this.label1);
            this.contentPanel.Controls.Add(this.pictureBox1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 92);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(40, 46, 40, 46);
            this.contentPanel.Size = new System.Drawing.Size(1333, 963);
            this.contentPanel.TabIndex = 1;

            // 
            // lblXP
            // 
            this.lblXP.AutoSize = true;
            this.lblXP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblXP.ForeColor = System.Drawing.Color.LightGray;
            this.lblXP.Location = new System.Drawing.Point(40, 330);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(100, 28);
            this.lblXP.TabIndex = 40;
            this.lblXP.Text = "Total XP: 0";

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Gold; // Dourado
            this.lblStatus.Location = new System.Drawing.Point(40, 360);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 32);
            this.lblStatus.TabIndex = 41;
            this.lblStatus.Text = "Loading...";

            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(707, 480);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 45);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(40, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 54);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Edit Profile";

            // panelDivider
            this.panelDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelDivider.Location = new System.Drawing.Point(40, 100);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(822, 1);
            this.panelDivider.TabIndex = 36;

            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(570, 480);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 45);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // btnDone
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDone.ForeColor = System.Drawing.Color.Black;
            this.btnDone.Location = new System.Drawing.Point(707, 480);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(155, 45);
            this.btnDone.TabIndex = 32;
            this.btnDone.Text = "SAVE PROFILE";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);

            // txtPassword
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(282, 382);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(580, 32);
            this.txtPassword.TabIndex = 30;

            // label6
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label6.Location = new System.Drawing.Point(282, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Password";

            // txtCountry
            this.txtCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCountry.ForeColor = System.Drawing.Color.Black;
            this.txtCountry.Location = new System.Drawing.Point(282, 302);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(281, 32);
            this.txtCountry.TabIndex = 28;

            // label5
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label5.Location = new System.Drawing.Point(282, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Country";

            // dateBorn
            this.dateBorn.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dateBorn.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.dateBorn.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dateBorn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateBorn.Location = new System.Drawing.Point(612, 302);
            this.dateBorn.Name = "dateBorn";
            this.dateBorn.Size = new System.Drawing.Size(250, 32);
            this.dateBorn.TabIndex = 26;

            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label4.Location = new System.Drawing.Point(612, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Birth Date";

            // txtEmail
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(282, 222);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(580, 32);
            this.txtEmail.TabIndex = 24;

            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label3.Location = new System.Drawing.Point(282, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Email";

            // txtUserName
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(610, 142);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(252, 32);
            this.txtUserName.TabIndex = 22;

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label2.Location = new System.Drawing.Point(610, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "UserName";

            // txtName
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(282, 142);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 32);
            this.txtName.TabIndex = 20;

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(282, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";

            // pictureBox1
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;

            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1333, 1055);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.toolbarPanel);
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditProfile_FormClosed);
            this.Load += new System.EventHandler(this.EditProfile_Load);
            this.toolbarPanel.ResumeLayout(false);
            this.toolbarPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel toolbarPanel;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnPlaylists;
        private System.Windows.Forms.Button btnAlbums;
        private System.Windows.Forms.Button btnMusics;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDivider;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateBorn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblXP; // NOVO
        private System.Windows.Forms.Label lblStatus; // NOVO
    }
}