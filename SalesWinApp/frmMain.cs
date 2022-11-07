using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void closeform() {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeform();
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Products")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmProducts frmProduct = new frmProducts();
                frmProduct.MdiParent = this;
                frmProduct.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            if (frmLogin.isAdmin)
            {
                menuStrip2.Hide();
            }
            else
            {
                menuStrip1.Hide();
            }
        }

        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeform();
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Members")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmMembers frmMember = new frmMembers();
                frmMember.MdiParent = this;
                frmMember.Show();
            }

        }

        private void orderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeform();
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Orders")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmOrders frmOrder = new frmOrders();
                frmOrder.MdiParent = this;
                frmOrder.Show();
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeform();
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Profile")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmProfile frmPro = new frmProfile();
                frmPro.MdiParent = this;
                frmPro.Show();
            }
        }
    }
}
