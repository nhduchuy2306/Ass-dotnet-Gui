using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository;

public class ProductRepository : IProductRepository
{
    private SaleManagementContext _saleManagementContext;

    public ProductRepository()
    {
        _saleManagementContext = new SaleManagementContext();
    }

    public bool Add(Product product)
    {
        _saleManagementContext.Products.Add(product);
        return _saleManagementContext.SaveChanges() > 0;
    }

    public bool Delete(int id)
    {
        Product product = GetById(id);
        _saleManagementContext.Products.Remove(product);
        return _saleManagementContext.SaveChanges() > 0;
    }

    public List<Product> GetAll()
    {
        var p = from c in _saleManagementContext.Products
                select c;
        return p.ToList();
    }

    public Product GetById(int id)
    {
        var product = (from p in _saleManagementContext.Products
                       where p.ProductId == id
                       select p).FirstOrDefault();
        return product;
    }

    public List<Product> GetByName(string name)
    {
        var product = from p in _saleManagementContext.Products
                      where p.ProductName.ToLower().Contains(name.ToLower())
                      select p;
        return product.ToList();
    }

    public bool Update(Product product)
    {
        Product productTmp = GetById(product.ProductId);

        if (productTmp != null)
        {
            productTmp.ProductName = product.ProductName;
            productTmp.UnitPrice = product.UnitPrice;
            productTmp.UnitsInStock = product.UnitsInStock;
            productTmp.CategoryId = product.CategoryId;
            productTmp.Weight = product.Weight;

            return _saleManagementContext.SaveChanges() > 0;
        }
        return false;
    }
}
