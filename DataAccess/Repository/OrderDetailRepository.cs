using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository;

public class OrderDetailRepository : IOrderDetailRepository
{
    SaleManagementContext _context;

    public OrderDetailRepository()
    {
        _context = new SaleManagementContext();
    }

    public bool Add(OrderDetail o)
    {
        var c = (from order in _context.Orders
                where order.OrderId == o.OrderId
                select order).FirstOrDefault();
        var a = c.OrderDetails.Where(p => p.ProductId == o.ProductId).FirstOrDefault();
        if(a == null)
        {
            _context.OrderDetails.Add(o);
            return _context.SaveChanges() > 0;
        }
        return false;
    }
}
