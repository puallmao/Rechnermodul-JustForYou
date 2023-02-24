using Rechnermodul.Grundrechner.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Rechnermodul.Grundrechner.View
{
    public partial class FRM_Grundrechner : Form
    {
        public FRM_Grundrechner()
        {
            InitializeComponent();
        }

        public event EventHandler<string> CopyEvent;

        private void BTN_enter_Click(object sender, EventArgs e)
        {
            string equation = TB_input.Text;
            if (string.IsNullOrEmpty(equation)) { MessageBox.Show("Syntax-Error", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                equation = equation.Replace(" ", "");
                int openParenthesisCount = equation.Count(x => x == '(');
                int closedParenthesisCount = equation.Count(x => x == '(');

                // Check if equation contains '(' or ')'
                if (equation.Contains("(") || equation.Contains(")"))
                {
                    // Check if the total amount of opening and closing parenthesis are the same
                    if (openParenthesisCount == closedParenthesisCount)
                    {
                        for (int i = 0; i <= openParenthesisCount; i++)
                        {
                            // Process parenthesis
                            equation = BasicCalculation.ProcessParenthesis(equation);
                        }
                    }
                    else { MessageBox.Show("Syntax-Error", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { equation = BasicCalculation.ProcessStringEquation(BasicCalculation.SplitInput(equation)); }
                TB_result.Text = equation;
            }
        }

        private void BTN_copy_Click(object sender, EventArgs e)
        {
            if (CopyEvent == null) { Clipboard.SetText(TB_result.Text); }
            else { try { CopyEvent(this, TB_result.Text); } catch { } }
        }
    }
}
