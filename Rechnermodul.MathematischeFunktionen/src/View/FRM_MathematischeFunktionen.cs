using Rechnermodul.Utils.Shared;
using Rechnermodul.Utils.Shared.View;
using System;
using System.Windows.Forms;

namespace Rechnermodul.MathematischeFunktionen.View
{
    public partial class FRM_MathematischeFunktionen : Form
    {
        private int UCState;
        private Eingabemodul.View.FRM_Eingabemodul eingabemodul;

        public FRM_MathematischeFunktionen()
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
                    userControl = UC_CalculateFactorial;
                    break;
                case 2:
                    userControl = UC_CalculateSqrt;
                    break;
                case 3:
                    userControl = UC_CalculatePower;
                    break;
                case 4:
                    userControl = UC_CalculatePrimeNumbers;
                    break;
                case 5:
                    userControl = UC_CalculateDecimalFraction;
                    break;
            }

            if (userControl == null) return;

            Control control = userControl.ActiveControl;
            if (control is NumericUpDown || control is TextBox)
            {
                control.Text = data;
                // Move to the next control
                if (userControl == UC_CalculatePower)
                {
                    if (control == UC_CalculatePower.NUM_base) UC_CalculatePower.NUM_exponent.Select();
                }
                if (userControl == UC_CalculatePrimeNumbers)
                {
                    if (control == UC_CalculatePrimeNumbers.NUM_rangeFrom) UC_CalculatePrimeNumbers.NUM_rangeTo.Select();
                }
                if (userControl == UC_CalculateDecimalFraction)
                {
                    if (control == UC_CalculateDecimalFraction.NUM_numerator) UC_CalculateDecimalFraction.NUM_denominator.Select();
                }
            }
        }

        private void FRM_MathematischeFunktionen_Load(object sender, EventArgs e)
        {
            UCState = 0;
            eingabemodul = new Eingabemodul.View.FRM_Eingabemodul();
            eingabemodul.EnterEvent += EnterEvent;
            eingabemodul.Show();
        }
        private void FRM_MathematischeFunktionen_FormClosing(object sender, FormClosingEventArgs e)
        {
            LBL_noFunctionSelected.Visible = true;
            UC_CalculateSqrt.Visible = false;
            UC_CalculatePower.Visible = false;
            UC_CalculatePrimeNumbers.Visible = false;
            UC_CalculateDecimalFraction.Visible = false;
            UC_CalculateFactorial.Visible = false;

            // Close eingabemodul
            eingabemodul.Close();
        }

        private void BTN_factorial_Click(object sender, EventArgs e)
        {
            UCState = 1;
            LBL_noFunctionSelected.Visible = false;
            UC_CalculateSqrt.Visible = false;
            UC_CalculatePower.Visible = false;
            UC_CalculatePrimeNumbers.Visible = false;
            UC_CalculateDecimalFraction.Visible = false;
            UC_CalculateFactorial.Visible = true;
        }

        private void BTN_sqrt_Click(object sender, EventArgs e)
        {
            UCState = 2;
            LBL_noFunctionSelected.Visible = false;
            UC_CalculateFactorial.Visible = false;
            UC_CalculatePower.Visible = false;
            UC_CalculatePrimeNumbers.Visible = false;
            UC_CalculateDecimalFraction.Visible = false;
            UC_CalculateSqrt.Visible = true;
        }

        private void BTN_power_Click(object sender, EventArgs e)
        {
            UCState = 3;
            LBL_noFunctionSelected.Visible = false;
            UC_CalculateFactorial.Visible = false;
            UC_CalculateSqrt.Visible = false;
            UC_CalculatePrimeNumbers.Visible = false;
            UC_CalculateDecimalFraction.Visible = false;
            UC_CalculatePower.Visible = true;
        }

        private void BTN_primeNumber_Click(object sender, EventArgs e)
        {
            UCState = 4;
            LBL_noFunctionSelected.Visible = false;
            UC_CalculateFactorial.Visible = false;
            UC_CalculateSqrt.Visible = false;
            UC_CalculatePower.Visible = false;
            UC_CalculateDecimalFraction.Visible = false;
            UC_CalculatePrimeNumbers.Visible = true;
        }

        private void BTN_decimalFraction_Click(object sender, EventArgs e)
        {
            UCState = 5;
            LBL_noFunctionSelected.Visible = false;
            UC_CalculateFactorial.Visible = false;
            UC_CalculateSqrt.Visible = false;
            UC_CalculatePower.Visible = false;
            UC_CalculatePrimeNumbers.Visible = false;
            UC_CalculateDecimalFraction.Visible = true;
        }

        private void TSMI_settings_Click(object sender, EventArgs e)
        {
            // Open settings
            FRM_Settings FRM_Settings = new FRM_Settings();
            FRM_Settings.ShowDialog();
        }
    }
}
