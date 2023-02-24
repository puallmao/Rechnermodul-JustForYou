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
    public partial class UC_PriceCalculation : UserControl
    {
        bool blockValueChangedEvents = false;

        public UC_PriceCalculation()
        {
            InitializeComponent();
        }

        private void NUM_nettoValue_ValueChanged(object sender, EventArgs e)
        {
            if (blockValueChangedEvents) return;

            blockValueChangedEvents = true;
            NUM_bruttoValue.Value = PriceCalculation.AddSalesTax(NUM_nettoValue.Value);
            History.AddEntry($"Nettopreis {NUM_nettoValue.Value} zu Bruttopreis {NUM_bruttoValue.Value}");
            blockValueChangedEvents = false;
        }

        private void NUM_bruttoValue_ValueChanged(object sender, EventArgs e)
        {
            if (blockValueChangedEvents) return;

            blockValueChangedEvents = true;
            NUM_nettoValue.Value = PriceCalculation.RemoveSalesTax(NUM_bruttoValue.Value);
            History.AddEntry($"Bruttopreis {NUM_bruttoValue.Value} zu Nettopreis {NUM_nettoValue.Value}");
            blockValueChangedEvents = false;
        }
    }
}
