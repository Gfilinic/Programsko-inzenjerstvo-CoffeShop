namespace PI_2021_Kafic
{
    partial class frmDodajNamirnicu
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
            this.lblNazivNamirnice = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cmbMjera = new System.Windows.Forms.ComboBox();
            this.lblMjera = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNazivNamirnice
            // 
            this.lblNazivNamirnice.AutoSize = true;
            this.lblNazivNamirnice.Location = new System.Drawing.Point(29, 35);
            this.lblNazivNamirnice.Name = "lblNazivNamirnice";
            this.lblNazivNamirnice.Size = new System.Drawing.Size(82, 13);
            this.lblNazivNamirnice.TabIndex = 0;
            this.lblNazivNamirnice.Text = "Naziv namirnice";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(138, 35);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // cmbMjera
            // 
            this.cmbMjera.FormattingEnabled = true;
            this.cmbMjera.Location = new System.Drawing.Point(138, 83);
            this.cmbMjera.Name = "cmbMjera";
            this.cmbMjera.Size = new System.Drawing.Size(100, 21);
            this.cmbMjera.TabIndex = 2;
            // 
            // lblMjera
            // 
            this.lblMjera.AutoSize = true;
            this.lblMjera.Location = new System.Drawing.Point(29, 86);
            this.lblMjera.Name = "lblMjera";
            this.lblMjera.Size = new System.Drawing.Size(81, 13);
            this.lblMjera.TabIndex = 0;
            this.lblMjera.Text = "Mjera namirnice";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(32, 175);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 37);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj namirnicu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(138, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDodajNamirnicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 246);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbMjera);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblMjera);
            this.Controls.Add(this.lblNazivNamirnice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDodajNamirnicu";
            this.Text = "frmDodajNamirnicu";
            this.Load += new System.EventHandler(this.frmDodajNamirnicu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivNamirnice;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbMjera;
        private System.Windows.Forms.Label lblMjera;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnCancel;
    }
}