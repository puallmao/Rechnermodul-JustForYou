
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
            this.grundrechner_txtbox = new System.Windows.Forms.TextBox();
            this.copy_btn = new System.Windows.Forms.Button();
            this.enter_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grundrechner_txtbox
            // 
            this.grundrechner_txtbox.Location = new System.Drawing.Point(12, 45);
            this.grundrechner_txtbox.Multiline = true;
            this.grundrechner_txtbox.Name = "grundrechner_txtbox";
            this.grundrechner_txtbox.Size = new System.Drawing.Size(332, 150);
            this.grundrechner_txtbox.TabIndex = 0;
            // 
            // copy_btn
            // 
            this.copy_btn.Location = new System.Drawing.Point(350, 45);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(96, 72);
            this.copy_btn.TabIndex = 1;
            this.copy_btn.Text = "Copy";
            this.copy_btn.UseVisualStyleBackColor = true;
            // 
            // enter_btn
            // 
            this.enter_btn.Location = new System.Drawing.Point(350, 123);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(96, 72);
            this.enter_btn.TabIndex = 2;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // FRM_Grundrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 206);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.copy_btn);
            this.Controls.Add(this.grundrechner_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Grundrechner";
            this.Text = "Grundrechner";
            this.Load += new System.EventHandler(this.FRM_Grundrechner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox grundrechner_txtbox;
        private System.Windows.Forms.Button copy_btn;
        private System.Windows.Forms.Button enter_btn;
    }
}