using Rechnermodul.Eingabemodul.View;
using Rechnermodul.Kreditberechnung.Utils;
using Rechnermodul.Utils.Shared;
using Rechnermodul.Utils.Shared.View;
using System;
using System.Windows.Forms;

namespace Rechnermodul.Kreditberechnung.View
{
    public partial class FRM_Kreditberechnung : Form
    {
        public int calcValue = 0;
        private FRM_Eingabemodul eingabemodul;

        public FRM_Kreditberechnung()
        {
            InitializeComponent();
            SettingsManager.SettingsChanged += SettingsChanged;
            SettingsManager.ApplySettingsToForm(this);
            GB_kreditbetrag.Enabled = true;
            GB_zinssatz.Enabled = true;
            GB_laufzeit.Enabled = true;
            GB_ratenhoehe.Enabled = true;
        }

        /// <summary>
        /// Change settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsChanged(object sender, EventArgs e)
        {
            SettingsManager.ApplySettingsToForm(this);
        }

        private void FRM_Kreditberechnung_Load(object sender, EventArgs e)
        {
            // Open eingabemodul
            eingabemodul = new FRM_Eingabemodul();
            eingabemodul.EnterEvent += EnterEvent;
            eingabemodul.Show();
        }

        private void FRM_Kreditberechnung_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close eingabemodul
            eingabemodul.Close();
        }

        /// <summary>
        /// Process the Enter Event of the connected Eingabemodul
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        private void EnterEvent(object sender, string data)
        {
            Control control = this.ActiveControl;
            if (control is NumericUpDown || control is TextBox)
            {
                control.Text = data;
                if (control == TB_kreditbetrag) TB_zinssatz.Select();
                if (calcValue != 3)
                    if (control == TB_zinssatz) TB_laufzeit.Select();
                if (calcValue == 3)
                    if (control == TB_zinssatz) TB_ratenhoehe.Select();
            }
        }

        private void BTN_creditOnePayment_Click(object sender, EventArgs e)
        {
            calcValue = 1;
            GB_kreditbetrag.Enabled = true;
            GB_zinssatz.Enabled = true;
            GB_laufzeit.Enabled = false;
            GB_ratenhoehe.Enabled = false;
        }

        private void BTN_creditTimed_Click(object sender, EventArgs e)
        {
            calcValue = 2;
            GB_kreditbetrag.Enabled = true;
            GB_zinssatz.Enabled = true;
            GB_laufzeit.Enabled = true;
            GB_ratenhoehe.Enabled = false;
        }

        private void BTN_creditRateAmount_Click(object sender, EventArgs e)
        {
            calcValue = 3;
            GB_kreditbetrag.Enabled = true;
            GB_zinssatz.Enabled = true;
            GB_laufzeit.Enabled = false;
            GB_ratenhoehe.Enabled = true;
        }

