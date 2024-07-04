namespace LMS
{
    partial class welcome_form
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
            btn1 = new Button();
            btnAdmin = new Button();
            btnUser = new Button();
            userLogin1 = new UserLogin();
            adminLogin1 = new AdminLogin();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = Color.DarkGray;
            btn1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn1.Location = new Point(126, 65);
            btn1.Name = "btn1";
            btn1.Size = new Size(390, 59);
            btn1.TabIndex = 0;
            btn1.Text = "Library Management System";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = SystemColors.ActiveCaption;
            btnAdmin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdmin.Location = new Point(12, 243);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(94, 47);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = SystemColors.ActiveCaption;
            btnUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUser.Location = new Point(566, 243);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(94, 47);
            btnUser.TabIndex = 1;
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // userLogin1
            // 
            userLogin1.Location = new Point(126, 65);
            userLogin1.Name = "userLogin1";
            userLogin1.Size = new Size(386, 582);
            userLogin1.TabIndex = 2;
            // 
            // adminLogin1
            // 
            adminLogin1.Location = new Point(126, 42);
            adminLogin1.Name = "adminLogin1";
            adminLogin1.Size = new Size(381, 575);
            adminLogin1.TabIndex = 3;
            adminLogin1.Load += adminLogin1_Load;
            // 
            // welcome_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.library;
            ClientSize = new Size(729, 521);
            Controls.Add(adminLogin1);
            Controls.Add(userLogin1);
            Controls.Add(btnUser);
            Controls.Add(btnAdmin);
            Controls.Add(btn1);
            Name = "welcome_form";
            Text = "WelcomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btnAdmin;
        private Button btnUser;
        private UserLogin userLogin1;
        private AdminLogin adminLogin1;
    }
}
