using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Rechnermodul.Utils.Shared
{
    /// <summary>
    /// This class is purely responsible for history related work.
    /// </summary>
    public static class History
    {
        private static string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Rechnermodul-JustForYou";
        private static readonly string FileName = "Rechnermodul-JustForYou-History.dat";

        /// <summary>
        /// Calculation history
        /// </summary>
        private static List<String> history = new List<string>();

        /// <summary>
        /// Load the given file and return the unencrypted content.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static void load()
        {
            DirectoryInfo dir = new DirectoryInfo(AppDataPath);
            if (dir.Exists)
            {
                string path = AppDataPath + "\\" + FileName;
                FileInfo file = new FileInfo(path);
                if (file.Exists)
                {
                    history = decrypt(File.ReadAllBytes(path));
                }
            }
        }

        /// <summary>
        /// Save the current History to the given file.
        /// If the given file already exists it will be replaced.
        /// </summary>
        /// <param name="file"></param>
        public static void save()
        {
            string path = AppDataPath + "\\" + FileName;
            DirectoryInfo dir = new DirectoryInfo(AppDataPath);
            if (!dir.Exists) { dir.Create(); }

            FileInfo file = new FileInfo(path);
            if (file.Exists) { file.Delete(); }
            File.WriteAllBytes(path, encrypt());
        }

        /// <summary>
        /// Add a new Entry to the History.
        /// </summary>
        /// <param name="Entry"></param>
        public static void addEntry(string Entry)
        {
            if (!string.IsNullOrEmpty(Entry) && !string.IsNullOrWhiteSpace(Entry))
                history.Add(Entry);
        }

        /// <summary>
        /// Get History.
        /// </summary>
        /// <returns></returns>
        public static List<string> getHistory()
        {
            return new List<string>(history);
        }

        /// <summary>
        /// Delete the current History.
        /// </summary>
        public static void clear()
        {
            string path = AppDataPath + "\\" + FileName;
            FileInfo file = new FileInfo(path);

            if (file.Exists)
            {
                file.Delete();
                history.Clear();
            }
        }

        /// <summary>
        /// Encrypt the History data.
        /// </summary>
        private static byte[] encrypt()
        {
            var json = JsonSerializer.Serialize(history);
            byte[] data = new byte[] { };
            try
            {
                data = Encryption.Encrypt(Encoding.UTF8.GetBytes(json));
            } catch { }
            return data;
        }

        /// <summary>
        /// Decrypt the given data and save it as the current History.
        /// </summary>
        /// <param name="data"></param>
        private static List<string> decrypt(byte[] data)
        {
            List<string> decryptedHistory = new List<string>();
            try
            {
                decryptedHistory = JsonSerializer.Deserialize<List<string>>(Encoding.UTF8.GetString(Encryption.Decrypt(data)));
            } catch { }
            return decryptedHistory;
        }
    }
}
