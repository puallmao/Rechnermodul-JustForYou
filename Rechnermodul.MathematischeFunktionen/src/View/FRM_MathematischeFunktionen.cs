using Rechnermodul.Utils.Shared;
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

        private void SettingsChanged(object sender, EventArgs e)
        {
            SettingsManager.ApplySettingsToForm(this);
        }

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

    }
}
