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

        private void LoadProduct(List<Product> list)
        {
            List<ProductObject> listOb = new List<ProductObject>();
            list.ForEach(l => listOb.Add(AutoMapperConfiguration.ToProductObject(l)));

            source = new BindingSource();

            source.DataSource = listOb;

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

            List<string> typeList = new List<string>() { "Product Name", "Product Id", "Unit Price", "Unit In Stock"};
            cboSearchType.DataSource = typeList;
            cboSearchType.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int row = dgvProductList.CurrentRow.Index;

            if (productObject != null)
            {
                frmProductDetails frmProductDetails = new frmProductDetails(productObject, true);

                if (frmProductDetails.ShowDialog() == DialogResult.OK)
                {
                    List<Product> list = repo.GetAll();
                    LoadProduct(list);
                    source.Position = row;
                }
            }
            else
            {
                MessageBox.Show("You must choose 1 row");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string alert = "Do you want to delete this product?";
            string title = "Delete a product";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(alert, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
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
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails(false);
            
            if(frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                List<Product> list = repo.GetAll();
                LoadProduct(list);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string typeSearch = cboSearchType.Text;

            if (typeSearch.Equals("Product Id"))
            {
                SearchProductID(sender, e);
            }
            else if (typeSearch.Equals("Product Name"))
            {
                SearchProductName(sender, e);
            }
            else if(typeSearch.Equals("Unit Price"))
            {
                SearchUnitPrice(sender, e);
            }
            else
            {
                SearchUnitsInStock(sender, e);
            }
        }

        private void SearchProductID(object sender, EventArgs e)
        {
            string productID = txtSearch.Text;

            if (productID.Equals(""))
            {
                List<Product> list = repo.GetAll();
                LoadProduct(list);
            }
            else
            {
                Product pro = repo.GetById(Convert.ToInt32(productID));

                List<Product> list = new List<Product>();
                list.Add(pro);
                if (pro != null)
                {
                    txtSearch.Clear();
                    LoadProduct(list);
                }
                else MessageBox.Show($"Not contain {productID}");
            }
        }


        private void SearchProductName(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;

            if (txt.Equals(""))
            {
                List<Product> list = repo.GetAll();
                LoadProduct(list);
            }
            else
            {
                List<Product> pro = repo.GetByName(txt);

                if (pro != null)
                {
                    txtSearch.Clear();
                    LoadProduct(pro);
                }
                else MessageBox.Show($"Not contain {txt}");
            }
        }

        private void SearchUnitPrice(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;

            if (txt.Equals(""))
            {
                List<Product> list = repo.GetAll();
                LoadProduct(list);
            }
            else
            {
                List<Product> pro = repo.GetByUnitPrice(Convert.ToInt32(txt));

                if (pro != null)
                {
                    txtSearch.Clear();
                    LoadProduct(pro);
                }
                else MessageBox.Show($"Not contain {txt}");
            }
        }

        private void SearchUnitsInStock(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;

            if (txt.Equals(""))
            {
                List<Product> list = repo.GetAll();
                LoadProduct(list);
            }
            else
            {
                List<Product> pro = repo.GetByUnitsInStock(Convert.ToInt32(txt));

                if (pro != null)
                {
                    txtSearch.Clear();
                    LoadProduct(pro);
                }
                else MessageBox.Show($"Not contain {txt}");
            }

        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Product> listAllProduct = repo.GetAll();

            if (e.RowIndex >= 0 && e.RowIndex < listAllProduct.Count)
            {
                var row = this.dgvProductList.Rows[e.RowIndex];
                productObject = new ProductObject
                {
                    ProductId = Convert.ToInt32(row.Cells["ProductId"].Value),
                    CategoryId = Convert.ToInt32(row.Cells["CategoryId"].Value),
                    ProductName = row.Cells["ProductName"].Value.ToString(),
                    UnitPrice = Convert.ToInt32(row.Cells["UnitPrice"].Value),
                    UnitsInStock = Convert.ToInt32(row.Cells["UnitsInStock"].Value),
                    Weight = row.Cells["Weight"].Value.ToString()
                };
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
