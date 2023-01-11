using System;

namespace Rechnermodul.Informationstechnik.Utils
{
    public static class NumberSystemConversion
    {
        #region BIN
        /// <summary>
        /// Convert Binary to Hexa-Decimal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string binToHex(string input)
        {
            return Convert.ToString(Convert.ToInt32(input, 2), 16);
        }

        /// <summary>
        /// Convert Binary to Octal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string binToOct(string input)
        {
            return Convert.ToString(Convert.ToInt32(input, 2), 8);
        }

        /// <summary>
        /// Convert Binary to Decimal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string binToDec(string input)
        {
            return Convert.ToString(Convert.ToInt32(input, 2), 10);
        }

        /// <summary>
        /// Convert Binary to Ternary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string binToTer(string input)
        {
            return toTernary(Convert.ToInt32(input, 2));
        }
        #endregion BIN

        #region TER
        /// <summary>
        /// Convert Decimal to Ternary
        /// </summary>
        /// <param name="dec"></param>
        /// <returns></returns>
        private static string toTernary(int dec)
        {
            string ternary = string.Empty;
            bool isNegative = dec < 0;

            if (isNegative)
            {
                dec = -dec;
            }

            while (dec > 0)
            {
                int remainder = dec % 3;
                ternary = remainder.ToString() + ternary;
                dec /= 3;
            }

            if (isNegative)
            {
                ternary = "-" + ternary;
            }

            return ternary.TrimStart('0');
        }

        /// <summary>
        /// Convert Ternary to Decimal
        /// </summary>
        /// <param name="ternary"></param>
        /// <returns></returns>
        private static int fromTernary(string ternary)
        {
            int dec = 0;
            int power = 1;
            bool isNegative = ternary[0] == '-';
            int startIndex = isNegative ? 1 : 0;

            for (int i = ternary.Length - 1; i >= startIndex; i--)
            {
                int digit = ternary[i] - '0';
                dec += digit * power;
                power *= 3;
            }

            return isNegative ? -dec : dec;
        }

        /// <summary>
        /// Convert Ternary to Binary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string terToBin(string input)
        {
            return Convert.ToString(fromTernary(input), 2);
        }

        /// <summary>
        /// Convert Ternary to Octal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string terToOct(string input)
        {
            return Convert.ToString(fromTernary(input), 8);
        }

        /// <summary>
        /// Convert Ternary to Decimal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string terToDec(string input)
        {
            return fromTernary(input).ToString();
        }

        /// <summary>
        /// Convert Ternary to Hexa-Decimal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string terToHex(string input)
        {
            return Convert.ToString(fromTernary(input), 16);
        }
        #endregion TER

        #region OCT
        /// <summary>
        /// Convert Octal to Hexa-Decimal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string octToHex(int input)
        {
            return Convert.ToString(Convert.ToInt32(input.ToString(), 8), 16);
        }

        /// <summary>
        /// Convert Octal to Decimal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string octToDec(int input)
        {
            return Convert.ToString(Convert.ToInt32(input.ToString(), 8), 10);
        }

        /// <summary>
        /// Convert Octal to Binary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string octToBin(int input)
        {
            return Convert.ToString(Convert.ToInt32(input.ToString(), 8), 2);
        }

        /// <summary>
        /// Convert Octal to Ternary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string octToTer(int input)
        {
            return toTernary(Convert.ToInt32(input.ToString(), 8));
        }
        #endregion OCT

        #region DEC
        /// <summary>
        /// Convert Decimal to Hexa-Decimal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string decToHex(int input)
        {
            return Convert.ToString(Convert.ToInt32(input), 16);
        }

        /// <summary>
        /// Convert Decimal to Octal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string decToOct(int input)
        {
            return Convert.ToString(Convert.ToInt32(input), 8);
        }

        /// <summary>
        /// Convert Decimal to Binary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string decToBin(int input)
        {
            return Convert.ToString(Convert.ToInt32(input), 2);
        }

        /// <summary>
        /// Convert Decimal to Ternary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string decToTer(int input)
        {
            return toTernary(input);
        }
        #endregion DEC

        #region HEX
        /// <summary>
        /// Convert Hexa-Decimal to Decimal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int hexToDec(string input)
        {
            return Convert.ToInt32(input, 16);
        }

        /// <summary>
        /// Convert Hexa-Decimal to Octal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string hexToOct(string input)
        {
            return Convert.ToString(Convert.ToInt32(input, 16), 8);
        }

        /// <summary>
        /// Convert Hexa-Decimal to Binary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string hexToBin(string input)
        {
            return Convert.ToString(Convert.ToInt32(input, 16), 2);
        }

        /// <summary>
        /// Convert Hexa-Decimal to Ternary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string hexToTer(string input)
        {
            return toTernary(Convert.ToInt32(input, 16));
        }
        #endregion HEX
    }
}
