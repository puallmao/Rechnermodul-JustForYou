
namespace Rechnermodul.MathematischeFunktionen.View
{
    partial class UC_CalculateFactorial
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TB_result = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NUM_value = new System.Windows.Forms.NumericUpDown();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_value)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_titel
            // 
            this.LBL_titel.AutoSize = true;
            this.LBL_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_titel.Location = new System.Drawing.Point(3, 0);
            this.LBL_titel.Name = "LBL_titel";
            this.LBL_titel.Size = new System.Drawing.Size(89, 25);
            this.LBL_titel.TabIndex = 4;
            this.LBL_titel.Text = "Fakultät";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TB_result);
            this.groupBox3.Location = new System.Drawing.Point(8, 122);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(416, 74);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ergebnis";
            // 
            // TB_result
            // 
            this.TB_result.Location = new System.Drawing.Point(9, 31);
            this.TB_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_result.Name = "TB_result";
            this.TB_result.ReadOnly = true;
            this.TB_result.Size = new System.Drawing.Size(392, 26);
            this.TB_result.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NUM_value);
            this.groupBox1.Location = new System.Drawing.Point(8, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(416, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingabe";
            // 
            // NUM_value
            // 
            this.NUM_value.Location = new System.Drawing.Point(14, 29);
            this.NUM_value.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NUM_value.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NUM_value.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.NUM_value.Name = "NUM_value";
            this.NUM_value.Size = new System.Drawing.Size(390, 26);
            this.NUM_value.TabIndex = 1;
            this.NUM_value.ValueChanged += new System.EventHandler(this.NUM_value_ValueChanged);
            // 
            // UC_CalculateFactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LBL_titel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_CalculateFactorial";
            this.Size = new System.Drawing.Size(438, 202);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_titel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TB_result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NUM_value;
    }
}
