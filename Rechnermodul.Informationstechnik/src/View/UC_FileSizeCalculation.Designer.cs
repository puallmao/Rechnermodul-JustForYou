
namespace Rechnermodul.Informationstechnik.View
{
    partial class UC_FileSizeCalculation
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_calcVideo = new System.Windows.Forms.RadioButton();
            this.RB_calcImage = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GB_videoLength = new System.Windows.Forms.GroupBox();
            this.NUM_videoLength = new System.Windows.Forms.NumericUpDown();
            this.GB_framesPerSecond = new System.Windows.Forms.GroupBox();
            this.NUM_framesPerSecond = new System.Windows.Forms.NumericUpDown();
            this.GB_imageWidth = new System.Windows.Forms.GroupBox();
            this.NUM_imageWidth = new System.Windows.Forms.NumericUpDown();
            this.GB_imageHeight = new System.Windows.Forms.GroupBox();
            this.NUM_imageHeight = new System.Windows.Forms.NumericUpDown();
            this.GB_colorDepth = new System.Windows.Forms.GroupBox();
            this.NUM_colorDepth = new System.Windows.Forms.NumericUpDown();
            this.LBL_titel = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.TB_size = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GB_videoLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_videoLength)).BeginInit();
            this.GB_framesPerSecond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_framesPerSecond)).BeginInit();
            this.GB_imageWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_imageWidth)).BeginInit();
            this.GB_imageHeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_imageHeight)).BeginInit();
            this.GB_colorDepth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_colorDepth)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_calcVideo);
            this.groupBox1.Controls.Add(this.RB_calcImage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funktionswahl";
            // 
            // RB_calcVideo
            // 
            this.RB_calcVideo.AutoSize = true;
            this.RB_calcVideo.Location = new System.Drawing.Point(194, 25);
            this.RB_calcVideo.Name = "RB_calcVideo";
            this.RB_calcVideo.Size = new System.Drawing.Size(197, 24);
            this.RB_calcVideo.TabIndex = 1;
            this.RB_calcVideo.Text = "Videogröße berechnen";
            this.RB_calcVideo.UseVisualStyleBackColor = true;
            this.RB_calcVideo.CheckedChanged += new System.EventHandler(this.RB_calcVideo_CheckedChanged);
            // 
            // RB_calcImage
            // 
            this.RB_calcImage.AutoSize = true;
            this.RB_calcImage.Checked = true;
            this.RB_calcImage.Location = new System.Drawing.Point(6, 25);
            this.RB_calcImage.Name = "RB_calcImage";
            this.RB_calcImage.Size = new System.Drawing.Size(182, 24);
            this.RB_calcImage.TabIndex = 0;
            this.RB_calcImage.TabStop = true;
            this.RB_calcImage.Text = "Bildgröße berechnen";
            this.RB_calcImage.UseVisualStyleBackColor = true;
            this.RB_calcImage.CheckedChanged += new System.EventHandler(this.RB_calcImage_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GB_videoLength);
            this.groupBox2.Controls.Add(this.GB_framesPerSecond);
            this.groupBox2.Controls.Add(this.GB_imageWidth);
            this.groupBox2.Controls.Add(this.GB_imageHeight);
            this.groupBox2.Controls.Add(this.GB_colorDepth);
            this.groupBox2.Location = new System.Drawing.Point(7, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eingaben";
            // 
            // GB_videoLength
            // 
            this.GB_videoLength.Controls.Add(this.NUM_videoLength);
            this.GB_videoLength.Enabled = false;
            this.GB_videoLength.Location = new System.Drawing.Point(394, 97);
            this.GB_videoLength.Name = "GB_videoLength";
            this.GB_videoLength.Size = new System.Drawing.Size(137, 66);
            this.GB_videoLength.TabIndex = 6;
            this.GB_videoLength.TabStop = false;
            this.GB_videoLength.Text = "Länge in Sek.";
            // 
            // NUM_videoLength
            // 
            this.NUM_videoLength.Location = new System.Drawing.Point(6, 25);
            this.NUM_videoLength.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUM_videoLength.Name = "NUM_videoLength";
            this.NUM_videoLength.Size = new System.Drawing.Size(110, 26);
            this.NUM_videoLength.TabIndex = 1;
            this.NUM_videoLength.ValueChanged += new System.EventHandler(this.setFileSize);
            // 
            // GB_framesPerSecond
            // 
            this.GB_framesPerSecond.Controls.Add(this.NUM_framesPerSecond);
            this.GB_framesPerSecond.Enabled = false;
            this.GB_framesPerSecond.Location = new System.Drawing.Point(264, 97);
            this.GB_framesPerSecond.Name = "GB_framesPerSecond";
            this.GB_framesPerSecond.Size = new System.Drawing.Size(124, 66);
            this.GB_framesPerSecond.TabIndex = 5;
            this.GB_framesPerSecond.TabStop = false;
            this.GB_framesPerSecond.Text = "Bilder/Sek.";
            // 
            // NUM_framesPerSecond
            // 
            this.NUM_framesPerSecond.Location = new System.Drawing.Point(6, 25);
            this.NUM_framesPerSecond.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUM_framesPerSecond.Name = "NUM_framesPerSecond";
            this.NUM_framesPerSecond.Size = new System.Drawing.Size(110, 26);
            this.NUM_framesPerSecond.TabIndex = 1;
            this.NUM_framesPerSecond.ValueChanged += new System.EventHandler(this.setFileSize);
            // 
            // GB_imageWidth
            // 
            this.GB_imageWidth.Controls.Add(this.NUM_imageWidth);
            this.GB_imageWidth.Location = new System.Drawing.Point(264, 25);
            this.GB_imageWidth.Name = "GB_imageWidth";
            this.GB_imageWidth.Size = new System.Drawing.Size(267, 66);
            this.GB_imageWidth.TabIndex = 4;
            this.GB_imageWidth.TabStop = false;
            this.GB_imageWidth.Text = "Bildbreite in Pixel";
            // 
            // NUM_imageWidth
            // 
            this.NUM_imageWidth.Location = new System.Drawing.Point(6, 25);
            this.NUM_imageWidth.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUM_imageWidth.Name = "NUM_imageWidth";
            this.NUM_imageWidth.Size = new System.Drawing.Size(252, 26);
            this.NUM_imageWidth.TabIndex = 1;
            this.NUM_imageWidth.ValueChanged += new System.EventHandler(this.setFileSize);
            // 
            // GB_imageHeight
            // 
            this.GB_imageHeight.Controls.Add(this.NUM_imageHeight);
            this.GB_imageHeight.Location = new System.Drawing.Point(6, 97);
            this.GB_imageHeight.Name = "GB_imageHeight";
            this.GB_imageHeight.Size = new System.Drawing.Size(252, 66);
            this.GB_imageHeight.TabIndex = 3;
            this.GB_imageHeight.TabStop = false;
            this.GB_imageHeight.Text = "Bildhöhe in Pixel";
            // 
            // NUM_imageHeight
            // 
            this.NUM_imageHeight.Location = new System.Drawing.Point(6, 25);
            this.NUM_imageHeight.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUM_imageHeight.Name = "NUM_imageHeight";
            this.NUM_imageHeight.Size = new System.Drawing.Size(240, 26);
            this.NUM_imageHeight.TabIndex = 1;
            this.NUM_imageHeight.ValueChanged += new System.EventHandler(this.setFileSize);
            // 
            // GB_colorDepth
            // 
            this.GB_colorDepth.Controls.Add(this.NUM_colorDepth);
            this.GB_colorDepth.Location = new System.Drawing.Point(6, 25);
            this.GB_colorDepth.Name = "GB_colorDepth";
            this.GB_colorDepth.Size = new System.Drawing.Size(252, 66);
            this.GB_colorDepth.TabIndex = 2;
            this.GB_colorDepth.TabStop = false;
            this.GB_colorDepth.Text = "Farbtiefe in Bit";
            // 
            // NUM_colorDepth
            // 
            this.NUM_colorDepth.Location = new System.Drawing.Point(6, 25);
            this.NUM_colorDepth.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUM_colorDepth.Name = "NUM_colorDepth";
            this.NUM_colorDepth.Size = new System.Drawing.Size(240, 26);
            this.NUM_colorDepth.TabIndex = 1;
            this.NUM_colorDepth.ValueChanged += new System.EventHandler(this.setFileSize);
            // 
            // LBL_titel
            // 
            this.LBL_titel.AutoSize = true;
            this.LBL_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_titel.Location = new System.Drawing.Point(0, 0);
            this.LBL_titel.Name = "LBL_titel";
            this.LBL_titel.Size = new System.Drawing.Size(244, 25);
            this.LBL_titel.TabIndex = 2;
            this.LBL_titel.Text = "Dateigrößenberechnung";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox11);
            this.groupBox7.Location = new System.Drawing.Point(7, 285);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(537, 100);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ergebnis";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.TB_size);
            this.groupBox11.Location = new System.Drawing.Point(6, 22);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(525, 66);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Speichergröße";
            // 
            // TB_size
            // 
            this.TB_size.Location = new System.Drawing.Point(6, 25);
            this.TB_size.Name = "TB_size";
            this.TB_size.ReadOnly = true;
            this.TB_size.Size = new System.Drawing.Size(510, 26);
            this.TB_size.TabIndex = 0;
            // 
            // UC_FileSizeCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.LBL_titel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_FileSizeCalculation";
            this.Size = new System.Drawing.Size(558, 394);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.GB_videoLength.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_videoLength)).EndInit();
            this.GB_framesPerSecond.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_framesPerSecond)).EndInit();
            this.GB_imageWidth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_imageWidth)).EndInit();
            this.GB_imageHeight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_imageHeight)).EndInit();
            this.GB_colorDepth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_colorDepth)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LBL_titel;
        private System.Windows.Forms.GroupBox GB_colorDepth;
        private System.Windows.Forms.GroupBox GB_imageHeight;
        private System.Windows.Forms.GroupBox GB_framesPerSecond;
        private System.Windows.Forms.GroupBox GB_imageWidth;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox TB_size;
        private System.Windows.Forms.GroupBox GB_videoLength;
        public System.Windows.Forms.NumericUpDown NUM_colorDepth;
        public System.Windows.Forms.NumericUpDown NUM_imageHeight;
        public System.Windows.Forms.NumericUpDown NUM_framesPerSecond;
        public System.Windows.Forms.NumericUpDown NUM_imageWidth;
        public System.Windows.Forms.NumericUpDown NUM_videoLength;
        public System.Windows.Forms.RadioButton RB_calcVideo;
        public System.Windows.Forms.RadioButton RB_calcImage;
    }
}
