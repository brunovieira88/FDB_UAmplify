namespace FBD_2526
{
    partial class Playlists
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            toolbarPanel = new Panel();
            btnPerfil = new Button();
            btnPlaylists = new Button();
            btnAlbums = new Button();
            btnMusics = new Button();
            btnHome = new Button();
            lblLogo = new Label();
            contentPanel = new Panel();
            dgvSearch = new DataGridView();
            btnTabSearch = new Button();
            btnTabLibrary = new Button();
            btnCreate = new Button();
            dgvMyPlaylists = new DataGridView();
            panelSearch = new Panel();
            txtSearch = new TextBox();
            lblSearchIcon = new Label();
            lblTitle = new Label();
            toolbarPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMyPlaylists).BeginInit();
            panelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // toolbarPanel
            // 
            toolbarPanel.BackColor = Color.FromArgb(30, 30, 30);
            toolbarPanel.Controls.Add(btnPerfil);
            toolbarPanel.Controls.Add(btnPlaylists);
            toolbarPanel.Controls.Add(btnAlbums);
            toolbarPanel.Controls.Add(btnMusics);
            toolbarPanel.Controls.Add(btnHome);
            toolbarPanel.Controls.Add(lblLogo);
            toolbarPanel.Dock = DockStyle.Top;
            toolbarPanel.Location = new Point(0, 0);
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
            btnPerfil.Location = new Point(893, 23);
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
            btnPlaylists.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPlaylists.ForeColor = Color.FromArgb(30, 215, 96);
            btnPlaylists.Location = new Point(733, 23);
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
            btnMusics.Font = new Font("Segoe UI", 10F);
            btnMusics.ForeColor = Color.White;
            btnMusics.Location = new Point(467, 23);
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
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(153, 41);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "UAmplify";
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(18, 18, 18);
            contentPanel.Controls.Add(dgvSearch);
            contentPanel.Controls.Add(btnTabSearch);
            contentPanel.Controls.Add(btnTabLibrary);
            contentPanel.Controls.Add(btnCreate);
            contentPanel.Controls.Add(dgvMyPlaylists);
            contentPanel.Controls.Add(panelSearch);
            contentPanel.Controls.Add(lblTitle);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 92);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(40, 46, 40, 46);
            contentPanel.Size = new Size(1333, 963);
            contentPanel.TabIndex = 1;
            // 
            // dgvSearch
            // 
            dgvSearch.AllowUserToAddRows = false;
            dgvSearch.AllowUserToDeleteRows = false;
            dgvSearch.AllowUserToResizeRows = false;
            dgvSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearch.BackgroundColor = Color.FromArgb(24, 24, 24);
            dgvSearch.BorderStyle = BorderStyle.None;
            dgvSearch.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(179, 179, 179);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSearch.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 215, 96);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSearch.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSearch.EnableHeadersVisualStyles = false;
            dgvSearch.GridColor = Color.FromArgb(40, 40, 40);
            dgvSearch.Location = new Point(44, 240);
            dgvSearch.MultiSelect = false;
            dgvSearch.Name = "dgvSearch";
            dgvSearch.ReadOnly = true;
            dgvSearch.RowHeadersVisible = false;
            dgvSearch.RowHeadersWidth = 51;
            dgvSearch.RowTemplate.Height = 45;
            dgvSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearch.Size = new Size(1240, 660);
            dgvSearch.TabIndex = 6;
            dgvSearch.Visible = false;
            dgvSearch.CellContentClick += dgvSearch_CellContentClick;
            // 
            // btnTabSearch
            // 
            btnTabSearch.BackColor = Color.FromArgb(24, 24, 24);
            btnTabSearch.Cursor = Cursors.Hand;
            btnTabSearch.FlatAppearance.BorderSize = 0;
            btnTabSearch.FlatStyle = FlatStyle.Flat;
            btnTabSearch.Font = new Font("Segoe UI", 11F);
            btnTabSearch.ForeColor = Color.Gray;
            btnTabSearch.Location = new Point(200, 110);
            btnTabSearch.Name = "btnTabSearch";
            btnTabSearch.Size = new Size(150, 40);
            btnTabSearch.TabIndex = 5;
            btnTabSearch.Text = "Find Playlists";
            btnTabSearch.UseVisualStyleBackColor = false;
            btnTabSearch.Click += btnTabSearch_Click;
            // 
            // btnTabLibrary
            // 
            btnTabLibrary.BackColor = Color.FromArgb(40, 40, 40);
            btnTabLibrary.Cursor = Cursors.Hand;
            btnTabLibrary.FlatAppearance.BorderSize = 0;
            btnTabLibrary.FlatStyle = FlatStyle.Flat;
            btnTabLibrary.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTabLibrary.ForeColor = Color.White;
            btnTabLibrary.Location = new Point(44, 110);
            btnTabLibrary.Name = "btnTabLibrary";
            btnTabLibrary.Size = new Size(150, 40);
            btnTabLibrary.TabIndex = 4;
            btnTabLibrary.Text = "My Library";
            btnTabLibrary.UseVisualStyleBackColor = false;
            btnTabLibrary.Click += btnTabLibrary_Click;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.BackColor = Color.FromArgb(30, 215, 96);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCreate.ForeColor = Color.Black;
            btnCreate.Location = new Point(1084, 50);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(200, 45);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "+ Create Playlist";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvMyPlaylists
            // 
            dgvMyPlaylists.AllowUserToAddRows = false;
            dgvMyPlaylists.AllowUserToDeleteRows = false;
            dgvMyPlaylists.AllowUserToResizeRows = false;
            dgvMyPlaylists.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMyPlaylists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyPlaylists.BackgroundColor = Color.FromArgb(24, 24, 24);
            dgvMyPlaylists.BorderStyle = BorderStyle.None;
            dgvMyPlaylists.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMyPlaylists.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(179, 179, 179);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMyPlaylists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMyPlaylists.ColumnHeadersHeight = 40;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(30, 215, 96);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvMyPlaylists.DefaultCellStyle = dataGridViewCellStyle4;
            dgvMyPlaylists.EnableHeadersVisualStyles = false;
            dgvMyPlaylists.GridColor = Color.FromArgb(40, 40, 40);
            dgvMyPlaylists.Location = new Point(44, 240);
            dgvMyPlaylists.MultiSelect = false;
            dgvMyPlaylists.Name = "dgvMyPlaylists";
            dgvMyPlaylists.ReadOnly = true;
            dgvMyPlaylists.RowHeadersVisible = false;
            dgvMyPlaylists.RowHeadersWidth = 51;
            dgvMyPlaylists.RowTemplate.Height = 45;
            dgvMyPlaylists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyPlaylists.Size = new Size(1240, 660);
            dgvMyPlaylists.TabIndex = 2;
            dgvMyPlaylists.CellContentClick += dgvPlaylists_CellContentClick;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(60, 60, 60);
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(lblSearchIcon);
            panelSearch.Location = new Point(44, 160);
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
            txtSearch.PlaceholderText = "Search playlists...";
            txtSearch.Size = new Size(330, 25);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
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
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(322, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Playlists Library";
            // 
            // Playlists
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1333, 1055);
            Controls.Add(contentPanel);
            Controls.Add(toolbarPanel);
            Name = "Playlists";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UAmplify - Playlists";
            FormClosed += Playlists_FormClosed;
            Load += Playlists_Load;
            toolbarPanel.ResumeLayout(false);
            toolbarPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMyPlaylists).EndInit();
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
        private System.Windows.Forms.Button btnCreate;

        // Elementos NOVOS para separar as listas
        private System.Windows.Forms.Button btnTabLibrary; // Botão de Aba 1
        private System.Windows.Forms.Button btnTabSearch;  // Botão de Aba 2
        private System.Windows.Forms.DataGridView dgvMyPlaylists; // Tabela das Minhas
        private System.Windows.Forms.DataGridView dgvSearch;      // Tabela da Pesquisa
    }
}