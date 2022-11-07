namespace SalesWinApp
{
    partial class frmMembers
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
            this.lbMemberList = new System.Windows.Forms.Label();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.lbManageMember = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMemberList
            // 
            this.lbMemberList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMemberList.Location = new System.Drawing.Point(224, 19);
            this.lbMemberList.Name = "lbMemberList";
            this.lbMemberList.Size = new System.Drawing.Size(139, 33);
            this.lbMemberList.TabIndex = 2;
            this.lbMemberList.Text = "Member List";
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(36, 69);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowTemplate.Height = 25;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(560, 328);
            this.dgvMemberList.TabIndex = 3;
            // 
            // lbManageMember
            // 
            this.lbManageMember.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbManageMember.Location = new System.Drawing.Point(746, 19);
            this.lbManageMember.Name = "lbManageMember";
            this.lbManageMember.Size = new System.Drawing.Size(181, 33);
            this.lbManageMember.TabIndex = 4;
            this.lbManageMember.Text = "Manage Member";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMemberID.Location = new System.Drawing.Point(693, 68);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(84, 20);
            this.lbMemberID.TabIndex = 22;
            this.lbMemberID.Text = "&Member ID";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(693, 120);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 23;
            this.lbEmail.Text = "&Email";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCompanyName.Location = new System.Drawing.Point(693, 178);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(116, 20);
            this.lbCompanyName.TabIndex = 22;
            this.lbCompanyName.Text = "&Company Name";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCity.Location = new System.Drawing.Point(693, 237);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 24;
            this.lbCity.Text = "&City";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCountry.Location = new System.Drawing.Point(693, 301);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 25;
            this.lbCountry.Text = "&Country";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(693, 364);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 26;
            this.lbPassword.Text = "&Password";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(827, 69);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(172, 23);
            this.txtMemberID.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(827, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(172, 23);
            this.txtEmail.TabIndex = 22;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(827, 179);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(172, 23);
            this.txtCompanyName.TabIndex = 22;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(827, 238);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(172, 23);
            this.txtCity.TabIndex = 22;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(827, 302);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(172, 23);
            this.txtCountry.TabIndex = 28;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(827, 365);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 23);
            this.txtPassword.TabIndex = 29;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(702, 412);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 33);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update Member";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(859, 412);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 33);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete Member";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNew.Location = new System.Drawing.Point(224, 412);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(152, 33);
            this.btnNew.TabIndex = 32;
            this.btnNew.Text = "New Member";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.MouseLeave += new System.EventHandler(this.btnNew_MouseLeave);
            this.btnNew.MouseHover += new System.EventHandler(this.btnNew_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1054, 22);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 484);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.lbManageMember);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.lbMemberList);
            this.Name = "frmMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbMemberList;
        private DataGridView dgvMemberList;
        private Label lbManageMember;
        private Label lbMemberID;
        private Label lbEmail;
        private Label lbCompanyName;
        private Label lbCity;
        private Label lbCountry;
        private Label lbPassword;
        private TextBox txtMemberID;
        private TextBox txtEmail;
        private TextBox txtCompanyName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPassword;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnNew;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}