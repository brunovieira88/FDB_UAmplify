namespace FBD_2526
{
    partial class MusicEdit
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
            IdMusic = new TextBox();
            label1 = new Label();
            button1 = new Button();
            musicName = new TextBox();
            musicDuration = new TextBox();
            musicReleaseDate = new TextBox();
            musicAlbumId = new TextBox();
            musicIdGenre = new TextBox();
            musicLanguage = new TextBox();
            musicLyrics = new RichTextBox();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            musicAlbumName = new TextBox();
            musicGenreName = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            labelPrimaryArtist = new Label();
            musicArtistId = new TextBox();
            musicArtistName = new TextBox();
            labelFeats = new Label();
            featArtistId = new TextBox();
            btnAddFeat = new Button();
            listFeats = new ListBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // IdMusic
            // 
            IdMusic.Location = new Point(299, 31);
            IdMusic.Name = "IdMusic";
            IdMusic.Size = new Size(151, 27);
            IdMusic.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 34);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(479, 22);
            button1.Name = "button1";
            button1.Size = new Size(55, 44);
            button1.TabIndex = 2;
            button1.Text = "GET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // musicName
            // 
            musicName.Location = new Point(234, 136);
            musicName.Name = "musicName";
            musicName.Size = new Size(313, 27);
            musicName.TabIndex = 3;
            // 
            // musicDuration
            // 
            musicDuration.Location = new Point(574, 136);
            musicDuration.Name = "musicDuration";
            musicDuration.Size = new Size(70, 27);
            musicDuration.TabIndex = 4;
            // 
            // musicReleaseDate
            // 
            musicReleaseDate.Location = new Point(668, 136);
            musicReleaseDate.Name = "musicReleaseDate";
            musicReleaseDate.Size = new Size(87, 27);
            musicReleaseDate.TabIndex = 5;
            // 
            // musicAlbumId
            // 
            musicAlbumId.Location = new Point(234, 214);
            musicAlbumId.Name = "musicAlbumId";
            musicAlbumId.Size = new Size(56, 27);
            musicAlbumId.TabIndex = 6;
            musicAlbumId.TextChanged += textBox5_TextChanged;
            // 
            // musicIdGenre
            // 
            musicIdGenre.Location = new Point(542, 214);
            musicIdGenre.Name = "musicIdGenre";
            musicIdGenre.Size = new Size(51, 27);
            musicIdGenre.TabIndex = 7;
            musicIdGenre.TextChanged += textBox6_TextChanged;
            // 
            // musicLanguage
            // 
            musicLanguage.Location = new Point(234, 286);
            musicLanguage.Name = "musicLanguage";
            musicLanguage.Size = new Size(129, 27);
            musicLanguage.TabIndex = 9;
            // 
            // musicLyrics
            // 
            musicLyrics.Location = new Point(262, 453);
            musicLyrics.Name = "musicLyrics";
            musicLyrics.Size = new Size(464, 133);
            musicLyrics.TabIndex = 10;
            musicLyrics.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Dock = DockStyle.Left;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 686);
            panel1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(574, 113);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 12;
            label2.Text = "Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(234, 113);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 13;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(663, 113);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 14;
            label4.Text = "ReleaseDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(234, 191);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 15;
            label5.Text = "Album";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(542, 191);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 16;
            label6.Text = "Genre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(237, 263);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 17;
            label7.Text = "Language";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(262, 430);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 18;
            label8.Text = "Lyrics";
            // 
            // musicAlbumName
            // 
            musicAlbumName.Location = new Point(299, 214);
            musicAlbumName.Name = "musicAlbumName";
            musicAlbumName.ReadOnly = true;
            musicAlbumName.Size = new Size(210, 27);
            musicAlbumName.TabIndex = 19;
            // 
            // musicGenreName
            // 
            musicGenreName.Location = new Point(599, 214);
            musicGenreName.Name = "musicGenreName";
            musicGenreName.ReadOnly = true;
            musicGenreName.Size = new Size(75, 27);
            musicGenreName.TabIndex = 20;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 215, 96);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(633, 614);
            button2.Name = "button2";
            button2.Size = new Size(122, 42);
            button2.TabIndex = 21;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(30, 215, 96);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(437, 614);
            button3.Name = "button3";
            button3.Size = new Size(110, 42);
            button3.TabIndex = 22;
            button3.Text = "Insert";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(30, 215, 96);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(237, 614);
            button4.Name = "button4";
            button4.Size = new Size(110, 44);
            button4.TabIndex = 23;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // labelPrimaryArtist
            // 
            labelPrimaryArtist.AutoSize = true;
            labelPrimaryArtist.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPrimaryArtist.Location = new Point(237, 330);
            labelPrimaryArtist.Name = "labelPrimaryArtist";
            labelPrimaryArtist.Size = new Size(109, 20);
            labelPrimaryArtist.TabIndex = 24;
            labelPrimaryArtist.Text = "Primary Artist";
            // 
            // musicArtistId
            // 
            musicArtistId.Location = new Point(237, 358);
            musicArtistId.Name = "musicArtistId";
            musicArtistId.Size = new Size(56, 27);
            musicArtistId.TabIndex = 25;
            musicArtistId.TextChanged += musicArtistId_TextChanged_1;
            // 
            // musicArtistName
            // 
            musicArtistName.Location = new Point(299, 358);
            musicArtistName.Name = "musicArtistName";
            musicArtistName.ReadOnly = true;
            musicArtistName.Size = new Size(210, 27);
            musicArtistName.TabIndex = 26;
            // 
            // labelFeats
            // 
            labelFeats.AutoSize = true;
            labelFeats.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelFeats.Location = new Point(542, 263);
            labelFeats.Name = "labelFeats";
            labelFeats.Size = new Size(94, 20);
            labelFeats.TabIndex = 27;
            labelFeats.Text = "Feat. Artists";
            // 
            // featArtistId
            // 
            featArtistId.Location = new Point(542, 286);
            featArtistId.Name = "featArtistId";
            featArtistId.Size = new Size(68, 27);
            featArtistId.TabIndex = 28;
            // 
            // btnAddFeat
            // 
            btnAddFeat.Location = new Point(616, 285);
            btnAddFeat.Name = "btnAddFeat";
            btnAddFeat.Size = new Size(58, 29);
            btnAddFeat.TabIndex = 29;
            btnAddFeat.Text = "Add";
            btnAddFeat.UseVisualStyleBackColor = true;
            btnAddFeat.Click += btnAddFeat_Click;
            // 
            // listFeats
            // 
            listFeats.FormattingEnabled = true;
            listFeats.Location = new Point(542, 320);
            listFeats.Name = "listFeats";
            listFeats.Size = new Size(213, 104);
            listFeats.TabIndex = 30;
            // 
            // button5
            // 
            button5.Location = new Point(680, 284);
            button5.Name = "button5";
            button5.Size = new Size(75, 29);
            button5.TabIndex = 31;
            button5.Text = "Remove";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // MusicEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 686);
            Controls.Add(button5);
            Controls.Add(listFeats);
            Controls.Add(btnAddFeat);
            Controls.Add(featArtistId);
            Controls.Add(labelFeats);
            Controls.Add(musicArtistName);
            Controls.Add(musicArtistId);
            Controls.Add(labelPrimaryArtist);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(musicGenreName);
            Controls.Add(musicAlbumName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(musicLyrics);
            Controls.Add(musicLanguage);
            Controls.Add(musicIdGenre);
            Controls.Add(musicAlbumId);
            Controls.Add(musicReleaseDate);
            Controls.Add(musicDuration);
            Controls.Add(musicName);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(IdMusic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MusicEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MusicEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IdMusic;
        private Label label1;
        private Button button1;
        private TextBox musicName;
        private TextBox musicDuration;
        private TextBox musicReleaseDate;
        private TextBox musicAlbumId;
        private TextBox musicIdGenre;
        private TextBox musicLanguage;
        private RichTextBox musicLyrics;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox musicAlbumName;
        private TextBox musicGenreName;
        private Button button2;
        private Button button3;
        private Button button4;

        // Novos componentes adicionados
        private Label labelPrimaryArtist;
        private TextBox musicArtistId;
        private TextBox musicArtistName;
        private Label labelFeats;
        private TextBox featArtistId;
        private Button btnAddFeat;
        private ListBox listFeats;
        private Button button5;
    }
}