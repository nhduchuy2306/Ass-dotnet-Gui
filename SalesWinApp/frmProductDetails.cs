using BussinessObject.Mappings;
using BussinessObject.Models;
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

namespace SalesWinApp
{
    public partial class frmProductDetails : Form
    {
        private IProductRepository repo = null;

        private bool UpdateOrCreate = false;

        private ProductObject _productObject = null;

        public frmProductDetails()
        {
            InitializeComponent();
            repo = new ProductRepository();
        }

        public frmProductDetails(bool updateOrCreate)
        {
            InitializeComponent();
            repo = new ProductRepository();
            UpdateOrCreate = updateOrCreate;
        }

        public frmProductDetails(ProductObject p, bool updateOrCreate)
        {
            InitializeComponent();
            repo = new ProductRepository();
            _productObject = p;
            UpdateOrCreate = updateOrCreate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UpdateOrCreate == true)
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
                    DialogResult = DialogResult.OK;
                }
                
            }
            else
            {
                lbProductID.Hide();
                txtProductID.Hide();
                string categoryId = txtCategoryID.Text;
                string productName = txtProductName.Text;
                string weight = txtWeight.Text;
                string unitPrice = txtUnitPrice.Text;
                string unitInStock = txtUnitsInStock.Text;

                ProductObject productObject = new ProductObject
                {
                    CategoryId = Convert.ToInt32(categoryId),
                    ProductName = productName,
                    Weight = weight,
                    UnitPrice = Decimal.Parse(unitPrice),
                    UnitsInStock = Convert.ToInt32(unitInStock)
                };

                Product product = AutoMapperConfiguration.ToProduct(productObject);

                bool check = repo.Add(product);

                if (check)
                {
                    MessageBox.Show("Add product successfully");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmProducts product = new frmProducts();
            frmMain main = new frmMain();
            product.MdiParent = main;
            product.Show();
            this.Hide();
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            if (UpdateOrCreate == true)
            {
                if (_productObject != null)
                {
                    txtProductID.Text = Convert.ToString(_productObject.ProductId);
                    txtCategoryID.Text = Convert.ToString(_productObject.CategoryId);
                    txtProductName.Text = _productObject.ProductName;
                    txtUnitPrice.Text = Convert.ToString(_productObject.UnitPrice);
                    txtUnitsInStock.Text = Convert.ToString(_productObject.UnitsInStock);
                    txtWeight.Text = Convert.ToString(_productObject.Weight);
                }
            }
        }
    }
}
