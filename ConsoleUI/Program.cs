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
            ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDAL());
           // productManager.Add(new Product { ProductName = "masa", CategoryID = 1, UnitPrice = 500, UnitsInStock = 50 });

            // EfProductDAL productDAL = new EfProductDAL();
            // productDAL.Add(new Product { ProductName = "nusret", CategoryID = 2, UnitPrice = 50, UnitsInStock = 50 });
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }
    }
}