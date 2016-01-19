using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATTAXMain
{
    public class CountryVatTax
    {
        private int countryId;
        private int VATTax;
        private bool isDefault = false;

        public CountryVatTax(int countryId, int VATTax, bool isDefault = false)
        {
            this.countryId = countryId;
            this.VATTax = VATTax;
            this.isDefault = isDefault;
        }

        public int CountryId
        {
            get
            {
                return this.countryId;
            }
            private set
            {
                this.countryId = value;
            }
        }

        public int VATTAX
        {
            get
            {
                return this.VATTax;
            }
            private set
            {
                this.VATTax = value;
            }
        }

        public bool IsDefault
        {
            get
            {
                return this.isDefault;
            }
            private set
            {
                this.isDefault = value;
            }
        }
    }
}
