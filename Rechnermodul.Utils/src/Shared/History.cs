using System;
using System.Collections.Generic;
using System.IO;

namespace Rechnermodul.Utils.Shared
{
    /// <summary>
    /// This class is purely responsible for history related work.
    /// </summary>
    public static class History
    {
        /// <summary>
        /// Calculation history
        /// </summary>
        public static List<String> history;

        /// <summary>
        /// Load the given file and return the unencrypted content.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static List<String> loadHistoryFromFile(FileInfo file)
        {
            List<String> tmpList = new List<string>();

            history = tmpList;
            return tmpList;
        }

        /// <summary>
        /// Save the current History to the given file.
        /// If the given file already exist it will be replaced.
        /// </summary>
        /// <param name="file"></param>
        public static void saveHistoryToFile(FileInfo file)
        {

        }

        /// <summary>
        /// Delete the current history.
        /// </summary>
        public static void deleteCurrentHistory()
        {

        }

        /// <summary>
        /// Encrypt the history data.
        /// </summary>
        private static void encryptHistory()
        {
        }

        /// <summary>
        /// Decrypt the given data and save it as the current history.
        /// </summary>
        /// <param name="data"></param>
        private static void decryptHistory(List<String> data)
        {

        }
    }
}
