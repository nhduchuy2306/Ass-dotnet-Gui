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
        private IMemberRepository repo = null;
        BindingSource source = null;
        public frmProfile()
        {
            InitializeComponent();
            repo = new MemberRepository();
        }
        private void LoadProduct(List<Member> list)
        {
            source = new BindingSource();
            source.DataSource = list;

            txtMemberID.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCompanyName.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtPassword.DataBindings.Clear();

            txtMemberID.DataBindings.Add("Text", source, "MemberID");
            txtEmail.DataBindings.Add("Text", source, "Email");
            txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
            txtCity.DataBindings.Add("Text", source, "City");
            txtCountry.DataBindings.Add("Text", source, "Country");
            txtPassword.DataBindings.Add("Text", source, "Password");

        }
        private void frmProfile_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();

        }
    }
}