        private void BTN_calc_Click(object sender, EventArgs e)
        {
            decimal testKreditbetragDecimal;

            if (Decimal.TryParse(TB_kreditbetrag.Text, out testKreditbetragDecimal) && CreditCalculation.ValidateKreditbetrag(Convert.ToDecimal(TB_kreditbetrag.Text)))
            {
                // Kredit mit einer R??ckzahlung
                decimal testZinssatz;
                if (calcValue == 1)
                {
                    decimal testLaufzeit;
                    if (Decimal.TryParse(TB_zinssatz.Text, out testZinssatz) && CreditCalculation.ValidateZinssatz(Convert.ToDecimal(TB_zinssatz.Text)))
                    {
                        //validate beide Zahlen, (kreditbetrag + zinssatz) d??rfen nur 6 Nachkommastellen haben
                        decimal zinssatz = Math4U.Round(Convert.ToDecimal(TB_zinssatz.Text), 6);
                        decimal kreditbetrag = Math4U.Round(Convert.ToDecimal(TB_kreditbetrag.Text), 2);

                        //decimal zinsenGes = kreditbetrag * zinssatz / 100;
                        decimal zinsenGes = kreditbetrag * (zinssatz / 100);

                        TB_resultKreditbetrag.Text = Math4U.Round(kreditbetrag, 2).ToString();
                        TB_resultZinssatz.Text = Math4U.Round(zinssatz, 6).ToString();
                        TB_resultRatenhoehe.Text = string.Empty;
                        TB_resultZinsenGesamt.Text = Math4U.Round(zinsenGes, 2).ToString();
                        TB_resultLaufzeit.Text = string.Empty;
                        TB_resultSchlussrate.Text = string.Empty;
                        History.AddEntry($"Kredit mit einer R??ckzahlung: Eingaben: (Zinssatz: {Math4U.Round(zinssatz, 6)}, Kreditbetrag: {Math4U.Round(kreditbetrag, 2)} | Ergebnis: Zinsen Gesamt{Math4U.Round(zinsenGes, 2)}");
                    }
                    else
                    {
                        //Errorcode 1: nicht alle n??tigen Parameter zur berechnung sind angegeben
                        MessageBox.Show("Es wurden nicht alle n??tigen Parameter zur Berechnung angegeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Ratenkredit mit angegebener Laufzeit
                else if (calcValue == 2)
                {
                    decimal testLaufzeit;
                    if (Decimal.TryParse(TB_zinssatz.Text, out testZinssatz) && Decimal.TryParse(TB_laufzeit.Text, out testLaufzeit) && (CreditCalculation.ValidateZinssatz(Convert.ToDecimal(TB_zinssatz.Text))) && (CreditCalculation.ValidateLaufzeit(Convert.ToDecimal(TB_laufzeit.Text))))
                    {
                        //validate Zahlen, (kreditbetrag + zinssatz + laufzeit) d??rfen nur 6 Nachkommastellen haben
                        decimal laufzeit = Math4U.Round(Convert.ToDecimal(TB_laufzeit.Text), 6);
                        decimal zinssatz = Math4U.Round(Convert.ToDecimal(TB_zinssatz.Text), 6);
                        decimal kreditbetrag = Math4U.Round(Convert.ToDecimal(TB_kreditbetrag.Text), 2);

                        // calc factor (zs per annual)
                        decimal faktor = 0;
                        for (int i = 1; i <= laufzeit; i++)
                        {
                            faktor = faktor + i;
                        }
                        faktor = faktor / laufzeit;

                        // decimal zinsenGes = kreditbetrag * zinssatz / 100;
                        decimal zinsenGes = kreditbetrag * (((zinssatz / 12) / 100) * faktor);
                        decimal ratenhoehe = (kreditbetrag + zinsenGes) / laufzeit;

                        TB_resultKreditbetrag.Text = Math4U.Round(kreditbetrag, 2).ToString();
                        TB_resultZinssatz.Text = Math4U.Round(zinssatz, 6).ToString();
                        TB_resultRatenhoehe.Text = Math4U.Round(ratenhoehe, 2).ToString();
                        TB_resultZinsenGesamt.Text = Math4U.Round(zinsenGes, 2).ToString();
                        TB_resultLaufzeit.Text = Math4U.Round(laufzeit, 6).ToString();
                        TB_resultSchlussrate.Text = string.Empty;
                        History.AddEntry($"Ratenkredit mit angegebener Laufzeit: Eingaben: (Zinssatz: {Math4U.Round(zinssatz, 6)}, Kreditbetrag: {Math4U.Round(kreditbetrag, 2)}, Laufzeit: {Math4U.Round(laufzeit, 6)}) | Ergebnis: Zinsen Gesamt: {Math4U.Round(zinsenGes, 2)}, Ratenh??he: {Math4U.Round(ratenhoehe, 2)}");
                    }
                    else
                    {
                        //Errorcode 1: nicht alle n??tigen Parameter zur berechnung sind angegeben
                        MessageBox.Show("Es wurden nicht alle n??tigen Parameter zur Berechnung angegeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Ratenkredit mit angegebener Ratenh??he
                else if (calcValue == 3)
                {
                    decimal testRatenhoehe;
                    if (Decimal.TryParse(TB_zinssatz.Text, out testZinssatz) && Decimal.TryParse(TB_ratenhoehe.Text, out testRatenhoehe) && (CreditCalculation.ValidateZinssatz(Convert.ToDecimal(TB_zinssatz.Text))) && (CreditCalculation.ValidateRatenhoehe(Convert.ToDecimal(TB_ratenhoehe.Text))))
                    {
                        //validate Zahlen, (kreditbetrag + zinssatz + ratenhoehe) d??rfen nur 6 Nachkommastellen haben
                        decimal ratenhoehe = Math4U.Round(Convert.ToDecimal(TB_ratenhoehe.Text), 2);
                        decimal zinssatz = Math4U.Round(Convert.ToDecimal(TB_zinssatz.Text), 6);
                        decimal kreditbetrag = Math4U.Round(Convert.ToDecimal(TB_kreditbetrag.Text), 2);

                        decimal laufzeit = kreditbetrag / ratenhoehe;
                        laufzeit = Math4U.Ceiling(laufzeit);
                        //???Ceiling???  gibt die n??chstm??gliche Ganzzahl wieder z.B. 7.03 ??8

                        // calc factor (zs per annual)
                        decimal faktor = 0;
                        for (int i = 1; i <= laufzeit; i++)
                        {
                            faktor = faktor + i;
                        }
                        faktor = faktor / laufzeit;

                        // decimal zinsenGes = kreditbetrag * zinssatz / 100;
                        decimal zinsenGes = kreditbetrag * (((zinssatz / 12) / 100) * faktor);
                        laufzeit = Math4U.Ceiling((kreditbetrag + zinsenGes) / ratenhoehe);
                        decimal schlussrate = (kreditbetrag + zinsenGes) - (laufzeit - 1) * ratenhoehe;

                        TB_resultKreditbetrag.Text = Math4U.Round(kreditbetrag, 2).ToString();
                        TB_resultZinssatz.Text = Math4U.Round(zinssatz, 6).ToString();
                        TB_resultRatenhoehe.Text = Math4U.Round(ratenhoehe, 2).ToString();
                        TB_resultZinsenGesamt.Text = Math4U.Round(zinsenGes, 2).ToString();
                        TB_resultLaufzeit.Text = Math4U.Round(laufzeit, 6).ToString();
                        TB_resultSchlussrate.Text = Math4U.Round(schlussrate, 2).ToString();
                        History.AddEntry($"Kredit mit angegebener Ratenh??he: Eingaben: (Zinssatz: {Math4U.Round(zinssatz, 6)}, Kreditbetrag: {Math4U.Round(kreditbetrag, 2)}, Ratenh??he: {Math4U.Round(ratenhoehe, 2)}) | Ergebnis: Zinsen Gesamt: {Math4U.Round(zinsenGes, 2)}, Laufzeit: {Math4U.Round(laufzeit, 6)}, Schlussrate: {Math4U.Round(schlussrate, 2)}");
                    }
                    else
                    {
                        //Errorcode 1: nicht alle n??tigen Parameter zur berechnung sind angegeben
                        MessageBox.Show("Es wurden nicht alle n??tigen Parameter zur Berechnung angegeben", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // unbekannte/nicht ausgew??hlte Berechnungsart
                else
                {
                    //return "Error: Berechnungsmethode unbekannt oder nicht ausgew??hlt"
                    MessageBox.Show("Berechnungsmethode unbekannt oder nicht ausgew??hlt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // kreditbetrag invalid
                MessageBox.Show("Kreditbetrag fehlerhaft", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TSMI_settings_Click(object sender, EventArgs e)
        {
            // Open settings
            FRM_Settings FRM_Settings = new FRM_Settings();
            FRM_Settings.ShowDialog();
        }
    }
}
