
namespace Rechnermodul.Informationstechnik.src.View
{
    partial class UC_NumberSystemConversion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_binary = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_ternary = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TB_octal = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TB_decimal = new System.Windows.Forms.TextBox();
            this.BTN_clearInputs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_titel
            // 
            this.LBL_titel.AutoSize = true;
            this.LBL_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_titel.Location = new System.Drawing.Point(0, 0);
            this.LBL_titel.Name = "LBL_titel";
            this.LBL_titel.Size = new System.Drawing.Size(265, 25);
            this.LBL_titel.TabIndex = 0;
            this.LBL_titel.Text = "Zahlensystemumrechnung";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_binary);
            this.groupBox1.Location = new System.Drawing.Point(5, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Binärsystem";
            // 
            // TB_binary
            // 
            this.TB_binary.Location = new System.Drawing.Point(6, 25);
            this.TB_binary.Name = "TB_binary";
            this.TB_binary.Size = new System.Drawing.Size(254, 26);
            this.TB_binary.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_ternary);
            this.groupBox2.Location = new System.Drawing.Point(5, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ternärsystem";
            // 
            // TB_ternary
            // 
            this.TB_ternary.Location = new System.Drawing.Point(6, 25);
            this.TB_ternary.Name = "TB_ternary";
            this.TB_ternary.Size = new System.Drawing.Size(254, 26);
            this.TB_ternary.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TB_octal);
            this.groupBox3.Location = new System.Drawing.Point(5, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 66);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Octalsystem";
            // 
            // TB_octal
            // 
            this.TB_octal.Location = new System.Drawing.Point(6, 25);
            this.TB_octal.Name = "TB_octal";
            this.TB_octal.Size = new System.Drawing.Size(254, 26);
            this.TB_octal.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TB_decimal);
            this.groupBox4.Location = new System.Drawing.Point(5, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 66);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dezimalsystem";
            // 
            // TB_decimal
            // 
            this.TB_decimal.Location = new System.Drawing.Point(6, 25);
            this.TB_decimal.Name = "TB_decimal";
            this.TB_decimal.Size = new System.Drawing.Size(254, 26);
            this.TB_decimal.TabIndex = 3;
            // 
            // BTN_clearInputs
            // 
            this.BTN_clearInputs.Location = new System.Drawing.Point(10, 321);
            this.BTN_clearInputs.Name = "BTN_clearInputs";
            this.BTN_clearInputs.Size = new System.Drawing.Size(261, 33);
            this.BTN_clearInputs.TabIndex = 5;
            this.BTN_clearInputs.Text = "Eingaben zurücksetzen";
            this.BTN_clearInputs.UseVisualStyleBackColor = true;
            // 
            // UC_NumberSystemConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_clearInputs);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBL_titel);
            this.Name = "UC_NumberSystemConversion";
            this.Size = new System.Drawing.Size(283, 394);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_titel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_binary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_ternary;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TB_octal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TB_decimal;
        private System.Windows.Forms.Button BTN_clearInputs;
    }
}
