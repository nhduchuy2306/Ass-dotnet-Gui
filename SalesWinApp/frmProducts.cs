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

        ProductObject productObject = null;

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

        private void LoadProduct(List<ProductObject> list)
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
            List<ProductObject> listP = new List<ProductObject>();
            List<Product> list = repo.GetAll();
            list.ForEach(p => listP.Add(AutoMapperConfiguration.ToProductObject(p)));
            LoadProduct(listP);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (productObject != null)
            {
                frmProductDetails frmProductDetails = new frmProductDetails(productObject, true);

                if (frmProductDetails.ShowDialog() == DialogResult.OK)
                {
                    List<ProductObject> listP = new List<ProductObject>();
                    List<Product> list = repo.GetAll();
                    list.ForEach(p => listP.Add(AutoMapperConfiguration.ToProductObject(p)));
                    LoadProduct(listP);
                }
            }
            else
            {
                MessageBox.Show("You must choose 1 row");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string productId = txtProductID.Text;
            bool check = repo.Delete(Convert.ToInt32(productId));
            if (check)
            {
                List<ProductObject> listP = new List<ProductObject>();
                List<Product> list = repo.GetAll();
                list.ForEach(p => listP.Add(AutoMapperConfiguration.ToProductObject(p)));
                LoadProduct(listP);
                MessageBox.Show("Delete product successfully");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails(false);
            
            if(frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                List<ProductObject> listP = new List<ProductObject>();
                List<Product> list = repo.GetAll();
                list.ForEach(p => listP.Add(AutoMapperConfiguration.ToProductObject(p)));
                LoadProduct(listP);
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string productName = txtSearchProductID.Text;

            if (productName.Equals(""))
            {
                List<ProductObject> listP = new List<ProductObject>();
                List<Product> list = repo.GetAll();
                list.ForEach(p => listP.Add(AutoMapperConfiguration.ToProductObject(p)));
                LoadProduct(listP);
            }
            else
            {
                List<Product> pro = repo.GetByName(productName);
                List<ProductObject> listP = new List<ProductObject>();
                pro.ForEach(p => listP.Add(AutoMapperConfiguration.ToProductObject(p)));
                
                if (pro != null)
                {
                    LoadProduct(listP);
                }
                else MessageBox.Show($"Not cantain {productName}");
            }
        }

        private void dgvProductList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Product> listAllProduct = repo.GetAll();

            if (e.RowIndex >= 0 && e.ColumnIndex < listAllProduct.Count)
            {
                string id = dgvProductList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                Product product = repo.GetById(Convert.ToInt32(id));
                productObject = AutoMapperConfiguration.ToProductObject(product);
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
