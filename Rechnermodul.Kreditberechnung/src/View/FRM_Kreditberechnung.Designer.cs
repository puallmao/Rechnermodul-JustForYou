
namespace Rechnermodul.Kreditberechnung.View
{
    partial class FRM_Kreditberechnung
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
            this.button_kreditRueckzahlung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_kreditRueckzahlung
            // 
            this.button_kreditRueckzahlung.Location = new System.Drawing.Point(60, 35);
            this.button_kreditRueckzahlung.Name = "button_kreditRueckzahlung";
            this.button_kreditRueckzahlung.Size = new System.Drawing.Size(75, 23);
            this.button_kreditRueckzahlung.TabIndex = 0;
            this.button_kreditRueckzahlung.Text = "Kredit mit einmaliger Rückzahlung";
            this.button_kreditRueckzahlung.UseVisualStyleBackColor = true;
            // 
            // FRM_Kreditberechnung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_kreditRueckzahlung);
            this.Name = "FRM_Kreditberechnung";
            this.Text = "Kreditberechnung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_kreditRueckzahlung;
    }
}