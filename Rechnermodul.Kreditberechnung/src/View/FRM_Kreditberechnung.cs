using Rechnermodul.Kreditberechnung.Utils;
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
            TB_kreditbetrag.ReadOnly = true;
            TB_zinssatz.ReadOnly = true;
            TB_laufzeit.ReadOnly = true;
            TB_ratenhoehe.ReadOnly = true;
        }

        private void BTN_creditOnePayment_Click(object sender, EventArgs e)
        {
            calcValue = 1;
            TB_kreditbetrag.ReadOnly = false;
            TB_zinssatz.ReadOnly = false;
            TB_laufzeit.ReadOnly = false;
            TB_ratenhoehe.ReadOnly = true;
        }

        private void BTN_creditTimed_Click(object sender, EventArgs e)
        {
            calcValue = 2;
            TB_kreditbetrag.ReadOnly = false;
            TB_zinssatz.ReadOnly = false;
            TB_laufzeit.ReadOnly = false;
            TB_ratenhoehe.ReadOnly = true;
        }

        private void BTN_creditRateAmount_Click(object sender, EventArgs e)
        {
            calcValue = 3;
            TB_kreditbetrag.ReadOnly = false;
            TB_zinssatz.ReadOnly = false;
            TB_laufzeit.ReadOnly = true;
            TB_ratenhoehe.ReadOnly = false;
        }
                
        private void BTN_calc_Click(object sender, EventArgs e)
        {
            decimal testKreditbetragDecimal;

            if (Decimal.TryParse(TB_kreditbetrag.Text, out testKreditbetragDecimal) && CreditCalculation.ValidateKreditbetrag(Convert.ToDecimal(TB_kreditbetrag.Text)))
            {
                // Kredit mit einer Rückzahlung
                decimal testZinssatz;
                if (calcValue == 1)
                {
                    decimal testLaufzeit;
                    if (Decimal.TryParse(TB_zinssatz.Text, out testZinssatz) && Decimal.TryParse(TB_laufzeit.Text, out testLaufzeit) && CreditCalculation.ValidateZinssatz(Convert.ToDecimal(TB_zinssatz.Text)) && CreditCalculation.ValidateLaufzeit(Convert.ToDecimal(TB_laufzeit.Text)))
                    {
                        //validate beide Zahlen, (kreditbetrag + zinssatz) dürfen nur 6 Nachkommastellen haben
                        decimal zinssatz = Convert.ToDecimal(TB_zinssatz.Text);
                        decimal kreditbetrag = Convert.ToDecimal(TB_kreditbetrag.Text);
                        decimal laufzeit = Convert.ToDecimal(TB_laufzeit.Text);

                        //decimal zinsenGes = kreditbetrag * zinssatz / 100;
                        decimal zinsenGes = kreditbetrag * (((zinssatz / 12) / 100) * laufzeit);

                        TB_resultZinssatz.Text = zinssatz.ToString();
                        TB_resultKreditbetrag.Text = kreditbetrag.ToString();
                        TB_resultZinsenGesamt.Text = zinsenGes.ToString();
                        TB_resultLaufzeit.Text = laufzeit.ToString();
                    }
                    else
                    {
                        //Errorcode 1: nicht alle nötigen Parameter zur berechnung sind angegeben
                        MessageBox.Show("Es wurden nicht alle nötigen Parameter zur Berechnung angegeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Ratenkredit mit angegebener Laufzeit
                else if (calcValue == 2)
                {
                    decimal testLaufzeit;
                    if (Decimal.TryParse(TB_zinssatz.Text, out testZinssatz) && Decimal.TryParse(TB_laufzeit.Text, out testLaufzeit) && (CreditCalculation.ValidateZinssatz(Convert.ToDecimal(TB_zinssatz.Text))) && (CreditCalculation.ValidateLaufzeit(Convert.ToDecimal(TB_laufzeit.Text))))
                    {
                        //validate Zahlen, (kreditbetrag + zinssatz + laufzeit) dürfen nur 6 Nachkommastellen haben
                        decimal laufzeit = Convert.ToDecimal(TB_laufzeit.Text);
                        decimal zinssatz = Convert.ToDecimal(TB_zinssatz.Text);
                        decimal kreditbetrag = Convert.ToDecimal(TB_kreditbetrag.Text);

                        //decimal zinsenGes = kreditbetrag * zinssatz / 100;
                        decimal zinsenGes = kreditbetrag * (((zinssatz / 12) / 100) * (laufzeit/2));
                        decimal ratenhoehe = (kreditbetrag + zinsenGes) / laufzeit;

                        TB_resultLaufzeit.Text = laufzeit.ToString();
                        TB_resultZinssatz.Text = zinssatz.ToString();
                        TB_resultKreditbetrag.Text = kreditbetrag.ToString();
                        TB_resultZinsenGesamt.Text = zinsenGes.ToString();
                        TB_resultRatenhoehe.Text = ratenhoehe.ToString();
                    }
                    else
                    {
                        //Errorcode 1: nicht alle nötigen Parameter zur berechnung sind angegeben
                        MessageBox.Show("Es wurden nicht alle nötigen Parameter zur Berechnung angegeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Ratenkredit mit angegebener Ratenhöhe
                else if (calcValue == 3)
                {
                    decimal testRatenhoehe;
                    if (Decimal.TryParse(TB_zinssatz.Text, out testZinssatz) && Decimal.TryParse(TB_ratenhoehe.Text, out testRatenhoehe) && (CreditCalculation.ValidateZinssatz(Convert.ToDecimal(TB_zinssatz.Text))) && (CreditCalculation.ValidateRatenhoehe(Convert.ToDecimal(TB_ratenhoehe.Text))))
                    {
                        //validate Zahlen, (kreditbetrag + zinssatz + ratenhoehe) dürfen nur 6 Nachkommastellen haben
                        decimal ratenhoehe = Convert.ToDecimal(TB_ratenhoehe.Text);
                        decimal zinssatz = Convert.ToDecimal(TB_zinssatz.Text);
                        decimal kreditbetrag = Convert.ToDecimal(TB_kreditbetrag.Text);

                        decimal zinsenGes = kreditbetrag * zinssatz / 100;
                        // muss aufgerundet sein
                        decimal laufzeit = Math.Ceiling((kreditbetrag + zinsenGes) / ratenhoehe);
                        decimal schlussrate = kreditbetrag % ratenhoehe;

                        TB_resultRatenhoehe.Text = ratenhoehe.ToString();
                        TB_resultZinssatz.Text = zinssatz.ToString();
                        TB_resultKreditbetrag.Text = kreditbetrag.ToString();
                        TB_resultZinsenGesamt.Text = zinsenGes.ToString();
                        TB_resultLaufzeit.Text = laufzeit.ToString();
                        TB_resultSchlussrate.Text = schlussrate.ToString();
                    }
                    else
                    {
                        //Errorcode 1: nicht alle nötigen Parameter zur berechnung sind angegeben
                        MessageBox.Show("Es wurden nicht alle nötigen Parameter zur Berechnung angegeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // unbekannte/nicht ausgewählte Berechnungsart
                else
                {
                    //return "Error: Berechnungsmethode unbekannt oder nicht ausgewählt"
                    MessageBox.Show("Berechnungsmethode unbekannt oder nicht ausgewählt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // kreditbetrag invalid
                MessageBox.Show("Kreditbetrag fehlerhaft", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
