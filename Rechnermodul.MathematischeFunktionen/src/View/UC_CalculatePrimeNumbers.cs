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
    public partial class UC_CalculatePrimeNumbers : UserControl
    {
        public UC_CalculatePrimeNumbers()
        {
            InitializeComponent();
        }

        private void setValue(object sender, EventArgs e)
        {
            TB_result.Text = string.Join(", ", Calculation.PrimeNumbers((uint)NUM_rangeFrom.Value, (uint)NUM_rangeTo.Value));
        }
    }
}
