using System;
using System.Windows.Forms;

namespace Rechnermodul.Utils.Shared
{
    public interface IGrundrechner
    {
        Form GetForm();
    }

    public static class GrundrechnerConnector
    {
        public static IGrundrechner Grundrechner;
    }
}
