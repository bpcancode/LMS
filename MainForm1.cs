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
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            welcome_form welcome = new welcome_form();
            welcome.Show();
        }



        private void btn_addbook_Click_1(object sender, EventArgs e)
        {
            returnBook1.Hide();
            newUser1.Hide();
            searchBook11.Hide();
            borrowbook11.Hide();
            addBook1.Show();
            addBook1.BringToFront();

        }

        private void borrow_book_Click(object sender, EventArgs e)
        {
            returnBook1.Hide();
            newUser1.Hide();
            searchBook11.Hide();
            borrowbook11.Show();
            addBook1.Hide();
            borrowbook11.BringToFront();

        }

        private void btn_searchbook_Click(object sender, EventArgs e)
        {
            returnBook1.Hide();
            newUser1.Hide();
            searchBook11.Show();
            borrowbook11.Hide();
            addBook1.Hide();
            searchBook11.BringToFront();
        }

        private void btn_returnbook_Click(object sender, EventArgs e)
        {
            returnBook1.Hide();
            newUser1.Hide();
            searchBook11.Hide();
            borrowbook11.Hide();
            addBook1.Hide();
            returnBook1.BringToFront();

        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            NewUser user = new NewUser();
            user.Show();
            user.BringToFront();
            addBook1.Hide();
            returnBook1.Hide();
            searchBook11.Hide();
            borrowbook11.Hide();

        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            welcome_form welcome = new welcome_form();
            welcome.Show();
            this.Hide();
        }

        private void searchBook11_Load(object sender, EventArgs e)
        {

        }
    }
}
