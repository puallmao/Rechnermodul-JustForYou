using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnermodul.Utils.Shared
{
    public static class Math4U
    {
        public static float Round(float n, int decimals)
        {
            float d = (float)Pow(10, decimals);
            int i = (int)((n * d) + 0.5f);
            return i / d;
        }

        public static decimal Round(decimal n, int decimals)
        {
            decimal d = (decimal)Pow(10, decimals);
            int i = (int)((n * d) + 0.5m);
            return i / d;
        }

        public static double Pow(double x, double y)
        {
            double n = x;
            for (int i = 1; i < y; i++)
            {
                n *= x;
            }
            return n;
        }

        public static double Ceiling(double n)
        {
            int x = ((int)n) + 1;
            return (double)x;
        }

        public static decimal Ceiling(decimal n)
        {
            int x = ((int)n) + 1;
            return (decimal)x;
        }
    }
}
