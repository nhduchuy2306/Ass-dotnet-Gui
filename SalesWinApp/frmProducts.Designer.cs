namespace SalesWinApp
{
    partial class frmProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.lbProductList = new System.Windows.Forms.Label();
            this.lbManageProduct = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbUnitsInStock = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtSearchProductID = new System.Windows.Forms.TextBox();
            this.btnSearchProductID = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtSearchProductName = new System.Windows.Forms.TextBox();
            this.txtSearchUnitPrice = new System.Windows.Forms.TextBox();
            this.txtSearchUnitsInStock = new System.Windows.Forms.TextBox();
            this.btnSearchProductName = new System.Windows.Forms.Button();
            this.btnSearchUnitPrice = new System.Windows.Forms.Button();
            this.btnSearchUnitsInStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(18, 156);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersWidth = 62;
            this.dgvProductList.RowTemplate.Height = 25;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(639, 372);
            this.dgvProductList.TabIndex = 0;
            this.dgvProductList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductList_CellMouseClick);
            // 
            // lbProductList
            // 
            this.lbProductList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProductList.Location = new System.Drawing.Point(256, 15);
            this.lbProductList.Name = "lbProductList";
            this.lbProductList.Size = new System.Drawing.Size(159, 44);
            this.lbProductList.TabIndex = 1;
            this.lbProductList.Text = "Product List";
            // 
            // lbManageProduct
            // 
            this.lbManageProduct.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbManageProduct.Location = new System.Drawing.Point(852, 15);
            this.lbManageProduct.Name = "lbManageProduct";
            this.lbManageProduct.Size = new System.Drawing.Size(232, 44);
            this.lbManageProduct.TabIndex = 2;
            this.lbManageProduct.Text = "Manage Product";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductID.Location = new System.Drawing.Point(792, 91);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(101, 25);
            this.lbProductID.TabIndex = 3;
            this.lbProductID.Text = "&Product ID";
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCategoryID.Location = new System.Drawing.Point(792, 160);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(111, 25);
            this.lbCategoryID.TabIndex = 4;
            this.lbCategoryID.Text = "&Category ID";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductName.Location = new System.Drawing.Point(792, 237);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(133, 25);
            this.lbProductName.TabIndex = 5;
            this.lbProductName.Text = "&Product Name";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWeight.Location = new System.Drawing.Point(792, 316);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(72, 25);
            this.lbWeight.TabIndex = 6;
            this.lbWeight.Text = "&Weight";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUnitPrice.Location = new System.Drawing.Point(792, 401);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(94, 25);
            this.lbUnitPrice.TabIndex = 7;
            this.lbUnitPrice.Text = "&Unit Price";
            // 
            // lbUnitsInStock
            // 
            this.lbUnitsInStock.AutoSize = true;
            this.lbUnitsInStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUnitsInStock.Location = new System.Drawing.Point(792, 485);
            this.lbUnitsInStock.Name = "lbUnitsInStock";
            this.lbUnitsInStock.Size = new System.Drawing.Size(125, 25);
            this.lbUnitsInStock.TabIndex = 8;
            this.lbUnitsInStock.Text = "&Units In Stock";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(945, 92);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(196, 27);
            this.txtProductID.TabIndex = 9;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(945, 156);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(196, 27);
            this.txtCategoryID.TabIndex = 10;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(945, 233);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(196, 27);
            this.txtProductName.TabIndex = 11;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(945, 312);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(196, 27);
            this.txtWeight.TabIndex = 12;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(945, 397);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(196, 27);
            this.txtUnitPrice.TabIndex = 13;
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(945, 481);
            this.txtUnitsInStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(196, 27);
            this.txtUnitsInStock.TabIndex = 14;
            // 
            // txtSearchProductID
            // 
            this.txtSearchProductID.Location = new System.Drawing.Point(34, 62);
            this.txtSearchProductID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearchProductID.Name = "txtSearchProductID";
            this.txtSearchProductID.PlaceholderText = "Search by product ID";
            this.txtSearchProductID.Size = new System.Drawing.Size(184, 27);
            this.txtSearchProductID.TabIndex = 15;
            // 
            // btnSearchProductID
            // 
            this.btnSearchProductID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchProductID.Location = new System.Drawing.Point(247, 55);
            this.btnSearchProductID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchProductID.Name = "btnSearchProductID";
            this.btnSearchProductID.Size = new System.Drawing.Size(80, 36);
            this.btnSearchProductID.TabIndex = 16;
            this.btnSearchProductID.Text = "Search";
            this.btnSearchProductID.UseVisualStyleBackColor = true;
            this.btnSearchProductID.Click += new System.EventHandler(this.btnSearchProduct_Click);
            this.btnSearchProductID.MouseLeave += new System.EventHandler(this.btnSearchProduct_MouseLeave);
            this.btnSearchProductID.MouseHover += new System.EventHandler(this.btnSearchProduct_MouseHover);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(220, 541);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(174, 44);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "New Product";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.MouseLeave += new System.EventHandler(this.btnNew_MouseLeave);
            this.btnNew.MouseHover += new System.EventHandler(this.btnNew_MouseHover);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(811, 525);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 44);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update Product";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(995, 525);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 44);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1232, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // txtSearchProductName
            // 
            this.txtSearchProductName.Location = new System.Drawing.Point(34, 119);
            this.txtSearchProductName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearchProductName.Name = "txtSearchProductName";
            this.txtSearchProductName.PlaceholderText = "Search by product name";
            this.txtSearchProductName.Size = new System.Drawing.Size(184, 27);
            this.txtSearchProductName.TabIndex = 22;
            // 
            // txtSearchUnitPrice
            // 
            this.txtSearchUnitPrice.Location = new System.Drawing.Point(360, 62);
            this.txtSearchUnitPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearchUnitPrice.Name = "txtSearchUnitPrice";
            this.txtSearchUnitPrice.PlaceholderText = "Search by unit price";
            this.txtSearchUnitPrice.Size = new System.Drawing.Size(186, 27);
            this.txtSearchUnitPrice.TabIndex = 23;
            // 
            // txtSearchUnitsInStock
            // 
            this.txtSearchUnitsInStock.Location = new System.Drawing.Point(360, 119);
            this.txtSearchUnitsInStock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearchUnitsInStock.Name = "txtSearchUnitsInStock";
            this.txtSearchUnitsInStock.PlaceholderText = "Search by units in stock";
            this.txtSearchUnitsInStock.Size = new System.Drawing.Size(186, 27);
            this.txtSearchUnitsInStock.TabIndex = 24;
            // 
            // btnSearchProductName
            // 
            this.btnSearchProductName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchProductName.Location = new System.Drawing.Point(247, 110);
            this.btnSearchProductName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchProductName.Name = "btnSearchProductName";
            this.btnSearchProductName.Size = new System.Drawing.Size(80, 36);
            this.btnSearchProductName.TabIndex = 25;
            this.btnSearchProductName.Text = "Search";
            this.btnSearchProductName.UseVisualStyleBackColor = true;
            // 
            // btnSearchUnitPrice
            // 
            this.btnSearchUnitPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchUnitPrice.Location = new System.Drawing.Point(566, 55);
            this.btnSearchUnitPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchUnitPrice.Name = "btnSearchUnitPrice";
            this.btnSearchUnitPrice.Size = new System.Drawing.Size(80, 36);
            this.btnSearchUnitPrice.TabIndex = 26;
            this.btnSearchUnitPrice.Text = "Search";
            this.btnSearchUnitPrice.UseVisualStyleBackColor = true;
            // 
            // btnSearchUnitsInStock
            // 
            this.btnSearchUnitsInStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchUnitsInStock.Location = new System.Drawing.Point(566, 112);
            this.btnSearchUnitsInStock.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchUnitsInStock.Name = "btnSearchUnitsInStock";
            this.btnSearchUnitsInStock.Size = new System.Drawing.Size(80, 36);
            this.btnSearchUnitsInStock.TabIndex = 27;
            this.btnSearchUnitsInStock.Text = "Search";
            this.btnSearchUnitsInStock.UseVisualStyleBackColor = true;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 681);
            this.Controls.Add(this.btnSearchUnitsInStock);
            this.Controls.Add(this.btnSearchUnitPrice);
            this.Controls.Add(this.btnSearchProductName);
            this.Controls.Add(this.txtSearchUnitsInStock);
            this.Controls.Add(this.txtSearchUnitPrice);
            this.Controls.Add(this.txtSearchProductName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSearchProductID);
            this.Controls.Add(this.txtSearchProductID);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lbUnitsInStock);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbCategoryID);
            this.Controls.Add(this.lbProductID);
            this.Controls.Add(this.lbManageProduct);
            this.Controls.Add(this.lbProductList);
            this.Controls.Add(this.dgvProductList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProductList;
        private Label lbProductList;
        private Label lbManageProduct;
        private Label lbProductID;
        private Label lbCategoryID;
        private Label lbProductName;
        private Label lbWeight;
        private Label lbUnitPrice;
        private Label lbUnitsInStock;
        private TextBox txtProductID;
        private TextBox txtCategoryID;
        private TextBox txtProductName;
        private TextBox txtWeight;
        private TextBox txtUnitPrice;
        private TextBox txtUnitsInStock;
        private TextBox txtSearchProductID;
        private Button btnSearchProductID;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox txtSearchProductName;
        private TextBox txtSearchUnitPrice;
        private TextBox txtSearchUnitsInStock;
        private Button btnSearchProductName;
        private Button btnSearchUnitPrice;
        private Button btnSearchUnitsInStock;
    }
}