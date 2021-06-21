
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
            this.cmbNamirnice = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbDodajstavku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStavkeNormativa
            // 
            this.lbStavkeNormativa.FormattingEnabled = true;
            this.lbStavkeNormativa.ItemHeight = 16;
            this.lbStavkeNormativa.Location = new System.Drawing.Point(33, 34);
            this.lbStavkeNormativa.Name = "lbStavkeNormativa";
            this.lbStavkeNormativa.Size = new System.Drawing.Size(208, 356);
            this.lbStavkeNormativa.TabIndex = 0;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(394, 34);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 22);
            this.txtNaziv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv normativa:";
            // 
            // gbDodajstavku
            // 
            this.gbDodajstavku.Controls.Add(this.btnDodajStavku);
            this.gbDodajstavku.Controls.Add(this.label3);
            this.gbDodajstavku.Controls.Add(this.label2);
            this.gbDodajstavku.Controls.Add(this.numericUpDown1);
            this.gbDodajstavku.Controls.Add(this.cmbNamirnice);
            this.gbDodajstavku.Location = new System.Drawing.Point(278, 140);
            this.gbDodajstavku.Name = "gbDodajstavku";
            this.gbDodajstavku.Size = new System.Drawing.Size(362, 193);
            this.gbDodajstavku.TabIndex = 3;
            this.gbDodajstavku.TabStop = false;
            this.gbDodajstavku.Text = "Dodaj stavku normativa";
            // 
            // cmbNamirnice
            // 
            this.cmbNamirnice.FormattingEnabled = true;
            this.cmbNamirnice.Location = new System.Drawing.Point(175, 48);
            this.cmbNamirnice.Name = "cmbNamirnice";
            this.cmbNamirnice.Size = new System.Drawing.Size(137, 24);
            this.cmbNamirnice.TabIndex = 0;
            this.cmbNamirnice.SelectedIndexChanged += new System.EventHandler(this.cmbNamirnice_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(259, 83);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 22);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odaberite namirnicu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odaberite kolicinu:";
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(102, 154);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(114, 23);
            this.btnDodajStavku.TabIndex = 3;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // frmDodajNormativ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbDodajstavku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lbStavkeNormativa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDodajNormativ";
            this.Text = "Dodaj normativ";
            this.Load += new System.EventHandler(this.frmDodajNormativ_Load);
            this.gbDodajstavku.ResumeLayout(false);
            this.gbDodajstavku.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStavkeNormativa;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDodajstavku;
        private System.Windows.Forms.ComboBox cmbNamirnice;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}