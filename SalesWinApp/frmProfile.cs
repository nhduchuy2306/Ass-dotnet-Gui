using BussinessObject.Mappings;
using BussinessObject;
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
    public partial class frmProfile : Form
    {
        public Member Member;
        private IMemberRepository _repo;
        public frmProfile()
        {
            InitializeComponent();
            _repo = new MemberRepository();
        }
        private void LoadProduct()
        {
            txtMemberID.Text = Member.MemberId.ToString();
            txtEmail.Text = Member.Email.ToString();
            txtCompanyName.Text = Member.CompanyName.ToString();
            txtCountry.Text = Member.Country.ToString();
            txtCity.Text = Member.City.ToString();
            txtPassword.Text = Member.Password.ToString();

        }
        private void frmProfile_Load(object sender, EventArgs e)
        {
            LoadProduct();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string memId = Member.MemberId.ToString();
            string email = txtEmail.Text;
            string company = txtCompanyName.Text;
            string country = txtCountry.Text;
            string city = txtCity.Text;
            string pwd = txtPassword.Text;

            MemberObject memberObject = new MemberObject
            {
                MemberId = Convert.ToInt32(memId),
                Email = email,
                CompanyName = company,
                Country = country,
                City = city,
                Password = pwd
            };

            Member = AutoMapperConfiguration.ToMember(memberObject);
            frmLogin.Member = Member;

            bool completed = _repo.UpdateProfile(Member);

            if (completed)
            {
                LoadProduct();
                //src.Position = src.Count - 1;
                MessageBox.Show("Update member info completed");
            }
        }
    }
}
