using System;
using System.Windows.Forms;

namespace Rechnermodul.Utils.Shared
{
    /// <summary>
    /// Connector for the Grundrechner
    /// Allows the Eingabemodul to open the Grundrechner
    /// </summary>
    public interface IGrundrechner
    {
        Form GetForm();
    }

    public static class GrundrechnerConnector
    {
        public static IGrundrechner Grundrechner;
    }
}
