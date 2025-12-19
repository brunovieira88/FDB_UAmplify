using System;
using System.Drawing; // Necessário para Color, Font, Point, Size
using System.Windows.Forms; // Necessário para os controlos

namespace FBD_2526
{
    partial class Listeners
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            toolbarPanel = new Panel();
            btnCommunity = new Button();
            btnPerfil = new Button();
            btnPlaylists = new Button();
            btnAlbums = new Button();
            btnMusics = new Button();
            btnHome = new Button();
            lblLogo = new Label();
            contentPanel = new Panel();
            lblPendingTitle = new Label();
            dgvPending = new DataGridView();
            dgvListeners = new DataGridView();
            colUsername = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCountry = new DataGridViewTextBoxColumn();
            colAction = new DataGridViewButtonColumn();
            panelSearch = new Panel();
            txtSearch = new TextBox();
            lblSearchIcon = new Label();
            lblTitle = new Label();
            toolbarPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPending).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListeners).BeginInit();
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
            btnCommunity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCommunity.ForeColor = Color.FromArgb(30, 215, 96);
            btnCommunity.Location = new Point(886, 23);
            btnCommunity.Margin = new Padding(4, 5, 4, 5);
            btnCommunity.Name = "btnCommunity";
            btnCommunity.Size = new Size(120, 46);
            btnCommunity.TabIndex = 7;
            btnCommunity.Text = "Community";
            btnCommunity.UseVisualStyleBackColor = false;
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
            btnPerfil.Location = new Point(1048, 26);
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
            contentPanel.BackColor = Color.FromArgb(18, 18, 18);
            contentPanel.Controls.Add(lblPendingTitle);
            contentPanel.Controls.Add(dgvPending);
            contentPanel.Controls.Add(dgvListeners);
            contentPanel.Controls.Add(panelSearch);
            contentPanel.Controls.Add(lblTitle);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 92);
            contentPanel.Margin = new Padding(4, 5, 4, 5);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(40, 46, 40, 46);
            contentPanel.Size = new Size(1333, 801);
            contentPanel.TabIndex = 1;
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPendingTitle.AutoSize = true;
            lblPendingTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPendingTitle.ForeColor = Color.FromArgb(179, 179, 179);
            lblPendingTitle.Location = new Point(900, 150);
            lblPendingTitle.Margin = new Padding(4, 0, 4, 0);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(244, 37);
            lblPendingTitle.TabIndex = 4;
            lblPendingTitle.Text = "Pending Requests";
            // 
            // dgvPending
            // 
            dgvPending.AllowUserToAddRows = false;
            dgvPending.AllowUserToDeleteRows = false;
            dgvPending.AllowUserToResizeRows = false;
            dgvPending.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPending.BackgroundColor = Color.FromArgb(24, 24, 24);
            dgvPending.BorderStyle = BorderStyle.None;
            dgvPending.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPending.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(179, 179, 179);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPending.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 215, 96);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPending.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPending.EnableHeadersVisualStyles = false;
            dgvPending.GridColor = Color.FromArgb(40, 40, 40);
            dgvPending.Location = new Point(900, 200);
            dgvPending.MultiSelect = false;
            dgvPending.Name = "dgvPending";
            dgvPending.ReadOnly = true;
            dgvPending.RowHeadersVisible = false;
            dgvPending.RowHeadersWidth = 51;
            dgvPending.RowTemplate.Height = 45;
            dgvPending.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPending.Size = new Size(390, 538);
            dgvPending.TabIndex = 3;
            // 
            // dgvListeners
            // 
            dgvListeners.AllowUserToAddRows = false;
            dgvListeners.AllowUserToDeleteRows = false;
            dgvListeners.AllowUserToResizeRows = false;
            dgvListeners.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListeners.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListeners.BackgroundColor = Color.FromArgb(24, 24, 24);
            dgvListeners.BorderStyle = BorderStyle.None;
            dgvListeners.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListeners.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(179, 179, 179);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListeners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListeners.ColumnHeadersHeight = 40;
            dgvListeners.Columns.AddRange(new DataGridViewColumn[] { colUsername, colName, colCountry, colAction });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(30, 215, 96);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvListeners.DefaultCellStyle = dataGridViewCellStyle5;
            dgvListeners.EnableHeadersVisualStyles = false;
            dgvListeners.GridColor = Color.FromArgb(40, 40, 40);
            dgvListeners.Location = new Point(44, 200);
            dgvListeners.MultiSelect = false;
            dgvListeners.Name = "dgvListeners";
            dgvListeners.ReadOnly = true;
            dgvListeners.RowHeadersVisible = false;
            dgvListeners.RowHeadersWidth = 51;
            dgvListeners.RowTemplate.Height = 45;
            dgvListeners.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListeners.Size = new Size(830, 538);
            dgvListeners.TabIndex = 2;
            dgvListeners.CellContentClick += dgvMusics_CellContentClick;
            // 
            // colUsername
            // 
            colUsername.HeaderText = "USERNAME";
            colUsername.MinimumWidth = 6;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            // 
            // colName
            // 
            colName.HeaderText = "NAME";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCountry
            // 
            colCountry.HeaderText = "COUNTRY";
            colCountry.MinimumWidth = 6;
            colCountry.Name = "colCountry";
            colCountry.ReadOnly = true;
            // 
            // colAction
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            colAction.DefaultCellStyle = dataGridViewCellStyle4;
            colAction.FlatStyle = FlatStyle.Flat;
            colAction.HeaderText = "";
            colAction.MinimumWidth = 6;
            colAction.Name = "colAction";
            colAction.ReadOnly = true;
            colAction.Text = "View Profile";
            colAction.UseColumnTextForButtonValue = true;
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
            txtSearch.PlaceholderText = "Search listeners...";
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
            lblTitle.Size = new Size(243, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Community";
            // 
            // Listeners
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1333, 893);
            Controls.Add(contentPanel);
            Controls.Add(toolbarPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Listeners";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UAmplify - Community";
            FormClosing += Listener_FormClosed;
            toolbarPanel.ResumeLayout(false);
            toolbarPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPending).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListeners).EndInit();
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
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.DataGridView dgvListeners;
        private System.Windows.Forms.DataGridView dgvPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
        private Button btnCommunity;
    }
}