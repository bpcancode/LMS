namespace LMS
{
    partial class UserLogin
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
            user_name = new TextBox();
            user_password = new TextBox();
            btn_userPassword = new Label();
            btn_UserName = new Label();
            button3 = new Button();
            login_user = new Button();
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
            panel1.Location = new Point(30, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 93);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(78, 22);
            button1.Name = "button1";
            button1.Size = new Size(157, 52);
            button1.TabIndex = 1;
            button1.Text = "USER LOGIN";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(user_name);
            panel2.Controls.Add(user_password);
            panel2.Controls.Add(btn_userPassword);
            panel2.Controls.Add(btn_UserName);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(login_user);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(30, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 295);
            panel2.TabIndex = 2;
            // 
            // user_name
            // 
            user_name.Location = new Point(78, 37);
            user_name.Name = "user_name";
            user_name.Size = new Size(226, 27);
            user_name.TabIndex = 3;
            user_name.MouseLeave += user_name_MouseLeave;
            user_name.MouseHover += user_name_MouseHover;
            // 
            // user_password
            // 
            user_password.Location = new Point(104, 99);
            user_password.Name = "user_password";
            user_password.PasswordChar = '*';
            user_password.Size = new Size(200, 27);
            user_password.TabIndex = 3;
            user_password.MouseLeave += user_password_MouseLeave;
            user_password.MouseHover += user_password_MouseHover;
            // 
            // btn_userPassword
            // 
            btn_userPassword.AutoSize = true;
            btn_userPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_userPassword.Location = new Point(16, 100);
            btn_userPassword.Name = "btn_userPassword";
            btn_userPassword.Size = new Size(82, 23);
            btn_userPassword.TabIndex = 2;
            btn_userPassword.Text = "Password";
            // 
            // btn_UserName
            // 
            btn_UserName.AutoSize = true;
            btn_UserName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_UserName.Location = new Point(16, 37);
            btn_UserName.Name = "btn_UserName";
            btn_UserName.Size = new Size(56, 23);
            btn_UserName.TabIndex = 2;
            btn_UserName.Text = "Name";
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
            // login_user
            // 
            login_user.BackColor = SystemColors.ActiveCaption;
            login_user.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_user.Location = new Point(69, 231);
            login_user.Name = "login_user";
            login_user.Size = new Size(159, 38);
            login_user.TabIndex = 1;
            login_user.Text = "Login";
            login_user.UseVisualStyleBackColor = false;
            login_user.Click += login_user_Click;
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
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserLogin";
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
        private TextBox user_name;
        private TextBox user_password;
        private Label btn_userPassword;
        private Label btn_UserName;
        private Button button3;
        private Button login_user;
        private Button button4;
        private Button button2;
    }
}
