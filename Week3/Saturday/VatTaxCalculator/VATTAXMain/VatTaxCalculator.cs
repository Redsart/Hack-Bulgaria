using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTAXMain
{
    class VatTaxCalculator
    {
        static void Main(string[] args)
        {
            CountryVatTax obj = new CountryVatTax(1,20,false);
            CountryVatTax secondObj = new CountryVatTax(2, 15, true);
            List<CountryVatTax> countries = new List<CountryVatTax> { obj, secondObj};
            Calculator calculator = new Calculator(countries);
            calculator.CalculateTax(4);
            calculator.CalculateTax(4, 2);
            Product product = new Product(4,2,"Storm",4,2,countries);
            Product secondProduct = new Product(8, 1, "Wind", 5, 1, countries);
            ShopInventory shopInventory = new ShopInventory(product);
            Console.WriteLine("If all products of that type are sold out, the profil you will gain is = {0}", shopInventory.Audit());
            Order order = new Order(1, 3);
            shopInventory.RequestOrder(order);
        }
    }
}
