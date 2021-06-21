namespace PI_2021_Kafic
{
    partial class frmSastojak
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
            this.lblSastojak = new System.Windows.Forms.Label();
            this.txtSastojak = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSastojak
            // 
            this.lblSastojak.AutoSize = true;
            this.lblSastojak.Location = new System.Drawing.Point(120, 58);
            this.lblSastojak.Name = "lblSastojak";
            this.lblSastojak.Size = new System.Drawing.Size(48, 13);
            this.lblSastojak.TabIndex = 0;
            this.lblSastojak.Text = "Sastojak";
            // 
            // txtSastojak
            // 
            this.txtSastojak.Location = new System.Drawing.Point(99, 85);
            this.txtSastojak.Name = "txtSastojak";
            this.txtSastojak.Size = new System.Drawing.Size(100, 20);
            this.txtSastojak.TabIndex = 1;
            // 
            // frmSastojak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 182);
            this.Controls.Add(this.txtSastojak);
            this.Controls.Add(this.lblSastojak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSastojak";
            this.Text = "frmSastojak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSastojak;
        private System.Windows.Forms.TextBox txtSastojak;
    }
}