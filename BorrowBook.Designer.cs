namespace LMS
{
    partial class Borrowbook1
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
            borrow_btn = new Button();
            borrow_book = new Panel();
            borrow_books = new Button();
            isbnno = new TextBox();
            authorname = new TextBox();
            bookname = new TextBox();
            usernaam = new TextBox();
            userid = new TextBox();
            author_name = new Button();
            book_name = new Button();
            user_name = new Button();
            users = new Button();
            user_ID = new Button();
            borrow_book.SuspendLayout();
            SuspendLayout();
            // 
            // borrow_btn
            // 
            borrow_btn.BackColor = Color.Transparent;
            borrow_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            borrow_btn.Location = new Point(3, 14);
            borrow_btn.Name = "borrow_btn";
            borrow_btn.Size = new Size(563, 54);
            borrow_btn.TabIndex = 0;
            borrow_btn.Text = "Borrow Book";
            borrow_btn.UseVisualStyleBackColor = false;
            // 
            // borrow_book
            // 
            borrow_book.BackColor = SystemColors.ActiveBorder;
            borrow_book.Controls.Add(borrow_books);
            borrow_book.Controls.Add(borrow_btn);
            borrow_book.Controls.Add(isbnno);
            borrow_book.Controls.Add(authorname);
            borrow_book.Controls.Add(bookname);
            borrow_book.Controls.Add(usernaam);
            borrow_book.Controls.Add(userid);
            borrow_book.Controls.Add(author_name);
            borrow_book.Controls.Add(book_name);
            borrow_book.Controls.Add(user_name);
            borrow_book.Controls.Add(users);
            borrow_book.Controls.Add(user_ID);
            borrow_book.Location = new Point(3, 3);
            borrow_book.Name = "borrow_book";
            borrow_book.Size = new Size(562, 394);
            borrow_book.TabIndex = 4;
            // 
            // borrow_books
            // 
            borrow_books.BackColor = SystemColors.ActiveCaption;
            borrow_books.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            borrow_books.ForeColor = SystemColors.ActiveCaptionText;
            borrow_books.Location = new Point(200, 351);
            borrow_books.Name = "borrow_books";
            borrow_books.Size = new Size(185, 43);
            borrow_books.TabIndex = 3;
            borrow_books.Text = "Borrow Book";
            borrow_books.UseVisualStyleBackColor = false;
            borrow_books.Click += borrow_books_Click;
            // 
            // isbnno
            // 
            isbnno.Location = new Point(209, 315);
            isbnno.Name = "isbnno";
            isbnno.Size = new Size(239, 27);
            isbnno.TabIndex = 1;
            // 
            // authorname
            // 
            authorname.Location = new Point(209, 253);
            authorname.Name = "authorname";
            authorname.Size = new Size(239, 27);
            authorname.TabIndex = 1;
            // 
            // bookname
            // 
            bookname.Location = new Point(209, 195);
            bookname.Name = "bookname";
            bookname.Size = new Size(233, 27);
            bookname.TabIndex = 1;
            // 
            // usernaam
            // 
            usernaam.Location = new Point(200, 138);
            usernaam.Name = "usernaam";
            usernaam.Size = new Size(233, 27);
            usernaam.TabIndex = 1;
            // 
            // userid
            // 
            userid.Location = new Point(200, 81);
            userid.Name = "userid";
            userid.Size = new Size(233, 27);
            userid.TabIndex = 1;
            // 
            // author_name
            // 
            author_name.BackColor = Color.Transparent;
            author_name.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            author_name.Location = new Point(36, 303);
            author_name.Name = "author_name";
            author_name.Size = new Size(136, 39);
            author_name.TabIndex = 0;
            author_name.Text = "ISBN ";
            author_name.UseVisualStyleBackColor = false;
            // 
            // book_name
            // 
            book_name.BackColor = Color.Transparent;
            book_name.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            book_name.Location = new Point(36, 248);
            book_name.Name = "book_name";
            book_name.Size = new Size(136, 32);
            book_name.TabIndex = 0;
            book_name.Text = "Author Name";
            book_name.UseVisualStyleBackColor = false;
            // 
            // user_name
            // 
            user_name.BackColor = Color.Transparent;
            user_name.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            user_name.Location = new Point(36, 185);
            user_name.Name = "user_name";
            user_name.Size = new Size(136, 43);
            user_name.TabIndex = 0;
            user_name.Text = "Book Name";
            user_name.UseVisualStyleBackColor = false;
            // 
            // users
            // 
            users.BackColor = Color.Transparent;
            users.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            users.Location = new Point(36, 130);
            users.Name = "users";
            users.Size = new Size(136, 35);
            users.TabIndex = 0;
            users.Text = "User Name";
            users.UseVisualStyleBackColor = false;
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
            // Borrowbook1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(borrow_book);
            Name = "Borrowbook1";
            Size = new Size(562, 394);
            borrow_book.ResumeLayout(false);
            borrow_book.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button borrow_btn;
        private Panel borrow_book;
        private Button borrow_books;
        private TextBox isbnno;
        private TextBox authorname;
        private TextBox bookname;
        private TextBox usernaam;
        private TextBox userid;
        private Button author_name;
        private Button book_name;
        private Button user_name;
        private Button users;
        private Button user_ID;
    }
}
