﻿using BussinessObject.Models;
using DataAccess.Repository;
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
    public partial class frmOrderDetails : Form
    {
        private IOrderDetailRepository repo;
        BindingSource source;
        int oId;

        public frmOrderDetails(int id)
        {
            InitializeComponent();
            oId = id;
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            txtOrderID.Text = oId.ToString();
            txtUnitPrice.DataBindings.Add();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmOrders frmOrder = new frmOrders();
            frmMain main = new frmMain();
            frmOrder.MdiParent = main;
            frmOrder.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
