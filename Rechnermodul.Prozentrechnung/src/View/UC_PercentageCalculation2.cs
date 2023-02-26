using Rechnermodul.Prozentrechnung.Utils;
using Rechnermodul.Utils.Shared;
using System;
using System.Windows.Forms;

namespace Rechnermodul.Prozentrechnung.View
{
    public partial class UC_PercentageCalculation2 : UserControl
    {
        public UC_PercentageCalculation2()
        {
            InitializeComponent();
        }

        private void setValue(object sender, EventArgs e)
        {
            calcResult();
        }

        /// <summary>
        /// Calculate and set result
        /// </summary>
        private void calcResult()
        {
            decimal result;
            decimal value = NUM_baseValue.Value;
            decimal percentageValue = NUM_percentageValue.Value;

            result = PercentageCalculation2.CalculatePercentage(value, percentageValue);
            History.AddEntry($"{percentageValue} vom Grundwert {value} = {result}%");
            TB_result.Text = Math4U.Round(result, 6).ToString();
        }
    }
}
