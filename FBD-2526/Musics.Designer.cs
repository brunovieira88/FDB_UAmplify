namespace FBD_2526
{
    partial class Musics
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            toolbarPanel = new Panel();
            btnCommunity = new Button();
            btnPerfil = new Button();
            btnPlaylists = new Button();
            btnAlbums = new Button();
            btnMusics = new Button();
            btnHome = new Button();
            lblLogo = new Label();
            contentPanel = new Panel();
            dgvMusics = new DataGridView();
            panelSearch = new Panel();
            txtSearch = new TextBox();
            lblSearchIcon = new Label();
            lblTitle = new Label();
            toolbarPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusics).BeginInit();
            panelSearch.SuspendLayout();
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
            // btnCommunity
            // 
            btnCommunity.BackColor = Color.Transparent;
            btnCommunity.Cursor = Cursors.Hand;
            btnCommunity.FlatAppearance.BorderSize = 0;
            btnCommunity.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnCommunity.FlatStyle = FlatStyle.Flat;
            btnCommunity.Font = new Font("Segoe UI", 10F);
            btnCommunity.ForeColor = Color.White;
            btnCommunity.Location = new Point(885, 23);
            btnCommunity.Margin = new Padding(4, 5, 4, 5);
            btnCommunity.Name = "btnCommunity";
            btnCommunity.Size = new Size(120, 46);
            btnCommunity.TabIndex = 8;
            btnCommunity.Text = "Community";
            btnCommunity.UseVisualStyleBackColor = false;
            btnCommunity.Click += btnCommunity_Click;
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
            btnPerfil.Location = new Point(1038, 23);
            btnPerfil.Margin = new Padding(4, 5, 4, 5);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(120, 46);
            btnPerfil.TabIndex = 5;
            btnPerfil.Text = "Profile ";
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
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
            btnPlaylists.Click += btnPlaylists_Click;
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
            btnAlbums.Click += btnAlbums_Click;
            // 
            // btnMusics
            // 
            btnMusics.BackColor = Color.Transparent;
            btnMusics.Cursor = Cursors.Hand;
            btnMusics.FlatAppearance.BorderSize = 0;
            btnMusics.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnMusics.FlatStyle = FlatStyle.Flat;
            btnMusics.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMusics.ForeColor = Color.FromArgb(30, 215, 96);
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
            contentPanel.BackColor = Color.FromArgb(18, 18, 18);
            contentPanel.Controls.Add(dgvMusics);
            contentPanel.Controls.Add(panelSearch);
            contentPanel.Controls.Add(lblTitle);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 92);
            contentPanel.Margin = new Padding(4, 5, 4, 5);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(40, 46, 40, 46);
            contentPanel.Size = new Size(1333, 963);
            contentPanel.TabIndex = 1;
            // 
            // dgvMusics
            // 
            dgvMusics.AllowUserToAddRows = false;
            dgvMusics.AllowUserToDeleteRows = false;
            dgvMusics.AllowUserToResizeRows = false;
            dgvMusics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMusics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMusics.BackgroundColor = Color.FromArgb(24, 24, 24);
            dgvMusics.BorderStyle = BorderStyle.None;
            dgvMusics.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMusics.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(179, 179, 179);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMusics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMusics.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 215, 96);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMusics.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMusics.EnableHeadersVisualStyles = false;
            dgvMusics.GridColor = Color.FromArgb(40, 40, 40);
            dgvMusics.Location = new Point(44, 200);
            dgvMusics.MultiSelect = false;
            dgvMusics.Name = "dgvMusics";
            dgvMusics.ReadOnly = true;
            dgvMusics.RowHeadersVisible = false;
            dgvMusics.RowHeadersWidth = 51;
            dgvMusics.RowTemplate.Height = 45;
            dgvMusics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMusics.Size = new Size(1240, 700);
            dgvMusics.TabIndex = 2;
            dgvMusics.CellContentClick += dgvMusics_CellContentClick_1;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(60, 60, 60);
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(lblSearchIcon);
            panelSearch.Location = new Point(44, 120);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(400, 45);
            panelSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(60, 60, 60);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(50, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search for songs...";
            txtSearch.Size = new Size(330, 25);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearchIcon
            // 
            lblSearchIcon.AutoSize = true;
            lblSearchIcon.Font = new Font("Segoe UI Symbol", 10F);
            lblSearchIcon.ForeColor = Color.White;
            lblSearchIcon.Location = new Point(10, 10);
            lblSearchIcon.Name = "lblSearchIcon";
            lblSearchIcon.Size = new Size(27, 23);
            lblSearchIcon.TabIndex = 0;
            lblSearchIcon.Text = "🔍";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(40, 40);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(197, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "All Songs";
            // 
            // Musics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1333, 1055);
            Controls.Add(contentPanel);
            Controls.Add(toolbarPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Musics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UAmplify - Musics";
            FormClosing += Musics_FormClosing;
            FormClosed += Musics_FormClosed;
            Load += Musics_Load;
            toolbarPanel.ResumeLayout(false);
            toolbarPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusics).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.DataGridView dgvMusics; // Trocado ListBox por DataGridView
        private Button btnCommunity;
    }
}