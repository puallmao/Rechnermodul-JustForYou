
namespace Rechnermodul.Prozentrechnung.View
{
    partial class UC_PriceCalculation
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBL_titel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NUM_bruttoValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NUM_nettoValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_bruttoValue)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_nettoValue)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_titel
            // 
            this.LBL_titel.AutoSize = true;
            this.LBL_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_titel.Location = new System.Drawing.Point(3, 0);
            this.LBL_titel.Name = "LBL_titel";
            this.LBL_titel.Size = new System.Drawing.Size(284, 25);
            this.LBL_titel.TabIndex = 12;
            this.LBL_titel.Text = "Brutto- Nettopreiskalkulation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(8, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(278, 197);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eingaben";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NUM_bruttoValue);
            this.groupBox5.Location = new System.Drawing.Point(9, 108);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(260, 77);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bruttopreis inkl. MwSt.";
            // 
            // NUM_bruttoValue
            // 
            this.NUM_bruttoValue.DecimalPlaces = 2;
            this.NUM_bruttoValue.Location = new System.Drawing.Point(9, 31);
            this.NUM_bruttoValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NUM_bruttoValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NUM_bruttoValue.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.NUM_bruttoValue.Name = "NUM_bruttoValue";
            this.NUM_bruttoValue.Size = new System.Drawing.Size(242, 26);
            this.NUM_bruttoValue.TabIndex = 0;
            this.NUM_bruttoValue.ValueChanged += new System.EventHandler(this.NUM_bruttoValue_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NUM_nettoValue);
            this.groupBox4.Location = new System.Drawing.Point(9, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(260, 77);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nettopreis ohne MwSt.";
            // 
            // NUM_nettoValue
            // 
            this.NUM_nettoValue.DecimalPlaces = 2;
            this.NUM_nettoValue.Location = new System.Drawing.Point(9, 31);
            this.NUM_nettoValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NUM_nettoValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NUM_nettoValue.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.NUM_nettoValue.Name = "NUM_nettoValue";
            this.NUM_nettoValue.Size = new System.Drawing.Size(242, 26);
            this.NUM_nettoValue.TabIndex = 0;
            this.NUM_nettoValue.ValueChanged += new System.EventHandler(this.NUM_nettoValue_ValueChanged);
            // 
            // UC_PriceCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LBL_titel);
            this.Name = "UC_PriceCalculation";
            this.Size = new System.Drawing.Size(295, 251);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_bruttoValue)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_nettoValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_titel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown NUM_bruttoValue;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown NUM_nettoValue;
    }
}
