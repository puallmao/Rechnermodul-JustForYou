using Rechnermodul.Prozentrechnung.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void calcResult()
        {
            decimal result;
            decimal value = NUM_baseValue.Value;
            decimal percentageValue = NUM_percentageValue.Value;

            result = PercentageCalculation2.CalculatePercentage(value, percentageValue);
            TB_result.Text = result.ToString();
        }
    }
}
