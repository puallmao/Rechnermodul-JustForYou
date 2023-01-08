using Rechnermodul.Schule.View;
using System;
using System.Windows.Forms;

namespace Rechnermodul.Schule
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FRM_Schule());
        }
    }
}
