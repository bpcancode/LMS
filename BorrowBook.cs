using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Borrowbook1 : UserControl
    {
        public Borrowbook1()
        {
            InitializeComponent();
        }

        private void borrow_books_Click(object sender, EventArgs e)
        {
            string UserData = userid.Text+ "," + usernaam.Text +"," + bookname.Text +"," + isbnno.Text;
            StreamWriter UserDetail = new StreamWriter("User.txt", append: true);
            UserDetail.WriteLine(UserData);
           
            userid.Clear();
            usernaam.Clear();
            bookname.Clear();
            authorname.Clear();
            isbnno.Clear();
            UserDetail.Close();
           
        }
    }
}
 