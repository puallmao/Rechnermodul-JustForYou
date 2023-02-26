
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
            this.BTN_creditOnePayment = new System.Windows.Forms.Button();
            this.BTN_creditTimed = new System.Windows.Forms.Button();
            this.BTN_creditRateAmount = new System.Windows.Forms.Button();
            this.BTN_calc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GB_ratenhoehe = new System.Windows.Forms.GroupBox();
            this.GB_zinssatz = new System.Windows.Forms.GroupBox();
            this.GB_laufzeit = new System.Windows.Forms.GroupBox();
            this.GB_kreditbetrag = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.TB_resultSchlussrate = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.TB_resultLaufzeit = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.TB_resultZinsenGesamt = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.TB_resultRatenhoehe = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.TB_resultZinssatz = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.TB_resultKreditbetrag = new System.Windows.Forms.TextBox();
            this.MS_default = new System.Windows.Forms.MenuStrip();
            this.TSMI_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.TB_ratenhoehe = new System.Windows.Forms.TextBox();
            this.TB_laufzeit = new System.Windows.Forms.TextBox();
            this.TB_zinssatz = new System.Windows.Forms.TextBox();
            this.TB_kreditbetrag = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GB_ratenhoehe.SuspendLayout();
            this.GB_zinssatz.SuspendLayout();
            this.GB_laufzeit.SuspendLayout();
            this.GB_kreditbetrag.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.MS_default.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_creditOnePayment
            // 
            this.BTN_creditOnePayment.Location = new System.Drawing.Point(16, 27);
            this.BTN_creditOnePayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_creditOnePayment.Name = "BTN_creditOnePayment";
            this.BTN_creditOnePayment.Size = new System.Drawing.Size(168, 54);
            this.BTN_creditOnePayment.TabIndex = 0;
            this.BTN_creditOnePayment.Text = "Kredit mit einmaliger Rückzahlung";
            this.BTN_creditOnePayment.UseVisualStyleBackColor = true;
            this.BTN_creditOnePayment.Click += new System.EventHandler(this.BTN_creditOnePayment_Click);
            // 
            // BTN_creditTimed
            // 
            this.BTN_creditTimed.Location = new System.Drawing.Point(192, 27);
            this.BTN_creditTimed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_creditTimed.Name = "BTN_creditTimed";
            this.BTN_creditTimed.Size = new System.Drawing.Size(168, 54);
            this.BTN_creditTimed.TabIndex = 1;
            this.BTN_creditTimed.Text = "Ratenkredit, Vorgabe der Laufzeit";
            this.BTN_creditTimed.UseVisualStyleBackColor = true;
            this.BTN_creditTimed.Click += new System.EventHandler(this.BTN_creditTimed_Click);
            // 
            // BTN_creditRateAmount
            // 
            this.BTN_creditRateAmount.Location = new System.Drawing.Point(368, 27);
            this.BTN_creditRateAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_creditRateAmount.Name = "BTN_creditRateAmount";
            this.BTN_creditRateAmount.Size = new System.Drawing.Size(168, 54);
            this.BTN_creditRateAmount.TabIndex = 2;
            this.BTN_creditRateAmount.Text = "Ratenkredit,Vorgabe der Ratenhöhe";
            this.BTN_creditRateAmount.UseVisualStyleBackColor = true;
            this.BTN_creditRateAmount.Click += new System.EventHandler(this.BTN_creditRateAmount_Click);
            // 
            // BTN_calc
            // 
            this.BTN_calc.Location = new System.Drawing.Point(419, 168);
            this.BTN_calc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_calc.Name = "BTN_calc";
            this.BTN_calc.Size = new System.Drawing.Size(119, 49);
            this.BTN_calc.TabIndex = 10;
            this.BTN_calc.Text = "Berechnen";
            this.BTN_calc.UseVisualStyleBackColor = true;
            this.BTN_calc.Click += new System.EventHandler(this.BTN_calc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_creditOnePayment);
            this.groupBox1.Controls.Add(this.BTN_creditTimed);
            this.groupBox1.Controls.Add(this.BTN_creditRateAmount);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 92);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funktionswahl";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GB_ratenhoehe);
            this.groupBox2.Controls.Add(this.GB_zinssatz);
            this.groupBox2.Controls.Add(this.BTN_calc);
            this.groupBox2.Controls.Add(this.GB_laufzeit);
            this.groupBox2.Controls.Add(this.GB_kreditbetrag);
            this.groupBox2.Location = new System.Drawing.Point(12, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 226);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eingaben";
            // 
            // GB_ratenhoehe
            // 
            this.GB_ratenhoehe.Controls.Add(this.TB_ratenhoehe);
            this.GB_ratenhoehe.Location = new System.Drawing.Point(278, 96);
            this.GB_ratenhoehe.Name = "GB_ratenhoehe";
            this.GB_ratenhoehe.Size = new System.Drawing.Size(260, 64);
            this.GB_ratenhoehe.TabIndex = 3;
            this.GB_ratenhoehe.TabStop = false;
            this.GB_ratenhoehe.Text = "Ratenhöhe (in €)";
            // 
            // GB_zinssatz
            // 
            this.GB_zinssatz.Controls.Add(this.TB_zinssatz);
            this.GB_zinssatz.Location = new System.Drawing.Point(278, 25);
            this.GB_zinssatz.Name = "GB_zinssatz";
            this.GB_zinssatz.Size = new System.Drawing.Size(260, 64);
            this.GB_zinssatz.TabIndex = 1;
            this.GB_zinssatz.TabStop = false;
            this.GB_zinssatz.Text = "Zinssatz (in %)";
            // 
            // GB_laufzeit
            // 
            this.GB_laufzeit.Controls.Add(this.TB_laufzeit);
            this.GB_laufzeit.Location = new System.Drawing.Point(7, 95);
            this.GB_laufzeit.Name = "GB_laufzeit";
            this.GB_laufzeit.Size = new System.Drawing.Size(260, 65);
            this.GB_laufzeit.TabIndex = 2;
            this.GB_laufzeit.TabStop = false;
            this.GB_laufzeit.Text = "Laufzeit (in Monaten)";
            // 
            // GB_kreditbetrag
            // 
            this.GB_kreditbetrag.Controls.Add(this.TB_kreditbetrag);
            this.GB_kreditbetrag.Location = new System.Drawing.Point(7, 25);
            this.GB_kreditbetrag.Name = "GB_kreditbetrag";
            this.GB_kreditbetrag.Size = new System.Drawing.Size(260, 64);
            this.GB_kreditbetrag.TabIndex = 0;
            this.GB_kreditbetrag.TabStop = false;
            this.GB_kreditbetrag.Text = "Kreditbetrag (in €)";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox12);
            this.groupBox7.Controls.Add(this.groupBox13);
            this.groupBox7.Controls.Add(this.groupBox10);
            this.groupBox7.Controls.Add(this.groupBox11);
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Location = new System.Drawing.Point(12, 370);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(551, 245);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ergebnisse";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.TB_resultSchlussrate);
            this.groupBox12.Location = new System.Drawing.Point(278, 167);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(260, 65);
            this.groupBox12.TabIndex = 11;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "ggf. Schlussrate";
            // 
            // TB_resultSchlussrate
            // 
            this.TB_resultSchlussrate.Location = new System.Drawing.Point(7, 27);
            this.TB_resultSchlussrate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_resultSchlussrate.Name = "TB_resultSchlussrate";
            this.TB_resultSchlussrate.ReadOnly = true;
            this.TB_resultSchlussrate.Size = new System.Drawing.Size(246, 26);
            this.TB_resultSchlussrate.TabIndex = 6;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.TB_resultLaufzeit);
            this.groupBox13.Location = new System.Drawing.Point(7, 167);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(260, 65);
            this.groupBox13.TabIndex = 10;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Laufzeit in Monaten";
            // 
            // TB_resultLaufzeit
            // 
            this.TB_resultLaufzeit.Location = new System.Drawing.Point(7, 27);
            this.TB_resultLaufzeit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_resultLaufzeit.Name = "TB_resultLaufzeit";
            this.TB_resultLaufzeit.ReadOnly = true;
            this.TB_resultLaufzeit.Size = new System.Drawing.Size(246, 26);
            this.TB_resultLaufzeit.TabIndex = 6;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.TB_resultZinsenGesamt);
            this.groupBox10.Location = new System.Drawing.Point(278, 96);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(260, 65);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Zinsen gesamt";
            // 
            // TB_resultZinsenGesamt
            // 
            this.TB_resultZinsenGesamt.Location = new System.Drawing.Point(7, 27);
            this.TB_resultZinsenGesamt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_resultZinsenGesamt.Name = "TB_resultZinsenGesamt";
            this.TB_resultZinsenGesamt.ReadOnly = true;
            this.TB_resultZinsenGesamt.Size = new System.Drawing.Size(246, 26);
            this.TB_resultZinsenGesamt.TabIndex = 6;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.TB_resultRatenhoehe);
            this.groupBox11.Location = new System.Drawing.Point(7, 96);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(260, 65);
            this.groupBox11.TabIndex = 8;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Ratenhöhe";
            // 
            // TB_resultRatenhoehe
            // 
            this.TB_resultRatenhoehe.Location = new System.Drawing.Point(7, 27);
            this.TB_resultRatenhoehe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_resultRatenhoehe.Name = "TB_resultRatenhoehe";
            this.TB_resultRatenhoehe.ReadOnly = true;
            this.TB_resultRatenhoehe.Size = new System.Drawing.Size(246, 26);
            this.TB_resultRatenhoehe.TabIndex = 6;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.TB_resultZinssatz);
            this.groupBox9.Location = new System.Drawing.Point(278, 25);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(260, 65);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Zinssatz";
            // 
            // TB_resultZinssatz
            // 
            this.TB_resultZinssatz.Location = new System.Drawing.Point(7, 27);
            this.TB_resultZinssatz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_resultZinssatz.Name = "TB_resultZinssatz";
            this.TB_resultZinssatz.ReadOnly = true;
            this.TB_resultZinssatz.Size = new System.Drawing.Size(246, 26);
            this.TB_resultZinssatz.TabIndex = 6;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.TB_resultKreditbetrag);
            this.groupBox8.Location = new System.Drawing.Point(7, 25);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(260, 65);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Kreditbetrag";
            // 
            // TB_resultKreditbetrag
            // 
            this.TB_resultKreditbetrag.Location = new System.Drawing.Point(7, 27);
            this.TB_resultKreditbetrag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_resultKreditbetrag.Name = "TB_resultKreditbetrag";
            this.TB_resultKreditbetrag.ReadOnly = true;
            this.TB_resultKreditbetrag.Size = new System.Drawing.Size(246, 26);
            this.TB_resultKreditbetrag.TabIndex = 6;
            // 
            // MS_default
            // 
            this.MS_default.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MS_default.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_settings});
            this.MS_default.Location = new System.Drawing.Point(0, 0);
            this.MS_default.Name = "MS_default";
            this.MS_default.Size = new System.Drawing.Size(574, 33);
            this.MS_default.TabIndex = 14;
            // 
            // TSMI_settings
            // 
            this.TSMI_settings.Name = "TSMI_settings";
            this.TSMI_settings.Size = new System.Drawing.Size(132, 29);
            this.TSMI_settings.Text = "Einstellungen";
            this.TSMI_settings.Click += new System.EventHandler(this.TSMI_settings_Click);
            // 
            // TB_ratenhoehe
            // 
            this.TB_ratenhoehe.Location = new System.Drawing.Point(7, 26);
            this.TB_ratenhoehe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_ratenhoehe.Name = "TB_ratenhoehe";
            this.TB_ratenhoehe.Size = new System.Drawing.Size(246, 26);
            this.TB_ratenhoehe.TabIndex = 9;
            // 
            // TB_laufzeit
            // 
            this.TB_laufzeit.Location = new System.Drawing.Point(7, 27);
            this.TB_laufzeit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_laufzeit.Name = "TB_laufzeit";
            this.TB_laufzeit.Size = new System.Drawing.Size(246, 26);
            this.TB_laufzeit.TabIndex = 7;
            // 
            // TB_zinssatz
            // 
            this.TB_zinssatz.Location = new System.Drawing.Point(7, 26);
            this.TB_zinssatz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_zinssatz.Name = "TB_zinssatz";
            this.TB_zinssatz.Size = new System.Drawing.Size(246, 26);
            this.TB_zinssatz.TabIndex = 6;
            // 
            // TB_kreditbetrag
            // 
            this.TB_kreditbetrag.Location = new System.Drawing.Point(7, 27);
            this.TB_kreditbetrag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_kreditbetrag.Name = "TB_kreditbetrag";
            this.TB_kreditbetrag.Size = new System.Drawing.Size(246, 26);
            this.TB_kreditbetrag.TabIndex = 5;
            // 
            // FRM_Kreditberechnung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 622);
            this.Controls.Add(this.MS_default);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRM_Kreditberechnung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreditberechnung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Kreditberechnung_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Kreditberechnung_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.GB_ratenhoehe.ResumeLayout(false);
            this.GB_ratenhoehe.PerformLayout();
            this.GB_zinssatz.ResumeLayout(false);
            this.GB_zinssatz.PerformLayout();
            this.GB_laufzeit.ResumeLayout(false);
            this.GB_laufzeit.PerformLayout();
            this.GB_kreditbetrag.ResumeLayout(false);
            this.GB_kreditbetrag.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.MS_default.ResumeLayout(false);
            this.MS_default.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_creditOnePayment;
        private System.Windows.Forms.Button BTN_creditTimed;
        private System.Windows.Forms.Button BTN_creditRateAmount;
        private System.Windows.Forms.Button BTN_calc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox GB_ratenhoehe;
        private System.Windows.Forms.GroupBox GB_zinssatz;
        private System.Windows.Forms.GroupBox GB_laufzeit;
        private System.Windows.Forms.GroupBox GB_kreditbetrag;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox TB_resultSchlussrate;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.TextBox TB_resultLaufzeit;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox TB_resultZinsenGesamt;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox TB_resultRatenhoehe;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox TB_resultZinssatz;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox TB_resultKreditbetrag;
        private System.Windows.Forms.MenuStrip MS_default;
        private System.Windows.Forms.ToolStripMenuItem TSMI_settings;
        private System.Windows.Forms.TextBox TB_ratenhoehe;
        private System.Windows.Forms.TextBox TB_zinssatz;
        private System.Windows.Forms.TextBox TB_laufzeit;
        private System.Windows.Forms.TextBox TB_kreditbetrag;
    }
}