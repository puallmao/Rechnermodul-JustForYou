using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Rechnermodul.Utils.Shared
{
    public static class Encryption
    {
        //Iinitialization Vector
        private static readonly byte[] initializationVector = { 0x84, 0x7D, 0x44, 0x4E, 0xE8, 0xF1, 0x60, 0x23, 0x09, 0x0F, 0x96, 0xFE, 0xB7, 0xF2, 0x28, 0xD1 };

        // Key for encryption and decryption
        private static readonly byte[] key = { 0x24, 0x75, 0x6F, 0x33, 0x83, 0xBA, 0x37, 0x51, 0x8C, 0x0A, 0xC0, 0x8E, 0x83, 0xA5, 0x0E, 0xCA, 0xE8, 0x52, 0x67, 0x00, 0x3E, 0x98, 0x0A, 0x73, 0xE8, 0xFB, 0x1D, 0xDB, 0xCA, 0x03, 0x9E, 0x6E };


        // Encrypt the given data.
        public static byte[] Encrypt (byte[] data)
        {
            using (Aes aes = Aes.Create())
            {
                aes.IV = initializationVector;
                aes.Key = key;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(data, 0, data.Length);
                        cs.FlushFinalBlock();
                        return ms.ToArray();
                    }
                }
            }
        }


        // Decrypt the given data.
        public static byte[] Decrypt (byte[] data)
        {
            using (Aes aes = Aes.Create())
            {
                aes.IV = initializationVector;
                aes.Key = key;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(data, 0, data.Length);
                        cs.FlushFinalBlock();
                        return ms.ToArray();
                    }
                }
            }
        }
    }
}
