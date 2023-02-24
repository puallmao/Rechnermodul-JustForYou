
namespace Rechnermodul.Prozentrechnung.View
{
    partial class FRM_Prozentrechnung
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
            this.BTN_priceCalculation = new System.Windows.Forms.Button();
            this.BTN_percentageCalculation1 = new System.Windows.Forms.Button();
            this.BTN_percentageCalculation2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LBL_noFunctionSelected = new System.Windows.Forms.Label();
            this.UC_PriceCalculation = new Rechnermodul.Prozentrechnung.View.UC_PriceCalculation();
            this.UC_PercentageCalculation2 = new Rechnermodul.Prozentrechnung.View.UC_PercentageCalculation2();
            this.UC_PercentageCalculation1 = new Rechnermodul.Prozentrechnung.View.UC_PercentageCalculation1();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_priceCalculation);
            this.groupBox1.Controls.Add(this.BTN_percentageCalculation1);
            this.groupBox1.Controls.Add(this.BTN_percentageCalculation2);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(336, 149);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funktionswahl";
            // 
            // BTN_priceCalculation
            // 
            this.BTN_priceCalculation.Location = new System.Drawing.Point(8, 106);
            this.BTN_priceCalculation.Name = "BTN_priceCalculation";
            this.BTN_priceCalculation.Size = new System.Drawing.Size(321, 33);
            this.BTN_priceCalculation.TabIndex = 3;
            this.BTN_priceCalculation.Text = "Brutto- Nettopreis Rechner";
            this.BTN_priceCalculation.UseVisualStyleBackColor = true;
            this.BTN_priceCalculation.Click += new System.EventHandler(this.BTN_priceCalculation_Click);
            // 
            // BTN_percentageCalculation1
            // 
            this.BTN_percentageCalculation1.Location = new System.Drawing.Point(8, 28);
            this.BTN_percentageCalculation1.Name = "BTN_percentageCalculation1";
            this.BTN_percentageCalculation1.Size = new System.Drawing.Size(321, 33);
            this.BTN_percentageCalculation1.TabIndex = 1;
            this.BTN_percentageCalculation1.Text = "Prozentwertberechnung";
            this.BTN_percentageCalculation1.UseVisualStyleBackColor = true;
            this.BTN_percentageCalculation1.Click += new System.EventHandler(this.BTN_percentageCalculation1_Click);
            // 
            // BTN_percentageCalculation2
            // 
            this.BTN_percentageCalculation2.Location = new System.Drawing.Point(8, 67);
            this.BTN_percentageCalculation2.Name = "BTN_percentageCalculation2";
            this.BTN_percentageCalculation2.Size = new System.Drawing.Size(321, 33);
            this.BTN_percentageCalculation2.TabIndex = 2;
            this.BTN_percentageCalculation2.Text = "Prozentsatzberechnung";
            this.BTN_percentageCalculation2.UseVisualStyleBackColor = true;
            this.BTN_percentageCalculation2.Click += new System.EventHandler(this.BTN_percentageCalculation2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBL_noFunctionSelected);
            this.groupBox2.Controls.Add(this.UC_PriceCalculation);
            this.groupBox2.Controls.Add(this.UC_PercentageCalculation2);
            this.groupBox2.Controls.Add(this.UC_PercentageCalculation1);
            this.groupBox2.Location = new System.Drawing.Point(13, 173);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(336, 448);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funktion";
            // 
            // LBL_noFunctionSelected
            // 
            this.LBL_noFunctionSelected.AutoSize = true;
            this.LBL_noFunctionSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_noFunctionSelected.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LBL_noFunctionSelected.Location = new System.Drawing.Point(55, 214);
            this.LBL_noFunctionSelected.Name = "LBL_noFunctionSelected";
            this.LBL_noFunctionSelected.Size = new System.Drawing.Size(213, 20);
            this.LBL_noFunctionSelected.TabIndex = 6;
            this.LBL_noFunctionSelected.Text = "Noch keine Funktion gewählt";
            // 
            // UC_PriceCalculation
            // 
            this.UC_PriceCalculation.Location = new System.Drawing.Point(11, 27);
            this.UC_PriceCalculation.Name = "UC_PriceCalculation";
            this.UC_PriceCalculation.Size = new System.Drawing.Size(295, 251);
            this.UC_PriceCalculation.TabIndex = 5;
            this.UC_PriceCalculation.Visible = false;
            // 
            // UC_PercentageCalculation2
            // 
            this.UC_PercentageCalculation2.Location = new System.Drawing.Point(10, 31);
            this.UC_PercentageCalculation2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UC_PercentageCalculation2.Name = "UC_PercentageCalculation2";
            this.UC_PercentageCalculation2.Size = new System.Drawing.Size(296, 323);
            this.UC_PercentageCalculation2.TabIndex = 4;
            this.UC_PercentageCalculation2.Visible = false;
            // 
            // UC_PercentageCalculation1
            // 
            this.UC_PercentageCalculation1.Location = new System.Drawing.Point(10, 31);
            this.UC_PercentageCalculation1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UC_PercentageCalculation1.Name = "UC_PercentageCalculation1";
            this.UC_PercentageCalculation1.Size = new System.Drawing.Size(296, 408);
            this.UC_PercentageCalculation1.TabIndex = 3;
            this.UC_PercentageCalculation1.Visible = false;
            // 
            // FRM_Prozentrechnung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 632);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Prozentrechnung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prozentrechnung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Prozentrechnung_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UC_PercentageCalculation2 UC_PercentageCalculation2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_priceCalculation;
        private System.Windows.Forms.Button BTN_percentageCalculation2;
        private System.Windows.Forms.Button BTN_percentageCalculation1;
        private System.Windows.Forms.GroupBox groupBox2;
        private UC_PercentageCalculation1 UC_PercentageCalculation1;
        private UC_PriceCalculation UC_PriceCalculation;
        private System.Windows.Forms.Label LBL_noFunctionSelected;
    }
}