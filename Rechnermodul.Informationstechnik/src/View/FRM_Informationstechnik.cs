using System.Windows.Forms;

namespace Rechnermodul.Informationstechnik.View
{
    public partial class FRM_Informationstechnik : Form
    {
        public FRM_Informationstechnik()
        {
            InitializeComponent();
        }

        private void BTN_dataSizeConversion_Click(object sender, System.EventArgs e)
        {
            LBL_noFunctionSelected.Visible = false;
            UC_FileSizeCalculation.Visible = false;
            UC_NumberSystemConversion.Visible = false;
            UC_DataSizeConversion.Visible = true;
        }

        private void BTN_numberSystemConversion_Click(object sender, System.EventArgs e)
        {
            LBL_noFunctionSelected.Visible = false;
            UC_FileSizeCalculation.Visible = false;
            UC_DataSizeConversion.Visible = false;
            UC_NumberSystemConversion.Visible = true;
        }

        private void BTN_fileSizeCalculation_Click(object sender, System.EventArgs e)
        {
            LBL_noFunctionSelected.Visible = false;
            UC_NumberSystemConversion.Visible = false;
            UC_DataSizeConversion.Visible = false;
            UC_FileSizeCalculation.Visible = true;
        }
    }
}
