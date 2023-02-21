using Rechnermodul.Informationstechnik.Utils;
using Rechnermodul.Utils.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Rechnermodul.Informationstechnik.View
{
    public partial class UC_DataSizeConversion : UserControl
    {
        bool blockValueChangedEvents = false;

        private static Dictionary<Control, Enum> dictionary = new Dictionary<Control, Enum>();
        public UC_DataSizeConversion()
        {
            InitializeComponent();
            initializeDictionary();
        }

        private void initializeDictionary()
        {
            dictionary.Add(NUM_inputKB, DataSizeConversion.decimalPrefixDataSizes.KiloByte);
            dictionary.Add(NUM_inputKiB, DataSizeConversion.binaryPrefixDataSizes.KibiByte);
            dictionary.Add(NUM_inputMB, DataSizeConversion.decimalPrefixDataSizes.MegaByte);
            dictionary.Add(NUM_inputMiB, DataSizeConversion.binaryPrefixDataSizes.MebiByte);
            dictionary.Add(NUM_inputGB, DataSizeConversion.decimalPrefixDataSizes.GigaByte);
            dictionary.Add(NUM_inputGiB, DataSizeConversion.binaryPrefixDataSizes.GibiByte);
            dictionary.Add(NUM_inputTB, DataSizeConversion.decimalPrefixDataSizes.TeraByte);
            dictionary.Add(NUM_inputTiB, DataSizeConversion.binaryPrefixDataSizes.TebiByte);
        }

        private void NUM_ValueChanged(object sender, System.EventArgs e)
        {
            // Block all Value_Changed events
            if (blockValueChangedEvents) return;

            // Get control and parse input
            NumericUpDown control = (NumericUpDown)sender;

            // Set the sizes
            Enum obj;
            if (dictionary.TryGetValue(control, out obj))
                setDataSizes(control, control.Value, obj);

            // Unblock ValueChanged Events
            blockValueChangedEvents = false;
        }

        private void setDataSizes(NumericUpDown control, decimal size, dynamic obj)
        {
            // Block ValueChanged Events
            blockValueChangedEvents = true;

            clearNUM(control);

            // KiloByte
            if (control != NUM_inputKB)
                NUM_inputKB.Value = DataSizeConversion.convertToDecimalPrefix(DataSizeConversion.decimalPrefixDataSizes.KiloByte, DataSizeConversion.calculateBytes(obj, size));

            // KibiByte
            if (control != NUM_inputKiB)
                NUM_inputKiB.Value = DataSizeConversion.convertToBinaryPrefix(DataSizeConversion.binaryPrefixDataSizes.KibiByte, DataSizeConversion.calculateBytes(obj, size));

            // MegaByte
            if (control != NUM_inputMB)
                NUM_inputMB.Value = DataSizeConversion.convertToDecimalPrefix(DataSizeConversion.decimalPrefixDataSizes.MegaByte, DataSizeConversion.calculateBytes(obj, size));

            // MebiByte
            if (control != NUM_inputMiB)
                NUM_inputMiB.Value = DataSizeConversion.convertToBinaryPrefix(DataSizeConversion.binaryPrefixDataSizes.MebiByte, DataSizeConversion.calculateBytes(obj, size));

            // GigaByte
            if (control != NUM_inputGB)
                NUM_inputGB.Value = DataSizeConversion.convertToDecimalPrefix(DataSizeConversion.decimalPrefixDataSizes.GigaByte, DataSizeConversion.calculateBytes(obj, size));

            // GibiByte
            if (control != NUM_inputGiB)
                NUM_inputGiB.Value = DataSizeConversion.convertToBinaryPrefix(DataSizeConversion.binaryPrefixDataSizes.GibiByte, DataSizeConversion.calculateBytes(obj, size));

            // TeraByte
            if (control != NUM_inputTB)
                NUM_inputTB.Value = DataSizeConversion.convertToDecimalPrefix(DataSizeConversion.decimalPrefixDataSizes.TeraByte, DataSizeConversion.calculateBytes(obj, size));

            // TebiByte
            if (control != NUM_inputTiB)
                NUM_inputTiB.Value = DataSizeConversion.convertToBinaryPrefix(DataSizeConversion.binaryPrefixDataSizes.TebiByte, DataSizeConversion.calculateBytes(obj, size));

            History.AddEntry($"Umrechnung: {size} {obj}");
        }

        private void clearNUM(NumericUpDown control)
        {
            if (control != NUM_inputKB)
                NUM_inputKB.Value = 0;
            if (control != NUM_inputKiB)
                NUM_inputKiB.Value = 0;
            if (control != NUM_inputMB)
                NUM_inputMB.Value = 0;
            if (control != NUM_inputMiB)
                NUM_inputMiB.Value = 0;
            if (control != NUM_inputGB)
                NUM_inputGB.Value = 0;
            if (control != NUM_inputGiB)
                NUM_inputGiB.Value = 0;
            if (control != NUM_inputTB)
                NUM_inputTB.Value = 0;
            if (control != NUM_inputTiB)
                NUM_inputTiB.Value = 0;
        }

    }
}
