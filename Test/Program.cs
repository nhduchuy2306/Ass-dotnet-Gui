
using BussinessObject;
using BussinessObject.Mappings;
using BussinessObject.Models;
using DataAccess.Repository;

namespace Test;
public static class Program
{
    static void Main()
    {
        IOrderRepository i = new OrderRepository();
        List<Order> list = i.GetAll();
        List<OrderObject> listO = new List<OrderObject>();
        list.ForEach(p => listO.Add(AutoMapperConfiguration.ToOrderObject(p)));

        foreach (var item in listO) { Console.WriteLine(item.MemberId); }
    }
}