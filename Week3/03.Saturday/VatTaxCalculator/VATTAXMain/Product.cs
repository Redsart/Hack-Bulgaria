using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTAXMain
{
    public class Product
    {
        private int prizeWithoutTax;
        private double prizeWithTax = 0;
        private int origin;
        private string name;
        private int quantity;
        private int id;

        public Product(int prizeWithoutTax, int origin, string name, int quantity, int id, List<CountryVatTax> countries)
        {
            foreach (var country in countries)
            {
                if (country.CountryId == origin)
                {
                    this.prizeWithTax = prizeWithoutTax + ((prizeWithoutTax * country.VATTAX) / 100);
                }
            }
            this.PrizeWithoutTax = prizeWithoutTax;
            this.Origin = origin;
            this.Name = name;
            this.Quantity = quantity;
            this.Id = id;
        }

        public int PrizeWithoutTax
        {
            get
            {
                return this.prizeWithoutTax;
            }
            set
            {
                this.prizeWithoutTax = value;
            }
        }

        public double PrizeWithTax
        {
            get
            {
                return this.prizeWithTax;
            }
            set
            {
                this.prizeWithTax = value;
            }
        }

        public int Origin
        {
            get
            {
                return this.origin;
            }
            set
            {
                this.origin = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

    }
}
