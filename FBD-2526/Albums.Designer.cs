namespace FBD_2526
{
    partial class Albums
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            toolbarPanel = new System.Windows.Forms.Panel();
            btnPerfil = new System.Windows.Forms.Button();
            btnPlaylists = new System.Windows.Forms.Button();
            btnAlbums = new System.Windows.Forms.Button();
            btnMusics = new System.Windows.Forms.Button();
            btnHome = new System.Windows.Forms.Button();
            lblLogo = new System.Windows.Forms.Label();
            contentPanel = new System.Windows.Forms.Panel();
            dgvAlbums = new System.Windows.Forms.DataGridView();
            panelSearch = new System.Windows.Forms.Panel();
            txtSearch = new System.Windows.Forms.TextBox();
            lblSearchIcon = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();

            toolbarPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvAlbums)).BeginInit();
            panelSearch.SuspendLayout();
            SuspendLayout();

            // 
            // toolbarPanel
            // 
            toolbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            toolbarPanel.Controls.Add(btnPerfil);
            toolbarPanel.Controls.Add(btnPlaylists);
            toolbarPanel.Controls.Add(btnAlbums);
            toolbarPanel.Controls.Add(btnMusics);
            toolbarPanel.Controls.Add(btnHome);
            toolbarPanel.Controls.Add(lblLogo);
            toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            toolbarPanel.Location = new System.Drawing.Point(0, 0);
            toolbarPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            toolbarPanel.Name = "toolbarPanel";
            toolbarPanel.Size = new System.Drawing.Size(1333, 92);
            toolbarPanel.TabIndex = 0;

            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = System.Drawing.Color.Transparent;
            btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPerfil.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnPerfil.ForeColor = System.Drawing.Color.White;
            btnPerfil.Location = new System.Drawing.Point(893, 23);
            btnPerfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new System.Drawing.Size(120, 46);
            btnPerfil.TabIndex = 5;
            btnPerfil.Text = "Profile ";
            btnPerfil.UseVisualStyleBackColor = false;

            // 
            // btnPlaylists
            // 
            btnPlaylists.BackColor = System.Drawing.Color.Transparent;
            btnPlaylists.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPlaylists.FlatAppearance.BorderSize = 0;
            btnPlaylists.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            btnPlaylists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPlaylists.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnPlaylists.ForeColor = System.Drawing.Color.White;
            btnPlaylists.Location = new System.Drawing.Point(733, 23);
            btnPlaylists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnPlaylists.Name = "btnPlaylists";
            btnPlaylists.Size = new System.Drawing.Size(120, 46);
            btnPlaylists.TabIndex = 4;
            btnPlaylists.Text = "Playlists";
            btnPlaylists.UseVisualStyleBackColor = false;

            // 
            // btnAlbums (ATIVO - VERDE)
            // 
            btnAlbums.BackColor = System.Drawing.Color.Transparent;
            btnAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAlbums.FlatAppearance.BorderSize = 0;
            btnAlbums.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            btnAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAlbums.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); // Bold
            btnAlbums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96))))); // Verde
            btnAlbums.Location = new System.Drawing.Point(600, 23);
            btnAlbums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnAlbums.Name = "btnAlbums";
            btnAlbums.Size = new System.Drawing.Size(120, 46);
            btnAlbums.TabIndex = 3;
            btnAlbums.Text = "Albums";
            btnAlbums.UseVisualStyleBackColor = false;

            // 
            // btnMusics
            // 
            btnMusics.BackColor = System.Drawing.Color.Transparent;
            btnMusics.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMusics.FlatAppearance.BorderSize = 0;
            btnMusics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            btnMusics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMusics.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnMusics.ForeColor = System.Drawing.Color.White;
            btnMusics.Location = new System.Drawing.Point(467, 23);
            btnMusics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnMusics.Name = "btnMusics";
            btnMusics.Size = new System.Drawing.Size(120, 46);
            btnMusics.TabIndex = 2;
            btnMusics.Text = "Musics";
            btnMusics.UseVisualStyleBackColor = false;

            // 
            // btnHome (INATIVO - BRANCO)
            // 
            btnHome.BackColor = System.Drawing.Color.Transparent;
            btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHome.Font = new System.Drawing.Font("Segoe UI", 10F); // Normal
            btnHome.ForeColor = System.Drawing.Color.White; // Branco
            btnHome.Location = new System.Drawing.Point(333, 23);
            btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnHome.Name = "btnHome";
            btnHome.Size = new System.Drawing.Size(120, 46);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;

            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            lblLogo.Location = new System.Drawing.Point(27, 23);
            lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(153, 41);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "UAmplify";

            // 
            // contentPanel
            // 
            contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            contentPanel.Controls.Add(dgvAlbums);
            contentPanel.Controls.Add(panelSearch);
            contentPanel.Controls.Add(lblTitle);
            contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            contentPanel.Location = new System.Drawing.Point(0, 92);
            contentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new System.Windows.Forms.Padding(40, 46, 40, 46);
            contentPanel.Size = new System.Drawing.Size(1333, 963);
            contentPanel.TabIndex = 1;

            // 
            // dgvAlbums
            // 
            dgvAlbums.AllowUserToAddRows = false;
            dgvAlbums.AllowUserToDeleteRows = false;
            dgvAlbums.AllowUserToResizeRows = false;
            dgvAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            dgvAlbums.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlbums.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dgvAlbums.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvAlbums.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAlbums.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            // Estilo do Cabeçalho
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvAlbums.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlbums.ColumnHeadersHeight = 40;
            dgvAlbums.EnableHeadersVisualStyles = false;

            // Estilo das Células
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvAlbums.DefaultCellStyle = dataGridViewCellStyle2;

            dgvAlbums.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dgvAlbums.Location = new System.Drawing.Point(44, 200);
            dgvAlbums.MultiSelect = false;
            dgvAlbums.Name = "dgvAlbums";
            dgvAlbums.ReadOnly = true;
            dgvAlbums.RowHeadersVisible = false;
            dgvAlbums.RowTemplate.Height = 45;
            dgvAlbums.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAlbums.Size = new System.Drawing.Size(1240, 700);
            dgvAlbums.TabIndex = 2;

            // 
            // panelSearch
            // 
            panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(lblSearchIcon);
            panelSearch.Location = new System.Drawing.Point(44, 120);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new System.Drawing.Size(400, 45);
            panelSearch.TabIndex = 1;

            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtSearch.ForeColor = System.Drawing.Color.White;
            txtSearch.Location = new System.Drawing.Point(50, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search for albums...";
            txtSearch.Size = new System.Drawing.Size(330, 25);
            txtSearch.TabIndex = 1;

            // 
            // lblSearchIcon
            // 
            lblSearchIcon.AutoSize = true;
            lblSearchIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            lblSearchIcon.ForeColor = System.Drawing.Color.White;
            lblSearchIcon.Location = new System.Drawing.Point(10, 10);
            lblSearchIcon.Name = "lblSearchIcon";
            lblSearchIcon.Size = new System.Drawing.Size(30, 23);
            lblSearchIcon.TabIndex = 0;
            lblSearchIcon.Text = "🔍";

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(40, 40);
            lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(211, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Albums";

            // 
            // Albums
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            ClientSize = new System.Drawing.Size(1333, 1055);
            Controls.Add(contentPanel);
            Controls.Add(toolbarPanel);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Albums";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "UAmplify - Albums";
            toolbarPanel.ResumeLayout(false);
            toolbarPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvAlbums)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvAlbums;
    }
}