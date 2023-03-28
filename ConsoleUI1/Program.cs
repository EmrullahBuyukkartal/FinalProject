﻿using Business.Concrete;
using DataAccess1.Concrete.EntityFramework;
using DataAccess1.Concrete.InMemory;

ProductManager productManager = new ProductManager(new EfProductDal());

foreach(var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}

