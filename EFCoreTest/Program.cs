

using EFCoreTest.Data;
using EFCoreTest.Models;

using ContosoPizzaPart1Context db = new ContosoPizzaPart1Context();

/*
Product product = new Product()
{
    Name = "Kakoi-ti product",
    Price = 1000
};

db.Products.Add(product);

Product product1 = new Product()
{
    Name = "Новый продукт",
    Price = 900
};

db.Add(product1);

db.SaveChanges();
*/

var products = db.Products;

foreach (var product in products)
{
    Console.WriteLine(product.Id);
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine();
}