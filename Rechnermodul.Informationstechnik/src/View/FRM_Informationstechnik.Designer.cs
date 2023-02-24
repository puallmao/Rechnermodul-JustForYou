
namespace Rechnermodul.Informationstechnik.View
{
    partial class FRM_Informationstechnik
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
            this.BTN_fileSizeCalculation = new System.Windows.Forms.Button();
            this.BTN_numberSystemConversion = new System.Windows.Forms.Button();
            this.BTN_dataSizeConversion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UC_NumberSystemConversion = new Rechnermodul.Informationstechnik.View.UC_NumberSystemConversion();
            this.UC_FileSizeCalculation = new Rechnermodul.Informationstechnik.View.UC_FileSizeCalculation();
            this.UC_DataSizeConversion = new Rechnermodul.Informationstechnik.View.UC_DataSizeConversion();
            this.LBL_noFunctionSelected = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_fileSizeCalculation);
            this.groupBox1.Controls.Add(this.BTN_numberSystemConversion);
            this.groupBox1.Controls.Add(this.BTN_dataSizeConversion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funktionswahl";
            // 
            // BTN_fileSizeCalculation
            // 
            this.BTN_fileSizeCalculation.Location = new System.Drawing.Point(364, 25);
            this.BTN_fileSizeCalculation.Name = "BTN_fileSizeCalculation";
            this.BTN_fileSizeCalculation.Size = new System.Drawing.Size(170, 55);
            this.BTN_fileSizeCalculation.TabIndex = 2;
            this.BTN_fileSizeCalculation.Text = "Dateigrößen berechnen";
            this.BTN_fileSizeCalculation.UseVisualStyleBackColor = true;
            this.BTN_fileSizeCalculation.Click += new System.EventHandler(this.BTN_fileSizeCalculation_Click);
            // 
            // BTN_numberSystemConversion
            // 
            this.BTN_numberSystemConversion.Location = new System.Drawing.Point(185, 25);
            this.BTN_numberSystemConversion.Name = "BTN_numberSystemConversion";
            this.BTN_numberSystemConversion.Size = new System.Drawing.Size(170, 55);
            this.BTN_numberSystemConversion.TabIndex = 1;
            this.BTN_numberSystemConversion.Text = "Zahlensysteme umrechnen";
            this.BTN_numberSystemConversion.UseVisualStyleBackColor = true;
            this.BTN_numberSystemConversion.Click += new System.EventHandler(this.BTN_numberSystemConversion_Click);
            // 
            // BTN_dataSizeConversion
            // 
            this.BTN_dataSizeConversion.Location = new System.Drawing.Point(6, 25);
            this.BTN_dataSizeConversion.Name = "BTN_dataSizeConversion";
            this.BTN_dataSizeConversion.Size = new System.Drawing.Size(170, 55);
            this.BTN_dataSizeConversion.TabIndex = 0;
            this.BTN_dataSizeConversion.Text = "Datenmengen umrechnen";
            this.BTN_dataSizeConversion.UseVisualStyleBackColor = true;
            this.BTN_dataSizeConversion.Click += new System.EventHandler(this.BTN_dataSizeConversion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UC_NumberSystemConversion);
            this.groupBox2.Controls.Add(this.UC_FileSizeCalculation);
            this.groupBox2.Controls.Add(this.UC_DataSizeConversion);
            this.groupBox2.Controls.Add(this.LBL_noFunctionSelected);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 418);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funktion";
            // 
            // UC_NumberSystemConversion
            // 
            this.UC_NumberSystemConversion.Location = new System.Drawing.Point(7, 26);
            this.UC_NumberSystemConversion.Name = "UC_NumberSystemConversion";
            this.UC_NumberSystemConversion.Size = new System.Drawing.Size(310, 367);
            this.UC_NumberSystemConversion.TabIndex = 3;
            this.UC_NumberSystemConversion.Visible = false;
            // 
            // UC_FileSizeCalculation
            // 
            this.UC_FileSizeCalculation.Location = new System.Drawing.Point(5, 26);
            this.UC_FileSizeCalculation.Name = "UC_FileSizeCalculation";
            this.UC_FileSizeCalculation.Size = new System.Drawing.Size(553, 386);
            this.UC_FileSizeCalculation.TabIndex = 2;
            this.UC_FileSizeCalculation.Visible = false;
            // 
            // UC_DataSizeConversion
            // 
            this.UC_DataSizeConversion.Location = new System.Drawing.Point(5, 26);
            this.UC_DataSizeConversion.Name = "UC_DataSizeConversion";
            this.UC_DataSizeConversion.Size = new System.Drawing.Size(553, 367);
            this.UC_DataSizeConversion.TabIndex = 1;
            this.UC_DataSizeConversion.Visible = false;
            // 
            // LBL_noFunctionSelected
            // 
            this.LBL_noFunctionSelected.AutoSize = true;
            this.LBL_noFunctionSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_noFunctionSelected.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LBL_noFunctionSelected.Location = new System.Drawing.Point(167, 222);
            this.LBL_noFunctionSelected.Name = "LBL_noFunctionSelected";
            this.LBL_noFunctionSelected.Size = new System.Drawing.Size(213, 20);
            this.LBL_noFunctionSelected.TabIndex = 0;
            this.LBL_noFunctionSelected.Text = "Noch keine Funktion gewählt";
            // 
            // FRM_Informationstechnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Informationstechnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informationstechnik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Informationstechnik_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Informationstechnik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_fileSizeCalculation;
        private System.Windows.Forms.Button BTN_numberSystemConversion;
        private System.Windows.Forms.Button BTN_dataSizeConversion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LBL_noFunctionSelected;
        private View.UC_NumberSystemConversion UC_NumberSystemConversion;
        private View.UC_FileSizeCalculation UC_FileSizeCalculation;
        private View.UC_DataSizeConversion UC_DataSizeConversion;
    }
}