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

        private void SettingsChanged(object sender, EventArgs e)
        {
            SettingsManager.ApplySettingsToForm(this);
        }
        private void FRM_Kreditberechnung_Load(object sender, EventArgs e)
        {
            eingabemodul = new FRM_Eingabemodul();
            eingabemodul.EnterEvent += EnterEvent;
            eingabemodul.Show();
        }

        private void FRM_Kreditberechnung_FormClosing(object sender, FormClosingEventArgs e)
        {
            eingabemodul.Close();
        }

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
            GB_laufzeit.Enabled = true;
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
                // Kredit mit einer Rückzahlung
                decimal testZinssatz;
                if (calcValue == 1)
                {
                    decimal testLaufzeit;
                    if (Decimal.TryParse(TB_zinssatz.Text, out testZinssatz) && Decimal.TryParse(TB_laufzeit.Text, out testLaufzeit) && CreditCalculation.ValidateZinssatz(Convert.ToDecimal(TB_zinssatz.Text)) && CreditCalculation.ValidateLaufzeit(Convert.ToDecimal(TB_laufzeit.Text)))
                    {
                        //validate beide Zahlen, (kreditbetrag + zinssatz) dürfen nur 6 Nachkommastellen haben
                        decimal zinssatz = Math4U.Round(Convert.ToDecimal(TB_zinssatz.Text), 6);
                        decimal kreditbetrag = Math4U.Round(Convert.ToDecimal(TB_kreditbetrag.Text), 2);
                        decimal laufzeit = Math4U.Round(Convert.ToDecimal(TB_laufzeit.Text), 6);

                        //decimal zinsenGes = kreditbetrag * zinssatz / 100;
                        decimal zinsenGes = kreditbetrag * (((zinssatz / 12) / 100) * laufzeit);

                        TB_resultKreditbetrag.Text = Math4U.Round(kreditbetrag, 2).ToString();
                        TB_resultZinssatz.Text = Math4U.Round(zinssatz, 6).ToString();
                        TB_resultRatenhoehe.Text = string.Empty;
                        TB_resultZinsenGesamt.Text = Math4U.Round(zinsenGes, 2).ToString();
                        TB_resultLaufzeit.Text = Math4U.Round(laufzeit, 6).ToString();
                        TB_resultSchlussrate.Text = string.Empty;
                        History.AddEntry($"Kredit mit einer Rückzahlung: Eingaben: (Zinssatz: {Math4U.Round(zinssatz, 6)}, Kreditbetrag: {Math4U.Round(kreditbetrag, 2)}, Laufzeit: {Math4U.Round(laufzeit, 6)}) | Ergebnis: Zinsen Gesamt{Math4U.Round(zinsenGes, 2)}");
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
                        decimal laufzeit = Math4U.Round(Convert.ToDecimal(TB_laufzeit.Text), 6);
                        decimal zinssatz = Math4U.Round(Convert.ToDecimal(TB_zinssatz.Text), 6);
                        decimal kreditbetrag = Math4U.Round(Convert.ToDecimal(TB_kreditbetrag.Text), 2);

                        //decimal zinsenGes = kreditbetrag * zinssatz / 100;
                        decimal zinsenGes = kreditbetrag * (((zinssatz / 12) / 100) * (laufzeit/2));
                        decimal ratenhoehe = (kreditbetrag + zinsenGes) / laufzeit;

                        TB_resultKreditbetrag.Text = Math4U.Round(kreditbetrag, 2).ToString();
                        TB_resultZinssatz.Text = Math4U.Round(zinssatz, 6).ToString();
                        TB_resultRatenhoehe.Text = Math4U.Round(ratenhoehe, 2).ToString();
                        TB_resultZinsenGesamt.Text = Math4U.Round(zinsenGes, 2).ToString();
                        TB_resultLaufzeit.Text = Math4U.Round(laufzeit, 6).ToString();
                        TB_resultSchlussrate.Text = string.Empty;
                        History.AddEntry($"Ratenkredit mit angegebener Laufzeit: Eingaben: (Zinssatz: {Math4U.Round(zinssatz, 6)}, Kreditbetrag: {Math4U.Round(kreditbetrag, 2)}, Laufzeit: {Math4U.Round(laufzeit, 6)}) | Ergebnis: Zinsen Gesamt: {Math4U.Round(zinsenGes, 2)}, Ratenhöhe: {Math4U.Round(ratenhoehe, 2)}");
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
                        decimal ratenhoehe = Math4U.Round(Convert.ToDecimal(TB_ratenhoehe.Text), 2);
                        decimal zinssatz = Math4U.Round(Convert.ToDecimal(TB_zinssatz.Text), 6);
                        decimal kreditbetrag = Math4U.Round(Convert.ToDecimal(TB_kreditbetrag.Text), 2);

                        decimal zinsenGes = kreditbetrag * zinssatz / 100;
                        // muss aufgerundet sein
                        decimal laufzeit = Math4U.Ceiling((kreditbetrag + zinsenGes) / ratenhoehe);
                        decimal schlussrate = kreditbetrag % ratenhoehe;

                        TB_resultKreditbetrag.Text = Math4U.Round(kreditbetrag, 2).ToString();
                        TB_resultZinssatz.Text = Math4U.Round(zinssatz, 6).ToString();
                        TB_resultRatenhoehe.Text = Math4U.Round(ratenhoehe, 2).ToString();
                        TB_resultZinsenGesamt.Text = Math4U.Round(zinsenGes, 2).ToString();
                        TB_resultLaufzeit.Text = Math4U.Round(laufzeit, 6).ToString();
                        TB_resultSchlussrate.Text = Math4U.Round(schlussrate, 2).ToString();
                        History.AddEntry($"Kredit mit angegebener Ratenhöhe: Eingaben: (Zinssatz: {Math4U.Round(zinssatz, 6)}, Kreditbetrag: {Math4U.Round(kreditbetrag, 2)}, Ratenhöhe: {Math4U.Round(ratenhoehe, 2)}) | Ergebnis: Zinsen Gesamt: {Math4U.Round(zinsenGes, 2)}, Laufzeit: {Math4U.Round(laufzeit, 6)}, Schlussrate: {Math4U.Round(schlussrate, 2)}");
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

        private void TSMI_settings_Click(object sender, EventArgs e)
        {
            FRM_Settings FRM_Settings = new FRM_Settings();
            FRM_Settings.ShowDialog();
        }

    }
}
