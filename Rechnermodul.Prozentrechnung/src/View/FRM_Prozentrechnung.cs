using Rechnermodul.Utils.Shared;
using Rechnermodul.Utils.Shared.View;
using System;
using System.Windows.Forms;

namespace Rechnermodul.Prozentrechnung.View
{
    public partial class FRM_Prozentrechnung : Form
    {
        private int UCState;
        private Eingabemodul.View.FRM_Eingabemodul eingabemodul;

        public FRM_Prozentrechnung()
        {
            InitializeComponent();
            SettingsManager.SettingsChanged += SettingsChanged;
            SettingsManager.ApplySettingsToForm(this);
        }

        /// <summary>
        /// Change settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsChanged(object sender, EventArgs e)
        {
            SettingsManager.ApplySettingsToForm(this);
        }

        private void FRM_Prozentrechnung_Load(object sender, EventArgs e)
        {
            UCState = 0;
            // Open eingabemodul
            eingabemodul = new Eingabemodul.View.FRM_Eingabemodul();
            eingabemodul.EnterEvent += EnterEvent;
            eingabemodul.Show();
        }
        private void FRM_Prozentrechnung_FormClosing(object sender, FormClosingEventArgs e)
        {
            LBL_noFunctionSelected.Visible = true;
            UC_PercentageCalculation1.Visible = false;
            UC_PercentageCalculation2.Visible = false;
            UC_PriceCalculation.Visible = false;

            // Close eingabemodul
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
                    userControl = UC_PercentageCalculation1;
                    break;
                case 2:
                    userControl = UC_PercentageCalculation2;
                    break;
                case 3:
                    userControl = UC_PriceCalculation;
                    break;
            }

            if (userControl == null) return;

            Control control = userControl.ActiveControl;
            if (control is NumericUpDown || control is TextBox)
            {
                control.Text = data;
                // Move to the next control
                if (userControl == UC_PercentageCalculation1)
                {
                    if (control == UC_PercentageCalculation1.NUM_baseValue) UC_PercentageCalculation1.NUM_percentage.Select();
                }
                if (userControl == UC_PercentageCalculation2)
                {
                    if (control == UC_PercentageCalculation2.NUM_baseValue) UC_PercentageCalculation2.NUM_percentageValue.Select();
                }
            }
        }

        private void BTN_percentageCalculation1_Click(object sender, EventArgs e)
        {
            UCState = 1;
            LBL_noFunctionSelected.Visible = false;
            UC_PercentageCalculation2.Visible = false;
            UC_PriceCalculation.Visible = false;
            UC_PercentageCalculation1.Visible = true;
        }

        private void BTN_percentageCalculation2_Click(object sender, EventArgs e)
        {
            UCState = 2;
            LBL_noFunctionSelected.Visible = false;
            UC_PercentageCalculation1.Visible = false;
            UC_PriceCalculation.Visible = false;
            UC_PercentageCalculation2.Visible = true;
        }

        private void BTN_priceCalculation_Click(object sender, EventArgs e)
        {
            UCState = 3;
            LBL_noFunctionSelected.Visible = false;
            UC_PercentageCalculation1.Visible = false;
            UC_PercentageCalculation2.Visible = false;
            UC_PriceCalculation.Visible = true;
        }

        private void TSMI_settings_Click(object sender, EventArgs e)
        {
            // Open settings
            FRM_Settings FRM_Settings = new FRM_Settings();
            FRM_Settings.ShowDialog();
        }
    }
}