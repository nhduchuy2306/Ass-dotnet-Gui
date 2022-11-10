using BussinessObject.Models;
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
    public partial class frmHistoryOrder : Form
    {
        public Member Member;
       
        public frmHistoryOrder()
        {
            InitializeComponent();
        }
        private void loadHistoryOrder()
        {
            dgvHistory.DataSource = Member.Orders;
        }
        private void frmHistoryOrder_Load(object sender, EventArgs e)
        {
            loadHistoryOrder();
        }
    }
}
