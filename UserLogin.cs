using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LMS
{
    public partial class UserLogin : UserControl
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void user_name_MouseHover(object sender, EventArgs e)
        {
            if (user_name.Text == "Username")
            {
                user_name.Text = "";
                user_name.ForeColor = Color.Black;
            }
        }

        private void user_name_MouseLeave(object sender, EventArgs e)
        {
            if (user_name.Text == "")
            {
                user_name.Text = "Username";
                user_name.ForeColor = Color.Black;
            }
        }

        private void user_password_MouseHover(object sender, EventArgs e)
        {
            if (user_password.Text == "Password")
            {
                user_password.Text = "";
                user_password.ForeColor = Color.Black;
            }
        }

        private void user_password_MouseLeave(object sender, EventArgs e)
        {
            if (user_password.Text == "")
            {
                user_password.Text = "Password";
                user_password.ForeColor = Color.Black;
            }
        }

        private void login_user_Click(object sender, EventArgs e)
        {
            //authenticating the user
            if (user_name.Text == "User" && user_password.Text == "User")
            {
                //Opening the user dashboard
                MainForm1 main = new MainForm1();
                main.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
