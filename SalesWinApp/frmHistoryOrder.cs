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
    public partial class frmHistoryOrder : Form
    {
        public Member Member;
        BindingSource _source;
        IOrderRepository _repo;
        public frmHistoryOrder()
        {
            InitializeComponent();
            _repo = new OrderRepository();
        }
        private void loadHistoryOrder(List<Order> list)
        {
            _source = new BindingSource();
            List<OrderObject> listO = new List<OrderObject>();
            list.ForEach(p => listO.Add(AutoMapperConfiguration.ToOrderObject(p)));
            _source.DataSource = listO;

            dgvHistory.DataSource = null;
            dgvHistory.DataSource = _source;
        }
        private void frmHistoryOrder_Load(object sender, EventArgs e)
        {
            var id = _repo.GetById(Member.MemberId);
            loadHistoryOrder(_repo.GetAllbyMemId(id));
            dgvHistory.RowTemplate.Height = 150;
        }
    }
}
