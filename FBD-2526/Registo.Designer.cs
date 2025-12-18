namespace FBD_2526
{
    partial class Registo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registo));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textName = new TextBox();
            textUserName = new TextBox();
            textPassword = new TextBox();
            textEmail = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            panel1 = new Panel();
            textBox5 = new TextBox();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            AccessCode = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(372, 40);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(372, 118);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "UserName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(372, 287);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // textName
            // 
            textName.Location = new Point(372, 75);
            textName.Name = "textName";
            textName.Size = new Size(397, 27);
            textName.TabIndex = 4;
            // 
            // textUserName
            // 
            textUserName.Location = new Point(372, 153);
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(397, 27);
            textUserName.TabIndex = 5;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(372, 320);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(397, 27);
            textPassword.TabIndex = 6;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(372, 242);
            textEmail.Name = "textEmail";
            textEmail.PasswordChar = '*';
            textEmail.Size = new Size(397, 27);
            textEmail.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(328, 515);
            button1.Name = "button1";
            button1.Size = new Size(202, 62);
            button1.TabIndex = 7;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(590, 515);
            button2.Name = "button2";
            button2.Size = new Size(202, 62);
            button2.TabIndex = 8;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(372, 202);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 10;
            label4.Text = "E-mail:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 606);
            panel1.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ControlLight;
            textBox5.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(60, 278);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(175, 49);
            textBox5.TabIndex = 1;
            textBox5.Text = "UAMPLIFY";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(372, 402);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(372, 367);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 13;
            label5.Text = "BirthDate:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(624, 367);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 14;
            label6.Text = "ModeratorCode:";
            // 
            // AccessCode
            // 
            AccessCode.Location = new Point(624, 402);
            AccessCode.Name = "AccessCode";
            AccessCode.PasswordChar = '*';
            AccessCode.Size = new Size(145, 27);
            AccessCode.TabIndex = 15;
            // 
            // Registo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(832, 603);
            Controls.Add(AccessCode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textEmail);
            Controls.Add(textPassword);
            Controls.Add(textUserName);
            Controls.Add(textName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registo";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UAmplify";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textName;
        private TextBox textUserName;
        private TextBox textPassword;
        private Button button1;
        private Button button2;
        private TextBox textEmail;
        private Label label4;
        private DateTimePicker dtpNascimento;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox textBox5;
        private PictureBox pictureBox1;
        private Label label6;
        private TextBox AccessCode;
    }
}
