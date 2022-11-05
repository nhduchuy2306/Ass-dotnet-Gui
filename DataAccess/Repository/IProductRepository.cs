using BussinessObject.Models;

namespace DataAccess.Repository;

public interface IProductRepository
{
    List<Product> GetAll();
    Product GetById(int id);
    Product GetByName(string name);
    bool Update(Product product);
    bool Delete(int id);
    bool Add(Product product);
}
