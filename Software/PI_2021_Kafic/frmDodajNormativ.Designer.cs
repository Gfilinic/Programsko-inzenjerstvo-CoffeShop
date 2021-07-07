
namespace PI_2021_Kafic
{
    partial class frmDodajNormativ
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
            this.lbStavkeNormativa = new System.Windows.Forms.ListBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDodajstavku = new System.Windows.Forms.GroupBox();
            this.btnRemoveStavka = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.cmbNamirnice = new System.Windows.Forms.ComboBox();
            this.btnDodajNormativ = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbDodajstavku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStavkeNormativa
            // 
            this.lbStavkeNormativa.FormattingEnabled = true;
            this.lbStavkeNormativa.Location = new System.Drawing.Point(25, 28);
            this.lbStavkeNormativa.Margin = new System.Windows.Forms.Padding(2);
            this.lbStavkeNormativa.Name = "lbStavkeNormativa";
            this.lbStavkeNormativa.Size = new System.Drawing.Size(157, 290);
            this.lbStavkeNormativa.TabIndex = 0;
            this.lbStavkeNormativa.SelectedIndexChanged += new System.EventHandler(this.lbStavkeNormativa_SelectedIndexChanged);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(296, 28);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(76, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv normativa:";
            // 
            // gbDodajstavku
            // 
            this.gbDodajstavku.Controls.Add(this.btnRemoveStavka);
            this.gbDodajstavku.Controls.Add(this.btnDodajStavku);
            this.gbDodajstavku.Controls.Add(this.label3);
            this.gbDodajstavku.Controls.Add(this.label2);
            this.gbDodajstavku.Controls.Add(this.nudKolicina);
            this.gbDodajstavku.Controls.Add(this.cmbNamirnice);
            this.gbDodajstavku.Location = new System.Drawing.Point(208, 114);
            this.gbDodajstavku.Margin = new System.Windows.Forms.Padding(2);
            this.gbDodajstavku.Name = "gbDodajstavku";
            this.gbDodajstavku.Padding = new System.Windows.Forms.Padding(2);
            this.gbDodajstavku.Size = new System.Drawing.Size(272, 157);
            this.gbDodajstavku.TabIndex = 3;
            this.gbDodajstavku.TabStop = false;
            this.gbDodajstavku.Text = "Stavke normativa";
            // 
            // btnRemoveStavka
            // 
            this.btnRemoveStavka.Location = new System.Drawing.Point(131, 115);
            this.btnRemoveStavka.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveStavka.Name = "btnRemoveStavka";
            this.btnRemoveStavka.Size = new System.Drawing.Size(86, 19);
            this.btnRemoveStavka.TabIndex = 3;
            this.btnRemoveStavka.Text = "Ukloni stavku";
            this.btnRemoveStavka.UseVisualStyleBackColor = true;
            this.btnRemoveStavka.Click += new System.EventHandler(this.btnRemoveStavka_Click);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(23, 115);
            this.btnDodajStavku.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(86, 19);
            this.btnDodajStavku.TabIndex = 3;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odaberite kolicinu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odaberite namirnicu:";
            // 
            // nudKolicina
            // 
            this.nudKolicina.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudKolicina.Location = new System.Drawing.Point(147, 67);
            this.nudKolicina.Margin = new System.Windows.Forms.Padding(2);
            this.nudKolicina.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(87, 20);
            this.nudKolicina.TabIndex = 1;
            this.nudKolicina.ThousandsSeparator = true;
            // 
            // cmbNamirnice
            // 
            this.cmbNamirnice.FormattingEnabled = true;
            this.cmbNamirnice.Location = new System.Drawing.Point(131, 39);
            this.cmbNamirnice.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNamirnice.Name = "cmbNamirnice";
            this.cmbNamirnice.Size = new System.Drawing.Size(104, 21);
            this.cmbNamirnice.TabIndex = 0;
            this.cmbNamirnice.SelectedIndexChanged += new System.EventHandler(this.cmbNamirnice_SelectedIndexChanged);
            // 
            // btnDodajNormativ
            // 
            this.btnDodajNormativ.Location = new System.Drawing.Point(209, 294);
            this.btnDodajNormativ.Name = "btnDodajNormativ";
            this.btnDodajNormativ.Size = new System.Drawing.Size(75, 23);
            this.btnDodajNormativ.TabIndex = 4;
            this.btnDodajNormativ.Text = "Dodaj normativ";
            this.btnDodajNormativ.UseVisualStyleBackColor = true;
            this.btnDodajNormativ.Click += new System.EventHandler(this.btnDodajNormativ_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(326, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDodajNormativ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDodajNormativ);
            this.Controls.Add(this.gbDodajstavku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lbStavkeNormativa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDodajNormativ";
            this.Text = "Dodaj normativ";
            this.Load += new System.EventHandler(this.frmDodajNormativ_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmDodajNormativ_HelpRequested);
            this.gbDodajstavku.ResumeLayout(false);
            this.gbDodajstavku.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStavkeNormativa;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDodajstavku;
        private System.Windows.Forms.ComboBox cmbNamirnice;
        private System.Windows.Forms.NumericUpDown nudKolicina;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajNormativ;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemoveStavka;
    }
}