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

    List<Order> GetAllbyMemId(Order order);
    bool Add(Order order);

    bool Update(Order order);

    Order GetById(int id);

    List<Order> GetByMemberID(int id);

    bool Delete(int id);

}
