namespace FBD_2526
{
    partial class ArtistPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtistPage));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            toolbarPanel = new Panel();
            btnPerfil = new Button();
            btnPlaylists = new Button();
            btnAlbums = new Button();
            btnMusics = new Button();
            btnHome = new Button();
            lblLogo = new Label();
            contentPanel = new Panel();
            btnFollow = new Button();
            pictureBox1 = new PictureBox();
            dgvArtistAlbums = new DataGridView();
            lblAlbumsTitle = new Label();
            dgvArtistMusics = new DataGridView();
            lblSongsTitle = new Label();
            lblDescription = new Label();
            lblGenre = new Label();
            lblVerified = new Label();
            lblArtistName = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btnCommunity = new Button();
            toolbarPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArtistAlbums).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArtistMusics).BeginInit();
            SuspendLayout();
            // 
            // toolbarPanel
            // 
            toolbarPanel.BackColor = Color.FromArgb(30, 30, 30);
            toolbarPanel.Controls.Add(btnCommunity);
            toolbarPanel.Controls.Add(btnPerfil);
            toolbarPanel.Controls.Add(btnPlaylists);
            toolbarPanel.Controls.Add(btnAlbums);
            toolbarPanel.Controls.Add(btnMusics);
            toolbarPanel.Controls.Add(btnHome);
            toolbarPanel.Controls.Add(lblLogo);
            toolbarPanel.Dock = DockStyle.Top;
            toolbarPanel.Location = new Point(0, 0);
            toolbarPanel.Margin = new Padding(4, 5, 4, 5);
            toolbarPanel.Name = "toolbarPanel";
            toolbarPanel.Size = new Size(1333, 92);
            toolbarPanel.TabIndex = 0;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.Transparent;
            btnPerfil.Cursor = Cursors.Hand;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Font = new Font("Segoe UI", 10F);
            btnPerfil.ForeColor = Color.White;
            btnPerfil.Location = new Point(1075, 23);
            btnPerfil.Margin = new Padding(4, 5, 4, 5);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(120, 46);
            btnPerfil.TabIndex = 5;
            btnPerfil.Text = "Profile ";
            btnPerfil.UseVisualStyleBackColor = false;
            // 
            // btnPlaylists
            // 
            btnPlaylists.BackColor = Color.Transparent;
            btnPlaylists.Cursor = Cursors.Hand;
            btnPlaylists.FlatAppearance.BorderSize = 0;
            btnPlaylists.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnPlaylists.FlatStyle = FlatStyle.Flat;
            btnPlaylists.Font = new Font("Segoe UI", 10F);
            btnPlaylists.ForeColor = Color.White;
            btnPlaylists.Location = new Point(733, 23);
            btnPlaylists.Margin = new Padding(4, 5, 4, 5);
            btnPlaylists.Name = "btnPlaylists";
            btnPlaylists.Size = new Size(120, 46);
            btnPlaylists.TabIndex = 4;
            btnPlaylists.Text = "Playlists";
            btnPlaylists.UseVisualStyleBackColor = false;
            // 
            // btnAlbums
            // 
            btnAlbums.BackColor = Color.Transparent;
            btnAlbums.Cursor = Cursors.Hand;
            btnAlbums.FlatAppearance.BorderSize = 0;
            btnAlbums.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnAlbums.FlatStyle = FlatStyle.Flat;
            btnAlbums.Font = new Font("Segoe UI", 10F);
            btnAlbums.ForeColor = Color.White;
            btnAlbums.Location = new Point(600, 23);
            btnAlbums.Margin = new Padding(4, 5, 4, 5);
            btnAlbums.Name = "btnAlbums";
            btnAlbums.Size = new Size(120, 46);
            btnAlbums.TabIndex = 3;
            btnAlbums.Text = "Albums";
            btnAlbums.UseVisualStyleBackColor = false;
            // 
            // btnMusics
            // 
            btnMusics.BackColor = Color.Transparent;
            btnMusics.Cursor = Cursors.Hand;
            btnMusics.FlatAppearance.BorderSize = 0;
            btnMusics.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnMusics.FlatStyle = FlatStyle.Flat;
            btnMusics.Font = new Font("Segoe UI", 10F);
            btnMusics.ForeColor = Color.White;
            btnMusics.Location = new Point(467, 23);
            btnMusics.Margin = new Padding(4, 5, 4, 5);
            btnMusics.Name = "btnMusics";
            btnMusics.Size = new Size(120, 46);
            btnMusics.TabIndex = 2;
            btnMusics.Text = "Musics";
            btnMusics.UseVisualStyleBackColor = false;
            btnMusics.Click += btnMusics_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(333, 23);
            btnHome.Margin = new Padding(4, 5, 4, 5);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(120, 46);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(30, 215, 96);
            lblLogo.Location = new Point(27, 23);
            lblLogo.Margin = new Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(153, 41);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "UAmplify";
            // 
            // contentPanel
            // 
            contentPanel.AutoScroll = true;
            contentPanel.BackColor = Color.FromArgb(18, 18, 18);
            contentPanel.Controls.Add(btnFollow);
            contentPanel.Controls.Add(pictureBox1);
            contentPanel.Controls.Add(dgvArtistAlbums);
            contentPanel.Controls.Add(lblAlbumsTitle);
            contentPanel.Controls.Add(dgvArtistMusics);
            contentPanel.Controls.Add(lblSongsTitle);
            contentPanel.Controls.Add(lblDescription);
            contentPanel.Controls.Add(lblGenre);
            contentPanel.Controls.Add(lblVerified);
            contentPanel.Controls.Add(lblArtistName);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 92);
            contentPanel.Margin = new Padding(4, 5, 4, 5);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(40, 46, 40, 46);
            contentPanel.Size = new Size(1333, 963);
            contentPanel.TabIndex = 1;
            // 
            // btnFollow
            // 
            btnFollow.BackColor = Color.FromArgb(40, 40, 40);
            btnFollow.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFollow.ForeColor = Color.FromArgb(30, 215, 96);
            btnFollow.Location = new Point(1176, 67);
            btnFollow.Name = "btnFollow";
            btnFollow.Size = new Size(114, 45);
            btnFollow.TabIndex = 8;
            btnFollow.Text = "Follow";
            btnFollow.UseVisualStyleBackColor = false;
            btnFollow.Click += btnFollow_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // dgvArtistAlbums
            // 
            dgvArtistAlbums.AllowUserToAddRows = false;
            dgvArtistAlbums.AllowUserToDeleteRows = false;
            dgvArtistAlbums.AllowUserToResizeRows = false;
            dgvArtistAlbums.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvArtistAlbums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArtistAlbums.BackgroundColor = Color.FromArgb(24, 24, 24);
            dgvArtistAlbums.BorderStyle = BorderStyle.None;
            dgvArtistAlbums.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvArtistAlbums.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(179, 179, 179);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvArtistAlbums.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvArtistAlbums.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(30, 215, 96);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvArtistAlbums.DefaultCellStyle = dataGridViewCellStyle6;
            dgvArtistAlbums.EnableHeadersVisualStyles = false;
            dgvArtistAlbums.GridColor = Color.FromArgb(40, 40, 40);
            dgvArtistAlbums.Location = new Point(44, 660);
            dgvArtistAlbums.MultiSelect = false;
            dgvArtistAlbums.Name = "dgvArtistAlbums";
            dgvArtistAlbums.ReadOnly = true;
            dgvArtistAlbums.RowHeadersVisible = false;
            dgvArtistAlbums.RowHeadersWidth = 51;
            dgvArtistAlbums.RowTemplate.Height = 45;
            dgvArtistAlbums.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArtistAlbums.Size = new Size(1240, 250);
            dgvArtistAlbums.TabIndex = 7;
            // 
            // lblAlbumsTitle
            // 
            lblAlbumsTitle.AutoSize = true;
            lblAlbumsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAlbumsTitle.ForeColor = Color.White;
            lblAlbumsTitle.Location = new Point(40, 610);
            lblAlbumsTitle.Margin = new Padding(4, 0, 4, 0);
            lblAlbumsTitle.Name = "lblAlbumsTitle";
            lblAlbumsTitle.Size = new Size(114, 37);
            lblAlbumsTitle.TabIndex = 6;
            lblAlbumsTitle.Text = "Albums";
            // 
            // dgvArtistMusics
            // 
            dgvArtistMusics.AllowUserToAddRows = false;
            dgvArtistMusics.AllowUserToDeleteRows = false;
            dgvArtistMusics.AllowUserToResizeRows = false;
            dgvArtistMusics.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvArtistMusics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArtistMusics.BackgroundColor = Color.FromArgb(24, 24, 24);
            dgvArtistMusics.BorderStyle = BorderStyle.None;
            dgvArtistMusics.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvArtistMusics.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(179, 179, 179);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvArtistMusics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvArtistMusics.ColumnHeadersHeight = 40;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(30, 215, 96);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvArtistMusics.DefaultCellStyle = dataGridViewCellStyle8;
            dgvArtistMusics.EnableHeadersVisualStyles = false;
            dgvArtistMusics.GridColor = Color.FromArgb(40, 40, 40);
            dgvArtistMusics.Location = new Point(44, 330);
            dgvArtistMusics.MultiSelect = false;
            dgvArtistMusics.Name = "dgvArtistMusics";
            dgvArtistMusics.ReadOnly = true;
            dgvArtistMusics.RowHeadersVisible = false;
            dgvArtistMusics.RowHeadersWidth = 51;
            dgvArtistMusics.RowTemplate.Height = 45;
            dgvArtistMusics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArtistMusics.Size = new Size(1240, 250);
            dgvArtistMusics.TabIndex = 5;
            // 
            // lblSongsTitle
            // 
            lblSongsTitle.AutoSize = true;
            lblSongsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSongsTitle.ForeColor = Color.White;
            lblSongsTitle.Location = new Point(40, 280);
            lblSongsTitle.Margin = new Padding(4, 0, 4, 0);
            lblSongsTitle.Name = "lblSongsTitle";
            lblSongsTitle.Size = new Size(201, 37);
            lblSongsTitle.TabIndex = 4;
            lblSongsTitle.Text = "Popular Songs";
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.FromArgb(200, 200, 200);
            lblDescription.Location = new Point(345, 185);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(878, 100);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Artist Description goes here...";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 11F);
            lblGenre.ForeColor = Color.FromArgb(179, 179, 179);
            lblGenre.Location = new Point(345, 139);
            lblGenre.Margin = new Padding(4, 0, 4, 0);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(63, 25);
            lblGenre.TabIndex = 2;
            lblGenre.Text = "Genre";
            // 
            // lblVerified
            // 
            lblVerified.AutoSize = true;
            lblVerified.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVerified.ForeColor = Color.FromArgb(30, 215, 96);
            lblVerified.Location = new Point(345, 18);
            lblVerified.Margin = new Padding(4, 0, 4, 0);
            lblVerified.Name = "lblVerified";
            lblVerified.Size = new Size(168, 28);
            lblVerified.TabIndex = 1;
            lblVerified.Text = "✓ Verified Artist";
            // 
            // lblArtistName
            // 
            lblArtistName.AutoSize = true;
            lblArtistName.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblArtistName.ForeColor = Color.White;
            lblArtistName.Location = new Point(333, 46);
            lblArtistName.Margin = new Padding(4, 0, 4, 0);
            lblArtistName.Name = "lblArtistName";
            lblArtistName.Size = new Size(375, 81);
            lblArtistName.TabIndex = 0;
            lblArtistName.Text = "Artist Name";
            // 
            // btnCommunity
            // 
            btnCommunity.BackColor = Color.Transparent;
            btnCommunity.Cursor = Cursors.Hand;
            btnCommunity.FlatAppearance.BorderSize = 0;
            btnCommunity.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnCommunity.FlatStyle = FlatStyle.Flat;
            btnCommunity.Font = new Font("Segoe UI", 10F);
            btnCommunity.ForeColor = Color.White;
            btnCommunity.Location = new Point(897, 23);
            btnCommunity.Margin = new Padding(4, 5, 4, 5);
            btnCommunity.Name = "btnCommunity";
            btnCommunity.Size = new Size(120, 46);
            btnCommunity.TabIndex = 43;
            btnCommunity.Text = "Community";
            btnCommunity.UseVisualStyleBackColor = false;
            btnCommunity.Click += btnCommunity_Click;
            // 
            // ArtistPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1333, 1055);
            Controls.Add(contentPanel);
            Controls.Add(toolbarPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ArtistPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UAmplify - Artist";
            FormClosing += Listener_FormClosed;
            toolbarPanel.ResumeLayout(false);
            toolbarPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArtistAlbums).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArtistMusics).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolbarPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMusics;
        private System.Windows.Forms.Button btnAlbums;
        private System.Windows.Forms.Button btnPlaylists;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.Label lblVerified;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSongsTitle;
        private System.Windows.Forms.DataGridView dgvArtistMusics;
        private System.Windows.Forms.Label lblAlbumsTitle;
        private System.Windows.Forms.DataGridView dgvArtistAlbums;
        private PictureBox pictureBox1;
        private Button btnFollow;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnCommunity;
    }
}