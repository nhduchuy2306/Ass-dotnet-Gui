
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
        i.Delete(7);

        var list = i.GetAll();
        foreach (var item in list) { Console.WriteLine(item.MemberId); }
    }
}