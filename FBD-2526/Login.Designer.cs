namespace FBD_2526
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            username = new Label();
            password = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnRegisto = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(224, 224, 224);
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(529, 229);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(144, 52);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(376, 83);
            username.Name = "username";
            username.Size = new Size(142, 38);
            username.TabIndex = 1;
            username.Text = "Username";
            username.Click += label1_Click;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(376, 144);
            password.Name = "password";
            password.Size = new Size(132, 38);
            password.TabIndex = 2;
            password.Text = "Password";
            password.Click += label2_Click;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(568, 94);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(252, 31);
            txtUser.TabIndex = 3;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(568, 155);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(252, 31);
            txtPass.TabIndex = 4;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(529, 351);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 6;
            label1.Text = "Não tens conta?";
            // 
            // btnRegisto
            // 
            btnRegisto.BackColor = Color.FromArgb(224, 224, 224);
            btnRegisto.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisto.Location = new Point(529, 392);
            btnRegisto.Name = "btnRegisto";
            btnRegisto.Size = new Size(144, 52);
            btnRegisto.TabIndex = 7;
            btnRegisto.Text = "Resgista-te";
            btnRegisto.UseVisualStyleBackColor = false;
            btnRegisto.Click += btnRegisto_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(898, 551);
            Controls.Add(btnRegisto);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Login";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label username;
        private Label password;
        private TextBox txtUser;
        private TextBox txtPass;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnRegisto;
    }
}