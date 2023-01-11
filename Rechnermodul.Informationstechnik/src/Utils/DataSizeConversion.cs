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
            Kiloyte,
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
            MibiByte,
            GibiByte,
            TibiByte
        }

        /// <summary>
        /// Convert to Binary Prefix.
        /// </summary>
        /// <param name="decimalPrefixDataSize"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double convertToBinaryPrefix(decimalPrefixDataSizes decimalPrefixDataSize, int input)
        {
            if (input < 0) { return 0; }

            int power = (int)decimalPrefixDataSize + 1;
            ulong byteSize = (ulong)(input * Math.Pow(1000, power));
            return byteSize / Math.Pow(1024, power);
        }

        /// <summary>
        /// Convert to Decimal Prefix.
        /// </summary>
        /// <param name="binaryPrefixDataSize"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double convertToDecimalPrefix(binaryPrefixDataSizes binaryPrefixDataSize, int input)
        {
            if (input < 0) { return 0; }

            int power = (int)binaryPrefixDataSize + 1;
            ulong byteSize = (ulong)(input * Math.Pow(1024, power));
            return byteSize / Math.Pow(1000, power);
        }
    }
}
