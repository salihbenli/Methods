using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
           Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 150;
            product1.UnitinStock = 5;

            Product product2 = new Product {Id=4, CategoryId=2,ProductName="sandalye", UnitinStock=2,UnitPrice=20};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
