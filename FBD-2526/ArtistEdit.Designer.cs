namespace FBD_2526
{
    partial class ArtistEdit
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            label8 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            textBox9 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Dock = DockStyle.Left;
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 600);
            panel1.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(299, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 47);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 13;
            label1.Text = "ID";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(481, 34);
            button1.Name = "button1";
            button1.Size = new Size(55, 44);
            button1.TabIndex = 14;
            button1.Text = "GET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.YellowGreen;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(246, 544);
            button4.Name = "button4";
            button4.Size = new Size(110, 44);
            button4.TabIndex = 24;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.YellowGreen;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(449, 546);
            button3.Name = "button3";
            button3.Size = new Size(110, 42);
            button3.TabIndex = 25;
            button3.Text = "Insert";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.YellowGreen;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(633, 546);
            button2.Name = "button2";
            button2.Size = new Size(122, 42);
            button2.TabIndex = 26;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(246, 117);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 27;
            label3.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 27);
            textBox2.TabIndex = 28;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(249, 224);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(452, 158);
            richTextBox1.TabIndex = 29;
            richTextBox1.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(249, 189);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 30;
            label8.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(249, 409);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 31;
            label6.Text = "Genre";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(249, 432);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(51, 27);
            textBox6.TabIndex = 32;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(344, 432);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(97, 27);
            textBox9.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(558, 409);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 34;
            label2.Text = "Verified";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(570, 432);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(51, 27);
            textBox3.TabIndex = 35;
            // 
            // ArtistEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox9);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "ArtistEdit";
            Text = "ArtistEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label3;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private Label label8;
        private Label label6;
        private TextBox textBox6;
        private TextBox textBox9;
        private Label label2;
        private TextBox textBox3;
    }
}