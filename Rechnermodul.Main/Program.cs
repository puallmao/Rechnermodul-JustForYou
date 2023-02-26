using Rechnermodul.Eingabemodul.View;
using Rechnermodul.Geometrie.View;
using Rechnermodul.Grundrechner.View;
using Rechnermodul.Informationstechnik.View;
using Rechnermodul.Kreditberechnung.View;
using Rechnermodul.Main.View;
using Rechnermodul.MathematischeFunktionen.View;
using Rechnermodul.Prozentrechnung.View;
using Rechnermodul.Schule.View;
using Rechnermodul.Utils.Controller;
using Rechnermodul.Utils.Shared.View;
using System;
using System.Windows.Forms;

namespace Rechnermodul.Main
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

            // Register Modules
            registerModules();

            Application.Run(new FRM_Main());
        }

        /// <summary>
        /// Register Application Moduls
        /// </summary>
        private static void registerModules()
        {
            ModuleController.registerModule(new FRM_Grundrechner());
            ModuleController.registerModule(new FRM_Eingabemodul());
            ModuleController.registerModule(new FRM_Prozentrechnung());
            ModuleController.registerModule(new FRM_Kreditberechnung());
            ModuleController.registerModule(new FRM_Geometrie());
            ModuleController.registerModule(new FRM_MathematischeFunktionen());
            ModuleController.registerModule(new FRM_Schule());
            ModuleController.registerModule(new FRM_Informationstechnik());
        }
    }
}
