using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmOrderDetails frmOrderDetail = new frmOrderDetails();
            frmOrderDetail.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        //dưới này là statusstrip

        private void btnNew_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to create new order";
        }
        private void btnNew_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to update order";
        }
        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to delete order";
        }
        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
