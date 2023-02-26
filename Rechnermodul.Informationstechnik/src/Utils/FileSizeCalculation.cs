using Rechnermodul.Utils.Shared;
using System;

namespace Rechnermodul.Informationstechnik.Utils
{
    public static class FileSizeCalculation
    {
        /// <summary>
        /// Calculate the Image size in bytes.
        /// </summary>
        /// <param name="colorDepth"></param>
        /// <param name="width"></param>
        /// <param name="heigth"></param>
        /// <param name="imageNum"></param>
        public static ulong calculateImageSize(int colorDepth, int width, int heigth)
        {
            return (ulong)Math4U.Ceiling((decimal)((colorDepth * (width * heigth)) / 8));
        }

        /// <summary>
        /// Calculate the Video size in bytes
        /// </summary>
        /// <param name="colorDepth"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="framesPerSecond"></param>
        /// <param name="lengthInSeconds"></param>
        /// <returns></returns>
        public static ulong calculateVideoSize(int colorDepth, int width, int height, int framesPerSecond, double lengthInSeconds)
        {
            return (ulong)Math4U.Ceiling((((colorDepth * (width * height)) / 8) * framesPerSecond) * lengthInSeconds);
        }
    }
}
