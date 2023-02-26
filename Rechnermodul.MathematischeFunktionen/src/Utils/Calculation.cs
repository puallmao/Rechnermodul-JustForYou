using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Rechnermodul.MathematischeFunktionen.Utils
{
    public static class Calculation
    {
        /// <summary>
        /// Calculate Factorial
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static BigInteger Factorial(int n)
        {
            bool isNegativ = false;
            if (n < 0) { n *= -1; isNegativ = true; }
            BigInteger result = Enumerable.Range(1, n < 1 ? 1 : n).Aggregate(BigInteger.One, (f, x) => f * x);
            if (isNegativ) { result *= -1; }
            return result;
        }

        /// <summary>
        /// Calculate the Square root
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static decimal Sqrt(decimal n)
        {
            decimal result = n / 2;
            decimal temp = 0;
            while (temp != result)
            {
                temp = result;
                result = (n / temp + temp) / 2;
            }
            return result;
        }

        /// <summary>
        /// Calculate the power y of x
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static decimal Power(decimal x, decimal y)
        {
            decimal n = x;
            for (int i = 1; i < y; i++)
            {
                n *= x;
            }
            if (y == 0) { n = 1; }
            return n;
        }

        /// <summary>
        /// Calculate all prime number in the given range
        /// </summary>
        /// <param name="rangeFrom"></param>
        /// <param name="rangeTo"></param>
        /// <returns></returns>
        public static uint[] PrimeNumbers(uint rangeFrom, uint rangeTo)
        {
            List<uint> PrimeNumbers = new List<uint>();
            bool Prime = true;
            if (rangeFrom == 0) rangeFrom = 2;
            for (uint a = rangeFrom; a <= rangeTo; a++)
            {
                for (uint b = rangeFrom; b <= rangeTo; b++)
                {
                    if (a != b && a % b == 0)
                    {
                        Prime = false;
                        break;
                    }
                }
                if (Prime) { PrimeNumbers.Add(a); }
                Prime = true;
            }
            return PrimeNumbers.ToArray();
        }
    }
}
