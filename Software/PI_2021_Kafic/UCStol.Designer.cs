namespace PI_2021_Kafic
{
    partial class UCStol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblImeStola = new System.Windows.Forms.Label();
            this.pbStol = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStol)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImeStola
            // 
            this.lblImeStola.AutoSize = true;
            this.lblImeStola.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeStola.Location = new System.Drawing.Point(50, 188);
            this.lblImeStola.Name = "lblImeStola";
            this.lblImeStola.Size = new System.Drawing.Size(93, 26);
            this.lblImeStola.TabIndex = 1;
            this.lblImeStola.Text = "ImeStola";
            // 
            // pbStol
            // 
            this.pbStol.Image = global::PI_2021_Kafic.Properties.Resources.meeting;
            this.pbStol.Location = new System.Drawing.Point(0, 0);
            this.pbStol.Name = "pbStol";
            this.pbStol.Size = new System.Drawing.Size(194, 185);
            this.pbStol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStol.TabIndex = 0;
            this.pbStol.TabStop = false;
            this.pbStol.Click += new System.EventHandler(this.pbStol_Click);
            // 
            // UCStol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lblImeStola);
            this.Controls.Add(this.pbStol);
            this.Name = "UCStol";
            this.Size = new System.Drawing.Size(187, 218);
            this.Load += new System.EventHandler(this.UCStol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStol;
        private System.Windows.Forms.Label lblImeStola;
    }
}
