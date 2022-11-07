using AutoMapper;
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public static ProductObject ToProductObject(Product product)
    {
        var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<Product, ProductObject>()
        );

        var mapper = new Mapper(config);
        var productObject = mapper.Map<ProductObject>(product);

        return productObject;
    }

    public static Member ToMember(MemberObject memberObject)
    {
        var config = new MapperConfiguration(c =>
        c.CreateMap<MemberObject, Member>());

        var mapper = new Mapper(config);
        var member = mapper.Map<Member>(memberObject);

        return member;
    }
}
