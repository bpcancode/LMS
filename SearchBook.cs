using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LMS
{
    public partial class searchBook1 : UserControl
    {
        
        public List<Book> allBooks = [];
        public List<Book> Books = [];
        public searchBook1()
        {
            InitializeComponent();
            Load += addBooksInGrid;

        }

        private void addBooksInGrid(object? sender, EventArgs e)
        {
            GetBooks();
            dataGridView1.DataSource = Books;
            /*DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "Action";
            uninstallButtonColumn.Text = "Action";
            if (dataGridView1.Columns["uninstall_column"] == null)
            {
                dataGridView1.Columns.Insert(3, uninstallButtonColumn);
            }*/
        }

        private void search_books_Click(object sender, EventArgs e)
        {
            //listItem.Items.Clear();
            if(bookSearchField.Text == "")
            {
                dataGridView1.DataSource = allBooks;
                return;
            }
            var books = allBooks.Where(x => x.Title.Equals(bookSearchField.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            Books = books;
            dataGridView1.DataSource = Books;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GetBooks()
        {
            allBooks.Clear();
            var bookName = bookSearchField.Text;
            var bookPath = "inventory.txt";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            foreach (string line in File.ReadLines(Path.Combine(docPath, bookPath)))
            {
                if (line.Contains(bookName))
                {
                    var book = JsonSerializer.Deserialize<Book>(line);
                    allBooks.Add(book);
                    Books.Add(book);
                }
            }
        }

            private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.ColumnIndex == dataGridView1.Columns["Action"].Index)
                {
                    Book book = (Book)dataGridView1.CurrentRow.DataBoundItem;
                    if(book.Action == "Borrow")
                    {
                        book.BorrowBook(book);
                    } else
                    {
                        book.ReturnBook(book);
                    }
                }
            }

        private void search_book_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
