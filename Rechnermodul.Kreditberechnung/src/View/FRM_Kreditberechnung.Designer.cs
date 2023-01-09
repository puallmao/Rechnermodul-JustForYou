
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
            this.button_creditOnePayment = new System.Windows.Forms.Button();
            this.button_creditTimed = new System.Windows.Forms.Button();
            this.button_creditRateAmount = new System.Windows.Forms.Button();
            this.label_creditsum = new System.Windows.Forms.Label();
            this.label_zinssatiz = new System.Windows.Forms.Label();
            this.label_laufzeit = new System.Windows.Forms.Label();
            this.input_kreditbetrag = new System.Windows.Forms.TextBox();
            this.input_zinssatz = new System.Windows.Forms.TextBox();
            this.input_laufzeit = new System.Windows.Forms.TextBox();
            this.label_ratenhoehe = new System.Windows.Forms.Label();
            this.input_ratenhoehe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_creditOnePayment
            // 
            this.button_creditOnePayment.Location = new System.Drawing.Point(41, 35);
            this.button_creditOnePayment.Name = "button_creditOnePayment";
            this.button_creditOnePayment.Size = new System.Drawing.Size(274, 23);
            this.button_creditOnePayment.TabIndex = 0;
            this.button_creditOnePayment.Text = "Kredit mit einmaliger Rückzahlung";
            this.button_creditOnePayment.UseVisualStyleBackColor = true;
            this.button_creditOnePayment.Click += new System.EventHandler(this.button_creditOnePayment_Click);
            // 
            // button_creditTimed
            // 
            this.button_creditTimed.Location = new System.Drawing.Point(41, 64);
            this.button_creditTimed.Name = "button_creditTimed";
            this.button_creditTimed.Size = new System.Drawing.Size(274, 23);
            this.button_creditTimed.TabIndex = 1;
            this.button_creditTimed.Text = "Ratenkredit, Vorgabe der Laufzeit";
            this.button_creditTimed.UseVisualStyleBackColor = true;
            this.button_creditTimed.Click += new System.EventHandler(this.button_creditTimed_Click);
            // 
            // button_creditRateAmount
            // 
            this.button_creditRateAmount.Location = new System.Drawing.Point(41, 94);
            this.button_creditRateAmount.Name = "button_creditRateAmount";
            this.button_creditRateAmount.Size = new System.Drawing.Size(274, 23);
            this.button_creditRateAmount.TabIndex = 2;
            this.button_creditRateAmount.Text = "Ratenkredit,Vorgabe der Ratenhöhe";
            this.button_creditRateAmount.UseVisualStyleBackColor = true;
            this.button_creditRateAmount.Click += new System.EventHandler(this.button_creditRateAmount_Click);
            // 
            // label_creditsum
            // 
            this.label_creditsum.AutoSize = true;
            this.label_creditsum.Location = new System.Drawing.Point(63, 164);
            this.label_creditsum.Name = "label_creditsum";
            this.label_creditsum.Size = new System.Drawing.Size(93, 13);
            this.label_creditsum.TabIndex = 3;
            this.label_creditsum.Text = "Kreditbetrag (in €):";
            // 
            // label_zinssatiz
            // 
            this.label_zinssatiz.AutoSize = true;
            this.label_zinssatiz.Location = new System.Drawing.Point(63, 201);
            this.label_zinssatiz.Name = "label_zinssatiz";
            this.label_zinssatiz.Size = new System.Drawing.Size(77, 13);
            this.label_zinssatiz.TabIndex = 4;
            this.label_zinssatiz.Text = "Zinssatz (in %):";
            // 
            // label_laufzeit
            // 
            this.label_laufzeit.Location = new System.Drawing.Point(63, 241);
            this.label_laufzeit.Name = "label_laufzeit";
            this.label_laufzeit.Size = new System.Drawing.Size(112, 13);
            this.label_laufzeit.TabIndex = 0;
            this.label_laufzeit.Text = "Laufzeit (in Monaten):";
            // 
            // input_kreditbetrag
            // 
            this.input_kreditbetrag.Location = new System.Drawing.Point(215, 157);
            this.input_kreditbetrag.Name = "input_kreditbetrag";
            this.input_kreditbetrag.Size = new System.Drawing.Size(100, 20);
            this.input_kreditbetrag.TabIndex = 5;
            this.input_kreditbetrag.TextChanged += new System.EventHandler(this.input_kreditbetrag_TextChanged);
            // 
            // input_zinssatz
            // 
            this.input_zinssatz.Location = new System.Drawing.Point(215, 194);
            this.input_zinssatz.Name = "input_zinssatz";
            this.input_zinssatz.Size = new System.Drawing.Size(100, 20);
            this.input_zinssatz.TabIndex = 6;
            this.input_zinssatz.TextChanged += new System.EventHandler(this.input_zinssatz_TextChanged);
            // 
            // input_laufzeit
            // 
            this.input_laufzeit.Location = new System.Drawing.Point(215, 234);
            this.input_laufzeit.Name = "input_laufzeit";
            this.input_laufzeit.Size = new System.Drawing.Size(100, 20);
            this.input_laufzeit.TabIndex = 7;
            this.input_laufzeit.TextChanged += new System.EventHandler(this.input_laufzeit_TextChanged);
            // 
            // label_ratenhoehe
            // 
            this.label_ratenhoehe.AutoSize = true;
            this.label_ratenhoehe.Location = new System.Drawing.Point(66, 285);
            this.label_ratenhoehe.Name = "label_ratenhoehe";
            this.label_ratenhoehe.Size = new System.Drawing.Size(89, 13);
            this.label_ratenhoehe.TabIndex = 8;
            this.label_ratenhoehe.Text = "Ratenhöhe (in €):";
            // 
            // input_ratenhoehe
            // 
            this.input_ratenhoehe.Location = new System.Drawing.Point(215, 278);
            this.input_ratenhoehe.Name = "input_ratenhoehe";
            this.input_ratenhoehe.Size = new System.Drawing.Size(100, 20);
            this.input_ratenhoehe.TabIndex = 9;
            this.input_ratenhoehe.TextChanged += new System.EventHandler(this.input_ratenhoehe_TextChanged);
            // 
            // FRM_Kreditberechnung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.input_ratenhoehe);
            this.Controls.Add(this.label_ratenhoehe);
            this.Controls.Add(this.input_laufzeit);
            this.Controls.Add(this.input_zinssatz);
            this.Controls.Add(this.input_kreditbetrag);
            this.Controls.Add(this.label_laufzeit);
            this.Controls.Add(this.label_zinssatiz);
            this.Controls.Add(this.label_creditsum);
            this.Controls.Add(this.button_creditRateAmount);
            this.Controls.Add(this.button_creditTimed);
            this.Controls.Add(this.button_creditOnePayment);
            this.Name = "FRM_Kreditberechnung";
            this.Text = "Kreditberechnung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_creditOnePayment;
        private System.Windows.Forms.Button button_creditTimed;
        private System.Windows.Forms.Button button_creditRateAmount;
        private System.Windows.Forms.Label label_creditsum;
        private System.Windows.Forms.Label label_zinssatiz;
        private System.Windows.Forms.Label label_laufzeit;
        private System.Windows.Forms.TextBox input_kreditbetrag;
        private System.Windows.Forms.TextBox input_zinssatz;
        private System.Windows.Forms.TextBox input_laufzeit;
        private System.Windows.Forms.Label label_ratenhoehe;
        private System.Windows.Forms.TextBox input_ratenhoehe;
    }
}