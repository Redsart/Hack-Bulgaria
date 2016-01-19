using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTAXMain
{
    public class Calculator
    {
        private List<CountryVatTax> list = new List<CountryVatTax>();

        public Calculator(List<CountryVatTax> countryList)
        {
            this.list = countryList;
        }

        public void CalculateTax(double productPrice, int countryId)
        {
            productPrice += (productPrice * countryId) / 100;
            Console.WriteLine("product price afted vat tax is {0}",productPrice);
        }

        public void CalculateTax(double productPrice)
        {
            foreach (var item in list)
            {
                if (item.IsDefault)
                {
                    productPrice += (productPrice * item.VATTAX);
                    Console.WriteLine("product price after vat tax is {0}",productPrice);
                }
            }
        }
    }
}
