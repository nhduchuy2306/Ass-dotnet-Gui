using BussinessObject.Mappings;
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
using BussinessObject.Models;

namespace SalesWinApp
{
    public partial class frmOrder : Form
    {
        private IOrderRepository repo;
        int oId = 0;
        BindingSource source = null;

        public frmOrder()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            repo = new OrderRepository();
        }
        public frmOrder(int id)
        {
            InitializeComponent();
            btnSave.Enabled = false;
            repo = new OrderRepository();
            oId = id;
        }

        private void frmOder_Load(object sender, EventArgs e)
        {
            IMemberRepository memRepo = new MemberRepository();
            List<Member> members = memRepo.GetAll();
            foreach (Member member in members)
            {
                txtMemberID.Items.Add(member.MemberId);
            }
            if(oId != 0)
            {
                OrderObject obj = AutoMapperConfiguration.ToOrderObject(repo.GetById(oId));
                txtOrderID.Text = oId.ToString();
                txtMemberID.Text = obj.MemberId.ToString();
                txtOrderDate.Text = obj.OrderDate.ToString();
                txtRequiredDate.Text = obj.RequiredDate.ToString();
                txtShippedDate.Text = obj.ShippedDate.ToString();
                txtFreight.Text = obj.Freight.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int memberId=0;
            DateTime orderDate = DateTime.Now.Date;
            DateTime? requiredDate = null;
            DateTime? shippedDate = null;
            decimal? freight = null;
            try
            {
                memberId = Convert.ToInt32(txtMemberID.Text);
                if (txtRequiredDate.Text != "")
                {
                    requiredDate = DateTime.Parse(txtRequiredDate.Text).Date;
                }
                if (txtShippedDate.Text != "")
                {
                    shippedDate = DateTime.Parse(txtShippedDate.Text).Date;
                }
                if (txtFreight.Text != "")
                {
                    freight = Convert.ToDecimal(txtFreight.Text);
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input!!!");
                MessageBox.Show("Invalid Input!!!");
            }
            OrderObject orderObject = new OrderObject(0, memberId, orderDate, requiredDate, shippedDate, freight);
            if(memberId == 0)
            {
                MessageBox.Show("Add fail!!!!");
            }
            else
            {
                repo.Add(AutoMapperConfiguration.ToOrder(orderObject));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(txtOrderID.Text);
            int memberId = 0;
            DateTime orderDate = DateTime.Parse(txtOrderDate.Text).Date;
            DateTime? requiredDate = null;
            DateTime? shippedDate = null;
            decimal? freight = null;
            try
            {
                memberId = Convert.ToInt32(txtMemberID.Text);
                if (txtRequiredDate.Text != "")
                {
                    requiredDate = DateTime.Parse(txtRequiredDate.Text).Date;
                }
                if (txtShippedDate.Text != "")
                {
                    shippedDate = DateTime.Parse(txtShippedDate.Text).Date;
                }
                if (txtFreight.Text != "")
                {
                    freight = Convert.ToDecimal(txtFreight.Text);
                }
            }
            catch
            {
                Console.WriteLine("Invalid Input!!!");
                MessageBox.Show("Invalid Input!!!");
            }
            OrderObject orderObject = new OrderObject(orderId, memberId, orderDate, requiredDate, shippedDate, freight);
            if (memberId == 0)
            {
                MessageBox.Show("Update fail!!!!");
            }
            else
            {
                repo.Update(AutoMapperConfiguration.ToOrder(orderObject));
                MessageBox.Show("Update successfully!!!");
            }
        }
    }
}
