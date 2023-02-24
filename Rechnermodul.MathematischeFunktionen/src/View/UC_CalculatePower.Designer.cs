
namespace Rechnermodul.MathematischeFunktionen.View
{
    partial class UC_CalculatePower
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TB_result = new System.Windows.Forms.TextBox();
            this.LBL_titel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NUM_exponent = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NUM_base = new System.Windows.Forms.NumericUpDown();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_exponent)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_base)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TB_result);
            this.groupBox3.Location = new System.Drawing.Point(12, 243);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(411, 74);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ergebnis";
            // 
            // TB_result
            // 
            this.TB_result.Location = new System.Drawing.Point(9, 31);
            this.TB_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_result.Name = "TB_result";
            this.TB_result.ReadOnly = true;
            this.TB_result.Size = new System.Drawing.Size(388, 26);
            this.TB_result.TabIndex = 0;
            // 
            // LBL_titel
            // 
            this.LBL_titel.AutoSize = true;
            this.LBL_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_titel.Location = new System.Drawing.Point(3, 0);
            this.LBL_titel.Name = "LBL_titel";
            this.LBL_titel.Size = new System.Drawing.Size(79, 25);
            this.LBL_titel.TabIndex = 12;
            this.LBL_titel.Text = "Potenz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(411, 191);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingabe";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NUM_exponent);
            this.groupBox4.Location = new System.Drawing.Point(9, 108);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(393, 74);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exponent";
            // 
            // NUM_exponent
            // 
            this.NUM_exponent.DecimalPlaces = 6;
            this.NUM_exponent.Location = new System.Drawing.Point(14, 29);
            this.NUM_exponent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NUM_exponent.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NUM_exponent.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.NUM_exponent.Name = "NUM_exponent";
            this.NUM_exponent.Size = new System.Drawing.Size(370, 26);
            this.NUM_exponent.TabIndex = 1;
            this.NUM_exponent.ValueChanged += new System.EventHandler(this.setValue);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NUM_base);
            this.groupBox2.Location = new System.Drawing.Point(9, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(393, 74);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basis";
            // 
            // NUM_base
            // 
            this.NUM_base.DecimalPlaces = 6;
            this.NUM_base.Location = new System.Drawing.Point(14, 29);
            this.NUM_base.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NUM_base.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NUM_base.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.NUM_base.Name = "NUM_base";
            this.NUM_base.Size = new System.Drawing.Size(370, 26);
            this.NUM_base.TabIndex = 1;
            this.NUM_base.ValueChanged += new System.EventHandler(this.setValue);
            // 
            // UC_CalculatePower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LBL_titel);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_CalculatePower";
            this.Size = new System.Drawing.Size(438, 326);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_exponent)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_base)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TB_result;
        private System.Windows.Forms.Label LBL_titel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown NUM_exponent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown NUM_base;
    }
}
