using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechnermodul.Grundrechner.Utils
{
    public static class BasicCalculation
    {
        /// <summary>
        /// Split the input of a String Equation
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<string> SplitInput(string input)
        {
            List<string> splitInput = new List<string>();
            char[] signs = { '+', '-', '/', '*' };
            int signsCount = input.Count(x => signs.Any(y => y == x));
            string[] onlyNumbers = input.Split(signs);

            // Filter signs
            char[] replaceableChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',', '.' };
            foreach (char c in replaceableChars)
            {
                input = input.Replace(c.ToString(), "");
            }
            
            // Check if there are more numbers than signs.
            if (input.Count() < onlyNumbers.Length)
            {
                for (int i = 0; i < signsCount; i++)
                {
                    splitInput.Add(onlyNumbers.GetValue(i).ToString());
                    splitInput.Add(input[i].ToString());
                }
                splitInput.Add(onlyNumbers.GetValue(onlyNumbers.Length - 1).ToString());
            }
            else
            {
                MessageBox.Show("Syntax-Fehler", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return splitInput;
        }

        /// <summary>
        /// Process a String Eqaution
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ProcessStringEquation(List<string> input)
        {
            try
            {
                // Mutlitplication and dividing
                for (int i = 0; i < input.Count; i++)
                {
                    string c = input[i];
                    if (c == "*")
                    {
                        // Replace the Item @ Index i with the result of the calculation
                        input[i] = (double.Parse(input[i - 1]) * double.Parse(input[i + 1])).ToString();

                        // Delete Item @ Index - 1 (Items are shifted to the right)
                        // Delete current Item and set the correct index
                        input.RemoveAt(i - 1);
                        input.RemoveAt(i);
                        i--;
                    }
                    else if (c == "/")
                    {
                        input[i] = (double.Parse(input[i - 1]) / double.Parse(input[i + 1])).ToString();
                        input.RemoveAt(i - 1);
                        input.RemoveAt(i);
                        i--;
                    }
                }

                // Addition and subtraction
                for (int i = 0; i < input.Count; i++)
                {
                    string c = input[i];
                    if (c == "+")
                    {
                        // Replace the Item @ Index i with the result of the calculation
                        input[i] = (double.Parse(input[i - 1]) + double.Parse(input[i + 1])).ToString();

                        // Delete Item @ Index - 1 (Items are shifted to the right)
                        // Delete current Item and set the correct index
                        input.RemoveAt(i - 1);
                        input.RemoveAt(i);
                        i--;
                    }
                    else if (c == "-")
                    {
                        input[i] = (double.Parse(input[i - 1]) - double.Parse(input[i + 1])).ToString();
                        input.RemoveAt(i - 1);
                        input.RemoveAt(i);
                        i--;
                    }
                }
                return input[0].ToString();
            }
            catch { return ""; }
        }

        /// <summary>
        /// Process Parenthesis in a String Equation
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ProcessParenthesis(string input)
        {
            int openingParenthesis = -1;
            int closingParenthesis = -1;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c == '(')
                {
                    // Set the index of c to the last read opening Parenthesis.
                    openingParenthesis = i;
                }
                else if (c == ')')
                {
                    // Set the index of c to the last read closing Parenthesis.
                    closingParenthesis = i;
                    if (openingParenthesis != -1)
                    {
                        // Get content between the both Parenthesis and process it
                        string subStr = input.Substring(openingParenthesis + 1, closingParenthesis - openingParenthesis - 1);
                        string output = ProcessParenthesis(subStr);

                        // Replace the Parentheses with the output
                        input = input.Remove(openingParenthesis, closingParenthesis - openingParenthesis + 1).Insert(openingParenthesis, output);
                        openingParenthesis = -1;
                    }
                    else
                    {
                        input = ProcessStringEquation(SplitInput(input));
                    }
                }
            }

            // Calculate
            if (openingParenthesis == -1 && closingParenthesis == -1)
            {
                input = ProcessStringEquation(SplitInput(input));
            }

            return input;
        }
    }
}
