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
    public partial class UC_PriceCalculation : UserControl
    {
        public UC_PriceCalculation()
        {
            InitializeComponent();
        }

        private void NUM_nettoValue_ValueChanged(object sender, EventArgs e)
        {
            NUM_bruttoValue.Value = PriceCalculation.AddSalesTax(NUM_nettoValue.Value);
        }

        private void NUM_bruttoValue_ValueChanged(object sender, EventArgs e)
        {
            NUM_nettoValue.Value = PriceCalculation.RemoveSalesTax(NUM_bruttoValue.Value);
        }
    }
}
