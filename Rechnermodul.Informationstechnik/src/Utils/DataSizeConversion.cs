using Rechnermodul.Utils.Shared;
using System;

namespace Rechnermodul.Informationstechnik.Utils
{
    public static class DataSizeConversion
    {
        /// <summary>
        /// Decimal Prefix DataSizes
        /// </summary>
        public enum decimalPrefixDataSizes
        {
            KiloByte,
            MegaByte,
            GigaByte,
            TeraByte
        }

        /// <summary>
        /// Binary Prefix DataSizes
        /// </summary>
        public enum binaryPrefixDataSizes
        {
            KibiByte,
            MebiByte,
            GibiByte,
            TebiByte
        }

        /// <summary>
        /// Calculate the given size in bytes.
        /// </summary>
        /// <param name="binaryPrefixDataSize"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static ulong calculateBytes(binaryPrefixDataSizes binaryPrefixDataSize, decimal size)
        {
            if (size <= 0) { return 0; }
            int power = (int)binaryPrefixDataSize + 1;
            return (ulong)(size * (decimal)Math4U.Pow(1024, power));
        }

        /// <summary>
        /// Calculate the given size in bytes.
        /// </summary>
        /// <param name="decimalPrefixDataSize"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static ulong calculateBytes(decimalPrefixDataSizes decimalPrefixDataSize, decimal size)
        {
            if (size <= 0) { return 0; }
            int power = (int)decimalPrefixDataSize + 1;
            return (ulong)(size * (decimal)Math4U.Pow(1000, power));
        }

        /// <summary>
        /// Convert to Binary Prefix.
        /// </summary>
        /// <param name="decimalPrefixDataSize"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal convertToBinaryPrefix(binaryPrefixDataSizes binaryPrefixDataSize, ulong bytes)
        {
            if (bytes <= 0) { return 0; }
            int power = (int)binaryPrefixDataSize + 1;
            return bytes / (decimal)Math4U.Pow(1024, power);
        }

        /// <summary>
        /// Convert to Decimal Prefix.
        /// </summary>
        /// <param name="binaryPrefixDataSize"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal convertToDecimalPrefix(decimalPrefixDataSizes decimalPrefixDataSize, ulong bytes)
        {
            if (bytes <= 0) { return 0; }
            int power = (int)decimalPrefixDataSize + 1;
            return bytes / (decimal)Math4U.Pow(1000, power);
        }
    }
}
