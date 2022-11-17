using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject;

public class ReportObjects
{
    public DateTime Date { get; set; }
    public int TotalOrder { get; set; }
    public int TotalProduct { get; set; }
    public decimal TotalPrice { get; set; }

    public ReportObjects()
    {
    }

    public ReportObjects(DateTime date, int totalOrder, int totalProduct, decimal totalPrice)
    {
        Date = date;
        TotalOrder = totalOrder;
        TotalProduct = totalProduct;
        TotalPrice = totalPrice;
    }
}
