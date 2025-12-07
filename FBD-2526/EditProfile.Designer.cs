namespace FBD_2526
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtName = new TextBox();
            txtUserName = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateBorn = new DateTimePicker();
            txtCountry = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            btnEdit = new Button();
            btnDone = new Button();
            btnCancel = new Button();
            btnQuit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 518);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 20);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(282, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(281, 27);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(610, 48);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(252, 27);
            txtUserName.TabIndex = 4;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(612, 20);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "UserName";
            label2.Click += label2_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(282, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 27);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 132);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(612, 132);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 7;
            label4.Text = "Birth Date";
            label4.Click += label4_Click;
            // 
            // dateBorn
            // 
            dateBorn.Location = new Point(612, 160);
            dateBorn.Name = "dateBorn";
            dateBorn.Size = new Size(250, 27);
            dateBorn.TabIndex = 8;
            dateBorn.ValueChanged += dateBorn_ValueChanged;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(282, 272);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(222, 27);
            txtCountry.TabIndex = 10;
            txtCountry.TextChanged += txtCountry_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(282, 244);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 9;
            label5.Text = "Country";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(543, 272);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(319, 27);
            txtPassword.TabIndex = 12;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(543, 244);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 11;
            label6.Text = "Password";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.AppWorkspace;
            btnEdit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnEdit.Location = new Point(400, 424);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(127, 44);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDone
            // 
            btnDone.BackColor = SystemColors.AppWorkspace;
            btnDone.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDone.Location = new Point(597, 424);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(127, 44);
            btnDone.TabIndex = 14;
            btnDone.Text = "Apply";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.AppWorkspace;
            btnCancel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCancel.Location = new Point(400, 424);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 44);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = SystemColors.AppWorkspace;
            btnQuit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnQuit.Location = new Point(597, 424);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(127, 44);
            btnQuit.TabIndex = 16;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 542);
            Controls.Add(btnQuit);
            Controls.Add(btnCancel);
            Controls.Add(btnDone);
            Controls.Add(btnEdit);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtCountry);
            Controls.Add(label5);
            Controls.Add(dateBorn);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "EditProfile";
            Text = "EditProfile";
            Load += EditProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtName;
        private TextBox txtUserName;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private Label label4;
        private DateTimePicker dateBorn;
        private TextBox txtCountry;
        private Label label5;
        private TextBox txtPassword;
        private Label label6;
        private Button btnEdit;
        private Button btnDone;
        private Button btnCancel;
        private Button btnQuit;
    }
}