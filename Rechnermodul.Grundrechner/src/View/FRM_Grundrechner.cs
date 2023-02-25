using Rechnermodul.Grundrechner.Utils;
using Rechnermodul.Utils.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Rechnermodul.Grundrechner.View
{
    public partial class FRM_Grundrechner : Form, IGrundrechner
    {
        private Eingabemodul.View.FRM_Eingabemodul eingabemodul;

        public FRM_Grundrechner()
        {
            InitializeComponent();
            SettingsManager.SettingsChanged += SettingsChanged;
            SettingsManager.ApplySettingsToForm(this);
        }

        public Form GetForm() { return new FRM_Grundrechner(); }

        private void SettingsChanged(object sender, EventArgs e)
        {
            SettingsManager.ApplySettingsToForm(this);
        }

        private void FRM_Grundrechner_Load(object sender, EventArgs e)
        {
            eingabemodul = new Eingabemodul.View.FRM_Eingabemodul();
            eingabemodul.EnterEvent += EnterEvent;
            eingabemodul.Show();
        }

        private void FRM_Grundrechner_FormClosing(object sender, FormClosingEventArgs e)
        {
            eingabemodul.Close();
        }

        private void EnterEvent(object sender, string data)
        {
            TB_input.Text = data;
        }


        private void BTN_enter_Click(object sender, EventArgs e)
        {
            string result = TB_input.Text;
            string stringEquation = result;

            if (string.IsNullOrEmpty(result)) { MessageBox.Show("Syntax-Error", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                result = result.Replace(" ", "");
                int openParenthesisCount = result.Count(x => x == '(');
                int closedParenthesisCount = result.Count(x => x == '(');

                // Check if equation contains '(' or ')'
                if (result.Contains("(") || result.Contains(")"))
                {
                    // Check if the total amount of opening and closing parenthesis are the same
                    if (openParenthesisCount == closedParenthesisCount)
                    {
                        for (int i = 0; i <= openParenthesisCount; i++)
                        {
                            // Process parenthesis
                            result = BasicCalculation.ProcessParenthesis(result);
                        }
                    }
                    else { MessageBox.Show("Syntax-Error", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { result = BasicCalculation.ProcessStringEquation(BasicCalculation.SplitInput(result)); }

                TB_result.Text = Math4U.Round(decimal.Parse(result), 6).ToString();
                History.AddEntry($"{stringEquation} = {result}");
            }
        }

        private void BTN_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TB_result.Text);           
        }
    }
}
