using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnermodul.Prozentrechnung.Utils
{
    public static class PercentageCalculation1
    {
        public static decimal AddPercentage(decimal value, decimal percentage)
        {
            return value * ((percentage / 100.0m) + 1.0m);
        }

        public static decimal SubtractPercentage(decimal value, decimal percentage)
        {
            return value * (1.0m - (percentage / 100.0m));
        }

        public static decimal CalcPercentageValue(decimal value, decimal percentage)
        {
            return value * (percentage / 100.0m);
        }
    }
}
