namespace FBD_2526
{
    partial class AlbumEdit
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
            panel1 = new Panel();
            label1 = new Label();
            albumId = new TextBox();
            button1 = new Button();
            label3 = new Label();
            albumName = new TextBox();
            label2 = new Label();
            albumDuration = new TextBox();
            label4 = new Label();
            albumReleaseDate = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            listView1 = new ListView();
            label5 = new Label();
            albumArtistName = new TextBox();
            label7 = new Label();
            albumArtistId = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Dock = DockStyle.Left;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 601);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 41);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 13;
            label1.Text = "ID";
            // 
            // albumId
            // 
            albumId.Location = new Point(342, 38);
            albumId.Name = "albumId";
            albumId.Size = new Size(151, 27);
            albumId.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(540, 28);
            button1.Name = "button1";
            button1.Size = new Size(55, 44);
            button1.TabIndex = 15;
            button1.Text = "GET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(241, 116);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 16;
            label3.Text = "Name";
            // 
            // albumName
            // 
            albumName.Location = new Point(241, 139);
            albumName.Name = "albumName";
            albumName.Size = new Size(293, 27);
            albumName.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(560, 116);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 18;
            label2.Text = "Duration";
            // 
            // albumDuration
            // 
            albumDuration.Location = new Point(560, 139);
            albumDuration.Name = "albumDuration";
            albumDuration.ReadOnly = true;
            albumDuration.Size = new Size(70, 27);
            albumDuration.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(668, 116);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 20;
            label4.Text = "ReleaseDate";
            // 
            // albumReleaseDate
            // 
            albumReleaseDate.Location = new Point(653, 139);
            albumReleaseDate.Name = "albumReleaseDate";
            albumReleaseDate.Size = new Size(138, 27);
            albumReleaseDate.TabIndex = 21;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(30, 215, 96);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(241, 545);
            button4.Name = "button4";
            button4.Size = new Size(110, 44);
            button4.TabIndex = 24;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(30, 215, 96);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(444, 545);
            button3.Name = "button3";
            button3.Size = new Size(110, 42);
            button3.TabIndex = 25;
            button3.Text = "Insert";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 215, 96);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(653, 545);
            button2.Name = "button2";
            button2.Size = new Size(122, 42);
            button2.TabIndex = 26;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(241, 281);
            listView1.Name = "listView1";
            listView1.Size = new Size(534, 188);
            listView1.TabIndex = 27;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(241, 258);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 28;
            label5.Text = "Musics";
            // 
            // albumArtistName
            // 
            albumArtistName.AllowDrop = true;
            albumArtistName.Location = new Point(362, 216);
            albumArtistName.Name = "albumArtistName";
            albumArtistName.ReadOnly = true;
            albumArtistName.Size = new Size(293, 27);
            albumArtistName.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(250, 193);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 31;
            label7.Text = "ArtistId";
            // 
            // albumArtistId
            // 
            albumArtistId.Location = new Point(250, 216);
            albumArtistId.Name = "albumArtistId";
            albumArtistId.Size = new Size(70, 27);
            albumArtistId.TabIndex = 32;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button5.Location = new Point(687, 206);
            button5.Name = "button5";
            button5.Size = new Size(55, 44);
            button5.TabIndex = 33;
            button5.Text = "GET";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // AlbumEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 601);
            Controls.Add(button5);
            Controls.Add(albumArtistId);
            Controls.Add(label7);
            Controls.Add(albumArtistName);
            Controls.Add(label5);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(albumReleaseDate);
            Controls.Add(label4);
            Controls.Add(albumDuration);
            Controls.Add(label2);
            Controls.Add(albumName);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(albumId);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "AlbumEdit";
            Text = "Album Editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox albumId;
        private Button button1;
        private Label label3;
        private TextBox albumName;
        private Label label2;
        private TextBox albumDuration;
        private Label label4;
        private TextBox albumReleaseDate;
        private Button button4;
        private Button button3;
        private Button button2;
        private ListView listView1;
        private Label label5;
        private TextBox albumArtistName;
        private Label label7;
        private TextBox albumArtistId;
        private Button button5;
    }
}