using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechnermodul.Grundrechner.View
{
    public partial class FRM_Grundrechner : Form
    {
        public FRM_Grundrechner()
        {
            InitializeComponent();
        }

        private void FRM_Grundrechner_Load(object sender, EventArgs e)
        {

        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            string rechnung = grundrechner_txtbox.Text;
            if (string.IsNullOrEmpty(rechnung))
            {
                MessageBox.Show("Syntax Error", "Pech gehabt2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rechnung = rechnung.Replace(" ", "");
                int openparenthesisCount = rechnung.Count(x => x == '(');
                int closedparenthesisCount = rechnung.Count(x => x == '(');

                //wenn Klammern in String
                if (rechnung.Contains("(") || rechnung.Contains(")"))
                {
                    //wenn Anzahl der Klammern ist gleich
                    if (openparenthesisCount == closedparenthesisCount)
                    {
                        //loopen durch Anzahl der Klammern
                        for (int i = 0; i <= openparenthesisCount; i++)
                        {
                            rechnung = parenthesis(rechnung);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Syntax Error", "Pech gehabt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    rechnung = calculaorCore(splitInput(rechnung));
                }
                grundrechner_txtbox.Text = grundrechner_txtbox.Text + " = " + rechnung;
            }
        }

        public static List<string> splitInput(string input)
        {
            List<string> splitInput = new List<string>();
            int operatorsCount = input.Count(x => x == '*' || x == '/' || x == '+' || x == '-');
            string[] onlyNumbers = input.Split('*', '/', '+', '-');

            //filtern der Operatoren
            for (int i = 0; i <= 10; i++)
            {
                input = input.Replace(i.ToString(), "");
            }

            //weil es mehr Nummern als Operatoren gibt
            if (input.Count() < onlyNumbers.Length)
            {
                //Arrays überlappend Verbinden und in Liste eintragen
                for (int i = 0; i < operatorsCount; i++)
                {
                    splitInput.Add(onlyNumbers.GetValue(i).ToString());
                    splitInput.Add(input[i].ToString());
                }
                //da es mehr Zahlen als Operatoren gibt, muss der Letzte der Liste noch hinzugefuegt werden
                splitInput.Add(onlyNumbers.GetValue(onlyNumbers.Length - 1).ToString());
            }
            else
            {
                MessageBox.Show("Syntax Error", "Pech gehabt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return splitInput;
            ////error handling! wenn nicht gerechnet wird
        }

        public static string calculaorCore(List<string> rechnung)
        {
            try
            {
                //Multiplikation und Division zuerst
                for (int itemIndex = 0; itemIndex < rechnung.Count; itemIndex++)
                {
                    //durch jedes Item loopen und schauen ob Mal oder Durch vorhanden sind
                    if (rechnung[itemIndex].ToString() == "*")
                    {
                        //ersetzen des aktuellen Item Index mit dem Ergebnis der Rechnung
                        rechnung[itemIndex] = (double.Parse(rechnung[itemIndex - 1]) * double.Parse(rechnung[itemIndex + 1])).ToString();
                        //löschen des Items vor dem aktuellen Item Index
                        rechnung.RemoveAt(itemIndex - 1);
                        //löschen des aktuellen Item Index, weil das Ergebnis mit der vorhergehenden Löschung aufgerueckt ist
                        rechnung.RemoveAt(itemIndex);
                        //Index um 1 zurcksetzten weil der aktuelle Item Index durch das Löschen verschoben hat
                        itemIndex--;
                    }
                    else if (rechnung[itemIndex].ToString() == "/")
                    {
                        rechnung[itemIndex] = (double.Parse(rechnung[itemIndex - 1]) / double.Parse(rechnung[itemIndex + 1])).ToString();
                        rechnung.RemoveAt(itemIndex - 1);
                        rechnung.RemoveAt(itemIndex);
                        itemIndex--;
                    }
                }

                //Addition und Subtraktion
                for (int itemIndex = 0; itemIndex < rechnung.Count; itemIndex++)
                {
                    if (rechnung[itemIndex].ToString() == "+")
                    {
                        rechnung[itemIndex] = (double.Parse(rechnung[itemIndex - 1]) + double.Parse(rechnung[itemIndex + 1])).ToString();
                        rechnung.RemoveAt(itemIndex - 1);
                        rechnung.RemoveAt(itemIndex);
                        itemIndex--;
                    }
                    else if (rechnung[itemIndex].ToString() == "-")
                    {
                        rechnung[itemIndex] = (double.Parse(rechnung[itemIndex - 1]) - double.Parse(rechnung[itemIndex + 1])).ToString();
                        rechnung.RemoveAt(itemIndex - 1);
                        rechnung.RemoveAt(itemIndex);
                        itemIndex--;
                    }
                }
                //da rechnung eine Liste mit einem Item ist muss dieses fue die weiterverarbeitung als String zuruek gegeben werden
                return rechnung[0].ToString();
            }
            catch
            {
                return "";
            }
        }

        public static string parenthesis(string rechnung)
        {
            int openingparenthesis = -1;
            int closingparenthesis = -1;

            //durch alle Charakter in String loopen
            for (int i = 0; i < rechnung.Length; i++)
            {
                //schauen ob die Klammer offen ist und ggf. in innere Klammer gehen
                if (rechnung[i] == '(')
                {
                    openingparenthesis = i;
                }
                else if (rechnung[i] == ')')
                {
                    closingparenthesis = i;

                    if (openingparenthesis != -1)
                    {
                        //extrahieren der Rechnung mit Klammern
                        string subStr = rechnung.Substring(openingparenthesis + 1, closingparenthesis - openingparenthesis - 1);
                        //sich selbst aufrufen weil KLammern
                        string output = parenthesis(subStr);
                        //ersetzen der Klammer mit dem Ergebnis des vorhergehenden selbstaufrufs
                        rechnung = rechnung.Remove(openingparenthesis, closingparenthesis - openingparenthesis + 1).Insert(openingparenthesis, output);
                        openingparenthesis = -1;
                    }

                    //test ob das ohne loop oben geht
                    else
                    {
                        rechnung = calculaorCore(splitInput(rechnung));
                    }
                }
            }
            //wenn es keine Klammern gibt rechnen
            if (openingparenthesis == -1 && closingparenthesis == -1)
            {
                rechnung = calculaorCore(splitInput(rechnung));
            }
            return rechnung;
        }
    }
}
