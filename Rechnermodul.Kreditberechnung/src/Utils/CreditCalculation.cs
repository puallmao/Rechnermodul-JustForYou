using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnermodul.Kreditberechnung.Utils
{
    public static class CreditCalculation
    {
        public static bool ValidateZinssatz(decimal zinssatz = 0)
        {
            // Zinssatz muss zwischen 0% und 100% liegen
            if (zinssatz <= 0 && zinssatz > 100)
            {
                // Create Message box - FEHLER
                return false;
            }
            return true;
        }

        public static bool ValidateRatenhoehe(decimal ratenhoehe = 0)
        {
            if (ratenhoehe <= 0)
            {
                // Create Message box - FEHLER
                return false;
            }
            return true;
        }
        public static bool ValidateLaufzeit(decimal laufzeit = 0)
        {
            // laufzeit hat keine Nachkommastellen, sind nur volle monate
            if (laufzeit <= 0 || laufzeit != Convert.ToDecimal(Convert.ToInt64(laufzeit)))
            {
                // Create Message box - FEHLER
                return false;
            }
            return true;
        }

        public static bool ValidateKreditbetrag(decimal kreditbetrag)
        {
            if (kreditbetrag > 0)
            {
                return true;
            }
            return false;
        }
    }
}
