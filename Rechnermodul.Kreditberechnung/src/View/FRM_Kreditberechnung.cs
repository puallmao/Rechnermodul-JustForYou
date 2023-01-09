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
        // default value to calc = Kreditsumme
        public int calcValue = 0;
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
            calcValue = 1;
            input_kreditbetrag.ReadOnly = false;
            input_zinssatz.ReadOnly = false;
            input_laufzeit.ReadOnly = true;
            input_ratenhoehe.ReadOnly = true;
        }

        private void button_creditTimed_Click(object sender, EventArgs e)
        {
            calcValue = 2;
            input_kreditbetrag.ReadOnly = false;
            input_zinssatz.ReadOnly = false;
            input_laufzeit.ReadOnly = false;
            input_ratenhoehe.ReadOnly = true;
        }

        private void button_creditRateAmount_Click(object sender, EventArgs e)
        {
            calcValue = 3;
            input_kreditbetrag.ReadOnly = false;
            input_zinssatz.ReadOnly = false;
            input_laufzeit.ReadOnly = true;
            input_ratenhoehe.ReadOnly = false;
        }

        private void input_kreditbetrag_TextChanged(object sender, EventArgs e)
        {
            // Kredit mit einer Rückzahlung
            if(calcValue == 1) 
            {
                if (!String.IsNullOrEmpty(input_zinssatz.Text))
                {
                    //validate beide Zahlen, zinssatz muss größer als >0 sein
                } 
                else
                {
                    //Errorcode 1: nicht alle nötigen Parameter zur berechnung sind angegeben
                }
            } 
            // Ratenkredit mit angegebener Laufzeit
            else if (calcValue == 2)
            {
                if ((!String.IsNullOrEmpty(input_zinssatz.Text)) && (!String.IsNullOrEmpty(input_laufzeit.Text)))
                {
                    //validate beide Zahlen, zinssatz muss größer als >0 sein
                }
                else
                {
                    //Errorcode 1: nicht alle nötigen Parameter zur berechnung sind angegeben
                }
            }
            // Ratenkredit mit angegebener Ratenhöhe
            else if (calcValue == 3)
            {
                if ((!String.IsNullOrEmpty(input_zinssatz.Text)) && (!String.IsNullOrEmpty(input_ratenhoehe.Text)))
                {
                    //validate beide Zahlen, zinssatz muss größer als >0 sein
                }
                else
                {
                    //Errorcode 1: nicht alle nötigen Parameter zur berechnung sind angegeben
                }
            } 
            // unbekannte/nicht ausgewählte Berechnungsart
            else
            {
                //return "Error: Berechnungsmethode unbekannt oder nicht ausgewählt"
            }
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
