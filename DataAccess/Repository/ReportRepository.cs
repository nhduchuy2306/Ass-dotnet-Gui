using BussinessObject;
using BussinessObject.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository;

public class ReportRepository : IReportRepository
{
    SaleManagementContext _context;

    public ReportRepository()
    {
        _context = new SaleManagementContext();
    }

    public List<ReportObjects> GetAll(DateTime start, DateTime end)
    {
        List<ReportObjects> reports = new List<ReportObjects>();
        var listOrder = (from order in _context.Orders
                        where order.OrderDate >= start && order.OrderDate <= end
                        select order).ToList();

        foreach (var order in listOrder)
        {
            int numOfProduct = 0;
            decimal totalPrice = 0;
            List<OrderDetail> orderDetail = (from detail in _context.OrderDetails
                                            where order.OrderId == detail.OrderId
                                            select detail).ToList();
            totalPrice = orderDetail.Sum(p => p.UnitPrice);
            numOfProduct = orderDetail.Count;
            ReportObjects report = new ReportObjects(order.OrderDate, 1, numOfProduct, totalPrice);
            reports.Add(report);
        }
        var list = from report in reports
                          group report by report.Date into r
                          select new
                          {
                              r.Key,
                              to = r.Sum(p => p.TotalOrder),
                              tpro = r.Sum(p => p.TotalProduct),
                              tprice = r.Sum(p => p.TotalPrice)
                          };
        var listReports = list.Select(p => new ReportObjects
        {
            Date = p.Key,
            TotalOrder = p.to,
            TotalProduct = p.tpro,
            TotalPrice = p.tprice
        }).ToList();
        return listReports;
    }


}
