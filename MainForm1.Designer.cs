namespace LMS
{
    partial class MainForm1
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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel3 = new Panel();
            btn_returnbook = new Button();
            btn_searchbook = new Button();
            borrow_book = new Button();
            btn_logout = new Button();
            btn_addbook = new Button();
            dash_board = new Button();
            newUser1 = new NewUser();
            addBook1 = new AddBook();
            borrowbook11 = new Borrowbook1();
            returnBook1 = new ReturnBook();
            searchBook11 = new searchBook1();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 122);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_100;
            pictureBox1.Location = new Point(16, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 102);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(144, 50);
            button1.Name = "button1";
            button1.Size = new Size(563, 46);
            button1.TabIndex = 0;
            button1.Text = "Library Management System";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(btn_returnbook);
            panel3.Controls.Add(btn_searchbook);
            panel3.Controls.Add(borrow_book);
            panel3.Controls.Add(btn_logout);
            panel3.Controls.Add(btn_addbook);
            panel3.Controls.Add(dash_board);
            panel3.Location = new Point(2, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 393);
            panel3.TabIndex = 2;
            // 
            // btn_returnbook
            // 
            btn_returnbook.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_returnbook.Location = new Point(16, 269);
            btn_returnbook.Name = "btn_returnbook";
            btn_returnbook.Size = new Size(94, 59);
            btn_returnbook.TabIndex = 0;
            btn_returnbook.Text = "show books";
            btn_returnbook.UseVisualStyleBackColor = true;
            btn_returnbook.Click += btn_returnbook_Click;
            // 
            // btn_searchbook
            // 
            btn_searchbook.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_searchbook.Location = new Point(16, 197);
            btn_searchbook.Name = "btn_searchbook";
            btn_searchbook.Size = new Size(94, 55);
            btn_searchbook.TabIndex = 0;
            btn_searchbook.Text = "Search Book";
            btn_searchbook.UseVisualStyleBackColor = true;
            btn_searchbook.Click += btn_searchbook_Click;
            // 
            // borrow_book
            // 
            borrow_book.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrow_book.Location = new Point(16, 123);
            borrow_book.Name = "borrow_book";
            borrow_book.Size = new Size(94, 58);
            borrow_book.TabIndex = 0;
            borrow_book.Text = "Borrow Book";
            borrow_book.UseVisualStyleBackColor = true;
            borrow_book.Click += borrow_book_Click;
            // 
            // btn_logout
            // 
            btn_logout.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logout.Location = new Point(16, 350);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 30);
            btn_logout.TabIndex = 0;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click_1;
            // 
            // btn_addbook
            // 
            btn_addbook.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addbook.Location = new Point(16, 75);
            btn_addbook.Name = "btn_addbook";
            btn_addbook.Size = new Size(94, 29);
            btn_addbook.TabIndex = 0;
            btn_addbook.Text = "Add Book";
            btn_addbook.UseVisualStyleBackColor = true;
            btn_addbook.Click += btn_addbook_Click_1;
            // 
            // dash_board
            // 
            dash_board.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dash_board.Location = new Point(3, 0);
            dash_board.Name = "dash_board";
            dash_board.Size = new Size(137, 54);
            dash_board.TabIndex = 0;
            dash_board.Text = "Dashboard";
            dash_board.UseVisualStyleBackColor = true;
            // 
            // newUser1
            // 
            newUser1.Location = new Point(158, 118);
            newUser1.Name = "newUser1";
            newUser1.Size = new Size(702, 492);
            newUser1.TabIndex = 3;
            // 
            // addBook1
            // 
            addBook1.Location = new Point(137, 129);
            addBook1.Name = "addBook1";
            addBook1.Size = new Size(702, 492);
            addBook1.TabIndex = 4;
            // 
            // borrowbook11
            // 
            borrowbook11.Location = new Point(118, 118);
            borrowbook11.Name = "borrowbook11";
            borrowbook11.Size = new Size(702, 492);
            borrowbook11.TabIndex = 5;
            // 
            // returnBook1
            // 
            returnBook1.Location = new Point(118, 118);
            returnBook1.Name = "returnBook1";
            returnBook1.Size = new Size(702, 492);
            returnBook1.TabIndex = 6;
            // 
            // searchBook11
            // 
            searchBook11.Location = new Point(118, 129);
            searchBook11.Name = "searchBook11";
            searchBook11.Size = new Size(702, 492);
            searchBook11.TabIndex = 7;
            searchBook11.Load += searchBook11_Load;
            // 
            // MainForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 521);
            Controls.Add(searchBook11);
            Controls.Add(returnBook1);
            Controls.Add(borrowbook11);
            Controls.Add(addBook1);
            Controls.Add(newUser1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "MainForm1";
            Text = "MainForm1";
            Load += MainForm1_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel3;
        private Button btn_returnbook;
        private Button btn_searchbook;
        private Button borrow_book;
        private Button btn_logout;
        private Button btn_addbook;
        private Button dash_board;
        private NewUser newUser1;
        private AddBook addBook1;
        private Borrowbook1 borrowbook11;
        private ReturnBook returnBook1;
        private searchBook1 searchBook11;
    }
}