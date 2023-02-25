
namespace Rechnermodul.Main.View
{
    partial class FRM_Main
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
            this.LB_history = new System.Windows.Forms.ListBox();
            this.BTN_deleteHistory = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_openGrundrechner = new System.Windows.Forms.Button();
            this.BTN_openSelectedModule = new System.Windows.Forms.Button();
            this.LB_modules = new System.Windows.Forms.ListBox();
            this.MS_default = new System.Windows.Forms.MenuStrip();
            this.TSMI_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.MS_default.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LB_history);
            this.groupBox1.Controls.Add(this.BTN_deleteHistory);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historie";
            // 
            // LB_history
            // 
            this.LB_history.FormattingEnabled = true;
            this.LB_history.HorizontalScrollbar = true;
            this.LB_history.ItemHeight = 20;
            this.LB_history.Location = new System.Drawing.Point(10, 25);
            this.LB_history.Name = "LB_history";
            this.LB_history.Size = new System.Drawing.Size(278, 224);
            this.LB_history.TabIndex = 7;
            // 
            // BTN_deleteHistory
            // 
            this.BTN_deleteHistory.Location = new System.Drawing.Point(10, 258);
            this.BTN_deleteHistory.Name = "BTN_deleteHistory";
            this.BTN_deleteHistory.Size = new System.Drawing.Size(278, 45);
            this.BTN_deleteHistory.TabIndex = 4;
            this.BTN_deleteHistory.Text = "Historie löschen";
            this.BTN_deleteHistory.UseVisualStyleBackColor = true;
            this.BTN_deleteHistory.Click += new System.EventHandler(this.BTN_deleteHistory_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_openGrundrechner);
            this.groupBox2.Controls.Add(this.BTN_openSelectedModule);
            this.groupBox2.Controls.Add(this.LB_modules);
            this.groupBox2.Location = new System.Drawing.Point(331, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 314);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Module";
            // 
            // BTN_openGrundrechner
            // 
            this.BTN_openGrundrechner.Location = new System.Drawing.Point(13, 258);
            this.BTN_openGrundrechner.Name = "BTN_openGrundrechner";
            this.BTN_openGrundrechner.Size = new System.Drawing.Size(232, 45);
            this.BTN_openGrundrechner.TabIndex = 6;
            this.BTN_openGrundrechner.Text = "Grundrechner";
            this.BTN_openGrundrechner.UseVisualStyleBackColor = true;
            this.BTN_openGrundrechner.Click += new System.EventHandler(this.BTN_openGrundrechner_Click);
            // 
            // BTN_openSelectedModule
            // 
            this.BTN_openSelectedModule.Location = new System.Drawing.Point(13, 215);
            this.BTN_openSelectedModule.Name = "BTN_openSelectedModule";
            this.BTN_openSelectedModule.Size = new System.Drawing.Size(232, 37);
            this.BTN_openSelectedModule.TabIndex = 5;
            this.BTN_openSelectedModule.Text = "Modul öffnen";
            this.BTN_openSelectedModule.UseVisualStyleBackColor = true;
            this.BTN_openSelectedModule.Click += new System.EventHandler(this.BTN_openSelectedModule_Click);
            // 
            // LB_modules
            // 
            this.LB_modules.FormattingEnabled = true;
            this.LB_modules.ItemHeight = 20;
            this.LB_modules.Location = new System.Drawing.Point(12, 25);
            this.LB_modules.Name = "LB_modules";
            this.LB_modules.Size = new System.Drawing.Size(232, 184);
            this.LB_modules.TabIndex = 4;
            this.LB_modules.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LB_modules_MouseDoubleClick);
            // 
            // MS_default
            // 
            this.MS_default.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MS_default.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MS_default.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_settings});
            this.MS_default.Location = new System.Drawing.Point(0, 0);
            this.MS_default.Name = "MS_default";
            this.MS_default.Size = new System.Drawing.Size(604, 33);
            this.MS_default.TabIndex = 6;
            // 
            // TSMI_settings
            // 
            this.TSMI_settings.Name = "TSMI_settings";
            this.TSMI_settings.Size = new System.Drawing.Size(132, 29);
            this.TSMI_settings.Text = "Einstellungen";
            this.TSMI_settings.Click += new System.EventHandler(this.TSMI_settings_Click);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 362);
            this.Controls.Add(this.MS_default);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechnermodul-JustForYou";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.MS_default.ResumeLayout(false);
            this.MS_default.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_deleteHistory;
        private System.Windows.Forms.Button BTN_openGrundrechner;
        private System.Windows.Forms.Button BTN_openSelectedModule;
        private System.Windows.Forms.ListBox LB_modules;
        private System.Windows.Forms.ListBox LB_history;
        private System.Windows.Forms.MenuStrip MS_default;
        private System.Windows.Forms.ToolStripMenuItem TSMI_settings;
    }
}