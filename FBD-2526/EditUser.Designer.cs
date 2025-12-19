namespace FBD_2526
{
    partial class EditUser
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
            userUsername = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            label3 = new Label();
            userName = new TextBox();
            label2 = new Label();
            userEmail = new TextBox();
            userPassword = new TextBox();
            label7 = new Label();
            label4 = new Label();
            userBirthDate = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Dock = DockStyle.Left;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 609);
            panel1.TabIndex = 12;
            // 
            // userUsername
            // 
            userUsername.Location = new Point(357, 62);
            userUsername.Name = "userUsername";
            userUsername.Size = new Size(151, 27);
            userUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 62);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 13;
            label1.Text = "Username";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(523, 52);
            button1.Name = "button1";
            button1.Size = new Size(55, 44);
            button1.TabIndex = 14;
            button1.Text = "GET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(30, 215, 96);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(346, 533);
            button4.Name = "button4";
            button4.Size = new Size(110, 44);
            button4.TabIndex = 24;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 215, 96);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(505, 535);
            button2.Name = "button2";
            button2.Size = new Size(122, 42);
            button2.TabIndex = 26;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(253, 133);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 27;
            label3.Text = "Name";
            // 
            // userName
            // 
            userName.Location = new Point(258, 156);
            userName.Name = "userName";
            userName.Size = new Size(250, 27);
            userName.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(253, 254);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 29;
            label2.Text = "Email";
            // 
            // userEmail
            // 
            userEmail.Location = new Point(258, 296);
            userEmail.Name = "userEmail";
            userEmail.Size = new Size(494, 27);
            userEmail.TabIndex = 30;
            // 
            // userPassword
            // 
            userPassword.Location = new Point(258, 383);
            userPassword.Name = "userPassword";
            userPassword.Size = new Size(320, 27);
            userPassword.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(258, 349);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 32;
            label7.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(569, 133);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 33;
            label4.Text = "BirthDate";
            // 
            // userBirthDate
            // 
            userBirthDate.Location = new Point(569, 156);
            userBirthDate.Name = "userBirthDate";
            userBirthDate.Size = new Size(183, 27);
            userBirthDate.TabIndex = 34;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 609);
            Controls.Add(userBirthDate);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(userPassword);
            Controls.Add(userEmail);
            Controls.Add(label2);
            Controls.Add(userName);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(userUsername);
            Controls.Add(panel1);
            Name = "EditUser";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox userUsername;
        private Label label1;
        private Button button1;
        private Button button4;
        private Button button2;
        private Label label3;
        private TextBox userName;
        private Label label2;
        private TextBox userEmail;
        private TextBox userPassword;
        private Label label7;
        private Label label4;
        private TextBox userBirthDate;
    }
}