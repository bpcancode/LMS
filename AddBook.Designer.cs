namespace LMS
{
    partial class AddBook
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
            add_books = new Button();
            add_btn = new Button();
            isbn = new TextBox();
            author = new TextBox();
            book = new TextBox();
            ISBNNnum = new Button();
            Writer_name = new Button();
            Books_name = new Button();
            add_book.SuspendLayout();
            SuspendLayout();
            // 
            // add_book
            // 
            add_book.BackColor = SystemColors.ActiveBorder;
            add_book.Controls.Add(add_books);
            add_book.Controls.Add(add_btn);
            add_book.Controls.Add(isbn);
            add_book.Controls.Add(author);
            add_book.Controls.Add(book);
            add_book.Controls.Add(ISBNNnum);
            add_book.Controls.Add(Writer_name);
            add_book.Controls.Add(Books_name);
            add_book.Location = new Point(8, 8);
            add_book.Name = "add_book";
            add_book.Size = new Size(562, 394);
            add_book.TabIndex = 5;
            // 
            // add_books
            // 
            add_books.BackColor = SystemColors.ActiveCaption;
            add_books.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            add_books.ForeColor = SystemColors.ActiveCaptionText;
            add_books.Location = new Point(143, 291);
            add_books.Name = "add_books";
            add_books.Size = new Size(185, 43);
            add_books.TabIndex = 3;
            add_books.Text = "Add Book";
            add_books.UseVisualStyleBackColor = false;
            add_books.Click += add_books_Click;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.Transparent;
            add_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            add_btn.Location = new Point(3, 14);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(563, 54);
            add_btn.TabIndex = 0;
            add_btn.Text = "Add Book";
            add_btn.UseVisualStyleBackColor = false;
            // 
            // isbn
            // 
            isbn.Location = new Point(209, 219);
            isbn.Name = "isbn";
            isbn.Size = new Size(239, 27);
            isbn.TabIndex = 1;
            // 
            // author
            // 
            author.Location = new Point(209, 162);
            author.Name = "author";
            author.Size = new Size(239, 27);
            author.TabIndex = 1;
            // 
            // book
            // 
            book.Location = new Point(209, 103);
            book.Name = "book";
            book.Size = new Size(233, 27);
            book.TabIndex = 1;
            // 
            // ISBNNnum
            // 
            ISBNNnum.BackColor = Color.Transparent;
            ISBNNnum.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            ISBNNnum.Location = new Point(36, 211);
            ISBNNnum.Name = "ISBNNnum";
            ISBNNnum.Size = new Size(136, 39);
            ISBNNnum.TabIndex = 0;
            ISBNNnum.Text = "ISBN ";
            ISBNNnum.UseVisualStyleBackColor = false;
            // 
            // Writer_name
            // 
            Writer_name.BackColor = Color.Transparent;
            Writer_name.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            Writer_name.Location = new Point(36, 157);
            Writer_name.Name = "Writer_name";
            Writer_name.Size = new Size(136, 32);
            Writer_name.TabIndex = 0;
            Writer_name.Text = "Author Name";
            Writer_name.UseVisualStyleBackColor = false;
            // 
            // Books_name
            // 
            Books_name.BackColor = Color.Transparent;
            Books_name.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            Books_name.Location = new Point(36, 93);
            Books_name.Name = "Books_name";
            Books_name.Size = new Size(136, 43);
            Books_name.TabIndex = 0;
            Books_name.Text = "Book Name";
            Books_name.UseVisualStyleBackColor = false;
            Books_name.Click += Books_name_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(add_book);
            Name = "AddBook";
            Size = new Size(562, 394);
            add_book.ResumeLayout(false);
            add_book.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel add_book;
        private Button add_books;
        private Button add_btn;
        private TextBox isbn;
        private TextBox author;
        private TextBox book;
        private Button ISBNNnum;
        private Button Writer_name;
        private Button Books_name;
    }
}
