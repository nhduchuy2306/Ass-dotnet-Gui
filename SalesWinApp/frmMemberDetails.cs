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
using System.Runtime.InteropServices;

namespace SalesWinApp
{
    public partial class frmMemberDetails : Form
    {

        bool flag1 = false, flag2 = false, flag3 = false, flag4 = false, flag5 = false;

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

        }


        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                flag1 = false;
                btnSave.Enabled = false;
            }
            else
            {
                flag1 = true;
                if (flag1 && flag2 && flag3 && flag4 && flag5)
                {
                    btnSave.Enabled = true;
                }
                else { btnSave.Enabled = false; }
            }

        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompany.Text))
            {
                flag2 = false;
                btnSave.Enabled = false;
            }
            else
            {
                flag2 = true;
                if (flag1 && flag2 && flag3 && flag4 && flag5)
                {
                    btnSave.Enabled = true;
                }
                else { btnSave.Enabled = false; }
            }
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCountry.Text))
            {
                flag3 = false;
                btnSave.Enabled = false;
            }
            else
            {
                flag3 = true;
                if (flag1 && flag2 && flag3 && flag4 && flag5)
                {
                    btnSave.Enabled = true;
                }
                else { btnSave.Enabled = false; }
            }
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                flag4 = false;
                btnSave.Enabled = false;
            }
            else
            {
                flag4 = true;
                if (flag1 && flag2 && flag3 && flag4 && flag5)
                {
                    btnSave.Enabled = true;
                }
                else { btnSave.Enabled = false; }
            }
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                flag5 = false;
                btnSave.Enabled = false;
            }
            else
            {
                flag5 = true;
                if (flag1 && flag2 && flag3 && flag4 && flag5)
                {
                    btnSave.Enabled = true;
                }
                else { btnSave.Enabled = false; }
            }
        }
    }
}
