using Rechnermodul.Informationstechnik.Utils;
using System.Windows.Forms;

namespace Rechnermodul.Informationstechnik.src.View
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

        private void calcSize()
        {
            ulong bytes = 0;
            string decSize = string.Empty;
            string binSize = string.Empty;

            if (RB_calcImage.Checked == true)
                bytes = FileSizeCalculation.calculateImageSize((int)NUM_colorDepth.Value, (int)NUM_imageWidth.Value, (int)NUM_imageHeight.Value);
            else if (RB_calcVideo.Checked == true)
                bytes = FileSizeCalculation.calculateVideoSize((int)NUM_colorDepth.Value, (int)NUM_imageWidth.Value, (int)NUM_imageHeight.Value, (int)NUM_framesPerSecond.Value, (int)NUM_videoLength.Value);

            if (bytes < 1000000)
            {
                decSize = DataSizeConversion.convertToDecimalPrefix(DataSizeConversion.decimalPrefixDataSizes.KiloByte, bytes).ToString() + " KB";
                binSize = DataSizeConversion.convertToBinaryPrefix(DataSizeConversion.binaryPrefixDataSizes.KibiByte, bytes).ToString() + " KiB";
            }
            else if (bytes >= 1000000 && bytes < 1000000000)
            {
                decSize = DataSizeConversion.convertToDecimalPrefix(DataSizeConversion.decimalPrefixDataSizes.MegaByte, bytes).ToString() + " MB";
                binSize = DataSizeConversion.convertToBinaryPrefix(DataSizeConversion.binaryPrefixDataSizes.MibiByte, bytes).ToString() + " MiB";
            }
            else if (bytes >= 1000000000 && bytes < 1000000000000)
            {
                decSize = DataSizeConversion.convertToDecimalPrefix(DataSizeConversion.decimalPrefixDataSizes.GigaByte, bytes).ToString() + " GB";
                binSize = DataSizeConversion.convertToBinaryPrefix(DataSizeConversion.binaryPrefixDataSizes.GibiByte, bytes).ToString() + " GiB";
            }
            else if (bytes >= 1000000000000)
            {
                decSize = DataSizeConversion.convertToDecimalPrefix(DataSizeConversion.decimalPrefixDataSizes.TeraByte, bytes).ToString() + " TB";
                binSize = DataSizeConversion.convertToBinaryPrefix(DataSizeConversion.binaryPrefixDataSizes.TebiByte, bytes).ToString() + " TiB";
            }

            TB_size.Text = $"{decSize} | {binSize}";
        }
    }
}
