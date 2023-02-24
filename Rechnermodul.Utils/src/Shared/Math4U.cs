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
            float d = Pow(10, decimals);
            int i = (int)((n * d) + 0.5f);
            return i / d;
        }

        public static decimal Round(decimal n, int decimals)
        {
            decimal d = Pow(10, decimals);
            int i = (int)((n * d) + 0.5m);
            return i / d;
        }

        public static int Pow(int x, int y)
        {
            int n = x;
            for (int i = 1; i < y; i++)
            {
                n *= x;
            }
            return n;
        }
    }
}
