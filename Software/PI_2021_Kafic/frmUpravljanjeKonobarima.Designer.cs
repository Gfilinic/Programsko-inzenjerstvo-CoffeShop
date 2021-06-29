namespace PI_2021_Kafic
{
    partial class frmUpravljanjeKonobarima
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
            this.lbKonobari = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.cbVoditelj = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPassE = new System.Windows.Forms.TextBox();
            this.btnUredi = new System.Windows.Forms.Button();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.txtOIBE = new System.Windows.Forms.TextBox();
            this.txtPrezimeE = new System.Windows.Forms.TextBox();
            this.txtImeE = new System.Windows.Forms.TextBox();
            this.cbVoditeljE = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbKonobari
            // 
            this.lbKonobari.FormattingEnabled = true;
            this.lbKonobari.ItemHeight = 31;
            this.lbKonobari.Location = new System.Drawing.Point(32, 50);
            this.lbKonobari.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lbKonobari.Name = "lbKonobari";
            this.lbKonobari.Size = new System.Drawing.Size(391, 934);
            this.lbKonobari.TabIndex = 0;
            this.lbKonobari.SelectedIndexChanged += new System.EventHandler(this.lbKonobari_SelectedIndexChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(27, 520);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(773, 55);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj Konobara";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.dtpPocetak);
            this.groupBox1.Controls.Add(this.txtOIB);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.cbVoditelj);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(445, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(816, 613);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj novog konobara";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(259, 339);
            this.txtPass.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(527, 38);
            this.txtPass.TabIndex = 6;
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Location = new System.Drawing.Point(259, 260);
            this.dtpPocetak.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(527, 38);
            this.dtpPocetak.TabIndex = 5;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(259, 181);
            this.txtOIB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(527, 38);
            this.txtOIB.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(259, 129);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(527, 38);
            this.txtPrezime.TabIndex = 4;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(259, 69);
            this.txtIme.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(527, 38);
            this.txtIme.TabIndex = 4;
            // 
            // cbVoditelj
            // 
            this.cbVoditelj.AutoSize = true;
            this.cbVoditelj.Location = new System.Drawing.Point(453, 422);
            this.cbVoditelj.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbVoditelj.Name = "cbVoditelj";
            this.cbVoditelj.Size = new System.Drawing.Size(34, 33);
            this.cbVoditelj.TabIndex = 3;
            this.cbVoditelj.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 422);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Voditelj: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sifra: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Datum pocetka: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "OIB: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prezime: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPassE);
            this.groupBox2.Controls.Add(this.btnUredi);
            this.groupBox2.Controls.Add(this.dtpKraj);
            this.groupBox2.Controls.Add(this.txtOIBE);
            this.groupBox2.Controls.Add(this.txtPrezimeE);
            this.groupBox2.Controls.Add(this.txtImeE);
            this.groupBox2.Controls.Add(this.cbVoditeljE);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(1285, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(816, 613);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uredi Konobara";
            // 
            // txtPassE
            // 
            this.txtPassE.Location = new System.Drawing.Point(259, 355);
            this.txtPassE.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPassE.Name = "txtPassE";
            this.txtPassE.Size = new System.Drawing.Size(527, 38);
            this.txtPassE.TabIndex = 6;
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(27, 520);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(773, 55);
            this.btnUredi.TabIndex = 1;
            this.btnUredi.Text = "Spremi promjene";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // dtpKraj
            // 
            this.dtpKraj.Location = new System.Drawing.Point(259, 260);
            this.dtpKraj.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(527, 38);
            this.dtpKraj.TabIndex = 5;
            // 
            // txtOIBE
            // 
            this.txtOIBE.Location = new System.Drawing.Point(259, 181);
            this.txtOIBE.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtOIBE.Name = "txtOIBE";
            this.txtOIBE.Size = new System.Drawing.Size(527, 38);
            this.txtOIBE.TabIndex = 4;
            // 
            // txtPrezimeE
            // 
            this.txtPrezimeE.Location = new System.Drawing.Point(259, 129);
            this.txtPrezimeE.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPrezimeE.Name = "txtPrezimeE";
            this.txtPrezimeE.Size = new System.Drawing.Size(527, 38);
            this.txtPrezimeE.TabIndex = 4;
            // 
            // txtImeE
            // 
            this.txtImeE.Location = new System.Drawing.Point(259, 69);
            this.txtImeE.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtImeE.Name = "txtImeE";
            this.txtImeE.Size = new System.Drawing.Size(527, 38);
            this.txtImeE.TabIndex = 4;
            // 
            // cbVoditeljE
            // 
            this.cbVoditeljE.AutoSize = true;
            this.cbVoditeljE.Location = new System.Drawing.Point(453, 422);
            this.cbVoditeljE.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbVoditeljE.Name = "cbVoditeljE";
            this.cbVoditeljE.Size = new System.Drawing.Size(34, 33);
            this.cbVoditeljE.TabIndex = 3;
            this.cbVoditeljE.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 422);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Voditelj: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 355);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Sifra: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 260);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Datum kraja: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 181);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "OIB: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 129);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Prezime: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 69);
            this.label14.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 32);
            this.label14.TabIndex = 0;
            this.label14.Text = "Ime: ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(32, 1004);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(403, 52);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Obrisi odabranog konobara";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmUpravljanjeKonobarima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbKonobari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmUpravljanjeKonobarima";
            this.Text = "upravljanje konobarima";
            this.Load += new System.EventHandler(this.frmUpravljanjeKonobarima_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbKonobari;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.CheckBox cbVoditelj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPassE;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.TextBox txtOIBE;
        private System.Windows.Forms.TextBox txtPrezimeE;
        private System.Windows.Forms.TextBox txtImeE;
        private System.Windows.Forms.CheckBox cbVoditeljE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDelete;
    }
}