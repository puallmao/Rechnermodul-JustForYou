
namespace Rechnermodul.Utils.Shared.View
{
    partial class FRM_Settings
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
            this.GB_Schriftart = new System.Windows.Forms.GroupBox();
            this.CB_fontFamily = new System.Windows.Forms.ComboBox();
            this.GB_Schriftgröße = new System.Windows.Forms.GroupBox();
            this.CB_fontSize = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_theme = new System.Windows.Forms.ComboBox();
            this.BTN_save = new System.Windows.Forms.Button();
            this.BTN_abort = new System.Windows.Forms.Button();
            this.GB_Schriftart.SuspendLayout();
            this.GB_Schriftgröße.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Schriftart
            // 
            this.GB_Schriftart.Controls.Add(this.CB_fontFamily);
            this.GB_Schriftart.Location = new System.Drawing.Point(12, 12);
            this.GB_Schriftart.Name = "GB_Schriftart";
            this.GB_Schriftart.Size = new System.Drawing.Size(252, 66);
            this.GB_Schriftart.TabIndex = 3;
            this.GB_Schriftart.TabStop = false;
            this.GB_Schriftart.Text = "Schriftart";
            // 
            // CB_fontFamily
            // 
            this.CB_fontFamily.FormattingEnabled = true;
            this.CB_fontFamily.Items.AddRange(new object[] {
            "Arial",
            "Calibir",
            "Microsoft Sans Serif"});
            this.CB_fontFamily.Location = new System.Drawing.Point(6, 28);
            this.CB_fontFamily.Name = "CB_fontFamily";
            this.CB_fontFamily.Size = new System.Drawing.Size(240, 28);
            this.CB_fontFamily.TabIndex = 4;
            this.CB_fontFamily.Text = "Microsoft Sans Serif";
            // 
            // GB_Schriftgröße
            // 
            this.GB_Schriftgröße.Controls.Add(this.CB_fontSize);
            this.GB_Schriftgröße.Location = new System.Drawing.Point(12, 84);
            this.GB_Schriftgröße.Name = "GB_Schriftgröße";
            this.GB_Schriftgröße.Size = new System.Drawing.Size(252, 66);
            this.GB_Schriftgröße.TabIndex = 5;
            this.GB_Schriftgröße.TabStop = false;
            this.GB_Schriftgröße.Text = "Schriftgröße";
            // 
            // CB_fontSize
            // 
            this.CB_fontSize.FormattingEnabled = true;
            this.CB_fontSize.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.CB_fontSize.Location = new System.Drawing.Point(6, 28);
            this.CB_fontSize.Name = "CB_fontSize";
            this.CB_fontSize.Size = new System.Drawing.Size(240, 28);
            this.CB_fontSize.TabIndex = 4;
            this.CB_fontSize.Text = "8";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_theme);
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 66);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Theme";
            // 
            // CB_theme
            // 
            this.CB_theme.FormattingEnabled = true;
            this.CB_theme.Items.AddRange(new object[] {
            "WhiteMode",
            "DarkMode",
            "FrogMode"});
            this.CB_theme.Location = new System.Drawing.Point(6, 28);
            this.CB_theme.Name = "CB_theme";
            this.CB_theme.Size = new System.Drawing.Size(240, 28);
            this.CB_theme.TabIndex = 4;
            this.CB_theme.Text = "WhiteMode";
            // 
            // BTN_save
            // 
            this.BTN_save.Location = new System.Drawing.Point(165, 228);
            this.BTN_save.Name = "BTN_save";
            this.BTN_save.Size = new System.Drawing.Size(99, 35);
            this.BTN_save.TabIndex = 7;
            this.BTN_save.Text = "Speichern";
            this.BTN_save.UseVisualStyleBackColor = true;
            this.BTN_save.Click += new System.EventHandler(this.BTN_save_Click);
            // 
            // BTN_abort
            // 
            this.BTN_abort.Location = new System.Drawing.Point(60, 228);
            this.BTN_abort.Name = "BTN_abort";
            this.BTN_abort.Size = new System.Drawing.Size(99, 35);
            this.BTN_abort.TabIndex = 8;
            this.BTN_abort.Text = "Abbrechen";
            this.BTN_abort.UseVisualStyleBackColor = true;
            this.BTN_abort.Click += new System.EventHandler(this.BTN_abort_Click);
            // 
            // FRM_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 270);
            this.Controls.Add(this.BTN_abort);
            this.Controls.Add(this.BTN_save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GB_Schriftgröße);
            this.Controls.Add(this.GB_Schriftart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Einstellungen";
            this.GB_Schriftart.ResumeLayout(false);
            this.GB_Schriftgröße.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Schriftart;
        private System.Windows.Forms.ComboBox CB_fontFamily;
        private System.Windows.Forms.GroupBox GB_Schriftgröße;
        private System.Windows.Forms.ComboBox CB_fontSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CB_theme;
        private System.Windows.Forms.Button BTN_save;
        private System.Windows.Forms.Button BTN_abort;
    }
}