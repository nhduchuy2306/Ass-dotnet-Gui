using BussinessObject.Mappings;
using BussinessObject;
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
using BussinessObject.Models;

namespace SalesWinApp
{
    public partial class frmOder : Form
    {
        IOrderRepository repo;
        int oId = 0;
        BindingSource source = null;

        public frmOder()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            repo = new OrderRepository();
        }
        public frmOder(int id)
        {
            InitializeComponent();
            btnSave.Enabled = false;
            repo = new OrderRepository();
            oId = id;
        }

        private void LoadOrder(Order order)
        {
            source = new BindingSource();
            OrderObject obj = AutoMapperConfiguration.ToOrderObject(order);
            source.DataSource = obj;

            txtOrderID.DataBindings.Clear();
            txtMemberID.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtRequiredDate.DataBindings.Clear();
            txtShippedDate.DataBindings.Clear();
            txtFreight.DataBindings.Clear();

            txtOrderID.DataBindings.Add("Text", source, "OrderId");
            txtMemberID.DataBindings.Add("Text", source, "MemberID");
            txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
            txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
            txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
            txtFreight.DataBindings.Add("Text", source, "Freight");
        }

        private void frmOder_Load(object sender, EventArgs e)
        {
            if(oId != 0)
            {
                LoadOrder(repo.GetById(oId));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int memberId=0;
            DateTime orderDate = DateTime.Now;
            DateTime? requiredDate = null;
            DateTime? shippedDate = null;
            decimal? freight = null;
            try
            {
                memberId = Convert.ToInt32(txtMemberID.Text);
                if (txtRequiredDate.Text != "")
                {
                    requiredDate = DateTime.Parse(txtRequiredDate.Text);
                }
                if (txtShippedDate.Text != "")
                {
                    shippedDate = DateTime.Parse(txtShippedDate.Text);
                }
                if (txtFreight.Text != "")
                {
                    freight = Convert.ToDecimal(txtFreight.Text);
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input!!!");
                MessageBox.Show("Invalid Input!!!");
            }
            OrderObject orderObject = new OrderObject(0, memberId, orderDate, requiredDate, shippedDate, freight);
            if(memberId == 0)
            {
                MessageBox.Show("Add fail!!!!");
            }
            else
            {
                repo.Add(AutoMapperConfiguration.ToOrder(orderObject));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(txtOrderID.Text);
            int memberId = 0;
            DateTime orderDate = DateTime.Parse(txtOrderDate.Text);
            DateTime? requiredDate = null;
            DateTime? shippedDate = null;
            decimal? freight = null;
            try
            {
                memberId = Convert.ToInt32(txtMemberID.Text);
                if (txtRequiredDate.Text != "")
                {
                    requiredDate = DateTime.Parse(txtRequiredDate.Text);
                }
                if (txtShippedDate.Text != "")
                {
                    shippedDate = DateTime.Parse(txtShippedDate.Text);
                }
                if (txtFreight.Text != "")
                {
                    freight = Convert.ToDecimal(txtFreight.Text);
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input!!!");
                MessageBox.Show("Invalid Input!!!");
            }
            OrderObject orderObject = new OrderObject(orderId, memberId, orderDate, requiredDate, shippedDate, freight);
            if (memberId == 0)
            {
                MessageBox.Show("Update fail!!!!");
            }
            else
            {
                repo.Update(AutoMapperConfiguration.ToOrder(orderObject));
            }
        }
    }
}
