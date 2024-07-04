namespace LMS
{
    partial class NewUser
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
            add_book = new Panel();
            save_user = new Button();
            new_btn = new Button();
            addr = new TextBox();
            mail = new TextBox();
            contact_c = new TextBox();
            user_nm = new TextBox();
            user1 = new TextBox();
            address_user = new Button();
            user_email = new Button();
            user_contact = new Button();
            user_name = new Button();
            user_ID = new Button();
            add_book.SuspendLayout();
            SuspendLayout();
            // 
            // add_book
            // 
            add_book.BackColor = SystemColors.ActiveBorder;
            add_book.Controls.Add(save_user);
            add_book.Controls.Add(new_btn);
            add_book.Controls.Add(addr);
            add_book.Controls.Add(mail);
            add_book.Controls.Add(contact_c);
            add_book.Controls.Add(user_nm);
            add_book.Controls.Add(user1);
            add_book.Controls.Add(address_user);
            add_book.Controls.Add(user_email);
            add_book.Controls.Add(user_contact);
            add_book.Controls.Add(user_name);
            add_book.Controls.Add(user_ID);
            add_book.Location = new Point(8, 8);
            add_book.Name = "add_book";
            add_book.Size = new Size(562, 394);
            add_book.TabIndex = 6;
            // 
            // save_user
            // 
            save_user.BackColor = SystemColors.ActiveCaption;
            save_user.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            save_user.ForeColor = SystemColors.ActiveCaptionText;
            save_user.Location = new Point(209, 340);
            save_user.Name = "save_user";
            save_user.Size = new Size(185, 43);
            save_user.TabIndex = 3;
            save_user.Text = "Save";
            save_user.UseVisualStyleBackColor = false;
            save_user.Click += save_user_Click;
            // 
            // new_btn
            // 
            new_btn.BackColor = Color.Transparent;
            new_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            new_btn.Location = new Point(3, 14);
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(563, 54);
            new_btn.TabIndex = 0;
            new_btn.Text = "New User";
            new_btn.UseVisualStyleBackColor = false;
            // 
            // addr
            // 
            addr.Location = new Point(209, 303);
            addr.Name = "addr";
            addr.Size = new Size(239, 27);
            addr.TabIndex = 1;
            // 
            // mail
            // 
            mail.Location = new Point(209, 253);
            mail.Name = "mail";
            mail.Size = new Size(239, 27);
            mail.TabIndex = 1;
            // 
            // contact_c
            // 
            contact_c.Location = new Point(209, 189);
            contact_c.Name = "contact_c";
            contact_c.Size = new Size(233, 27);
            contact_c.TabIndex = 1;
            // 
            // user_nm
            // 
            user_nm.Location = new Point(200, 130);
            user_nm.Name = "user_nm";
            user_nm.Size = new Size(233, 27);
            user_nm.TabIndex = 1;
            // 
            // user1
            // 
            user1.Location = new Point(200, 81);
            user1.Name = "user1";
            user1.Size = new Size(233, 27);
            user1.TabIndex = 1;
            // 
            // address_user
            // 
            address_user.BackColor = Color.Transparent;
            address_user.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            address_user.Location = new Point(36, 295);
            address_user.Name = "address_user";
            address_user.Size = new Size(136, 39);
            address_user.TabIndex = 0;
            address_user.Text = "Address";
            address_user.UseVisualStyleBackColor = false;
            // 
            // user_email
            // 
            user_email.BackColor = Color.Transparent;
            user_email.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            user_email.Location = new Point(36, 248);
            user_email.Name = "user_email";
            user_email.Size = new Size(136, 32);
            user_email.TabIndex = 0;
            user_email.Text = "Email Address";
            user_email.UseVisualStyleBackColor = false;
            // 
            // user_contact
            // 
            user_contact.BackColor = Color.Transparent;
            user_contact.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            user_contact.Location = new Point(36, 179);
            user_contact.Name = "user_contact";
            user_contact.Size = new Size(136, 43);
            user_contact.TabIndex = 0;
            user_contact.Text = "Contact";
            user_contact.UseVisualStyleBackColor = false;
            // 
            // user_name
            // 
            user_name.BackColor = Color.Transparent;
            user_name.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            user_name.Location = new Point(36, 124);
            user_name.Name = "user_name";
            user_name.Size = new Size(136, 35);
            user_name.TabIndex = 0;
            user_name.Text = "User Name";
            user_name.UseVisualStyleBackColor = false;
            // 
            // user_ID
            // 
            user_ID.BackColor = Color.Transparent;
            user_ID.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            user_ID.Location = new Point(52, 74);
            user_ID.Name = "user_ID";
            user_ID.Size = new Size(100, 37);
            user_ID.TabIndex = 0;
            user_ID.Text = "User ID";
            user_ID.UseVisualStyleBackColor = false;
            // 
            // NewUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(add_book);
            Name = "NewUser";
            Size = new Size(562, 394);
            add_book.ResumeLayout(false);
            add_book.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel add_book;
        private Button save_user;
        private Button new_btn;
        private TextBox addr;
        private TextBox mail;
        private TextBox contact_c;
        private TextBox user_nm;
        private TextBox user1;
        private Button address_user;
        private Button user_email;
        private Button user_contact;
        private Button user_name;
        private Button user_ID;
    }
}
