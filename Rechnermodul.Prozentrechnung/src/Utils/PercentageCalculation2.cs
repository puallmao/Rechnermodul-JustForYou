using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnermodul.Prozentrechnung.Utils
{
    public static class PercentageCalculation2
    {
        public static decimal CalculatePercentage(decimal value, decimal percentageValue)
        {
            return (percentageValue / value) * 100.0m;
        }
    }
}
