using Rechnermodul.Utils.Shared;
using Rechnermodul.Utils.Shared.View;
using System;
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
            SettingsManager.SettingsChanged += SettingsChanged;
            SettingsManager.ApplySettingsToForm(this);
        }

        /// <summary>
        /// Change Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsChanged(object sender, EventArgs e)
        {
            SettingsManager.ApplySettingsToForm(this);
        }

        private void FRM_Informationstechnik_Load(object sender, System.EventArgs e)
        {
            UCState = 0;

            // Open Eingabemodul
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

            // Close Eingabemodul
            eingabemodul.Close();
        }

        /// <summary>
        /// Process the Enter Event of the connected Eingabemodul
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
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
                // Move to the next control
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

        private void TSMI_settings_Click(object sender, EventArgs e)
        {
            // Open settings
            FRM_Settings FRM_Settings = new FRM_Settings();
            FRM_Settings.ShowDialog();
        }
    }
}
