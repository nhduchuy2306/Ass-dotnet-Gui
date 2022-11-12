namespace SalesWinApp
{
    partial class frmOrderDetails
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
            this.lbProductID = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtQuantity = new System.Windows.Forms.MaskedTextBox();
            this.txtDiscount = new System.Windows.Forms.MaskedTextBox();
            this.txtProductId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductID.Location = new System.Drawing.Point(80, 97);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(101, 25);
            this.lbProductID.TabIndex = 10;
            this.lbProductID.Text = "&Product ID";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUnitPrice.Location = new System.Drawing.Point(80, 151);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(94, 25);
            this.lbUnitPrice.TabIndex = 11;
            this.lbUnitPrice.Text = "&Unit Price";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuantity.Location = new System.Drawing.Point(80, 211);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(84, 25);
            this.lbQuantity.TabIndex = 12;
            this.lbQuantity.Text = "&Quantity";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDiscount.Location = new System.Drawing.Point(80, 268);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(86, 25);
            this.lbDiscount.TabIndex = 13;
            this.lbDiscount.Text = "&Discount";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(104, 332);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 44);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(256, 332);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 44);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOrderID.Location = new System.Drawing.Point(80, 44);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(84, 25);
            this.lbOrderID.TabIndex = 23;
            this.lbOrderID.Text = "&Order ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(223, 45);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(170, 27);
            this.txtOrderID.TabIndex = 24;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(223, 152);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(170, 27);
            this.txtUnitPrice.TabIndex = 25;
            this.txtUnitPrice.Text = "0";
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(223, 212);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(170, 27);
            this.txtQuantity.TabIndex = 26;
            this.txtQuantity.Text = "0";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(223, 269);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ResetOnSpace = false;
            this.txtDiscount.Size = new System.Drawing.Size(170, 27);
            this.txtDiscount.TabIndex = 27;
            this.txtDiscount.Text = "0";
            // 
            // txtProductId
            // 
            this.txtProductId.FormattingEnabled = true;
            this.txtProductId.Location = new System.Drawing.Point(223, 97);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(59, 28);
            this.txtProductId.TabIndex = 28;
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 416);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbProductID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Details";
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbProductID;
        private Label lbUnitPrice;
        private Label lbQuantity;
        private Label lbDiscount;
        private Button btnSave;
        private Button btnCancel;
        private Label lbOrderID;
        private TextBox txtOrderID;
        private MaskedTextBox txtUnitPrice;
        private MaskedTextBox txtQuantity;
        private MaskedTextBox txtDiscount;
        private ComboBox txtProductId;
    }
}
