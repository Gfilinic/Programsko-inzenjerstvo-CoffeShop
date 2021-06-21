namespace PI_2021_Kafic
{
    partial class frmStavkaNormativa
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
            this.lblNormativ = new System.Windows.Forms.Label();
            this.txtNormativ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNormativ
            // 
            this.lblNormativ.AutoSize = true;
            this.lblNormativ.Location = new System.Drawing.Point(28, 86);
            this.lblNormativ.Name = "lblNormativ";
            this.lblNormativ.Size = new System.Drawing.Size(121, 13);
            this.lblNormativ.TabIndex = 0;
            this.lblNormativ.Text = "Unesite željeni normativ:";
            // 
            // txtNormativ
            // 
            this.txtNormativ.Location = new System.Drawing.Point(172, 83);
            this.txtNormativ.Name = "txtNormativ";
            this.txtNormativ.Size = new System.Drawing.Size(100, 20);
            this.txtNormativ.TabIndex = 1;
            // 
            // frmStavkaNormativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 227);
            this.Controls.Add(this.txtNormativ);
            this.Controls.Add(this.lblNormativ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStavkaNormativa";
            this.Text = "frmStavkaNormativa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNormativ;
        private System.Windows.Forms.TextBox txtNormativ;
    }
}