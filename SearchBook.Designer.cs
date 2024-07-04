
namespace LMS
{
    partial class searchBook1
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
            components = new System.ComponentModel.Container();
            search_book = new Panel();
            dataGridView1 = new DataGridView();
            search_books = new Button();
            bookSearchField = new TextBox();
            user_name = new Button();
            bookBindingSource = new BindingSource(components);
            search_book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // search_book
            // 
            search_book.BackColor = SystemColors.ActiveBorder;
            search_book.Controls.Add(dataGridView1);
            search_book.Controls.Add(search_books);
            search_book.Controls.Add(bookSearchField);
            search_book.Controls.Add(user_name);
            search_book.Location = new Point(3, 3);
            search_book.Name = "search_book";
            search_book.Size = new Size(562, 394);
            search_book.TabIndex = 5;
            search_book.Paint += search_book_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(3, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(553, 259);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView_CellClick;
            // 
            // search_books
            // 
            search_books.BackColor = SystemColors.ActiveCaption;
            search_books.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            search_books.ForeColor = SystemColors.ActiveCaptionText;
            search_books.Location = new Point(371, 61);
            search_books.Name = "search_books";
            search_books.Size = new Size(185, 43);
            search_books.TabIndex = 3;
            search_books.Text = "Search Book";
            search_books.UseVisualStyleBackColor = false;
            search_books.Click += search_books_Click;
            // 
            // bookSearchField
            // 
            bookSearchField.Location = new Point(156, 28);
            bookSearchField.Name = "bookSearchField";
            bookSearchField.Size = new Size(400, 27);
            bookSearchField.TabIndex = 1;
            bookSearchField.TextChanged += textBox2_TextChanged;
            // 
            // user_name
            // 
            user_name.BackColor = Color.Transparent;
            user_name.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            user_name.Location = new Point(3, 21);
            user_name.Name = "user_name";
            user_name.Size = new Size(148, 37);
            user_name.TabIndex = 0;
            user_name.Text = "Book Name";
            user_name.UseVisualStyleBackColor = false;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // searchBook1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(search_book);
            Name = "searchBook1";
            Size = new Size(562, 394);
            search_book.ResumeLayout(false);
            search_book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel search_book;
        private Button search_books;
        private TextBox bookSearchField;
        private Button user_name;
        private BindingSource bookBindingSource;
        private DataGridView dataGridView1;
    }
}
