using Rechnermodul.Informationstechnik.Utils;
using Rechnermodul.Utils.Shared;
using System.Windows.Forms;

namespace Rechnermodul.Informationstechnik.View
{
    public partial class UC_FileSizeCalculation : UserControl
    {
        public UC_FileSizeCalculation()
        {
            InitializeComponent();
        }

        private void RB_calcImage_CheckedChanged(object sender, System.EventArgs e)
        {
            RadioButton control = (RadioButton)sender;
            if (control.Checked == true)
            {
                GB_framesPerSecond.Enabled = false;
                GB_videoLength.Enabled = false;
                calcSize();
            }
        }

        private void RB_calcVideo_CheckedChanged(object sender, System.EventArgs e)
        {
            RadioButton control = (RadioButton)sender;
            if (control.Checked == true)
            {
                GB_framesPerSecond.Enabled = true;
                GB_videoLength.Enabled = true;
                calcSize();
            }
        }

        private void setFileSize(object sender, System.EventArgs e)
        {
            calcSize();
        }

        /// <summary>
        /// Calculate the file size
        /// </summary>
        private void calcSize()
        {
            ulong bytes = 0;
            string decSize = string.Empty;
            string binSize = string.Empty;

            if (RB_calcImage.Checked == true) // Image
                bytes = FileSizeCalculation.calculateImageSize((int)NUM_colorDepth.Value, (int)NUM_imageWidth.Value, (int)NUM_imageHeight.Value);
            else if (RB_calcVideo.Checked == true) // Video
                bytes = FileSizeCalculation.calculateVideoSize((int)NUM_colorDepth.Value, (int)NUM_imageWidth.Value, (int)NUM_imageHeight.Value, (int)NUM_framesPerSecond.Value, (int)NUM_videoLength.Value);

            // Get correct DataSize Prefix
            if (bytes < 1000000)
            {
                decSize = Math4U.Round(DataSizeConversion.convertToDecimalPrefix(DataSizeConversion.decimalPrefixDataSizes.KiloByte, bytes), 6).ToString() + " KB";
                binSize = Math4U.Round(DataSizeConversion.convertToBinaryPrefix(DataSizeConversion.binaryPrefixDataSizes.KibiByte, bytes), 6).ToString() + " KiB";
            }
            else if (bytes >= 1000000 && bytes < 1000000000)
            {
                decSize = Math4U.Round(DataSizeConversion.convertToDecimalPrefix(DataSizeConversion.decimalPrefixDataSizes.MegaByte, bytes), 6).ToString() + " MB";
                binSize = Math4U.Round(DataSizeConversion.convertToBinaryPrefix(DataSizeConversion.binaryPrefixDataSizes.MebiByte, bytes), 6).ToString() + " MiB";
            }
            else if (bytes >= 1000000000 && bytes < 1000000000000)
            {
                decSize = Math4U.Round(DataSizeConversion.convertToDecimalPrefix(DataSizeConversion.decimalPrefixDataSizes.GigaByte, bytes), 6).ToString() + " GB";
                binSize = Math4U.Round(DataSizeConversion.convertToBinaryPrefix(DataSizeConversion.binaryPrefixDataSizes.GibiByte, bytes), 6).ToString() + " GiB";
            }
            else if (bytes >= 1000000000000)
            {
                decSize = Math4U.Round(DataSizeConversion.convertToDecimalPrefix(DataSizeConversion.decimalPrefixDataSizes.TeraByte, bytes), 6).ToString() + " TB";
                binSize = Math4U.Round(DataSizeConversion.convertToBinaryPrefix(DataSizeConversion.binaryPrefixDataSizes.TebiByte, bytes), 6).ToString() + " TiB";
            }

            TB_size.Text = $"{decSize} | {binSize}";
            if (NUM_colorDepth.Value != 0 && NUM_imageHeight.Value != 0 && NUM_imageWidth.Value != 0)
                if (RB_calcImage.Checked)
                    History.AddEntry($"Dateigröße berechnet: {decSize} | {binSize} (Farbtiefe: {NUM_colorDepth.Value}, Höhe: {NUM_imageHeight.Value}, Breite: {NUM_imageWidth.Value})");
                else
                    if (NUM_framesPerSecond.Value != 0 && NUM_videoLength.Value != 0)
                        History.AddEntry($"Videogröße berechnet: {decSize} | {binSize} (Farbtiefe: {NUM_colorDepth.Value}, Höhe: {NUM_imageHeight.Value}, Breite: {NUM_imageWidth.Value}, FPS: {NUM_framesPerSecond.Value}, Videolänge: {NUM_videoLength.Value})");
        }
    }
}
