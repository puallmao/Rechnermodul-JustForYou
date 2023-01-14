
namespace Rechnermodul.Informationstechnik.View
{
    partial class UC_DataSizeConversion
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NUM_inputTB = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NUM_inputGB = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NUM_inputMB = new System.Windows.Forms.NumericUpDown();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.NUM_inputKB = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NUM_inputTiB = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.NUM_inputGiB = new System.Windows.Forms.NumericUpDown();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.NUM_inputMiB = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.NUM_inputKiB = new System.Windows.Forms.NumericUpDown();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputTB)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputGB)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputMB)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputKB)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputTiB)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputGiB)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputMiB)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputKiB)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_titel
            // 
            this.LBL_titel.AutoSize = true;
            this.LBL_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_titel.Location = new System.Drawing.Point(0, 0);
            this.LBL_titel.Name = "LBL_titel";
            this.LBL_titel.Size = new System.Drawing.Size(265, 25);
            this.LBL_titel.TabIndex = 1;
            this.LBL_titel.Text = "Datenmengenumrechnung";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox3);
            this.groupBox7.Controls.Add(this.groupBox2);
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Controls.Add(this.groupBox11);
            this.groupBox7.Location = new System.Drawing.Point(5, 44);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(264, 315);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Dezimalpräfix";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NUM_inputTB);
            this.groupBox3.Location = new System.Drawing.Point(6, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 66);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TeraByte";
            // 
            // NUM_inputTB
            // 
            this.NUM_inputTB.DecimalPlaces = 6;
            this.NUM_inputTB.Location = new System.Drawing.Point(6, 25);
            this.NUM_inputTB.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.NUM_inputTB.Name = "NUM_inputTB";
            this.NUM_inputTB.Size = new System.Drawing.Size(240, 26);
            this.NUM_inputTB.TabIndex = 0;
            this.NUM_inputTB.ThousandsSeparator = true;
            this.NUM_inputTB.ValueChanged += new System.EventHandler(this.NUM_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NUM_inputGB);
            this.groupBox2.Location = new System.Drawing.Point(6, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 66);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GigaByte";
            // 
            // NUM_inputGB
            // 
            this.NUM_inputGB.DecimalPlaces = 6;
            this.NUM_inputGB.Location = new System.Drawing.Point(6, 25);
            this.NUM_inputGB.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.NUM_inputGB.Name = "NUM_inputGB";
            this.NUM_inputGB.Size = new System.Drawing.Size(240, 26);
            this.NUM_inputGB.TabIndex = 0;
            this.NUM_inputGB.ThousandsSeparator = true;
            this.NUM_inputGB.ValueChanged += new System.EventHandler(this.NUM_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NUM_inputMB);
            this.groupBox1.Location = new System.Drawing.Point(6, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MegaByte";
            // 
            // NUM_inputMB
            // 
            this.NUM_inputMB.DecimalPlaces = 6;
            this.NUM_inputMB.Location = new System.Drawing.Point(6, 25);
            this.NUM_inputMB.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.NUM_inputMB.Name = "NUM_inputMB";
            this.NUM_inputMB.Size = new System.Drawing.Size(240, 26);
            this.NUM_inputMB.TabIndex = 0;
            this.NUM_inputMB.ThousandsSeparator = true;
            this.NUM_inputMB.ValueChanged += new System.EventHandler(this.NUM_ValueChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.NUM_inputKB);
            this.groupBox11.Location = new System.Drawing.Point(6, 25);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(252, 66);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "KiloByte";
            // 
            // NUM_inputKB
            // 
            this.NUM_inputKB.DecimalPlaces = 6;
            this.NUM_inputKB.Location = new System.Drawing.Point(6, 25);
            this.NUM_inputKB.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.NUM_inputKB.Name = "NUM_inputKB";
            this.NUM_inputKB.Size = new System.Drawing.Size(240, 26);
            this.NUM_inputKB.TabIndex = 0;
            this.NUM_inputKB.ThousandsSeparator = true;
            this.NUM_inputKB.ValueChanged += new System.EventHandler(this.NUM_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.groupBox9);
            this.groupBox4.Location = new System.Drawing.Point(279, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 315);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Binärpräfix";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NUM_inputTiB);
            this.groupBox5.Location = new System.Drawing.Point(6, 241);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(252, 66);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TebiByte";
            // 
            // NUM_inputTiB
            // 
            this.NUM_inputTiB.DecimalPlaces = 6;
            this.NUM_inputTiB.Location = new System.Drawing.Point(6, 25);
            this.NUM_inputTiB.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.NUM_inputTiB.Name = "NUM_inputTiB";
            this.NUM_inputTiB.Size = new System.Drawing.Size(240, 26);
            this.NUM_inputTiB.TabIndex = 0;
            this.NUM_inputTiB.ThousandsSeparator = true;
            this.NUM_inputTiB.ValueChanged += new System.EventHandler(this.NUM_ValueChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.NUM_inputGiB);
            this.groupBox6.Location = new System.Drawing.Point(6, 169);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(252, 66);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "GibiByte";
            // 
            // NUM_inputGiB
            // 
            this.NUM_inputGiB.DecimalPlaces = 6;
            this.NUM_inputGiB.Location = new System.Drawing.Point(6, 25);
            this.NUM_inputGiB.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.NUM_inputGiB.Name = "NUM_inputGiB";
            this.NUM_inputGiB.Size = new System.Drawing.Size(240, 26);
            this.NUM_inputGiB.TabIndex = 0;
            this.NUM_inputGiB.ThousandsSeparator = true;
            this.NUM_inputGiB.ValueChanged += new System.EventHandler(this.NUM_ValueChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.NUM_inputMiB);
            this.groupBox8.Location = new System.Drawing.Point(6, 97);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(252, 66);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "MibiByte";
            // 
            // NUM_inputMiB
            // 
            this.NUM_inputMiB.DecimalPlaces = 6;
            this.NUM_inputMiB.Location = new System.Drawing.Point(6, 25);
            this.NUM_inputMiB.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.NUM_inputMiB.Name = "NUM_inputMiB";
            this.NUM_inputMiB.Size = new System.Drawing.Size(240, 26);
            this.NUM_inputMiB.TabIndex = 0;
            this.NUM_inputMiB.ThousandsSeparator = true;
            this.NUM_inputMiB.ValueChanged += new System.EventHandler(this.NUM_ValueChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.NUM_inputKiB);
            this.groupBox9.Location = new System.Drawing.Point(6, 25);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(252, 66);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "KibiByte";
            // 
            // NUM_inputKiB
            // 
            this.NUM_inputKiB.DecimalPlaces = 6;
            this.NUM_inputKiB.Location = new System.Drawing.Point(6, 25);
            this.NUM_inputKiB.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.NUM_inputKiB.Name = "NUM_inputKiB";
            this.NUM_inputKiB.Size = new System.Drawing.Size(240, 26);
            this.NUM_inputKiB.TabIndex = 0;
            this.NUM_inputKiB.ThousandsSeparator = true;
            this.NUM_inputKiB.ValueChanged += new System.EventHandler(this.NUM_ValueChanged);
            // 
            // UC_DataSizeConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.LBL_titel);
            this.Name = "UC_DataSizeConversion";
            this.Size = new System.Drawing.Size(553, 367);
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputTB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputGB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputMB)).EndInit();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputKB)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputTiB)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputGiB)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputMiB)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_inputKiB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_titel;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown NUM_inputTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown NUM_inputGB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NUM_inputMB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown NUM_inputTiB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown NUM_inputGiB;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown NUM_inputMiB;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.NumericUpDown NUM_inputKiB;
        private System.Windows.Forms.NumericUpDown NUM_inputKB;
    }
}
