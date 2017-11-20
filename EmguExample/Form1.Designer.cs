namespace EmguExample
{
    partial class Form1
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
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxFilter = new System.Windows.Forms.PictureBox();
            this.hueBarMin = new System.Windows.Forms.TrackBar();
            this.satBarMin = new System.Windows.Forms.TrackBar();
            this.valBarMin = new System.Windows.Forms.TrackBar();
            this.valBarMax = new System.Windows.Forms.TrackBar();
            this.satBarMax = new System.Windows.Forms.TrackBar();
            this.hueBarMax = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueBarMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satBarMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valBarMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valBarMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satBarMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueBarMax)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(478, 320);
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxFilter
            // 
            this.pictureBoxFilter.Location = new System.Drawing.Point(496, 12);
            this.pictureBoxFilter.Name = "pictureBoxFilter";
            this.pictureBoxFilter.Size = new System.Drawing.Size(478, 320);
            this.pictureBoxFilter.TabIndex = 1;
            this.pictureBoxFilter.TabStop = false;
            // 
            // hueBarMin
            // 
            this.hueBarMin.Location = new System.Drawing.Point(12, 353);
            this.hueBarMin.Maximum = 180;
            this.hueBarMin.Name = "hueBarMin";
            this.hueBarMin.Size = new System.Drawing.Size(478, 56);
            this.hueBarMin.TabIndex = 2;
            this.hueBarMin.Scroll += new System.EventHandler(this.hueBarMin_Scroll);
            // 
            // satBarMin
            // 
            this.satBarMin.Location = new System.Drawing.Point(496, 353);
            this.satBarMin.Maximum = 255;
            this.satBarMin.Name = "satBarMin";
            this.satBarMin.Size = new System.Drawing.Size(478, 56);
            this.satBarMin.TabIndex = 3;
            this.satBarMin.Scroll += new System.EventHandler(this.satBarMin_Scroll);
            // 
            // valBarMin
            // 
            this.valBarMin.Location = new System.Drawing.Point(980, 353);
            this.valBarMin.Maximum = 255;
            this.valBarMin.Name = "valBarMin";
            this.valBarMin.Size = new System.Drawing.Size(478, 56);
            this.valBarMin.TabIndex = 4;
            this.valBarMin.Scroll += new System.EventHandler(this.valBarMin_Scroll);
            // 
            // valBarMax
            // 
            this.valBarMax.Location = new System.Drawing.Point(980, 413);
            this.valBarMax.Maximum = 255;
            this.valBarMax.Name = "valBarMax";
            this.valBarMax.Size = new System.Drawing.Size(478, 56);
            this.valBarMax.TabIndex = 7;
            this.valBarMax.Scroll += new System.EventHandler(this.valBarMax_Scroll);
            // 
            // satBarMax
            // 
            this.satBarMax.Location = new System.Drawing.Point(496, 413);
            this.satBarMax.Maximum = 255;
            this.satBarMax.Name = "satBarMax";
            this.satBarMax.Size = new System.Drawing.Size(478, 56);
            this.satBarMax.TabIndex = 6;
            this.satBarMax.Scroll += new System.EventHandler(this.satBarMax_Scroll);
            // 
            // hueBarMax
            // 
            this.hueBarMax.Location = new System.Drawing.Point(12, 413);
            this.hueBarMax.Maximum = 180;
            this.hueBarMax.Name = "hueBarMax";
            this.hueBarMax.Size = new System.Drawing.Size(478, 56);
            this.hueBarMax.TabIndex = 5;
            this.hueBarMax.Scroll += new System.EventHandler(this.hueBarMax_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 481);
            this.Controls.Add(this.valBarMax);
            this.Controls.Add(this.satBarMax);
            this.Controls.Add(this.hueBarMax);
            this.Controls.Add(this.valBarMin);
            this.Controls.Add(this.satBarMin);
            this.Controls.Add(this.hueBarMin);
            this.Controls.Add(this.pictureBoxFilter);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueBarMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satBarMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valBarMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valBarMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satBarMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueBarMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxFilter;
        private System.Windows.Forms.TrackBar hueBarMin;
        private System.Windows.Forms.TrackBar satBarMin;
        private System.Windows.Forms.TrackBar valBarMin;
        private System.Windows.Forms.TrackBar valBarMax;
        private System.Windows.Forms.TrackBar satBarMax;
        private System.Windows.Forms.TrackBar hueBarMax;
    }
}

