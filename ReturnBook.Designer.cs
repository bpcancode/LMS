namespace LMS
{
    partial class ReturnBook
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
            return_book = new Panel();
            return_btn = new Button();
            return_book.SuspendLayout();
            SuspendLayout();
            // 
            // return_book
            // 
            return_book.BackColor = SystemColors.ActiveBorder;
            return_book.Controls.Add(return_btn);
            return_book.Location = new Point(8, 8);
            return_book.Name = "return_book";
            return_book.Size = new Size(591, 434);
            return_book.TabIndex = 5;
            return_book.Paint += return_book_Paint;
            // 
            // return_btn
            // 
            return_btn.BackColor = Color.Transparent;
            return_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            return_btn.Location = new Point(3, 14);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(563, 54);
            return_btn.TabIndex = 0;
            return_btn.Text = "Book Lists";
            return_btn.UseVisualStyleBackColor = false;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(return_book);
            Name = "ReturnBook";
            Size = new Size(562, 394);
            return_book.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel return_book;
        private Button return_btn;
    }
}
