using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository;

public interface IOrderRepository
{
    List<Order> GetAll();

    bool Add(Order order);

    bool Update(Order order);

    bool Delete(int id);

}
