
namespace Rechnermodul.MathematischeFunktionen.View
{
    partial class FRM_MathematischeFunktionen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_decimalFraction = new System.Windows.Forms.Button();
            this.BTN_factorial = new System.Windows.Forms.Button();
            this.BTN_primeNumber = new System.Windows.Forms.Button();
            this.BTN_sqrt = new System.Windows.Forms.Button();
            this.BTN_power = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UC_CalculateDecimalFraction = new Rechnermodul.MathematischeFunktionen.View.UC_CalculateDecimalFraction();
            this.UC_CalculatePrimeNumbers = new Rechnermodul.MathematischeFunktionen.View.UC_CalculatePrimeNumbers();
            this.UC_CalculatePower = new Rechnermodul.MathematischeFunktionen.View.UC_CalculatePower();
            this.UC_CalculateSqrt = new Rechnermodul.MathematischeFunktionen.View.UC_CalculateSqrt();
            this.UC_CalculateFactorial = new Rechnermodul.MathematischeFunktionen.View.UC_CalculateFactorial();
            this.LBL_noFunctionSelected = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_decimalFraction);
            this.groupBox1.Controls.Add(this.BTN_factorial);
            this.groupBox1.Controls.Add(this.BTN_primeNumber);
            this.groupBox1.Controls.Add(this.BTN_sqrt);
            this.groupBox1.Controls.Add(this.BTN_power);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(447, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funktionswahl";
            // 
            // BTN_decimalFraction
            // 
            this.BTN_decimalFraction.Location = new System.Drawing.Point(356, 28);
            this.BTN_decimalFraction.Name = "BTN_decimalFraction";
            this.BTN_decimalFraction.Size = new System.Drawing.Size(81, 55);
            this.BTN_decimalFraction.TabIndex = 5;
            this.BTN_decimalFraction.Text = "Dezimalbruch";
            this.BTN_decimalFraction.UseVisualStyleBackColor = true;
            this.BTN_decimalFraction.Click += new System.EventHandler(this.BTN_decimalFraction_Click);
            // 
            // BTN_factorial
            // 
            this.BTN_factorial.Location = new System.Drawing.Point(8, 28);
            this.BTN_factorial.Name = "BTN_factorial";
            this.BTN_factorial.Size = new System.Drawing.Size(81, 55);
            this.BTN_factorial.TabIndex = 1;
            this.BTN_factorial.Text = "Fakultät";
            this.BTN_factorial.UseVisualStyleBackColor = true;
            this.BTN_factorial.Click += new System.EventHandler(this.BTN_factorial_Click);
            // 
            // BTN_primeNumber
            // 
            this.BTN_primeNumber.Location = new System.Drawing.Point(268, 28);
            this.BTN_primeNumber.Name = "BTN_primeNumber";
            this.BTN_primeNumber.Size = new System.Drawing.Size(81, 55);
            this.BTN_primeNumber.TabIndex = 4;
            this.BTN_primeNumber.Text = "Primzahl";
            this.BTN_primeNumber.UseVisualStyleBackColor = true;
            this.BTN_primeNumber.Click += new System.EventHandler(this.BTN_primeNumber_Click);
            // 
            // BTN_sqrt
            // 
            this.BTN_sqrt.Location = new System.Drawing.Point(94, 29);
            this.BTN_sqrt.Name = "BTN_sqrt";
            this.BTN_sqrt.Size = new System.Drawing.Size(81, 55);
            this.BTN_sqrt.TabIndex = 2;
            this.BTN_sqrt.Text = "Wurzel";
            this.BTN_sqrt.UseVisualStyleBackColor = true;
            this.BTN_sqrt.Click += new System.EventHandler(this.BTN_sqrt_Click);
            // 
            // BTN_power
            // 
            this.BTN_power.Location = new System.Drawing.Point(182, 28);
            this.BTN_power.Name = "BTN_power";
            this.BTN_power.Size = new System.Drawing.Size(81, 55);
            this.BTN_power.TabIndex = 3;
            this.BTN_power.Text = "Potenz";
            this.BTN_power.UseVisualStyleBackColor = true;
            this.BTN_power.Click += new System.EventHandler(this.BTN_power_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UC_CalculateDecimalFraction);
            this.groupBox2.Controls.Add(this.UC_CalculatePrimeNumbers);
            this.groupBox2.Controls.Add(this.UC_CalculatePower);
            this.groupBox2.Controls.Add(this.UC_CalculateSqrt);
            this.groupBox2.Controls.Add(this.UC_CalculateFactorial);
            this.groupBox2.Controls.Add(this.LBL_noFunctionSelected);
            this.groupBox2.Location = new System.Drawing.Point(18, 118);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(447, 372);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funktion";
            // 
            // UC_CalculateDecimalFraction
            // 
            this.UC_CalculateDecimalFraction.Location = new System.Drawing.Point(8, 31);
            this.UC_CalculateDecimalFraction.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.UC_CalculateDecimalFraction.Name = "UC_CalculateDecimalFraction";
            this.UC_CalculateDecimalFraction.Size = new System.Drawing.Size(429, 326);
            this.UC_CalculateDecimalFraction.TabIndex = 8;
            this.UC_CalculateDecimalFraction.Visible = false;
            // 
            // UC_CalculatePrimeNumbers
            // 
            this.UC_CalculatePrimeNumbers.Location = new System.Drawing.Point(8, 31);
            this.UC_CalculatePrimeNumbers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UC_CalculatePrimeNumbers.Name = "UC_CalculatePrimeNumbers";
            this.UC_CalculatePrimeNumbers.Size = new System.Drawing.Size(429, 326);
            this.UC_CalculatePrimeNumbers.TabIndex = 7;
            this.UC_CalculatePrimeNumbers.Visible = false;
            // 
            // UC_CalculatePower
            // 
            this.UC_CalculatePower.Location = new System.Drawing.Point(8, 31);
            this.UC_CalculatePower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UC_CalculatePower.Name = "UC_CalculatePower";
            this.UC_CalculatePower.Size = new System.Drawing.Size(429, 326);
            this.UC_CalculatePower.TabIndex = 6;
            this.UC_CalculatePower.Visible = false;
            // 
            // UC_CalculateSqrt
            // 
            this.UC_CalculateSqrt.Location = new System.Drawing.Point(8, 31);
            this.UC_CalculateSqrt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UC_CalculateSqrt.Name = "UC_CalculateSqrt";
            this.UC_CalculateSqrt.Size = new System.Drawing.Size(429, 202);
            this.UC_CalculateSqrt.TabIndex = 5;
            this.UC_CalculateSqrt.Visible = false;
            // 
            // UC_CalculateFactorial
            // 
            this.UC_CalculateFactorial.Location = new System.Drawing.Point(8, 31);
            this.UC_CalculateFactorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UC_CalculateFactorial.Name = "UC_CalculateFactorial";
            this.UC_CalculateFactorial.Size = new System.Drawing.Size(429, 202);
            this.UC_CalculateFactorial.TabIndex = 4;
            this.UC_CalculateFactorial.Visible = false;
            // 
            // LBL_noFunctionSelected
            // 
            this.LBL_noFunctionSelected.AutoSize = true;
            this.LBL_noFunctionSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_noFunctionSelected.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LBL_noFunctionSelected.Location = new System.Drawing.Point(114, 177);
            this.LBL_noFunctionSelected.Name = "LBL_noFunctionSelected";
            this.LBL_noFunctionSelected.Size = new System.Drawing.Size(213, 20);
            this.LBL_noFunctionSelected.TabIndex = 9;
            this.LBL_noFunctionSelected.Text = "Noch keine Funktion gewählt";
            // 
            // FRM_MathematischeFunktionen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRM_MathematischeFunktionen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mathematische Funktionen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_MathematischeFunktionen_FormClosing);
            this.Load += new System.EventHandler(this.FRM_MathematischeFunktionen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_decimalFraction;
        private System.Windows.Forms.Button BTN_factorial;
        private System.Windows.Forms.Button BTN_primeNumber;
        private System.Windows.Forms.Button BTN_sqrt;
        private System.Windows.Forms.Button BTN_power;
        private System.Windows.Forms.GroupBox groupBox2;
        private UC_CalculateDecimalFraction UC_CalculateDecimalFraction;
        private UC_CalculatePrimeNumbers UC_CalculatePrimeNumbers;
        private UC_CalculatePower UC_CalculatePower;
        private UC_CalculateSqrt UC_CalculateSqrt;
        private UC_CalculateFactorial UC_CalculateFactorial;
        private System.Windows.Forms.Label LBL_noFunctionSelected;
    }
}