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
    public partial class AdminLogin : UserControl
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            if (textBox2.Text == "Username")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Username";
                textBox2.ForeColor = Color.Black;
            }

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            if (textBox1.Text == "Password")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Password";
                textBox1.ForeColor = Color.Black;
            }
        }
    }
}
