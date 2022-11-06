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
    public partial class frmProducts : Form
    {
        private IProductRepository repo = null;
        BindingSource source = null;

        public frmProducts()
        {
            InitializeComponent();
            repo = new ProductRepository();
        }

        private void Clear()
        {
            txtProductID.Text = string.Empty;
            txtCategoryID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
        }

        private void LoadProduct(List<Product> list)
        {
            source = new BindingSource();

            source.DataSource = list;

            txtProductID.DataBindings.Clear();
            txtCategoryID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtWeight.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtUnitsInStock.DataBindings.Clear();

            txtProductID.DataBindings.Add("Text", source, "ProductId");
            txtCategoryID.DataBindings.Add("Text", source, "CategoryId");
            txtProductName.DataBindings.Add("Text", source, "ProductName");
            txtWeight.DataBindings.Add("Text", source, "Weight");
            txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
            txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

            dgvProductList.DataSource = null;
            dgvProductList.DataSource = source;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            List<Product> list = repo.GetAll();
            LoadProduct(list);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string productId = txtProductID.Text;
            string categoryId = txtCategoryID.Text;
            string productName = txtProductName.Text;
            string weight = txtWeight.Text;
            string unitPrice = txtUnitPrice.Text;
            string unitInStock = txtUnitsInStock.Text;

            ProductObject productObject = new ProductObject
            {
                ProductId = Convert.ToInt32(productId),
                CategoryId = Convert.ToInt32(categoryId),
                ProductName = productName,
                Weight = weight,
                UnitPrice = Convert.ToDecimal(unitPrice),
                UnitsInStock = Convert.ToInt32(unitInStock)
            };

            Product product = AutoMapperConfiguration.ToProduct(productObject);

            bool check = repo.Update(product);

            if (check)
            {
                MessageBox.Show("Update product successfully");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string productId = txtProductID.Text;
            bool check = repo.Delete(Convert.ToInt32(productId));
            if (check)
            {
                List<Product> list = repo.GetAll();
                LoadProduct(list);
                MessageBox.Show("Delete product successfully");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails();
            
            if(frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                List<Product> list = repo.GetAll();
                LoadProduct(list);
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string productName = txtSearchProduct.Text;

            List<Product> listAllProduct = repo.GetAll();

            if (productName.Equals(""))
            {
                LoadProduct(listAllProduct);
            }
            else
            {
                List<Product> pro = repo.GetByName(productName);
                if (pro != null)
                {
                    LoadProduct(pro);
                }
                else MessageBox.Show($"Not cantain {productName}");
            }
        }

        //dưới này là statusstrip
        private void txtSearchProduct_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Input to search product";
        }
        private void txtSearchProduct_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        private void btnSearchProduct_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to search product";
        }
        private void btnSearchProduct_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        private void btnNew_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to create new product";
        }
        private void btnNew_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to update product";
        }
        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to delete product";
        }
        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        
    }
}
