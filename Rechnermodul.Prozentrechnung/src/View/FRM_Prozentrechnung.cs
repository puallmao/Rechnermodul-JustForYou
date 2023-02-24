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
    public partial class FRM_Prozentrechnung : Form
    {
        public FRM_Prozentrechnung()
        {
            InitializeComponent();
        }

        private void BTN_percentageCalculation1_Click(object sender, EventArgs e)
        {
            LBL_noFunctionSelected.Visible = false;
            UC_PercentageCalculation2.Visible = false;
            UC_PriceCalculation.Visible = false;
            UC_PercentageCalculation1.Visible = true;
        }

        private void BTN_percentageCalculation2_Click(object sender, EventArgs e)
        {
            LBL_noFunctionSelected.Visible = false;
            UC_PercentageCalculation1.Visible = false;
            UC_PriceCalculation.Visible = false;
            UC_PercentageCalculation2.Visible = true;
        }

        private void BTN_priceCalculation_Click(object sender, EventArgs e)
        {
            LBL_noFunctionSelected.Visible = false;
            UC_PercentageCalculation1.Visible = false;
            UC_PercentageCalculation2.Visible = false;
            UC_PriceCalculation.Visible = true;
        }

        private void FRM_Prozentrechnung_FormClosing(object sender, FormClosingEventArgs e)
        {
            LBL_noFunctionSelected.Visible = true;
            UC_PercentageCalculation1.Visible = false;
            UC_PercentageCalculation2.Visible = false;
            UC_PriceCalculation.Visible = false;
        }
    }
}