using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTAXMain
{
    public class Order
    {
        private int productId;
        private int quantity;

        public Order(int productId, int quantity)
        {
            this.ProductId = productId;
            this.Quantity = quantity;
        }

        public int ProductId
        {
            get
            {
                return this.productId;
            }
            set
            {
                this.productId = value;
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
    }
}
