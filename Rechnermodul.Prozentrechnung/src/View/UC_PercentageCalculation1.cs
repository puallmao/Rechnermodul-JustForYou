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
    public partial class UC_PercentageCalculation1 : UserControl
    {
        public UC_PercentageCalculation1()
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
            decimal percentage = NUM_percentage.Value;

            if (RB_addPercentage.Checked)
                result = PercentageCalculation1.AddPercentage(value, percentage);
            else if (RB_subtractPercentage.Checked)
                result = PercentageCalculation1.SubtractPercentage(value, percentage);
            else
                result = PercentageCalculation1.CalcPercentageValue(value, percentage);

            TB_result.Text = result.ToString();
        }
    }
}
