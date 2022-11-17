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

namespace SalesWinApp
{
    public partial class frmReport : Form
    {

        IReportRepository _repo;


        public frmReport()
        {
            InitializeComponent();
            _repo = new ReportRepository();
        }

        private void LoadData(DateTime start, DateTime end)
        {
            List<ReportObjects> list = _repo.GetAll(start,end);

            dgvReport.DataSource = null;
            dgvReport.DataSource = list;

        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            DateTime star = DateTime.Parse(dtpStart.Value.ToString());
            DateTime end = DateTime.Parse(dtpEnd.Value.ToString());
            LoadData(star, end);
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime star = DateTime.Parse(dtpStart.Value.ToString());
            DateTime end = DateTime.Parse(dtpEnd.Value.ToString());
            LoadData(star, end);
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            DateTime star = DateTime.Parse(dtpStart.Value.ToString());
            DateTime end = DateTime.Parse(dtpEnd.Value.ToString());
            LoadData(star, end);
        }
    }
}
