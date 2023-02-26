using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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

        private bool validZinssatz(decimal zinssatz = 0)
        {
            // Zinssatz muss zwischen 0% und 100% liegen
            if (zinssatz <= 0 && zinssatz > 100)
            {
                // Create Message box - FEHLER
                return false;
            }
            return true;
        }

        private bool validRatenhoehe(decimal ratenhoehe = 0)
        {
            if (ratenhoehe <= 0)
            {
                // Create Message box - FEHLER
                return false;
            }
            return true;
        }
        private bool validLaufzeit(decimal laufzeit = 0)
        {
            // laufzeit hat keine Nachkommastellen, sind nur volle monate
            if (laufzeit <= 0 || laufzeit != Convert.ToDecimal(Convert.ToInt64(laufzeit)))
            {
                // Create Message box - FEHLER
                return false;
            }
            return true;
        }

        private bool validkreditbetrag(decimal kreditbetrag)
        {
            if (kreditbetrag > 0)
            {
                return true;
            }
            return false;
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            decimal testKreditbetragDecimal;

            if (Decimal.TryParse(input_kreditbetrag.Text, out testKreditbetragDecimal) && validkreditbetrag(Convert.ToDecimal(input_kreditbetrag.Text)))
            {
                // Kredit mit einer Rückzahlung
                decimal testZinssatz;
                if (calcValue == 1)
                {
                    if (Decimal.TryParse(input_zinssatz.Text, out testZinssatz) && validZinssatz(Convert.ToDecimal(input_zinssatz.Text)))
                    {
                        //validate beide Zahlen, (kreditbetrag + zinssatz) dürfen nur 6 Nachkommastellen haben
                        decimal zinssatz = Convert.ToDecimal(input_zinssatz.Text);
                        decimal kreditbetrag = Convert.ToDecimal(input_kreditbetrag.Text);

                        decimal zinsenGes = kreditbetrag * zinssatz / 100;
                    }
                    else
                    {
                        //Errorcode 1: nicht alle nötigen Parameter zur berechnung sind angegeben
                    }
                }
                // Ratenkredit mit angegebener Laufzeit
                else if (calcValue == 2)
                {
                    decimal testLaufzeit;
                    if (Decimal.TryParse(input_zinssatz.Text, out testZinssatz) && Decimal.TryParse(input_laufzeit.Text, out testLaufzeit) && (validZinssatz(Convert.ToDecimal(input_zinssatz.Text))) && (validLaufzeit(Convert.ToDecimal(input_laufzeit.Text))))
                    {
                        //validate Zahlen, (kreditbetrag + zinssatz + laufzeit) dürfen nur 6 Nachkommastellen haben
                        decimal laufzeit = Convert.ToDecimal(input_laufzeit.Text);
                        decimal zinssatz = Convert.ToDecimal(input_zinssatz.Text);
                        decimal kreditbetrag = Convert.ToDecimal(input_kreditbetrag.Text);

                        decimal zinsenGes = kreditbetrag * zinssatz / 100;
                        decimal ratenhoehe = (kreditbetrag + zinsenGes) / laufzeit;

                    }
                    else
                    {
                        //Errorcode 1: nicht alle nötigen Parameter zur berechnung sind angegeben
                    }
                }
                // Ratenkredit mit angegebener Ratenhöhe
                else if (calcValue == 3)
                {
                    decimal testRatenhoehe;
                    if (Decimal.TryParse(input_zinssatz.Text, out testZinssatz) && Decimal.TryParse(input_ratenhoehe.Text, out testRatenhoehe) && (validZinssatz(Convert.ToDecimal(input_zinssatz.Text))) && (validRatenhoehe(Convert.ToDecimal(input_ratenhoehe.Text))))
                    {
                        //validate Zahlen, (kreditbetrag + zinssatz + ratenhoehe) dürfen nur 6 Nachkommastellen haben
                        decimal ratenhoehe = Convert.ToDecimal(input_ratenhoehe.Text);
                        decimal zinssatz = Convert.ToDecimal(input_zinssatz.Text);
                        decimal kreditbetrag = Convert.ToDecimal(input_kreditbetrag.Text);

                        decimal zinsenGes = kreditbetrag * zinssatz / 100;
                        // muss aufgerundet sein
                        decimal laufzeit = Math.Ceiling((kreditbetrag + zinsenGes) / ratenhoehe);
                        decimal schlussrate = kreditbetrag % ratenhoehe;

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
            else
            {
                // kreditbetrag invalid
            }
        }
    }
}
