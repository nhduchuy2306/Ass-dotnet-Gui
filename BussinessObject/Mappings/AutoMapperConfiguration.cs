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


    public static Order ToOrder(OrderObject orderObject)
    {
        var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<OrderObject, Order>()
        );

        var mapper = new Mapper(config);
        var order = mapper.Map<Order>(orderObject);

        return order;
    }

    public static OrderDetail ToOrderDetail(OrderDetailObject orderdetailObject)
    {
        var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<OrderDetailObject, OrderDetail>()
        );

        var mapper = new Mapper(config);
        var orderdetail = mapper.Map<OrderDetail>(orderdetailObject);

        return orderdetail;
    }



}
