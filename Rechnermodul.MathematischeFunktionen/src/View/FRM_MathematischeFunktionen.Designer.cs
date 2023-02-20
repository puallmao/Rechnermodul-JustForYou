
namespace Rechnermodul.MathematischeFunktionen.View
{
    partial class FRM_MathematischeFunktionen
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
            this.settings_btn = new System.Windows.Forms.Button();
            this.fak_btn = new System.Windows.Forms.Button();
            this.input_txtbx = new System.Windows.Forms.TextBox();
            this.wrz_btn = new System.Windows.Forms.Button();
            this.enter_btn = new System.Windows.Forms.Button();
            this.ptz_btn = new System.Windows.Forms.Button();
            this.prim_btn = new System.Windows.Forms.Button();
            this.dezi_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settings_btn
            // 
            this.settings_btn.Location = new System.Drawing.Point(14, 14);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(87, 23);
            this.settings_btn.TabIndex = 0;
            this.settings_btn.Text = "Einstellungen";
            this.settings_btn.UseVisualStyleBackColor = true;
            // 
            // fak_btn
            // 
            this.fak_btn.Location = new System.Drawing.Point(13, 100);
            this.fak_btn.Name = "fak_btn";
            this.fak_btn.Size = new System.Drawing.Size(89, 51);
            this.fak_btn.TabIndex = 1;
            this.fak_btn.Text = "Fakultät";
            this.fak_btn.UseVisualStyleBackColor = true;
            this.fak_btn.Click += new System.EventHandler(this.fak_btn_Click);
            // 
            // input_txtbx
            // 
            this.input_txtbx.Location = new System.Drawing.Point(13, 43);
            this.input_txtbx.Multiline = true;
            this.input_txtbx.Name = "input_txtbx";
            this.input_txtbx.Size = new System.Drawing.Size(184, 51);
            this.input_txtbx.TabIndex = 2;
            // 
            // wrz_btn
            // 
            this.wrz_btn.Location = new System.Drawing.Point(108, 100);
            this.wrz_btn.Name = "wrz_btn";
            this.wrz_btn.Size = new System.Drawing.Size(89, 51);
            this.wrz_btn.TabIndex = 3;
            this.wrz_btn.Text = "Wurzel";
            this.wrz_btn.UseVisualStyleBackColor = true;
            this.wrz_btn.Click += new System.EventHandler(this.wrz_btn_Click);
            // 
            // enter_btn
            // 
            this.enter_btn.Location = new System.Drawing.Point(203, 43);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(87, 51);
            this.enter_btn.TabIndex = 4;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // ptz_btn
            // 
            this.ptz_btn.Location = new System.Drawing.Point(203, 100);
            this.ptz_btn.Name = "ptz_btn";
            this.ptz_btn.Size = new System.Drawing.Size(87, 51);
            this.ptz_btn.TabIndex = 5;
            this.ptz_btn.Text = "Potenz";
            this.ptz_btn.UseVisualStyleBackColor = true;
            this.ptz_btn.Click += new System.EventHandler(this.ptz_btn_Click);
            // 
            // prim_btn
            // 
            this.prim_btn.Location = new System.Drawing.Point(14, 157);
            this.prim_btn.Name = "prim_btn";
            this.prim_btn.Size = new System.Drawing.Size(87, 51);
            this.prim_btn.TabIndex = 6;
            this.prim_btn.Text = "Primzahlen";
            this.prim_btn.UseVisualStyleBackColor = true;
            this.prim_btn.Click += new System.EventHandler(this.prim_btn_Click);
            // 
            // dezi_btn
            // 
            this.dezi_btn.Location = new System.Drawing.Point(108, 157);
            this.dezi_btn.Name = "dezi_btn";
            this.dezi_btn.Size = new System.Drawing.Size(182, 51);
            this.dezi_btn.TabIndex = 7;
            this.dezi_btn.Text = "Dezimalbruch";
            this.dezi_btn.UseVisualStyleBackColor = true;
            this.dezi_btn.Click += new System.EventHandler(this.dezi_btn_Click);
            // 
            // FRM_MathematischeFunktionen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 220);
            this.Controls.Add(this.dezi_btn);
            this.Controls.Add(this.prim_btn);
            this.Controls.Add(this.ptz_btn);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.wrz_btn);
            this.Controls.Add(this.input_txtbx);
            this.Controls.Add(this.fak_btn);
            this.Controls.Add(this.settings_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_MathematischeFunktionen";
            this.Text = "MathematischeFunktionen";
            this.Load += new System.EventHandler(this.FRM_MathematischeFunktionen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Button fak_btn;
        private System.Windows.Forms.TextBox input_txtbx;
        private System.Windows.Forms.Button wrz_btn;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Button ptz_btn;
        private System.Windows.Forms.Button prim_btn;
        private System.Windows.Forms.Button dezi_btn;
    }
}