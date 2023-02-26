using Rechnermodul.Utils.Controller;
using Rechnermodul.Utils.Shared;
using Rechnermodul.Utils.Shared.View;
using System;
using System.Windows.Forms;

namespace Rechnermodul.Main.View
{
    public partial class FRM_Main : Form
    {
        public FRM_Main()
        {
            InitializeComponent();
            startupWork();
            SettingsManager.SettingsChanged += SettingsChanged;
            SettingsManager.ApplySettingsToForm(this);
            History.NewEntryEvent += NewEntryEvent;
            GrundrechnerConnector.Grundrechner = new Grundrechner.View.FRM_Grundrechner();
        }

        /// <summary>
        /// Change settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsChanged(object sender, EventArgs e)
        {
            SettingsManager.ApplySettingsToForm(this);
        }

        /// <summary>
        /// Add new entrie to history List Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="entry"></param>
        private void NewEntryEvent(object sender, string entry)
        {
            LB_history.Items.Add(entry);
        }

        /// <summary>
        /// Do necessary work.
        /// </summary>
        private void startupWork()
        {
            // Load Settings
            SettingsManager.Load();

            // Display all modules
            foreach (var module in ModuleController.getRegisteredModules())
            {
                if (module.Text == "Eingabemodul") { continue; }
                if (module.Text == "Grundrechner") { continue; }
                LB_modules.Items.Add(module.Text);
            }

            // Load History
            History.Load();

            // Display History
            History.getHistory().ForEach(x => LB_history.Items.Add(x));
        }
        private void BTN_deleteHistory_Click(object sender, EventArgs e)
        {
            History.Clear();
            LB_history.Items.Clear();
        }

        private void BTN_openSelectedModule_Click(object sender, EventArgs e)
        {
            if (LB_modules.SelectedItem != null)
            {
                try
                {
                    ModuleController.getModuleByName(LB_modules.SelectedItem.ToString()).ShowDialog();
                } catch { }
            }
        }

        private void BTN_openGrundrechner_Click(object sender, EventArgs e)
        {
            ModuleController.getModuleByName("Grundrechner").ShowDialog();
        }

        private void LB_modules_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LB_modules.SelectedItem != null)
            {
                try
                {
                    ModuleController.getModuleByName(LB_modules.SelectedItem.ToString()).ShowDialog();
                }
                catch { }
            }
        }

        private void TSMI_settings_Click(object sender, EventArgs e)
        {
            // Open settings
            FRM_Settings FRM_Settings = new FRM_Settings();
            FRM_Settings.ShowDialog();
        }
    }
}
