using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var productList = new List<Product>();
            productList.Add(new Product() { ProductId = 50, CategoryId = 90, Name="Samsung" });
            productList.Add(new Product() { ProductId = 90, CategoryId = 110, Name = "LG" });
            productList.Add(new Product() { ProductId = 150, CategoryId = 150, Name = "Toshiba" });
            productList.Add(new Product() { ProductId = 60, CategoryId = 200, Name="Sony" });
            productList.Add(new Product() { ProductId = 75, CategoryId = 190, Name = "Sharp" });

            var someCategory = new Category() { CategoryID = 100, CategoryName = "TV" };
            foreach (var product in productList)
            {
                product.Category = someCategory;
            }

            var sortedProductList = GetProducts(productList);
            Console.WriteLine("Products with ID between 1-100");
            foreach (var product in sortedProductList)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Product Name: {0}; ID: {1}",product.Name,product.ProductId);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            var categoryList = new List<Category>();
            categoryList.Add(new Category() { CategoryID = 100, CategoryName = "TV" });
            categoryList.Add(new Category() { CategoryID = 90, CategoryName = "Computers" });
            categoryList.Add(new Category() { CategoryID = 150, CategoryName = "Audio" });
            categoryList.Add(new Category() { CategoryID = 210, CategoryName = "Appliances" });
            categoryList.Add(new Category() { CategoryID = 190, CategoryName = "Accesories" });

            foreach (var category in categoryList)
            {
                category.Products = productList;
            }

            var sortedCategoryList = GetCategoryes(categoryList);
            Console.WriteLine("Categoryes with ID between 101-200");
            foreach (var category in categoryList)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Category Name: {0}; Category ID: {1}",category.CategoryName,category.CategoryID);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            var orderList = new List<Order>();
            orderList.Add(new Order() { OrderId = 240, Name = "Oreder 1", OrderDate = DateTime.Now, Products = productList });
            orderList.Add(new Order() { OrderId = 190, Name = "Order 2", OrderDate = DateTime.Now, Products = sortedProductList });
            orderList.Add(new Order() { OrderId = 280, Name = "Order 3", OrderDate = DateTime.Now, Products = productList });
            orderList.Add(new Order() { OrderId = 310, Name = "Order 4", OrderDate = DateTime.Now, Products = sortedProductList });

            var sortedOrderList = GetOrders(orderList);
            Console.WriteLine("Orders with ID between 201-300");
            foreach (var order in sortedOrderList)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Order Name: {0}; Order ID: {1}",order.Name,order.OrderId);
                foreach (var product in order.Products)
                {
                    Console.WriteLine("-{0}",product.Name);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Queries
            //returns all products with ids between 15 and 30
            productList.Where(p => p.ProductId >= 15 && p.ProductId <= 30);

            //returns all categories with ids between 105 and 125
            categoryList.Where(c => c.CategoryID >= 105 && c.CategoryID <= 125);

            //returns first 15 orders sorted by order name
            orderList.OrderBy(o => o.Name).Take(15);

            //returns first 3 orders which contains a specific productId (e.g. 10)
            //Orders must be sorted based on OrderDate The print order names.
            var customOrder = orderList.Where(o => o.Products.Any(p => p.ProductId == 150)).OrderBy(o => o.OrderDate).Take(3).ToList();
            foreach (var order in customOrder)
            {
                Console.WriteLine(order.Name);
            }
            Console.WriteLine();

            //returns all product with the name of the category which they belong to
            //Orders must be sorted based on OrderDate The print order names.
            var customProductList = productList.OrderBy(p => p.Category.CategoryName);

            foreach (var product in customProductList)
            {
                Console.WriteLine("Product: {0}; Category: {1}",product.Name,product.Category.CategoryName);
            }
            Console.WriteLine();

            //Create linq query which returns all categories together with their products
            //Create class CategoryWithProduct which should keep the result
            List<CategoryWithProduct> categoryWithProduct = categoryList.Select(c => new CategoryWithProduct
                {
                    CateforyId = c.CategoryID,
                    CategoryName = c.CategoryName,
                    ProductNames = c.Products.Select(p => p.Name).ToList()
                }).ToList();
            foreach (var item in categoryWithProduct)
            {
                Console.WriteLine("Name: {0} - ID: {1}",item.CategoryName,item.CateforyId);
                foreach (var productName in item.ProductNames)
                {
                    Console.WriteLine("-{0}",productName);
                }
            }
            Console.WriteLine();

            //Create linq query which selects all orders together with their products and then print it to the screen.
            //For every product print its category name as well. Sort the result by orderDate
            var customOrderList = orderList.OrderBy(o => o.OrderDate).ToList();
            foreach (var order in customOrderList)
            {
                Console.WriteLine("-{0}",order.Name);
                foreach (var product in order.Products)
                {
                    Console.WriteLine("{0} - {1}",product.Category.CategoryName,product.Name);
                }
            }
        }

        public static List<Product> GetProducts(List<Product> products)
        {
            var productList = products.Where(p => p.ProductId >= 1 && p.ProductId <= 100).ToList();
            return productList;
        }

        public static List<Category> GetCategoryes(List<Category> categoryes)
        {
            var categoryList = categoryes.Where(c => c.CategoryID >= 101 && c.CategoryID <= 200).ToList();
            return categoryList;
        }

        public static List<Order> GetOrders(List<Order> orders)
        {
            var orderList = orders.Where(o => o.OrderId >= 201 && o.OrderId <= 300).ToList();
            return orderList;
        }
    }
}
