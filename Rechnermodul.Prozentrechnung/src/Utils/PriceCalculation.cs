using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnermodul.Prozentrechnung.Utils
{
    public static class PriceCalculation
    {
        public static decimal AddSalesTax(decimal price)
        {
            return (price * 1.19M);
        }

        public static decimal RemoveSalesTax(decimal price)
        {
            return (price / 1.19M) * 1.0M;
        }
    }
}
