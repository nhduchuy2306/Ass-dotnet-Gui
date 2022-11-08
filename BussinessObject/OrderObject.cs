using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject;

public class OrderObject
{

    public int OrderId { get; set; }
    public int? MemberId { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime? RequiredDate { get; set; }
    public DateTime? ShippedDate { get; set; }
    public decimal? Freight { get; set; }

    public OrderObject()
    {
    }

 

    public OrderObject(int orderId, int? memberId, DateTime orderDate, 
        DateTime? requiredDate, DateTime? shippedDate, decimal? freight)
    {
        OrderId = orderId;
        MemberId = memberId;
        OrderDate = orderDate;
        RequiredDate = requiredDate;
        ShippedDate = shippedDate;
        Freight = freight;
    }
}
