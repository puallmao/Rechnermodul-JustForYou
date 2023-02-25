
namespace Rechnermodul.Grundrechner.View
{
    partial class FRM_Grundrechner
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
            this.BTN_enter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_input = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_result = new System.Windows.Forms.TextBox();
            this.BTN_copy = new System.Windows.Forms.Button();
            this.MS_default = new System.Windows.Forms.MenuStrip();
            this.TSMI_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.MS_default.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_enter
            // 
            this.BTN_enter.Location = new System.Drawing.Point(344, 50);
            this.BTN_enter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_enter.Name = "BTN_enter";
            this.BTN_enter.Size = new System.Drawing.Size(144, 71);
            this.BTN_enter.TabIndex = 5;
            this.BTN_enter.Text = "Enter";
            this.BTN_enter.UseVisualStyleBackColor = true;
            this.BTN_enter.Click += new System.EventHandler(this.BTN_enter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_input);
            this.groupBox1.Location = new System.Drawing.Point(18, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(316, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingabe";
            // 
            // TB_input
            // 
            this.TB_input.Location = new System.Drawing.Point(9, 29);
            this.TB_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_input.Name = "TB_input";
            this.TB_input.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TB_input.Size = new System.Drawing.Size(296, 26);
            this.TB_input.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_result);
            this.groupBox2.Location = new System.Drawing.Point(18, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(316, 78);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eingabe";
            // 
            // TB_result
            // 
            this.TB_result.Location = new System.Drawing.Point(9, 29);
            this.TB_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_result.Name = "TB_result";
            this.TB_result.ReadOnly = true;
            this.TB_result.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TB_result.Size = new System.Drawing.Size(296, 26);
            this.TB_result.TabIndex = 0;
            // 
            // BTN_copy
            // 
            this.BTN_copy.Location = new System.Drawing.Point(344, 138);
            this.BTN_copy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_copy.Name = "BTN_copy";
            this.BTN_copy.Size = new System.Drawing.Size(144, 71);
            this.BTN_copy.TabIndex = 8;
            this.BTN_copy.Text = "Kopieren";
            this.BTN_copy.UseVisualStyleBackColor = true;
            this.BTN_copy.Click += new System.EventHandler(this.BTN_copy_Click);
            // 
            // MS_default
            // 
            this.MS_default.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MS_default.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MS_default.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_settings});
            this.MS_default.Location = new System.Drawing.Point(0, 0);
            this.MS_default.Name = "MS_default";
            this.MS_default.Size = new System.Drawing.Size(504, 33);
            this.MS_default.TabIndex = 9;
            // 
            // TSMI_settings
            // 
            this.TSMI_settings.Name = "TSMI_settings";
            this.TSMI_settings.Size = new System.Drawing.Size(132, 29);
            this.TSMI_settings.Text = "Einstellungen";
            this.TSMI_settings.Click += new System.EventHandler(this.TSMI_settings_Click);
            // 
            // FRM_Grundrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 220);
            this.Controls.Add(this.MS_default);
            this.Controls.Add(this.BTN_copy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRM_Grundrechner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grundrechner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Grundrechner_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Grundrechner_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.MS_default.ResumeLayout(false);
            this.MS_default.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_enter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_input;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_result;
        private System.Windows.Forms.Button BTN_copy;
        private System.Windows.Forms.MenuStrip MS_default;
        private System.Windows.Forms.ToolStripMenuItem TSMI_settings;
    }
}