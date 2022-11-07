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
    public partial class frmMemberDetails : Form
    {
        private IMemberRepository repo = null;
        public frmMemberDetails()
        {
            InitializeComponent();
            this.repo = new MemberRepository();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string company = txtCompany.Text;
            string country = txtCountry.Text;
            string city = txtCity.Text;
            string pwd = txtPwd.Text;

            MemberObject memberObject = new MemberObject
            {
                Email = email,
                CompanyName = company,
                Country = country,
                City = city,
                Password = pwd
            };

            Member mem = AutoMapperConfiguration.ToMember(memberObject);

            bool completed = repo.Add(mem);

            if (completed)
            {
                MessageBox.Show("Update member info completed");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
