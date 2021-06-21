namespace PI_2021_Kafic
{
    partial class frmMjera
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
            this.lblMjera = new System.Windows.Forms.Label();
            this.txtMjera = new System.Windows.Forms.TextBox();
            this.lblMjernaJedinica = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMjera
            // 
            this.lblMjera.AutoSize = true;
            this.lblMjera.Location = new System.Drawing.Point(61, 55);
            this.lblMjera.Name = "lblMjera";
            this.lblMjera.Size = new System.Drawing.Size(110, 13);
            this.lblMjera.TabIndex = 0;
            this.lblMjera.Text = "Unesite željenu mjeru:";
            this.lblMjera.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMjera
            // 
            this.txtMjera.Location = new System.Drawing.Point(188, 52);
            this.txtMjera.Name = "txtMjera";
            this.txtMjera.Size = new System.Drawing.Size(130, 20);
            this.txtMjera.TabIndex = 1;
            // 
            // lblMjernaJedinica
            // 
            this.lblMjernaJedinica.AutoSize = true;
            this.lblMjernaJedinica.Location = new System.Drawing.Point(61, 103);
            this.lblMjernaJedinica.Name = "lblMjernaJedinica";
            this.lblMjernaJedinica.Size = new System.Drawing.Size(78, 13);
            this.lblMjernaJedinica.TabIndex = 2;
            this.lblMjernaJedinica.Text = "Mjerna jedinica";
            this.lblMjernaJedinica.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // frmMjera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 239);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblMjernaJedinica);
            this.Controls.Add(this.txtMjera);
            this.Controls.Add(this.lblMjera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMjera";
            this.Text = "frmMjera";
            this.Load += new System.EventHandler(this.frmMjera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMjera;
        private System.Windows.Forms.TextBox txtMjera;
        private System.Windows.Forms.Label lblMjernaJedinica;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}