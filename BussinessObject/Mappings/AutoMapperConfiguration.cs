using AutoMapper;
using BussinessObject.Models;

namespace BussinessObject.Mappings;

public class AutoMapperConfiguration
{
    public static Product ToProduct(ProductObject productObject)
    {
        var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<ProductObject, Product>()
        );

        var mapper = new Mapper(config);
        var product = mapper.Map<Product>(productObject);

        return product;
    }
}
