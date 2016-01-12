using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTAXMain
{
    public class ShopInventory
    {
        private Dictionary<Product, int> products = new Dictionary<Product, int>();

        public ShopInventory(Product newProduct)
        {
            if (products.ContainsKey(newProduct))
            {
                products[newProduct] += 1;
            }
            else
            {
                products.Add(newProduct, 1);
            }
        }

        public double Audit()
        {
            double total = 0;
            foreach (var item in products)
            {
                total += (item.Key.PrizeWithTax * item.Key.Quantity);
            }
            return total;
        }

        public void RequestOrder(Order order)
        {
            foreach (var item in products)
            {
                if (item.Key.Id==order.ProductId)
                {
                    if (item.Key.Quantity >= order.Quantity)
                    {
                        double result = 0;
                        result = item.Key.PrizeWithTax * order.Quantity;
                        Console.WriteLine("The order will cost you: {0}",result);
                    }
                    else
                    {
                        Console.WriteLine("Not enough quantity.");
                    }
                }
                else
                {
                    Console.WriteLine("We dont have the product in our inventory.");
                }
            }
        }
    }
}
