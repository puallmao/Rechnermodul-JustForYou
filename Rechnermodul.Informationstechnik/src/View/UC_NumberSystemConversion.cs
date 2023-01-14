﻿using Rechnermodul.Informationstechnik.Utils;
using System.Windows.Forms;

namespace Rechnermodul.Informationstechnik.src.View
{
    public partial class UC_NumberSystemConversion : UserControl
    {
        private bool blockTextChangedEvents = false;
        private enum numberSystems
        {
            Binary,
            Ternary,
            Octal,
            Decimal
        }

        public UC_NumberSystemConversion()
        {
            InitializeComponent();
        }

        private void TB_binary_TextChanged(object sender, System.EventArgs e)
        {
            // Block all Value_Changed events
            if (blockTextChangedEvents) return;
            blockTextChangedEvents = true;

            // Check if input is empty
            if (TB_binary.Text == string.Empty)
            {
                clearTextBoxInputs(TB_binary);
                // Allow TextChangedEvents
                blockTextChangedEvents = false;
                return;
            }

            // Clear TextBox Inputs
            clearTextBoxInputs(TB_binary);

            // Get input
            string input = TB_binary.Text;

            // Validate binary input
            if (!NumberSystemConversion.validateBinaryInput(input))
            {
                // Allow TextChangedEvents
                blockTextChangedEvents = false;
                return;
            }

            // Set values
            setTernary(input, numberSystems.Binary);
            setOctal(input, numberSystems.Binary);
            setDecimal(input, numberSystems.Binary);

            // Allow TextChangedEvents
            blockTextChangedEvents = false;
        }

        private void TB_ternary_TextChanged(object sender, System.EventArgs e)
        {
            // Block all Value_Changed events
            if (blockTextChangedEvents) return;
            blockTextChangedEvents = true;

            // Check if input is empty
            if (TB_ternary.Text == string.Empty)
            {
                clearTextBoxInputs(TB_ternary);
                // Allow TextChangedEvents
                blockTextChangedEvents = false;
                return;
            }

            // Clear TextBox Inputs
            clearTextBoxInputs(TB_ternary);

            // Get input
            string input = TB_ternary.Text;

            // Validate ternary input
            if (!NumberSystemConversion.validateTernaryInput(input))
            {
                // Allow TextChangedEvents
                blockTextChangedEvents = false;
                return;
            }

            // Set values
            setBinary(input, numberSystems.Ternary);
            setOctal(input, numberSystems.Ternary);
            setDecimal(input, numberSystems.Ternary);

            // Allow TextChangedEvents
            blockTextChangedEvents = false;
        }

        private void TB_octal_ValueChanged(object sender, System.EventArgs e)
        {
            // Block all Value_Changed events
            if (blockTextChangedEvents) return;
            blockTextChangedEvents = true;

            // Check if input is empty
            if (TB_octal.Text == string.Empty)
            {
                clearTextBoxInputs(TB_octal);
                // Allow TextChangedEvents
                blockTextChangedEvents = false;
                return;
            }

            // Clear TextBox Inputs
            clearTextBoxInputs(TB_octal);

            // Get input
            string input = TB_octal.Text;

            // Validate octal input
            if (!NumberSystemConversion.validateOctalInput(input))
            {
                // Allow TextChangedEvents
                blockTextChangedEvents = false;
                return;
            }

            // Set values
            setBinary(input, numberSystems.Octal);
            setTernary(input, numberSystems.Octal);
            setDecimal(input, numberSystems.Octal);

            // Allow TextChangedEvents
            blockTextChangedEvents = false;
        }

        private void TB_decimal_TextChanged(object sender, System.EventArgs e)
        {
            // Block all Value_Changed events
            if (blockTextChangedEvents) return;
            blockTextChangedEvents = true;

            // Check if input is empty
            if (TB_decimal.Text == string.Empty)
            {
                clearTextBoxInputs(TB_decimal);
                // Allow TextChangedEvents
                blockTextChangedEvents = false;
                return;
            }

            // Clear TextBox Inputs
            clearTextBoxInputs(TB_decimal);

            // Get input
            string input = TB_decimal.Text;

            // Validate decimal input
            if (!NumberSystemConversion.validateDecimalInput(input))
            {
                // Allow TextChangedEvents
                blockTextChangedEvents = false;
                return;
            }

            // Set values
            setBinary(input, numberSystems.Decimal);
            setTernary(input, numberSystems.Decimal);
            setOctal(input, numberSystems.Decimal);

            // Allow TextChangedEvents
            blockTextChangedEvents = false;
        }

        private void setBinary(string input, numberSystems inputNumberSystem)
        {
            string output = string.Empty;

            try
            {
                if (inputNumberSystem == numberSystems.Ternary)
                    output = NumberSystemConversion.terToBin(input);
                if (inputNumberSystem == numberSystems.Octal)
                    output = NumberSystemConversion.octToBin(long.Parse(input));
                if (inputNumberSystem == numberSystems.Decimal)
                    output = NumberSystemConversion.decToBin(long.Parse(input));
            }
            catch { }

            TB_binary.Text = output;
        }

        private void setTernary(string input, numberSystems inputNumberSystem)
        {
            string output = string.Empty;

            try
            {
                if (inputNumberSystem == numberSystems.Binary)
                    output = NumberSystemConversion.binToTer(input);
                if (inputNumberSystem == numberSystems.Octal)
                    output = NumberSystemConversion.octToTer(long.Parse(input));
                if (inputNumberSystem == numberSystems.Decimal)
                    output = NumberSystemConversion.decToTer(long.Parse(input));
            }
            catch { }

            TB_ternary.Text = output;
        }

        private void setOctal(string input, numberSystems inputNumberSystem)
        {
            string output = string.Empty;

            try
            {
                if (inputNumberSystem == numberSystems.Binary)
                    output = NumberSystemConversion.binToOct(input);
                if (inputNumberSystem == numberSystems.Ternary)
                    output = NumberSystemConversion.terToOct(input);
                if (inputNumberSystem == numberSystems.Decimal)
                    output = NumberSystemConversion.decToOct(long.Parse(input));
            }
            catch { }

            TB_octal.Text = output;
        }

        private void setDecimal(string input, numberSystems inputNumberSystem)
        {
            string output = string.Empty;

            try
            {
                if (inputNumberSystem == numberSystems.Binary)
                    output = NumberSystemConversion.binToDec(input);
                if (inputNumberSystem == numberSystems.Ternary)
                    output = NumberSystemConversion.terToDec(input);
                if (inputNumberSystem == numberSystems.Octal)
                    output = NumberSystemConversion.octToDec(long.Parse(input));
            }
            catch { }

            TB_decimal.Text = output;
        }

        private void clearTextBoxInputs(TextBox blockedTextBox)
        {
            if (blockedTextBox != TB_binary)
                TB_binary.Text = string.Empty;
            if (blockedTextBox != TB_ternary)
                TB_ternary.Text = string.Empty;
            if (blockedTextBox != TB_octal)
                TB_octal.Text = string.Empty;
            if (blockedTextBox != TB_decimal)
                TB_decimal.Text = string.Empty;
        }

        private void BTN_clearInputs_Click(object sender, System.EventArgs e)
        {
            TB_binary.Text = string.Empty;
            TB_ternary.Text = string.Empty;
            TB_octal.Text = string.Empty;
            TB_decimal.Text = string.Empty;
        }
    }
}
