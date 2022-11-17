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

        public int MemID { get; set; }  
        public frmOrders()
        {
            InitializeComponent();
            repo = new OrderRepository();
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
            
            if (MemID > 0)
            {
                LoadOrder(repo.GetByMemberID(MemID));
            }
            else
            {
                LoadOrder(repo.GetAll());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmOrder form = new frmOrder();
            if(form.ShowDialog() == DialogResult.OK)
            {
                LoadOrder(repo.GetAll());
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmOrder form = new frmOrder(Convert.ToInt32(txtOrderID.Text));
            if(form.ShowDialog() == DialogResult.OK)
            {
                LoadOrder(repo.GetAll());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            repo.Delete(Convert.ToInt32(txtOrderID.Text));
            LoadOrder(repo.GetAll());
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            frmOrderDetails form = new frmOrderDetails(Convert.ToInt32(txtOrderID.Text));
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadOrder(repo.GetAll());
            }
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            frmReport form = new frmReport();
            form.ShowDialog();
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
