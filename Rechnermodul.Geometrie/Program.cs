using Rechnermodul.Geometrie.View;
using System;
using System.Windows.Forms;

namespace Rechnermodul.Geometrie
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
            Application.Run(new FRM_Geometrie());
        }
    }
}
