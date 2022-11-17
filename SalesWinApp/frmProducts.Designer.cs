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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductList.EnableHeadersVisualStyles = false;
            this.dgvProductList.Location = new System.Drawing.Point(20, 127);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductList.RowHeadersWidth = 62;
            this.dgvProductList.RowTemplate.Height = 25;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(588, 282);
            this.dgvProductList.TabIndex = 0;
            this.dgvProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellClick);
            // 
            // lbProductList
            // 
            this.lbProductList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProductList.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbProductList.Location = new System.Drawing.Point(224, 11);
            this.lbProductList.Name = "lbProductList";
            this.lbProductList.Size = new System.Drawing.Size(139, 33);
            this.lbProductList.TabIndex = 1;
            this.lbProductList.Text = "Product List";
            // 
            // lbManageProduct
            // 
            this.lbManageProduct.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbManageProduct.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbManageProduct.Location = new System.Drawing.Point(746, 11);
            this.lbManageProduct.Name = "lbManageProduct";
            this.lbManageProduct.Size = new System.Drawing.Size(203, 33);
            this.lbManageProduct.TabIndex = 2;
            this.lbManageProduct.Text = "Manage Product";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductID.Location = new System.Drawing.Point(693, 68);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(79, 20);
            this.lbProductID.TabIndex = 3;
            this.lbProductID.Text = "&Product ID";
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCategoryID.Location = new System.Drawing.Point(693, 120);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(88, 20);
            this.lbCategoryID.TabIndex = 4;
            this.lbCategoryID.Text = "&Category ID";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductName.Location = new System.Drawing.Point(693, 178);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 5;
            this.lbProductName.Text = "&Product Name";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWeight.Location = new System.Drawing.Point(693, 237);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(56, 20);
            this.lbWeight.TabIndex = 6;
            this.lbWeight.Text = "&Weight";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUnitPrice.Location = new System.Drawing.Point(693, 301);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 7;
            this.lbUnitPrice.Text = "&Unit Price";
            // 
            // lbUnitsInStock
            // 
            this.lbUnitsInStock.AutoSize = true;
            this.lbUnitsInStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUnitsInStock.Location = new System.Drawing.Point(693, 364);
            this.lbUnitsInStock.Name = "lbUnitsInStock";
            this.lbUnitsInStock.Size = new System.Drawing.Size(98, 20);
            this.lbUnitsInStock.TabIndex = 8;
            this.lbUnitsInStock.Text = "&Units In Stock";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(827, 69);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(172, 23);
            this.txtProductID.TabIndex = 9;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(827, 117);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(172, 23);
            this.txtCategoryID.TabIndex = 10;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(827, 175);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(172, 23);
            this.txtProductName.TabIndex = 11;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(827, 234);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(172, 23);
            this.txtWeight.TabIndex = 12;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(827, 298);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(172, 23);
            this.txtUnitPrice.TabIndex = 13;
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(827, 361);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.ReadOnly = true;
            this.txtUnitsInStock.Size = new System.Drawing.Size(172, 23);
            this.txtUnitsInStock.TabIndex = 14;
            // 
            // txtSearchProductID
            // 
            this.txtSearchProductID.Location = new System.Drawing.Point(30, 46);
            this.txtSearchProductID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchProductID.Name = "txtSearchProductID";
            this.txtSearchProductID.PlaceholderText = "Search by product ID";
            this.txtSearchProductID.Size = new System.Drawing.Size(162, 23);
            this.txtSearchProductID.TabIndex = 15;
            // 
            // btnSearchProductID
            // 
            this.btnSearchProductID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchProductID.FlatAppearance.BorderSize = 0;
            this.btnSearchProductID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchProductID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchProductID.Location = new System.Drawing.Point(210, 47);
            this.btnSearchProductID.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchProductID.Name = "btnSearchProductID";
            this.btnSearchProductID.Size = new System.Drawing.Size(70, 27);
            this.btnSearchProductID.TabIndex = 16;
            this.btnSearchProductID.Text = "Search";
            this.btnSearchProductID.UseVisualStyleBackColor = false;
            this.btnSearchProductID.MouseLeave += new System.EventHandler(this.btnSearchProduct_MouseLeave);
            this.btnSearchProductID.MouseHover += new System.EventHandler(this.btnSearchProduct_MouseHover);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(224, 424);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(152, 30);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "New Product";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.MouseLeave += new System.EventHandler(this.btnNew_MouseLeave);
            this.btnNew.MouseHover += new System.EventHandler(this.btnNew_MouseHover);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(702, 424);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 30);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update Product";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(871, 424);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 30);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1070, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // txtSearchProductName
            // 
            this.txtSearchProductName.Location = new System.Drawing.Point(30, 88);
            this.txtSearchProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchProductName.Name = "txtSearchProductName";
            this.txtSearchProductName.PlaceholderText = "Search by product name";
            this.txtSearchProductName.Size = new System.Drawing.Size(162, 23);
            this.txtSearchProductName.TabIndex = 22;
            // 
            // txtSearchUnitPrice
            // 
            this.txtSearchUnitPrice.Location = new System.Drawing.Point(301, 47);
            this.txtSearchUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchUnitPrice.Name = "txtSearchUnitPrice";
            this.txtSearchUnitPrice.PlaceholderText = "Search by unit price";
            this.txtSearchUnitPrice.Size = new System.Drawing.Size(182, 23);
            this.txtSearchUnitPrice.TabIndex = 23;
            // 
            // txtSearchUnitsInStock
            // 
            this.txtSearchUnitsInStock.Location = new System.Drawing.Point(301, 88);
            this.txtSearchUnitsInStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchUnitsInStock.Name = "txtSearchUnitsInStock";
            this.txtSearchUnitsInStock.PlaceholderText = "Search by units in stock";
            this.txtSearchUnitsInStock.Size = new System.Drawing.Size(182, 23);
            this.txtSearchUnitsInStock.TabIndex = 24;
            // 
            // btnSearchProductName
            // 
            this.btnSearchProductName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchProductName.FlatAppearance.BorderSize = 0;
            this.btnSearchProductName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchProductName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchProductName.Location = new System.Drawing.Point(210, 83);
            this.btnSearchProductName.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchProductName.Name = "btnSearchProductName";
            this.btnSearchProductName.Size = new System.Drawing.Size(70, 27);
            this.btnSearchProductName.TabIndex = 25;
            this.btnSearchProductName.Text = "Search";
            this.btnSearchProductName.UseVisualStyleBackColor = false;
            // 
            // btnSearchUnitPrice
            // 
            this.btnSearchUnitPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchUnitPrice.FlatAppearance.BorderSize = 0;
            this.btnSearchUnitPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchUnitPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchUnitPrice.Location = new System.Drawing.Point(501, 47);
            this.btnSearchUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchUnitPrice.Name = "btnSearchUnitPrice";
            this.btnSearchUnitPrice.Size = new System.Drawing.Size(70, 27);
            this.btnSearchUnitPrice.TabIndex = 26;
            this.btnSearchUnitPrice.Text = "Search";
            this.btnSearchUnitPrice.UseVisualStyleBackColor = false;
            // 
            // btnSearchUnitsInStock
            // 
            this.btnSearchUnitsInStock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchUnitsInStock.FlatAppearance.BorderSize = 0;
            this.btnSearchUnitsInStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchUnitsInStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchUnitsInStock.Location = new System.Drawing.Point(501, 83);
            this.btnSearchUnitsInStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchUnitsInStock.Name = "btnSearchUnitsInStock";
            this.btnSearchUnitsInStock.Size = new System.Drawing.Size(70, 27);
            this.btnSearchUnitsInStock.TabIndex = 27;
            this.btnSearchUnitsInStock.Text = "Search";
            this.btnSearchUnitsInStock.UseVisualStyleBackColor = false;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 496);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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