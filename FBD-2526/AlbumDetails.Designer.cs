namespace FBD_2526
{
    partial class AlbumDetails
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

            this.headerPanel = new System.Windows.Forms.Panel();
            this.panelAlbumArt = new System.Windows.Forms.Panel();
            this.lblArtPlaceholder = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.headerPanel.SuspendLayout();
            this.panelAlbumArt.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.SuspendLayout();

            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.headerPanel.Controls.Add(this.panelAlbumArt);
            this.headerPanel.Controls.Add(this.btnClose);
            this.headerPanel.Controls.Add(this.lblArtist);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 180);
            this.headerPanel.TabIndex = 0;

            // 
            // panelAlbumArt (Simula a Capa do Álbum)
            // 
            this.panelAlbumArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelAlbumArt.Controls.Add(this.lblArtPlaceholder);
            this.panelAlbumArt.Location = new System.Drawing.Point(30, 25);
            this.panelAlbumArt.Name = "panelAlbumArt";
            this.panelAlbumArt.Size = new System.Drawing.Size(130, 130);
            this.panelAlbumArt.TabIndex = 3;

            // 
            // lblArtPlaceholder
            // 
            this.lblArtPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArtPlaceholder.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblArtPlaceholder.ForeColor = System.Drawing.Color.Gray;
            this.lblArtPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.lblArtPlaceholder.Name = "lblArtPlaceholder";
            this.lblArtPlaceholder.Size = new System.Drawing.Size(130, 130);
            this.lblArtPlaceholder.TabIndex = 0;
            this.lblArtPlaceholder.Text = "🎵";
            this.lblArtPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(750, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lblArtist.Location = new System.Drawing.Point(180, 80);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(113, 32);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Artist Name";

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(175, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Album Title";

            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.contentPanel.Controls.Add(this.dgvSongs);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 180);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(30);
            this.contentPanel.Size = new System.Drawing.Size(800, 420);
            this.contentPanel.TabIndex = 1;

            // 
            // dgvSongs
            // 
            this.dgvSongs.AllowUserToAddRows = false;
            this.dgvSongs.AllowUserToDeleteRows = false;
            this.dgvSongs.AllowUserToResizeRows = false;
            this.dgvSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSongs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dgvSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSongs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSongs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            // Estilo Cabeçalho
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSongs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSongs.ColumnHeadersHeight = 40;
            this.dgvSongs.EnableHeadersVisualStyles = false;

            // Estilo Células
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSongs.DefaultCellStyle = dataGridViewCellStyle2;

            this.dgvSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSongs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvSongs.Location = new System.Drawing.Point(30, 30);
            this.dgvSongs.MultiSelect = false;
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            this.dgvSongs.RowHeadersVisible = false;
            this.dgvSongs.RowTemplate.Height = 45;
            this.dgvSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongs.Size = new System.Drawing.Size(740, 360);
            this.dgvSongs.TabIndex = 0;

            // 
            // AlbumDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Sem borda do Windows para ser "clean"
            this.Name = "AlbumDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Album Details";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panelAlbumArt.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.Panel panelAlbumArt;
        private System.Windows.Forms.Label lblArtPlaceholder;
    }
}