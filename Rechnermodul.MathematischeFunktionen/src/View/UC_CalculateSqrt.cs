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
    public partial class UC_CalculateSqrt : UserControl
    {
        public UC_CalculateSqrt()
        {
            InitializeComponent();
        }

        private void NUM_value_ValueChanged(object sender, EventArgs e)
        {
            TB_result.Text = Calculation.Sqrt(NUM_value.Value).ToString();
        }
    }
}
