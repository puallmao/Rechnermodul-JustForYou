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
            return Convert.ToString(Convert.ToInt64(input, 2), 16);
        }

        /// <summary>
        /// Convert Binary to Octal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string binToOct(string input)
        {
            return Convert.ToString(Convert.ToInt64(input, 2), 8);
        }

        /// <summary>
        /// Convert Binary to Decimal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string binToDec(string input)
        {
            return Convert.ToString(Convert.ToInt64(input, 2), 10);
        }

        /// <summary>
        /// Convert Binary to Ternary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string binToTer(string input)
        {
            return toTernary(Convert.ToInt64(input, 2));
        }

        public static bool validateBinaryInput(string input)
        {
            string whitelist = "01";
            foreach (var c in input.ToCharArray())
            {
                if (!whitelist.Contains(c.ToString()))
                    return false; // Input not valid
            }
            return true; // Input valid
        }
        #endregion BIN

        #region TER
        /// <summary>
        /// Convert Decimal to Ternary
        /// </summary>
        /// <param name="dec"></param>
        /// <returns></returns>
        private static string toTernary(long dec)
        {
            string ternary = string.Empty;
            bool isNegative = dec < 0;

            if (isNegative)
            {
                dec = -dec;
            }

            while (dec > 0)
            {
                long remainder = dec % 3;
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
        private static long fromTernary(string ternary)
        {
            long dec = 0;
            long power = 1;
            bool isNegative = ternary[0] == '-';
            long startIndex = isNegative ? 1 : 0;

            for (int i = ternary.Length - 1; i >= startIndex; i--)
            {
                long digit = ternary[i] - '0';
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

        public static bool validateTernaryInput(string input)
        {
            string whitelist = "012";
            foreach (var c in input.ToCharArray())
            {
                if (!whitelist.Contains(c.ToString()))
                    return false; // Input not valid
            }
            return true; // Input valid
        }
        #endregion TER

        #region OCT
        /// <summary>
        /// Convert Octal to Hexa-Decimal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string octToHex(long input)
        {
            return Convert.ToString(Convert.ToInt64(input.ToString(), 8), 16);
        }

        /// <summary>
        /// Convert Octal to Decimal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string octToDec(long input)
        {
            return Convert.ToString(Convert.ToInt64(input.ToString(), 8), 10);
        }

        /// <summary>
        /// Convert Octal to Binary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string octToBin(long input)
        {
            return Convert.ToString(Convert.ToInt64(input.ToString(), 8), 2);
        }

        /// <summary>
        /// Convert Octal to Ternary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string octToTer(long input)
        {
            return toTernary(Convert.ToInt64(input.ToString(), 8));
        }

        public static bool validateOctalInput(string input)
        {
            string whitelist = "01234567";
            foreach (var c in input.ToCharArray())
            {
                if (!whitelist.Contains(c.ToString()))
                    return false; // Input not valid
            }
            return true; // Input valid
        }
        #endregion OCT

        #region DEC
        /// <summary>
        /// Convert Decimal to Hexa-Decimal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string decToHex(long input)
        {
            return Convert.ToString(Convert.ToInt64(input), 16);
        }

        /// <summary>
        /// Convert Decimal to Octal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string decToOct(long input)
        {
            return Convert.ToString(Convert.ToInt64(input), 8);
        }

        /// <summary>
        /// Convert Decimal to Binary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string decToBin(long input)
        {
            return Convert.ToString(Convert.ToInt64(input), 2);
        }

        /// <summary>
        /// Convert Decimal to Ternary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string decToTer(long input)
        {
            return toTernary(input);
        }

        public static bool validateDecimalInput(string input)
        {
            string whitelist = "0123456789";
            foreach (var c in input.ToCharArray())
            {
                if (!whitelist.Contains(c.ToString()))
                    return false; // Input not valid
            }
            return true; // Input valid
        }
        #endregion DEC

        #region HEX
        /// <summary>
        /// Convert Hexa-Decimal to Decimal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static long hexToDec(string input)
        {
            return Convert.ToInt64(input, 16);
        }

        /// <summary>
        /// Convert Hexa-Decimal to Octal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string hexToOct(string input)
        {
            return Convert.ToString(Convert.ToInt64(input, 16), 8);
        }

        /// <summary>
        /// Convert Hexa-Decimal to Binary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string hexToBin(string input)
        {
            return Convert.ToString(Convert.ToInt64(input, 16), 2);
        }

        /// <summary>
        /// Convert Hexa-Decimal to Ternary
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string hexToTer(string input)
        {
            return toTernary(Convert.ToInt64(input, 16));
        }

        public static bool validateHexInput(string input)
        {
            string whitelist = "0123456789ABCDEF";
            foreach (var c in input.ToCharArray())
            {
                if (!whitelist.Contains(c.ToString()))
                    return false; // Input not valid
            }
            return true; // Input valid
        }
        #endregion HEX
    }
}
