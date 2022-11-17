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
    public partial class frmOrderDetails : Form
    {
        private IOrderDetailRepository repo;


        BindingSource source;
        int oId;

        public frmOrderDetails(int id)
        {
            InitializeComponent();
            oId = id;
            repo = new OrderDetailRepository();
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            IProductRepository proRepo = new ProductRepository();
            List<Product> products = proRepo.GetAll();
            txtOrderID.Text = oId.ToString();
            foreach (Product product in products)
            {
                txtProductId.Items.Add(product.ProductId);
            }
            txtProductId.SelectedIndex = 0;
            txtProductId.TextChanged += new EventHandler(txtUnitPrice_TextChanged);
            txtQuantity.TextChanged += new EventHandler(txtUnitPrice_TextChanged);
            txtDiscount.TextChanged += new EventHandler(txtUnitPrice_TextChanged);
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

            int pId = 0;
            int quantity = 0;
            double discount = 0;
            decimal unitPrice = 0;
            try
            {
                quantity = Convert.ToInt32(txtQuantity.Text);
                discount = Convert.ToDouble(txtDiscount.Text);
                unitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                pId = Convert.ToInt32(txtProductId.Text);
            }
            catch
            {
                MessageBox.Show("Add Fail!! Invalid Input!! ");
                return;
            }
            IProductRepository productRepo = new ProductRepository();
            Product product = productRepo.GetById(pId);
            if (product == null)
            {
                MessageBox.Show("Product not exist!!!");
                return;
            }
            else if (quantity <= 0)
            {
                MessageBox.Show("Quantity must > 0!!!");
                return;
            }
            else
            {
                OrderDetailObject obj = new OrderDetailObject(oId, pId, unitPrice, quantity, discount);
                if (repo.Add(AutoMapperConfiguration.ToOrderDetail(obj)))
                {
                    MessageBox.Show("Add Successfully!!!");
                }
                else { MessageBox.Show("Add Fail!!! Detail may be duplicated!!!"); }
            }


        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(txtQuantity.Text);
                int discount = Convert.ToInt32(txtDiscount.Text);
                int pId = Convert.ToInt32(txtProductId.Text);
                IProductRepository productRepo = new ProductRepository();
                Product product = productRepo.GetById(pId);
                int price = Convert.ToInt32(product.UnitPrice);
                txtUnitPrice.Text = (quantity * price - discount).ToString();
            }
            catch
            {
                Console.WriteLine("Invalid Input!!");
            }

        }
    }
}
