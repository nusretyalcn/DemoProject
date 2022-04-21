using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{

    class Program
    {

        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDAL());
            productManager.Add(new Product { ProductName="masa", CategoryID=1, UnitPrice=500, UnitsInStock=50});
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

        }

    }
}