using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Reflection.Metadata.BlobBuilder;


namespace LMS
{
    public partial class AddBook : UserControl
    {

        public List<Book> bookie;
        public List<User> usiee;

        public AddBook()
        {
            bookie = new List<Book>();
            usiee = new List<User>();

            InitializeComponent();

        }

        private void user1_TextChanged(object sender, EventArgs e)
        {

        }


        private void add_books_Click(object sender, EventArgs e)
        {
            string title = book.Text;
            string authorname = author.Text;
            string Isbn = isbn.Text;
            Book newBook = new(title, authorname, Isbn);
            Library.Add(newBook);

            book.Clear();
            author.Clear();
            isbn.Clear();

            

        }

        private void Books_name_Click(object sender, EventArgs e)
        {

        }
    }
}
