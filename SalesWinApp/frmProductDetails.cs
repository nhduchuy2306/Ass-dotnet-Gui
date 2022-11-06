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

        public frmProductDetails()
        {
            InitializeComponent();
            repo = new ProductRepository();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
                UnitPrice = Convert.ToDecimal(unitPrice),
                UnitsInStock = Convert.ToInt32(unitInStock)
            };

            Product product = AutoMapperConfiguration.ToProduct(productObject);

            bool check = repo.Add(product);

            if (check)
            {
                MessageBox.Show("Add product successfully");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmProducts product = new frmProducts();
            product.Show();
            this.Hide();
        }
    }
}
