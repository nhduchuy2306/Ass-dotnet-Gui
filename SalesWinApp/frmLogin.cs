using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the password!";
        }

        private void txtEmail_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the email!";
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to login";
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to Exit";
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}