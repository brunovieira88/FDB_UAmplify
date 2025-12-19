namespace FBD_2526
{
    partial class EditPlaylist
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            topPanel = new Panel();
            btnDelete = new Button();
            btnClose = new Button();
            btnSaveDetails = new Button();
            txtDescription = new TextBox();
            lblDesc = new Label();
            txtName = new TextBox();
            lblTitle = new Label();
            splitContainer = new SplitContainer();
            dgvInPlaylist = new DataGridView();
            lblInPlaylist = new Label();
            dgvAllMusics = new DataGridView();
            txtSearchMusic = new TextBox();
            lblAllMusic = new Label();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInPlaylist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllMusics).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(30, 30, 30);
            topPanel.Controls.Add(btnDelete);
            topPanel.Controls.Add(btnClose);
            topPanel.Controls.Add(btnSaveDetails);
            topPanel.Controls.Add(txtDescription);
            topPanel.Controls.Add(lblDesc);
            topPanel.Controls.Add(txtName);
            topPanel.Controls.Add(lblTitle);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1200, 180);
            topPanel.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(550, 120);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 50);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(60, 60, 60);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1080, 20);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "Done";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSaveDetails
            // 
            btnSaveDetails.BackColor = Color.FromArgb(30, 215, 96);
            btnSaveDetails.FlatStyle = FlatStyle.Flat;
            btnSaveDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveDetails.Location = new Point(440, 120);
            btnSaveDetails.Name = "btnSaveDetails";
            btnSaveDetails.Size = new Size(100, 50);
            btnSaveDetails.TabIndex = 2;
            btnSaveDetails.Text = "Save Changes";
            btnSaveDetails.UseVisualStyleBackColor = false;
            btnSaveDetails.Click += btnSaveDetails_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(25, 120);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(400, 50);
            txtDescription.TabIndex = 5;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.ForeColor = Color.LightGray;
            lblDesc.Location = new Point(25, 100);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(88, 20);
            lblDesc.TabIndex = 6;
            lblDesc.Text = "Description:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(25, 60);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Playlist Name";
            txtName.Size = new Size(400, 32);
            txtName.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Edit Playlist";
            // 
            // splitContainer
            // 
            splitContainer.BackColor = Color.FromArgb(18, 18, 18);
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 180);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(dgvInPlaylist);
            splitContainer.Panel1.Controls.Add(lblInPlaylist);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(dgvAllMusics);
            splitContainer.Panel2.Controls.Add(txtSearchMusic);
            splitContainer.Panel2.Controls.Add(lblAllMusic);
            splitContainer.Size = new Size(1200, 620);
            splitContainer.SplitterDistance = 655;
            splitContainer.TabIndex = 1;
            splitContainer.SplitterMoved += splitContainer_SplitterMoved;
            // 
            // dgvInPlaylist
            // 
            dgvInPlaylist.AllowUserToAddRows = false;
            dgvInPlaylist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInPlaylist.BackgroundColor = Color.FromArgb(24, 24, 24);
            dgvInPlaylist.BorderStyle = BorderStyle.None;
            dgvInPlaylist.ColumnHeadersHeight = 29;
            dgvInPlaylist.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 215, 96);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvInPlaylist.DefaultCellStyle = dataGridViewCellStyle1;
            dgvInPlaylist.Dock = DockStyle.Bottom;
            dgvInPlaylist.Location = new Point(0, 150);
            dgvInPlaylist.Name = "dgvInPlaylist";
            dgvInPlaylist.ReadOnly = true;
            dgvInPlaylist.RowHeadersVisible = false;
            dgvInPlaylist.RowHeadersWidth = 51;
            dgvInPlaylist.RowTemplate.Height = 40;
            dgvInPlaylist.Size = new Size(655, 470);
            dgvInPlaylist.TabIndex = 1;
            dgvInPlaylist.CellContentClick += dgvInPlaylist_CellContentClick;
            // 
            // lblInPlaylist
            // 
            lblInPlaylist.AutoSize = true;
            lblInPlaylist.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblInPlaylist.ForeColor = Color.White;
            lblInPlaylist.Location = new Point(20, 10);
            lblInPlaylist.Name = "lblInPlaylist";
            lblInPlaylist.Size = new Size(148, 28);
            lblInPlaylist.TabIndex = 2;
            lblInPlaylist.Text = "Current Tracks";
            // 
            // dgvAllMusics
            // 
            dgvAllMusics.AllowUserToAddRows = false;
            dgvAllMusics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllMusics.BackgroundColor = Color.FromArgb(24, 24, 24);
            dgvAllMusics.BorderStyle = BorderStyle.None;
            dgvAllMusics.ColumnHeadersHeight = 29;
            dgvAllMusics.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 215, 96);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAllMusics.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAllMusics.Dock = DockStyle.Bottom;
            dgvAllMusics.Location = new Point(0, 150);
            dgvAllMusics.Name = "dgvAllMusics";
            dgvAllMusics.ReadOnly = true;
            dgvAllMusics.RowHeadersVisible = false;
            dgvAllMusics.RowHeadersWidth = 51;
            dgvAllMusics.RowTemplate.Height = 40;
            dgvAllMusics.Size = new Size(541, 470);
            dgvAllMusics.TabIndex = 2;
            dgvAllMusics.CellContentClick += dgvAllMusics_CellContentClick;
            // 
            // txtSearchMusic
            // 
            txtSearchMusic.BackColor = Color.FromArgb(60, 60, 60);
            txtSearchMusic.BorderStyle = BorderStyle.None;
            txtSearchMusic.Font = new Font("Segoe UI", 11F);
            txtSearchMusic.ForeColor = Color.White;
            txtSearchMusic.Location = new Point(250, 10);
            txtSearchMusic.Name = "txtSearchMusic";
            txtSearchMusic.PlaceholderText = "Search to add...";
            txtSearchMusic.Size = new Size(300, 25);
            txtSearchMusic.TabIndex = 3;
            txtSearchMusic.TextChanged += txtSearchMusic_TextChanged;
            // 
            // lblAllMusic
            // 
            lblAllMusic.AutoSize = true;
            lblAllMusic.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAllMusic.ForeColor = Color.White;
            lblAllMusic.Location = new Point(20, 10);
            lblAllMusic.Name = "lblAllMusic";
            lblAllMusic.Size = new Size(195, 28);
            lblAllMusic.TabIndex = 4;
            lblAllMusic.Text = "Add Music (Search)";
            // 
            // EditPlaylist
            // 
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1200, 800);
            Controls.Add(splitContainer);
            Controls.Add(topPanel);
            Name = "EditPlaylist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Playlist";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInPlaylist).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllMusics).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription; // NOVO
        private System.Windows.Forms.Label lblDesc; // NOVO
        private System.Windows.Forms.Button btnSaveDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label lblInPlaylist;
        private System.Windows.Forms.DataGridView dgvInPlaylist;
        private System.Windows.Forms.Label lblAllMusic;
        private System.Windows.Forms.TextBox txtSearchMusic;
        private System.Windows.Forms.DataGridView dgvAllMusics;
    }
}