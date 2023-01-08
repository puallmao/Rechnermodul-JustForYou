using System.Collections.Generic;
using System.Windows.Forms;

namespace Rechnermodul.Utils.Controller
{
    public class ModuleController
    {
        // This list contains all registerd Modules
        private static List<Form> registeredModules = new List<Form>();

        // Store the total amount of used modules.
        // The total amount of modules is 5
        private static int moduleAmount = 0;

        // Set the max. amount of Application-Modules. 
#if DEBUG
        private const int maxModules = 100;
#else
            private const int maxModules = 5;
#endif

        /// <summary>
        /// Register an Application-Module
        /// </summary>
        public static void registerModule(Form module)
        {
            if ((moduleAmount + 1) <= maxModules)
            {
                registeredModules.Add(module);
                moduleAmount += 1;
            }
        }

        /// <summary>
        /// Get Module from registered Modules List by Name.
        /// </summary>
        /// <param name="moduleName"></param>
        /// <returns></returns>
        public static Form getModuleByName(string moduleName)
        {
            foreach (var module in registeredModules)
            {
                if (module.Text == moduleName)
                    return module;
            }
            return null;
        }

        /// <summary>
        /// Get a list of all currently registerd Modules.
        /// </summary>
        /// <returns></returns>
        public static List<Form> getRegisteredModules()
        {
            return registeredModules;
        }
    }
}
