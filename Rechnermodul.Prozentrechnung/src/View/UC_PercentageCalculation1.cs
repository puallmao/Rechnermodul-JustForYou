using Rechnermodul.Prozentrechnung.Utils;
using Rechnermodul.Utils.Shared;
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
            if (sender is RadioButton)
            {
                RadioButton control = (RadioButton)sender;
                if (control.Checked)
                    calcResult();
            }
            else
            {
                calcResult();
            }
        }

        private void calcResult()
        {
            decimal result;
            decimal value = NUM_baseValue.Value;
            decimal percentage = NUM_percentage.Value;

            if (RB_addPercentage.Checked)
            {
                result = PercentageCalculation1.AddPercentage(value, percentage);
                History.AddEntry($"{percentage}% zum Grundwert {value} = {result}");
            }
            else if (RB_subtractPercentage.Checked)
            {
                result = PercentageCalculation1.SubtractPercentage(value, percentage);
                History.AddEntry($"{percentage}% weg vom Grundwert {value} = {result}");
            }
            else
            {
                result = PercentageCalculation1.CalcPercentageValue(value, percentage);
                History.AddEntry($"{percentage}% vom Grundwert {value} = {result}");
            }

            TB_result.Text = Math4U.Round(result, 6).ToString();
        }
    }
}
