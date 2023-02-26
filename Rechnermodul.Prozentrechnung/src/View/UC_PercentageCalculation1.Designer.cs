
namespace Rechnermodul.Prozentrechnung.View
{
    partial class UC_PercentageCalculation1
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
            this.NUM_percentage = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NUM_baseValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_calcPercentageValue = new System.Windows.Forms.RadioButton();
            this.RB_subtractPercentage = new System.Windows.Forms.RadioButton();
            this.RB_addPercentage = new System.Windows.Forms.RadioButton();
            this.LBL_titel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TB_result = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_percentage)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_baseValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(11, 122);
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
            this.groupBox5.Controls.Add(this.NUM_percentage);
            this.groupBox5.Location = new System.Drawing.Point(9, 108);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(260, 77);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Prozentsatz";
            // 
            // NUM_percentage
            // 
            this.NUM_percentage.DecimalPlaces = 6;
            this.NUM_percentage.Location = new System.Drawing.Point(9, 31);
            this.NUM_percentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NUM_percentage.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NUM_percentage.Name = "NUM_percentage";
            this.NUM_percentage.Size = new System.Drawing.Size(242, 26);
            this.NUM_percentage.TabIndex = 0;
            this.NUM_percentage.ValueChanged += new System.EventHandler(this.setValue);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_calcPercentageValue);
            this.groupBox1.Controls.Add(this.RB_subtractPercentage);
            this.groupBox1.Controls.Add(this.RB_addPercentage);
            this.groupBox1.Location = new System.Drawing.Point(11, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(278, 69);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funktionswahl";
            // 
            // RB_calcPercentageValue
            // 
            this.RB_calcPercentageValue.AutoSize = true;
            this.RB_calcPercentageValue.Location = new System.Drawing.Point(174, 29);
            this.RB_calcPercentageValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RB_calcPercentageValue.Name = "RB_calcPercentageValue";
            this.RB_calcPercentageValue.Size = new System.Drawing.Size(80, 24);
            this.RB_calcPercentageValue.TabIndex = 2;
            this.RB_calcPercentageValue.Text = "Davon";
            this.RB_calcPercentageValue.UseVisualStyleBackColor = true;
            this.RB_calcPercentageValue.CheckedChanged += new System.EventHandler(this.setValue);
            // 
            // RB_subtractPercentage
            // 
            this.RB_subtractPercentage.AutoSize = true;
            this.RB_subtractPercentage.Location = new System.Drawing.Point(93, 29);
            this.RB_subtractPercentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RB_subtractPercentage.Name = "RB_subtractPercentage";
            this.RB_subtractPercentage.Size = new System.Drawing.Size(67, 24);
            this.RB_subtractPercentage.TabIndex = 1;
            this.RB_subtractPercentage.Text = "Weg";
            this.RB_subtractPercentage.UseVisualStyleBackColor = true;
            this.RB_subtractPercentage.CheckedChanged += new System.EventHandler(this.setValue);
            // 
            // RB_addPercentage
            // 
            this.RB_addPercentage.AutoSize = true;
            this.RB_addPercentage.Checked = true;
            this.RB_addPercentage.Location = new System.Drawing.Point(9, 29);
            this.RB_addPercentage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RB_addPercentage.Name = "RB_addPercentage";
            this.RB_addPercentage.Size = new System.Drawing.Size(72, 24);
            this.RB_addPercentage.TabIndex = 0;
            this.RB_addPercentage.TabStop = true;
            this.RB_addPercentage.Text = "Dazu";
            this.RB_addPercentage.UseVisualStyleBackColor = true;
            this.RB_addPercentage.CheckedChanged += new System.EventHandler(this.setValue);
            // 
            // LBL_titel
            // 
            this.LBL_titel.AutoSize = true;
            this.LBL_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_titel.Location = new System.Drawing.Point(6, 5);
            this.LBL_titel.Name = "LBL_titel";
            this.LBL_titel.Size = new System.Drawing.Size(240, 25);
            this.LBL_titel.TabIndex = 7;
            this.LBL_titel.Text = "Prozentwertberechnung";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TB_result);
            this.groupBox3.Location = new System.Drawing.Point(11, 328);
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
            // UC_PercentageCalculation1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBL_titel);
            this.Controls.Add(this.groupBox3);
            this.Name = "UC_PercentageCalculation1";
            this.Size = new System.Drawing.Size(298, 412);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_percentage)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_baseValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_calcPercentageValue;
        private System.Windows.Forms.RadioButton RB_subtractPercentage;
        private System.Windows.Forms.RadioButton RB_addPercentage;
        private System.Windows.Forms.Label LBL_titel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TB_result;
        public System.Windows.Forms.NumericUpDown NUM_percentage;
        public System.Windows.Forms.NumericUpDown NUM_baseValue;
    }
}
