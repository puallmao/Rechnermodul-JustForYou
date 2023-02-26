
namespace Rechnermodul.Prozentrechnung.View
{
    partial class UC_PercentageCalculation2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NUM_percentageValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NUM_baseValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TB_result = new System.Windows.Forms.TextBox();
            this.LBL_titel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_percentageValue)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_baseValue)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(8, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(278, 197);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eingaben";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NUM_percentageValue);
            this.groupBox5.Location = new System.Drawing.Point(9, 108);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(260, 77);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Prozentwert";
            // 
            // NUM_percentageValue
            // 
            this.NUM_percentageValue.DecimalPlaces = 6;
            this.NUM_percentageValue.Location = new System.Drawing.Point(9, 31);
            this.NUM_percentageValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NUM_percentageValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NUM_percentageValue.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.NUM_percentageValue.Name = "NUM_percentageValue";
            this.NUM_percentageValue.Size = new System.Drawing.Size(242, 26);
            this.NUM_percentageValue.TabIndex = 0;
            this.NUM_percentageValue.ValueChanged += new System.EventHandler(this.setValue);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NUM_baseValue);
            this.groupBox4.Location = new System.Drawing.Point(9, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(260, 77);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Grundwert";
            // 
            // NUM_baseValue
            // 
            this.NUM_baseValue.DecimalPlaces = 6;
            this.NUM_baseValue.Location = new System.Drawing.Point(9, 31);
            this.NUM_baseValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NUM_baseValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NUM_baseValue.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.NUM_baseValue.Name = "NUM_baseValue";
            this.NUM_baseValue.Size = new System.Drawing.Size(242, 26);
            this.NUM_baseValue.TabIndex = 0;
            this.NUM_baseValue.ValueChanged += new System.EventHandler(this.setValue);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TB_result);
            this.groupBox3.Location = new System.Drawing.Point(8, 241);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(278, 74);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ergebnis";
            // 
            // TB_result
            // 
            this.TB_result.Location = new System.Drawing.Point(9, 31);
            this.TB_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_result.Name = "TB_result";
            this.TB_result.ReadOnly = true;
            this.TB_result.Size = new System.Drawing.Size(254, 26);
            this.TB_result.TabIndex = 0;
            // 
            // LBL_titel
            // 
            this.LBL_titel.AutoSize = true;
            this.LBL_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_titel.Location = new System.Drawing.Point(3, 4);
            this.LBL_titel.Name = "LBL_titel";
            this.LBL_titel.Size = new System.Drawing.Size(240, 25);
            this.LBL_titel.TabIndex = 11;
            this.LBL_titel.Text = "Prozentsatzberechnung";
            // 
            // UC_PercentageCalculation2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LBL_titel);
            this.Name = "UC_PercentageCalculation2";
            this.Size = new System.Drawing.Size(295, 323);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_percentageValue)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_baseValue)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TB_result;
        private System.Windows.Forms.Label LBL_titel;
        public System.Windows.Forms.NumericUpDown NUM_percentageValue;
        public System.Windows.Forms.NumericUpDown NUM_baseValue;
    }
}
