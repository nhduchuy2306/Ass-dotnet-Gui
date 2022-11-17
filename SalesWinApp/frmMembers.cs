﻿using BussinessObject;
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

        MemberObject member = null;
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
            List<MemberObject> listOb = new List<MemberObject>();
            list.ForEach(l => listOb.Add(AutoMapperConfiguration.ToMemberObject(l)));

            src = new BindingSource();
            src.DataSource = listOb;

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
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int row = dgvMember.CurrentRow.Index;

            string memId = txtMemID.Text;
            string email = txtEmail.Text;
            string company = txtCompany.Text;
            string country = txtCountry.Text;
            string city = txtCity.Text;
            //string pwd = txtPwd.Text;

            MemberObject memberObject = new MemberObject
            {
                MemberId = Convert.ToInt32(memId),
                Email = email,
                CompanyName = company,
                Country = country,
                City = city,
                //Password = pwd;
            };

            Member mem = AutoMapperConfiguration.ToMember(memberObject);

            bool completed = repo.Update(mem);

            if (completed)
            {
                List<Member> list = repo.GetAll();
                LoadMemberList(list);
                src.Position = row;
                btnUpdate.Enabled = false;
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
                src.Position = src.Count - 1;
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
                    try
                    {
                        int id = 0;
                        id = Convert.ToInt32(search);
                        Member m = repo.GetById(id);
                        mem = new List<Member>();
                        mem.Add(m);
                        LoadMemberList(mem);
                    }
                    catch (Exception)
                    {
                        mem = new List<Member>();
                        LoadMemberList(mem);
                    }
                }
            }
        }

        // return frmMain
        private void btnBack_Click(object sender, EventArgs e)
        {
            int row = 0;
            if (dgvMember.SelectedCells.Count > 0)
            {
                row = dgvMember.CurrentCell.RowIndex;
            }
            LoadMemberList(repo.GetAll());


        //status Strip
        private void btnNew_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to create new member";
        }
        private void btnNew_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to update member";
        }
        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to delete member";
        }
        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

            src.Position = row;

            btnUpdate.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (dgvMember.SelectedCells.Count > 0)
            {
                string email = dgvMember.SelectedRows[0].Cells[1].Value.ToString();
                if (!txtEmail.Text.Equals(email))
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {
            if (dgvMember.SelectedCells.Count > 0)
            {
                string company = dgvMember.SelectedRows[0].Cells[2].Value.ToString();
                if (!txtCompany.Text.Equals(company))
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            if (dgvMember.SelectedCells.Count > 0)
            {
                string country = dgvMember.SelectedRows[0].Cells[4].Value.ToString();
                if (!txtCountry.Text.Equals(country))
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if (dgvMember.SelectedCells.Count > 0)
            {
                string city = dgvMember.SelectedRows[0].Cells[3].Value.ToString();
                if (!txtCity.Text.Equals(city))
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e) => btnBack_Click(sender, e);
    }
}
