namespace LMS
{
    partial class AdminLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btn_Password = new Label();
            btn_AdminName = new Label();
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(35, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 93);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(78, 22);
            button1.Name = "button1";
            button1.Size = new Size(157, 52);
            button1.TabIndex = 1;
            button1.Text = "ADMIN LOGIN";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(btn_Password);
            panel2.Controls.Add(btn_AdminName);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(35, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 295);
            panel2.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 27);
            textBox2.TabIndex = 3;
            textBox2.MouseLeave += textBox2_MouseLeave;
            textBox2.MouseHover += textBox2_MouseHover;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 99);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 3;
            textBox1.MouseLeave += textBox1_MouseLeave;
            textBox1.MouseHover += textBox1_MouseHover;
            // 
            // btn_Password
            // 
            btn_Password.AutoSize = true;
            btn_Password.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Password.Location = new Point(16, 100);
            btn_Password.Name = "btn_Password";
            btn_Password.Size = new Size(82, 23);
            btn_Password.TabIndex = 2;
            btn_Password.Text = "Password";
            // 
            // btn_AdminName
            // 
            btn_AdminName.AutoSize = true;
            btn_AdminName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AdminName.Location = new Point(16, 37);
            btn_AdminName.Name = "btn_AdminName";
            btn_AdminName.Size = new Size(56, 23);
            btn_AdminName.TabIndex = 2;
            btn_AdminName.Text = "Name";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 162);
            button3.Name = "button3";
            button3.Size = new Size(126, 38);
            button3.TabIndex = 1;
            button3.Text = "New register";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(69, 231);
            button5.Name = "button5";
            button5.Size = new Size(159, 38);
            button5.TabIndex = 1;
            button5.Text = "Login";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveBorder;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(166, 162);
            button4.Name = "button4";
            button4.Size = new Size(159, 38);
            button4.TabIndex = 1;
            button4.Text = "Forgot Password";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(132, 162);
            button2.Name = "button2";
            button2.Size = new Size(28, 38);
            button2.TabIndex = 1;
            button2.Text = "|";
            button2.UseVisualStyleBackColor = false;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminLogin";
            Size = new Size(399, 465);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label btn_Password;
        private Label btn_AdminName;
        private Button button3;
        private Button button5;
        private Button button4;
    }
}
