using BussinessObject;
using BussinessObject.Mappings;
using BussinessObject.Models;
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
    public partial class frmOrders : Form
    {

        private IOrderRepository repo;
        BindingSource source = null;
        public frmOrders()
        {
            InitializeComponent();
            repo = new OrderRepository();
        }

        private void Clear()
        {
            txtOrderID.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtRequiredDate.Text = string.Empty;
            txtShippedDate.Text = string.Empty;
            txtFreight.Text = string.Empty;
        }

        private void LoadOrder(List<Order> list)
        {
            source = new BindingSource();
            List<OrderObject> listO = new List<OrderObject>();
            list.ForEach(p => listO.Add(AutoMapperConfiguration.ToOrderObject(p)));
            source.DataSource = listO;
            
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

            dgvOrderList.DataSource = null;
            dgvOrderList.DataSource = source;

        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadOrder(repo.GetAll());
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            int memberId = Convert.ToInt32(txtMemberID.Text);
            DateTime orderDate = DateTime.Now;
            DateTime? requiredDate = null;
            DateTime? shippedDate = null;
            try
            {
                orderDate = DateTime.Parse(txtOrderDate.Text);
                if (txtRequiredDate.Text != "")
                {
                    requiredDate = DateTime.Parse(txtRequiredDate.Text);
                }
                if (txtShippedDate.Text != "")
                {
                    shippedDate = DateTime.Parse(txtShippedDate.Text);
                }
            }
            catch
            {
                Console.WriteLine("Invalid Date!!!");
                MessageBox.Show("Invalid Date!!!");
            }
            decimal? freight = Convert.ToDecimal(txtFreight.Text);
            OrderObject orderObject = new OrderObject(0, memberId, orderDate, requiredDate, shippedDate, freight);
            if (repo.Add(AutoMapperConfiguration.ToOrder(orderObject)))
            {
                MessageBox.Show("Add Successfully!!!");
            }else MessageBox.Show("Add Fail!!!");
            
            LoadOrder(repo.GetAll());

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
