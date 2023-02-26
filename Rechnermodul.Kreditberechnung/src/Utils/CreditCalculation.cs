using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnermodul.Kreditberechnung.Utils
{
    public static class CreditCalculation
    {
        /// <summary>
        /// Validate the given Zinssatz
        /// </summary>
        /// <param name="zinssatz"></param>
        /// <returns></returns>
        public static bool ValidateZinssatz(decimal zinssatz = 0)
        {
            // Zinssatz must have a value between 0% and 100%
            if (zinssatz <= 0 && zinssatz > 100)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Validate the given Ratenhoehe
        /// </summary>
        /// <param name="ratenhoehe"></param>
        /// <returns></returns>
        public static bool ValidateRatenhoehe(decimal ratenhoehe = 0)
        {
            if (ratenhoehe <= 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Validate the given Laufzeit
        /// </summary>
        /// <param name="laufzeit"></param>
        /// <returns></returns>
        public static bool ValidateLaufzeit(decimal laufzeit = 0)
        {
            // Laufzeit has no decimal places
            if (laufzeit <= 0 || laufzeit != Convert.ToDecimal(Convert.ToInt64(laufzeit)))
            {
                // Create Message box - FEHLER
                return false;
            }
            return true;
        }

        /// <summary>
        /// Validate the given Kreditbetrag
        /// </summary>
        /// <param name="kreditbetrag"></param>
        /// <returns></returns>
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
