using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechnermodul.MathematischeFunktionen.View
{
    public partial class FRM_MathematischeFunktionen : Form
    {
        enum Rechenfunktion
        {
            Fakultät,
            Wurzel,
            Potenz,
            Primzahlen,
            Dezimabruch
        };
        Rechenfunktion funktion;

        public FRM_MathematischeFunktionen()
        {
            InitializeComponent();
        }

        private void FRM_MathematischeFunktionen_Load(object sender, EventArgs e)
        {

        }

        // Buttons
        private void enter_btn_Click(object sender, EventArgs e)
        {
            string rechnung = input_txtbx.Text;
            string ergebnis = "";
            switch (funktion)
            {
                case Rechenfunktion.Fakultät:
                    fakultätBerechnen(rechnung, ref ergebnis);
                    input_txtbx.Text = rechnung + " = " + ergebnis;
                    break;
                case Rechenfunktion.Wurzel:
                    wurzelBerechnen(rechnung, ref ergebnis);
                    input_txtbx.Text = rechnung + " = " + ergebnis;
                    break;
                case Rechenfunktion.Potenz:
                    potenzBerechnen(rechnung, ref ergebnis);
                    input_txtbx.Text = rechnung + " = " + ergebnis;
                    break;
                case Rechenfunktion.Primzahlen:
                    primzahlenBerechnen(int.Parse(rechnung), ref ergebnis);
                    input_txtbx.Text = rechnung + " = " + ergebnis;
                    break;
                case Rechenfunktion.Dezimabruch:
                    dezimalbruchBerechnen(rechnung, ref ergebnis);
                    input_txtbx.Text = rechnung + " = " + ergebnis;
                    break;
            }
        }

        private void fak_btn_Click(object sender, EventArgs e)
        {
            input_txtbx.Text = input_txtbx.Text + "!";
            funktion = Rechenfunktion.Fakultät;
        }

        private void prim_btn_Click(object sender, EventArgs e)
        {
            funktion = Rechenfunktion.Primzahlen;
        }

        private void wrz_btn_Click(object sender, EventArgs e)
        {
            input_txtbx.Text = "√" + input_txtbx.Text;
            funktion = Rechenfunktion.Wurzel;
        }

        private void ptz_btn_Click(object sender, EventArgs e)
        {
            input_txtbx.Text = input_txtbx.Text + "^";
            funktion = Rechenfunktion.Potenz;
        }

        private void dezi_btn_Click(object sender, EventArgs e)
        {
            funktion = Rechenfunktion.Dezimabruch;
        }


        // Funktionen
        public void fakultätBerechnen(string rechung, ref string ergebnis)
        {
            //alles außer das Ausrufezeichen
            int fakultät = int.Parse(rechung.Remove(rechung.Length - 1));
            int num = 1;
            for (int i = 1; i <= fakultät; i++)
            {
                //num mit sichselbst und i multiplizieren, dadruch ist es um eine Zahl versetzt, bis i gleich der Falkultaet ist
                num *= i;
            }
            ergebnis = num.ToString();
        }

        public void wurzelBerechnen(string rechung, ref string ergebnis)
        {
            int num = int.Parse(rechung.Substring(1));
            //haelfte von 16 = 8
            double sqrt = num / 2;
            double temp = 0;
            //solange temp != sqrt
            while (temp != sqrt)
            {
                //war 0 jetzt 8
                //im naechsten durchlauf 5
                temp = sqrt;
                //(16 / 8 + 8) / 2 = 5
                //(16 / 5 + 5) / 2 = 4.1
                //usw. bis 4 = 4
                sqrt = (num / temp + temp) / 2;
            }
            ergebnis = sqrt.ToString();
        }

        public void potenzBerechnen(string rechnung, ref string ergebnis)
        {
            string[] num = rechnung.Split(new char[] { '^' }, 2, System.StringSplitOptions.RemoveEmptyEntries);
            int result = 1;
            int basis = int.Parse(num[0]);
            int exponent = int.Parse(num[1]);
            //loop durch Exponent und multipliziere die Basis mit dem Ergebnis aus dem ersten vorherigen loop
            for (int i = 1; i <= exponent; i++)
            {
                result *= basis;
            }
            ergebnis = result.ToString();
        }

        public void primzahlenBerechnen(int num, ref string ergebnis)
        {
            List<int> PrimeNumbers = new List<int>();
            bool Prime = true;
            //a = 2 weil 1 keine Primzahl ist
            for (int a = 2; a <= num; a++)
            {
                for (int b = 2; b <= num; b++)
                {
                    //weil die Zahlen nicht gleich sein druefen und muss beim der Modulo Operation nicht Null sein da Primzahlen nur durch sich und 1 Teilbar sind
                    if (a != b && a % b == 0)
                    {
                        Prime = false;
                        break;
                    }
                }
                if (Prime)
                {
                    //wenn nur durch sich und selbst Teilbar dann Primzahl
                    PrimeNumbers.Add(a);
                }
                Prime = true;
            }
            //String aus Liste erstellen und hinzufuegen
            ergebnis = string.Join(",", PrimeNumbers);
        }

        public void dezimalbruchBerechnen(string rechnung, ref string ergebnis)
        {
            string[] dezimalbruch = rechnung.Split(new char[] {'/'}, 2, StringSplitOptions.RemoveEmptyEntries);
            double zähler = int.Parse(dezimalbruch[0]);
            double nenner = int.Parse(dezimalbruch[1]);
            double potenzwert = zähler / nenner;
            ergebnis = potenzwert.ToString();
        }
    }
}
