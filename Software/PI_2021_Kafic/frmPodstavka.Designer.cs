namespace PI_2021_Kafic
{
    partial class frmPodstavka
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
            this.lblPodstavka = new System.Windows.Forms.Label();
            this.lblMjera = new System.Windows.Forms.Label();
            this.lblSastojak = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtPodstavka = new System.Windows.Forms.TextBox();
            this.txtMjera = new System.Windows.Forms.TextBox();
            this.txtSastojak = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblStavkaNormativa = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPodstavka
            // 
            this.lblPodstavka.AutoSize = true;
            this.lblPodstavka.Location = new System.Drawing.Point(100, 95);
            this.lblPodstavka.Name = "lblPodstavka";
            this.lblPodstavka.Size = new System.Drawing.Size(58, 13);
            this.lblPodstavka.TabIndex = 0;
            this.lblPodstavka.Text = "Podstavka";
            // 
            // lblMjera
            // 
            this.lblMjera.AutoSize = true;
            this.lblMjera.Location = new System.Drawing.Point(102, 146);
            this.lblMjera.Name = "lblMjera";
            this.lblMjera.Size = new System.Drawing.Size(33, 13);
            this.lblMjera.TabIndex = 1;
            this.lblMjera.Text = "Mjera";
            // 
            // lblSastojak
            // 
            this.lblSastojak.AutoSize = true;
            this.lblSastojak.Location = new System.Drawing.Point(102, 196);
            this.lblSastojak.Name = "lblSastojak";
            this.lblSastojak.Size = new System.Drawing.Size(48, 13);
            this.lblSastojak.TabIndex = 2;
            this.lblSastojak.Text = "Sastojak";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(102, 245);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(44, 13);
            this.lblKolicina.TabIndex = 3;
            this.lblKolicina.Text = "Količina";
            // 
            // txtPodstavka
            // 
            this.txtPodstavka.Location = new System.Drawing.Point(198, 92);
            this.txtPodstavka.Name = "txtPodstavka";
            this.txtPodstavka.Size = new System.Drawing.Size(100, 20);
            this.txtPodstavka.TabIndex = 4;
            this.txtPodstavka.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMjera
            // 
            this.txtMjera.Location = new System.Drawing.Point(198, 146);
            this.txtMjera.Name = "txtMjera";
            this.txtMjera.Size = new System.Drawing.Size(100, 20);
            this.txtMjera.TabIndex = 5;
            // 
            // txtSastojak
            // 
            this.txtSastojak.Location = new System.Drawing.Point(198, 189);
            this.txtSastojak.Name = "txtSastojak";
            this.txtSastojak.Size = new System.Drawing.Size(100, 20);
            this.txtSastojak.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(198, 245);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // lblStavkaNormativa
            // 
            this.lblStavkaNormativa.AutoSize = true;
            this.lblStavkaNormativa.Location = new System.Drawing.Point(100, 297);
            this.lblStavkaNormativa.Name = "lblStavkaNormativa";
            this.lblStavkaNormativa.Size = new System.Drawing.Size(92, 13);
            this.lblStavkaNormativa.TabIndex = 8;
            this.lblStavkaNormativa.Text = "Stavka Normativa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // frmPodstavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 365);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblStavkaNormativa);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtSastojak);
            this.Controls.Add(this.txtMjera);
            this.Controls.Add(this.txtPodstavka);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblSastojak);
            this.Controls.Add(this.lblMjera);
            this.Controls.Add(this.lblPodstavka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPodstavka";
            this.Text = "frmPodstavka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPodstavka;
        private System.Windows.Forms.Label lblMjera;
        private System.Windows.Forms.Label lblSastojak;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtPodstavka;
        private System.Windows.Forms.TextBox txtMjera;
        private System.Windows.Forms.TextBox txtSastojak;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblStavkaNormativa;
        private System.Windows.Forms.TextBox textBox1;
    }
}