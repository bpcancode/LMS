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
    public partial class NewUser : UserControl
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void save_user_Click(object sender, EventArgs e)
        {
            string userData = user_ID.Text + "," + user_name.Text + "," + user_contact.Text + "," + user_email.Text;
            StreamWriter UserDetail = new StreamWriter("User.txt", append: true);
            UserDetail.WriteLine(userData);
            MessageBox.Show("New userr details saved successfully!");
            user1.Clear();
            user_nm.Clear();
            contact_c.Clear();
            mail.Clear();
            addr.Clear();
            UserDetail.Close();
            
        } 
    }

       }
 
