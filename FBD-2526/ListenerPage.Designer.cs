namespace FBD_2526
{
    partial class ListenerPage
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListenerPage));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            toolbarPanel = new Panel();
            btnRETURN = new Button();
            btnPerfil = new Button();
            btnPlaylists = new Button();
            btnAlbums = new Button();
            btnMusics = new Button();
            btnHome = new Button();
            lblLogo = new Label();
            contentPanel = new Panel();
            lblFollowingTitle = new Label();
            dgvFollowing = new DataGridView();
            btnFollow = new Button();
            pbProfile = new PictureBox();
            dgvPlaylists = new DataGridView();
            lblPlaylistsTitle = new Label();
            lblCountry = new Label();
            lblTag = new Label();
            lblListenerName = new Label();
            btnCommunity = new Button();
            toolbarPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFollowing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlaylists).BeginInit();
            SuspendLayout();
            // 
            // toolbarPanel
            // 
            toolbarPanel.BackColor = Color.FromArgb(30, 30, 30);
            toolbarPanel.Controls.Add(btnCommunity);
            toolbarPanel.Controls.Add(btnRETURN);
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
            // btnRETURN
            // 
            btnRETURN.BackColor = Color.FromArgb(40, 40, 40);
            btnRETURN.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnRETURN.ForeColor = Color.FromArgb(30, 215, 96);
            btnRETURN.Location = new Point(1160, 23);
            btnRETURN.Name = "btnRETURN";
            btnRETURN.Size = new Size(144, 55);
            btnRETURN.TabIndex = 12;
            btnRETURN.Text = "Voltar";
            btnRETURN.UseVisualStyleBackColor = false;
            btnRETURN.Click += btnRETURN_Click;
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
            btnPerfil.Location = new Point(1004, 23);
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
            contentPanel.Controls.Add(lblFollowingTitle);
            contentPanel.Controls.Add(dgvFollowing);
            contentPanel.Controls.Add(btnFollow);
            contentPanel.Controls.Add(pbProfile);
            contentPanel.Controls.Add(dgvPlaylists);
            contentPanel.Controls.Add(lblPlaylistsTitle);
            contentPanel.Controls.Add(lblCountry);
            contentPanel.Controls.Add(lblTag);
            contentPanel.Controls.Add(lblListenerName);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 92);
            contentPanel.Margin = new Padding(4, 5, 4, 5);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(40, 46, 40, 46);
            contentPanel.Size = new Size(1333, 963);
            contentPanel.TabIndex = 1;
            // 
            // lblFollowingTitle
            // 
            lblFollowingTitle.AutoSize = true;
            lblFollowingTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFollowingTitle.ForeColor = Color.White;
            lblFollowingTitle.Location = new Point(44, 627);
            lblFollowingTitle.Margin = new Padding(4, 0, 4, 0);
            lblFollowingTitle.Name = "lblFollowingTitle";
            lblFollowingTitle.Size = new Size(236, 37);
            lblFollowingTitle.TabIndex = 10;
            lblFollowingTitle.Text = "Following Artists";
            // 
            // dgvFollowing
            // 
            dgvFollowing.AllowUserToAddRows = false;
            dgvFollowing.AllowUserToDeleteRows = false;
            dgvFollowing.AllowUserToResizeRows = false;
            dgvFollowing.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvFollowing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFollowing.BackgroundColor = Color.FromArgb(24, 24, 24);
            dgvFollowing.BorderStyle = BorderStyle.None;
            dgvFollowing.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFollowing.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(179, 179, 179);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvFollowing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvFollowing.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(30, 215, 96);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvFollowing.DefaultCellStyle = dataGridViewCellStyle6;
            dgvFollowing.EnableHeadersVisualStyles = false;
            dgvFollowing.GridColor = Color.FromArgb(40, 40, 40);
            dgvFollowing.Location = new Point(50, 689);
            dgvFollowing.MultiSelect = false;
            dgvFollowing.Name = "dgvFollowing";
            dgvFollowing.ReadOnly = true;
            dgvFollowing.RowHeadersVisible = false;
            dgvFollowing.RowHeadersWidth = 51;
            dgvFollowing.RowTemplate.Height = 45;
            dgvFollowing.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFollowing.Size = new Size(1240, 225);
            dgvFollowing.TabIndex = 11;
            dgvFollowing.CellContentClick += dgvFollowing_CellContentClick;
            // 
            // btnFollow
            // 
            btnFollow.BackColor = Color.FromArgb(40, 40, 40);
            btnFollow.Cursor = Cursors.Hand;
            btnFollow.FlatAppearance.BorderSize = 0;
            btnFollow.FlatStyle = FlatStyle.Flat;
            btnFollow.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFollow.ForeColor = Color.FromArgb(30, 215, 96);
            btnFollow.Location = new Point(1176, 67);
            btnFollow.Name = "btnFollow";
            btnFollow.Size = new Size(114, 45);
            btnFollow.TabIndex = 8;
            btnFollow.Text = "Follow";
            btnFollow.UseVisualStyleBackColor = false;
            // 
            // pbProfile
            // 
            pbProfile.Image = (Image)resources.GetObject("pbProfile.Image");
            pbProfile.Location = new Point(60, 25);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(248, 231);
            pbProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfile.TabIndex = 8;
            pbProfile.TabStop = false;
            // 
            // dgvPlaylists
            // 
            dgvPlaylists.AllowUserToAddRows = false;
            dgvPlaylists.AllowUserToDeleteRows = false;
            dgvPlaylists.AllowUserToResizeRows = false;
            dgvPlaylists.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvPlaylists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlaylists.BackgroundColor = Color.FromArgb(24, 24, 24);
            dgvPlaylists.BorderStyle = BorderStyle.None;
            dgvPlaylists.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPlaylists.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(179, 179, 179);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPlaylists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPlaylists.ColumnHeadersHeight = 40;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(30, 215, 96);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPlaylists.DefaultCellStyle = dataGridViewCellStyle8;
            dgvPlaylists.EnableHeadersVisualStyles = false;
            dgvPlaylists.GridColor = Color.FromArgb(40, 40, 40);
            dgvPlaylists.Location = new Point(44, 330);
            dgvPlaylists.MultiSelect = false;
            dgvPlaylists.Name = "dgvPlaylists";
            dgvPlaylists.ReadOnly = true;
            dgvPlaylists.RowHeadersVisible = false;
            dgvPlaylists.RowHeadersWidth = 51;
            dgvPlaylists.RowTemplate.Height = 45;
            dgvPlaylists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlaylists.Size = new Size(1240, 240);
            dgvPlaylists.TabIndex = 5;
            // 
            // lblPlaylistsTitle
            // 
            lblPlaylistsTitle.AutoSize = true;
            lblPlaylistsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPlaylistsTitle.ForeColor = Color.White;
            lblPlaylistsTitle.Location = new Point(40, 280);
            lblPlaylistsTitle.Margin = new Padding(4, 0, 4, 0);
            lblPlaylistsTitle.Name = "lblPlaylistsTitle";
            lblPlaylistsTitle.Size = new Size(123, 37);
            lblPlaylistsTitle.TabIndex = 4;
            lblPlaylistsTitle.Text = "Playlists";
            // 
            // lblCountry
            // 
            lblCountry.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCountry.Font = new Font("Segoe UI", 10F);
            lblCountry.ForeColor = Color.FromArgb(200, 200, 200);
            lblCountry.Location = new Point(345, 185);
            lblCountry.Margin = new Padding(4, 0, 4, 0);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(899, 40);
            lblCountry.TabIndex = 3;
            lblCountry.Text = "Country: Portugal";
            // 
            // lblTag
            // 
            lblTag.AutoSize = true;
            lblTag.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTag.ForeColor = Color.FromArgb(179, 179, 179);
            lblTag.Location = new Point(345, 139);
            lblTag.Margin = new Padding(4, 0, 4, 0);
            lblTag.Name = "lblTag";
            lblTag.Size = new Size(87, 28);
            lblTag.TabIndex = 2;
            lblTag.Text = "Listener";
            // 
            // lblListenerName
            // 
            lblListenerName.AutoSize = true;
            lblListenerName.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblListenerName.ForeColor = Color.White;
            lblListenerName.Location = new Point(333, 46);
            lblListenerName.Margin = new Padding(4, 0, 4, 0);
            lblListenerName.Name = "lblListenerName";
            lblListenerName.Size = new Size(439, 81);
            lblListenerName.TabIndex = 0;
            lblListenerName.Text = "Listener Name";
            // 
            // btnCommunity
            // 
            btnCommunity.BackColor = Color.Transparent;
            btnCommunity.Cursor = Cursors.Hand;
            btnCommunity.FlatAppearance.BorderSize = 0;
            btnCommunity.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnCommunity.FlatStyle = FlatStyle.Flat;
            btnCommunity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCommunity.ForeColor = Color.FromArgb(30, 215, 96);
            btnCommunity.Location = new Point(876, 23);
            btnCommunity.Margin = new Padding(4, 5, 4, 5);
            btnCommunity.Name = "btnCommunity";
            btnCommunity.Size = new Size(120, 46);
            btnCommunity.TabIndex = 12;
            btnCommunity.Text = "Community";
            btnCommunity.UseVisualStyleBackColor = false;
            // 
            // ListenerPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1333, 1055);
            Controls.Add(contentPanel);
            Controls.Add(toolbarPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ListenerPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UAmplify - Listener Profile";
            FormClosing += Listener_FormClosed;
            toolbarPanel.ResumeLayout(false);
            toolbarPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFollowing).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlaylists).EndInit();
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
        private System.Windows.Forms.Label lblListenerName;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPlaylistsTitle;
        private System.Windows.Forms.DataGridView dgvPlaylists;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Button btnFollow;
        private System.Windows.Forms.Label lblFollowingTitle;
        private System.Windows.Forms.DataGridView dgvFollowing;
        private Button btnRETURN;
        private Button btnCommunity;
    }
}