using BussinessObject.Models;

namespace DataAccess.Repository;

public interface IProductRepository
{
    List<Product> GetAll();
    Product GetById(int id);
    List<Product> GetByName(string name);
    bool Update(Product product);
    bool Delete(int id);
    bool Add(Product product);
    List<Product> GetByUnitPrice(decimal unitPrice);
    List<Product> GetByUnitsInStock(int unitInStock);
}
