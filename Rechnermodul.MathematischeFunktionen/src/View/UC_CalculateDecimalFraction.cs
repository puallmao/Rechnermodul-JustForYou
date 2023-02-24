using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechnermodul.MathematischeFunktionen.View
{
    public partial class UC_CalculateDecimalFraction : UserControl
    {
        public UC_CalculateDecimalFraction()
        {
            InitializeComponent();
        }

        private void setValue(object sender, EventArgs e)
        {
            if (NUM_denominator.Value == 0) { TB_result.Text = "0"; return; }
            TB_result.Text = (NUM_numerator.Value / NUM_denominator.Value).ToString();
        }
    }
}
