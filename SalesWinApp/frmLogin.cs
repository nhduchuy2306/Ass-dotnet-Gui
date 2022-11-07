using DataAccess.Repository;
using BussinessObject.Models;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        private IMemberRepository _memberRepository;
        public static bool isAdmin = false;
        public frmLogin()
        {
            InitializeComponent();
            _memberRepository = new MemberRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = this._memberRepository.GetEmailAdmin();
            string pass = this._memberRepository.GetPassAdmin();
            if(txtEmail.Text == "")
            {
                MessageBox.Show("Please input Email");
            }else if(txtPassword.Text == "")
            {
                MessageBox.Show("Please input Password");
            }
            if(txtEmail.Text.Equals(email) && txtPassword.Text.Equals(pass))
            {
                frmMain main = new frmMain();
                isAdmin = true;
                this.Hide();
                main.Show();
            }
            else
            {
                var member = this._memberRepository.GetMembers().Where(m => m.Email == txtEmail.Text && m.Password == txtPassword.Text).FirstOrDefault();
                if(member != null)
                {
                    frmMain main = new frmMain();
                    isAdmin = false;
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Email and Password!");
                }
            }
        }

        //statusstrip

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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}