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
    public partial class frmMembers : Form
    {
        private IMemberRepository repo = null;
        BindingSource src = null;
        public frmMembers()
        {
            InitializeComponent();
            this.repo = new MemberRepository();
        }

        // Clear txt
        private void Clear()
        {
            txtMemID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCompany.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPwd.Text = string.Empty;
        }

        // Load members 
        private void LoadMemberList(List<Member> list)
        {
            src = new BindingSource();
            src.DataSource = list;

            txtMemID.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCompany.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtPwd.DataBindings.Clear();

            txtMemID.DataBindings.Add("Text", src, "MemberId");
            txtEmail.DataBindings.Add("Text", src, "Email");
            txtCompany.DataBindings.Add("Text", src, "CompanyName");
            txtCountry.DataBindings.Add("Text", src, "Country");
            txtCity.DataBindings.Add("Text", src, "City");
            txtPwd.DataBindings.Add("Text", src, "Password");

            dgvMember.DataSource = src;
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            List<Member> list = repo.GetAll();
            LoadMemberList(list);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string memId = txtMemID.Text;
            string email = txtEmail.Text;
            string company = txtCompany.Text;
            string country = txtCountry.Text;
            string city = txtCity.Text;
            string pwd = txtPwd.Text;

            MemberObject memberObject = new MemberObject
            {
                MemberId = Convert.ToInt32(memId),
                Email = email,
                CompanyName = company,
                Country = country,
                City = city,
                Password = pwd
            };

            Member mem = AutoMapperConfiguration.ToMember(memberObject);

            bool completed = repo.Update(mem);

            if (completed)
            {
                List<Member> list = repo.GetAll();
                LoadMemberList(list);
                MessageBox.Show("Update member info completed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // show alert messageBox
            string alert = "Do you want to delete this member?";
            string title = "Delete a member";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(alert, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                string memId = txtMemID.Text;
                bool completed = repo.Delete(Convert.ToInt32(memId));

                if (completed)
                {
                    List<Member> list = repo.GetAll();
                    LoadMemberList(list);
                    MessageBox.Show($"Delete member id [ {memId} ] completed");
                }
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetails form = new frmMemberDetails();

            if (form.ShowDialog() == DialogResult.OK)
            {
                List<Member> list = repo.GetAll();
                LoadMemberList(list);
                MessageBox.Show("Create new member completed");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            List<Member> list = repo.GetAll();

            if (search.Equals(""))
            {
                LoadMemberList(list);
            }
            else
            {
                List<Member> mem = repo.GetByEmail(search);
                if (mem.Count > 0)
                {
                    LoadMemberList(mem);
                }
                else
                {
                    int id = 0;
                    if (Convert.ToInt32(search) != null)
                    {
                        id = Convert.ToInt32(search);
                        Member m = repo.GetById(id);
                        mem = new List<Member>();
                        mem.Add(m);
                        LoadMemberList(mem);
                    }
                }
            }
        }

        // return frmMain
        private void btnBack_Click(object sender, EventArgs e) => Close();
    }
}
