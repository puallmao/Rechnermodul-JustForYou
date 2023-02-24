using System.Windows.Forms;

namespace Rechnermodul.MathematischeFunktionen.View
{
    public partial class FRM_MathematischeFunktionen : Form
    {
        public FRM_MathematischeFunktionen()
        {
            InitializeComponent();
        }

        private void BTN_factorial_Click(object sender, EventArgs e)
        {
            LBL_noFunctionSelected.Visible = false;
            UC_CalculateSqrt.Visible = false;
            UC_CalculatePower.Visible = false;
            UC_CalculatePrimeNumbers.Visible = false;
            UC_CalculateDecimalFraction.Visible = false;
            UC_CalculateFactorial.Visible = true;
        }

        private void BTN_sqrt_Click(object sender, EventArgs e)
        {
            LBL_noFunctionSelected.Visible = false;
            UC_CalculateFactorial.Visible = false;
            UC_CalculatePower.Visible = false;
            UC_CalculatePrimeNumbers.Visible = false;
            UC_CalculateDecimalFraction.Visible = false;
            UC_CalculateSqrt.Visible = true;
        }

        private void BTN_power_Click(object sender, EventArgs e)
        {
            LBL_noFunctionSelected.Visible = false;
            UC_CalculateFactorial.Visible = false;
            UC_CalculateSqrt.Visible = false;
            UC_CalculatePrimeNumbers.Visible = false;
            UC_CalculateDecimalFraction.Visible = false;
            UC_CalculatePower.Visible = true;
        }

        private void BTN_primeNumber_Click(object sender, EventArgs e)
        {
            LBL_noFunctionSelected.Visible = false;
            UC_CalculateFactorial.Visible = false;
            UC_CalculateSqrt.Visible = false;
            UC_CalculatePower.Visible = false;
            UC_CalculateDecimalFraction.Visible = false;
            UC_CalculatePrimeNumbers.Visible = true;
        }

        private void BTN_decimalFraction_Click(object sender, EventArgs e)
        {
            LBL_noFunctionSelected.Visible = false;
            UC_CalculateFactorial.Visible = false;
            UC_CalculateSqrt.Visible = false;
            UC_CalculatePower.Visible = false;
            UC_CalculatePrimeNumbers.Visible = false;
            UC_CalculateDecimalFraction.Visible = true;
        }
    }
}
