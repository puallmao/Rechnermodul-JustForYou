using System.Windows.Forms;

namespace Rechnermodul.Informationstechnik.View
{
    public partial class FRM_Informationstechnik : Form
    {
        private int UCState;
        private Eingabemodul.View.FRM_Eingabemodul eingabemodul;

        public FRM_Informationstechnik()
        {
            InitializeComponent();
        }

        private void FRM_Informationstechnik_Load(object sender, System.EventArgs e)
        {
            UCState = 0;
            eingabemodul = new Eingabemodul.View.FRM_Eingabemodul();
            eingabemodul.EnterEvent += EnterEvent;
            eingabemodul.Show();
        }

        private void FRM_Informationstechnik_FormClosing(object sender, FormClosingEventArgs e)
        {
            LBL_noFunctionSelected.Visible = true;
            UC_FileSizeCalculation.Visible = false;
            UC_DataSizeConversion.Visible = false;
            UC_NumberSystemConversion.Visible = false;

            eingabemodul.Close();
        }

        private void EnterEvent(object sender, string data)
        {
            UserControl userControl = null;
            switch (UCState)
            {
                case 1:
                    userControl = UC_DataSizeConversion;
                    break;
                case 2:
                    userControl = UC_NumberSystemConversion;
                    break;
                case 3:
                    userControl = UC_FileSizeCalculation;
                    break;
            }

            if (userControl == null) return;

            Control control = userControl.ActiveControl;
            if (control is NumericUpDown || control is TextBox)
            {
                control.Text = data;
                if (userControl == UC_FileSizeCalculation)
                {
                    if (control == UC_FileSizeCalculation.NUM_colorDepth) UC_FileSizeCalculation.NUM_imageWidth.Select();
                    if (control == UC_FileSizeCalculation.NUM_imageWidth) UC_FileSizeCalculation.NUM_imageHeight.Select();
                    if (UC_FileSizeCalculation.RB_calcVideo.Checked)
                    {
                        if (control == UC_FileSizeCalculation.NUM_imageHeight) UC_FileSizeCalculation.NUM_framesPerSecond.Select();
                        if (control == UC_FileSizeCalculation.NUM_framesPerSecond) UC_FileSizeCalculation.NUM_videoLength.Select();
                    }
                }
            }
        }

        private void BTN_dataSizeConversion_Click(object sender, System.EventArgs e)
        {
            UCState = 1;
            LBL_noFunctionSelected.Visible = false;
            UC_FileSizeCalculation.Visible = false;
            UC_NumberSystemConversion.Visible = false;
            UC_DataSizeConversion.Visible = true;
        }

        private void BTN_numberSystemConversion_Click(object sender, System.EventArgs e)
        {
            UCState = 2;
            LBL_noFunctionSelected.Visible = false;
            UC_FileSizeCalculation.Visible = false;
            UC_DataSizeConversion.Visible = false;
            UC_NumberSystemConversion.Visible = true;
        }

        private void BTN_fileSizeCalculation_Click(object sender, System.EventArgs e)
        {
            UCState = 3;
            LBL_noFunctionSelected.Visible = false;
            UC_NumberSystemConversion.Visible = false;
            UC_DataSizeConversion.Visible = false;
            UC_FileSizeCalculation.Visible = true;
        }

    }
}
