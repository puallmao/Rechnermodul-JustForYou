using Rechnermodul.MathematischeFunktionen.Utils;
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
    public partial class UC_CalculatePower : UserControl
    {
        public UC_CalculatePower()
        {
            InitializeComponent();
        }

        private void setValue(object sender, EventArgs e)
        {
            TB_result.Text = Calculation.Power(NUM_base.Value, NUM_exponent.Value).ToString();
        }
    }
}
