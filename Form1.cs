namespace LMS
{
    public partial class welcome_form : Form
    {
        public welcome_form()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminLogin1.Show();
            adminLogin1.BringToFront();
            userLogin1.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            userLogin1.Show();
            userLogin1.BringToFront();
            adminLogin1.Hide();
        }

        private void adminLogin1_Load(object sender, EventArgs e)
        {

        }
    }
}
