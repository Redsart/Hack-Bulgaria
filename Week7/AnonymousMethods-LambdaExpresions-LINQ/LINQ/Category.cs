using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Category
    {
        private List<Product> products;

        public Category()
        {
            this.products = new List<Product>();
        }

        public List<Product> Products
        {
            get
            {
                return this.products;
            }
            set
            {
                this.products = value;
            }
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
