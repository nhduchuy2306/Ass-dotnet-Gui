
﻿using AutoMapper;

using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Mappings;

public class AutoMapperConfiguration
{
    // product
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

    // member
    public static Member ToMember(MemberObject memberObject)
    {
        var config = new MapperConfiguration(c =>
        c.CreateMap<MemberObject, Member>());

        var mapper = new Mapper(config);
        var member = mapper.Map<Member>(memberObject);

        return member;
    }

    public static MemberObject ToMemberObject(Member member)
    {
        var config = new MapperConfiguration(c =>
        c.CreateMap<Member, MemberObject>());

        var mapper = new Mapper(config);
        var memberObject = mapper.Map<MemberObject>(member);

        return memberObject;
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

    public static OrderObject ToOrderObject(Order order)
    {
        var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<Order, OrderObject>()
        );

        var mapper = new Mapper(config);
        var orderobject = mapper.Map<OrderObject>(order);

        return orderobject;
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
