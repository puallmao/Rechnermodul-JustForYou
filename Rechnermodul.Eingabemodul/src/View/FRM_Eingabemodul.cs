using Rechnermodul.Utils.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Rechnermodul.Eingabemodul.View
{
    public partial class FRM_Eingabemodul : Form
    {
        private char[] signs = { '+', '-', '/', '*' };
        private char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        
        public FRM_Eingabemodul()
        {
            InitializeComponent();
            SettingsManager.SettingsChanged += SettingsChanged;
            SettingsManager.ApplySettingsToForm(this);
        }

        private void SettingsChanged(object sender, EventArgs e)
        {
            SettingsManager.ApplySettingsToForm(this);
        }

        public event EventHandler<string> EnterEvent;

        private void appendCharToInput(char input)
        {
            TB_input.Text = TB_input.Text + input.ToString();
        }

        private void BTN_input0_Click(object sender, EventArgs e)
        {
            string input = TB_input.Text;
            if (input.Length > 0)
            {
                if (input[input.Length - 1] == '0')
                {
                    for (int i = input.Length-1; i >= 0; i--)
                    {
                        if (numbers.Any(x => x == input[i]))
                            break;
                        if (input[i] == ',')
                            break;
                        if (signs.Any(x => x == input[i]))
                            return;
                        if (i == 0)
                            return;
                    }
                }
            }
            appendCharToInput('0');
        }

        private void BTN_input1_Click(object sender, EventArgs e)
        {
            appendCharToInput('1');
        }

        private void BTN_input2_Click(object sender, EventArgs e)
        {
            appendCharToInput('2');
        }

        private void BTN_input3_Click(object sender, EventArgs e)
        {
            appendCharToInput('3');
        }

        private void BTN_input4_Click(object sender, EventArgs e)
        {
            appendCharToInput('4');
        }

        private void BTN_input5_Click(object sender, EventArgs e)
        {
            appendCharToInput('5');
        }

        private void BTN_input6_Click(object sender, EventArgs e)
        {
            appendCharToInput('6');
        }

        private void BTN_input7_Click(object sender, EventArgs e)
        {
            appendCharToInput('7');
        }

        private void BTN_input8_Click(object sender, EventArgs e)
        {
            appendCharToInput('8');
        }

        private void BTN_input9_Click(object sender, EventArgs e)
        {
            appendCharToInput('9');
        }

        private void BTN_inputComma_Click(object sender, EventArgs e)
        {
            string input = TB_input.Text;
            if (input.Length > 0)
            {                
                for (int i = input.Length -1; i > 0; i--)
                {
                    if (input[i] == ',')
                        return;
                    if (signs.Any(x => x == input[i]))
                        break;
                }
                if (!signs.Any(x => x == input[input.Length-1]))
                    appendCharToInput(',');
            }
        }

        private void BTN_inputPlus_Click(object sender, EventArgs e)
        {
            if (TB_input.Text.Length > 0)
            {
                char[] input = TB_input.Text.ToCharArray();
                if (!signs.Any(x => x == input[input.Length - 1]))
                    if (input[TB_input.Text.Length - 1] != '(')
                        appendCharToInput('+');
            }
        }

        private void BTN_inputMinus_Click(object sender, EventArgs e)
        {
            string input = TB_input.Text;
            if (input.Length > 0)
            {
                if (signs.Any(x => x == input[input.Length - 1]))
                    return;

            }
            appendCharToInput('-');
        }

        private void BTN_inputMultiply_Click(object sender, EventArgs e)
        {
            string input = TB_input.Text;
            if (input.Length > 0)
            {
                if (!signs.Any(x => x == input[input.Length - 1]))
                    if (input[TB_input.Text.Length - 1] != '(')
                        appendCharToInput('*');
            }
        }

        private void BTN_inputDivided_Click(object sender, EventArgs e)
        {
            string input = TB_input.Text;
            if (TB_input.Text.Length > 0)
            {
                if (!signs.Any(x => x == input[input.Length - 1]))
                    if (input[TB_input.Text.Length - 1] != '(')
                        appendCharToInput('/');
            }
        }

        private void BTN_inputFlipSign_Click(object sender, EventArgs e)
        {
            char[] input = TB_input.Text.ToCharArray();
            string output = new string(input);
            for (int i = TB_input.Text.Length-1; i >= 0; i--)
            {
                if (i == 0 && input[i] != '-')
                {
                    output = "-" + output;
                    TB_input.Text = output;
                    break;
                }

                if (input[i-1] == '+' || input[i-1] == '-')
                {
                    if (input[i-2] != '(')
                    {
                        output = output.Insert(i, "(-") + ")";
                        TB_input.Text = output;
                        break;
                    }
                    else
                    {
                        if (input[i - 1] == '-')
                        {
                            output = output.Remove(i - 1, 1);
                            TB_input.Text = output;
                            break;
                        }
                        if (input[i - 1] == '+')
                        {
                            output = output.Remove(i - 1, 1);
                            output = output.Insert(i - 1, "-");
                            TB_input.Text = output;
                            break;
                        }
                    }
                }
                else if (input[i-1] == '(')
                {
                    output = output.Insert(i, "-");
                    TB_input.Text = output;
                    break;
                }
            }
        }

        private void BTN_inputReturn_Click(object sender, EventArgs e)
        {
            if (TB_input.Text.Length != 0)
                TB_input.Text = TB_input.Text.Remove(TB_input.Text.Length - 1);
        }

        private void BTN_inputOpeningBracket_Click(object sender, EventArgs e)
        {
            appendCharToInput('(');
        }

        private void BTN_inputClosingBracket_Click(object sender, EventArgs e)
        {
            if (TB_input.Text.Length > 0)
            {
                string input = TB_input.Text;
                int countOpen = input.Count(x => x == '(');
                int countClosed = input.Count(x => x == ')');
                if (countOpen > countClosed)
                    if (input[input.Length-1] != '(')
                        appendCharToInput(')');
            }
        }

        private void BTN_inputClear_Click(object sender, EventArgs e)
        {
            TB_input.Text = String.Empty;
        }

        private void BTN_inputEnter_Click(object sender, EventArgs e)
        {
            EnterEvent(this, this.TB_input.Text);
            TB_input.Text = String.Empty;
        }
        
        private void BTN_inputNR_Click(object sender, EventArgs e)
        {
            Form FRM_Grundrechner = GrundrechnerConnector.Grundrechner.GetForm();
            FRM_Grundrechner.ShowDialog();
        }
    }
}
