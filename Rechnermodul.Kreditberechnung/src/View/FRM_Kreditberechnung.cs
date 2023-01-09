using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechnermodul.Kreditberechnung.View
{
    public partial class FRM_Kreditberechnung : Form
    {
        public FRM_Kreditberechnung()
        {
            InitializeComponent();
            input_kreditbetrag.ReadOnly = true;
            input_zinssatz.ReadOnly = true;
            input_laufzeit.ReadOnly = true;
            input_ratenhoehe.ReadOnly = true;
        }

        private void button_creditOnePayment_Click(object sender, EventArgs e)
        {
            input_kreditbetrag.ReadOnly = false;
            input_zinssatz.ReadOnly = false;
            input_laufzeit.ReadOnly = true;
            input_ratenhoehe.ReadOnly = true;
        }

        private void button_creditTimed_Click(object sender, EventArgs e)
        {
            input_kreditbetrag.ReadOnly = false;
            input_zinssatz.ReadOnly = false;
            input_laufzeit.ReadOnly = false;
            input_ratenhoehe.ReadOnly = true;
        }

        private void button_creditRateAmount_Click(object sender, EventArgs e)
        {
            input_kreditbetrag.ReadOnly = false;
            input_zinssatz.ReadOnly = false;
            input_laufzeit.ReadOnly = true;
            input_ratenhoehe.ReadOnly = false;
        }

        private void input_kreditbetrag_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_zinssatz_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_laufzeit_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_ratenhoehe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
