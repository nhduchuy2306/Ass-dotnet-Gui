using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository;

public class OrderRepository : IOrderRepository
{
    SaleManagementContext _context;

    public OrderRepository()
    {
        this._context =new SaleManagementContext();
    }

    public bool Add(Order order)
    {
         _context.Orders.Add(order);
  
        return _context.SaveChanges() > 0;
    }

    public bool Delete(int id)
    {
        Order order = _context.Orders.Find(id);
        if(order != null)
        {
            _context.Orders.Remove(order);
            return _context.SaveChanges() > 0;
        }
        return false;
    }

    public List<Order> GetAll()
    {
        using var c = new SaleManagementContext();
        var o = from order in c.Orders
                select order;
        return o.ToList();
    }

    public List<Order> GetAllbyMemId(Order or)
    {
        using var c = new SaleManagementContext();
        var o = from order in c.Orders
                where order.MemberId == or.MemberId
                select new Order
                {
                    OrderId = order.OrderId,
                    OrderDate = order.OrderDate,
                    RequiredDate = order.RequiredDate,
                    ShippedDate = order.ShippedDate,
                    Freight = order.Freight,
                } ;
        return o.ToList();
    }

    public Order GetById(int id)
    {
        return _context.Orders.Find(id);
    }

    public bool Update(Order order)
    {
        using var c = new SaleManagementContext();
        c.Orders.Update(order);
        return c.SaveChanges() > 0; 
    }
}
