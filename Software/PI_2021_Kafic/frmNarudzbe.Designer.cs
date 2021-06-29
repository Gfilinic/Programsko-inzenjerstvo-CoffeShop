namespace PI_2021_Kafic
{
    partial class frmNarudzbe
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
            this.lblKonobar = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.pbHladniNapitci = new System.Windows.Forms.PictureBox();
            this.pbTopliNapitci = new System.Windows.Forms.PictureBox();
            this.listboxMeni = new System.Windows.Forms.ListBox();
            this.lbRacun = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbArtikli = new System.Windows.Forms.Label();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.btnSpremiRacun = new System.Windows.Forms.Button();
            this.lblUkupnaCijena = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHladniNapitci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopliNapitci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKonobar
            // 
            this.lblKonobar.AutoSize = true;
            this.lblKonobar.Location = new System.Drawing.Point(546, 644);
            this.lblKonobar.Name = "lblKonobar";
            this.lblKonobar.Size = new System.Drawing.Size(50, 13);
            this.lblKonobar.TabIndex = 0;
            this.lblKonobar.Text = "Konobar:";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(760, 7);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(28, 25);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pbHladniNapitci
            // 
            this.pbHladniNapitci.Image = global::PI_2021_Kafic.Properties.Resources.cola;
            this.pbHladniNapitci.Location = new System.Drawing.Point(678, 446);
            this.pbHladniNapitci.Name = "pbHladniNapitci";
            this.pbHladniNapitci.Size = new System.Drawing.Size(110, 85);
            this.pbHladniNapitci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHladniNapitci.TabIndex = 5;
            this.pbHladniNapitci.TabStop = false;
            this.pbHladniNapitci.Click += new System.EventHandler(this.pbHladniNapitci_Click);
            // 
            // pbTopliNapitci
            // 
            this.pbTopliNapitci.Image = global::PI_2021_Kafic.Properties.Resources.download;
            this.pbTopliNapitci.Location = new System.Drawing.Point(549, 446);
            this.pbTopliNapitci.Name = "pbTopliNapitci";
            this.pbTopliNapitci.Size = new System.Drawing.Size(110, 85);
            this.pbTopliNapitci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTopliNapitci.TabIndex = 5;
            this.pbTopliNapitci.TabStop = false;
            this.pbTopliNapitci.Click += new System.EventHandler(this.pbTopliNapitci_Click);
            // 
            // listboxMeni
            // 
            this.listboxMeni.FormattingEnabled = true;
            this.listboxMeni.Location = new System.Drawing.Point(575, 38);
            this.listboxMeni.Name = "listboxMeni";
            this.listboxMeni.Size = new System.Drawing.Size(213, 394);
            this.listboxMeni.TabIndex = 6;
            this.listboxMeni.SelectedIndexChanged += new System.EventHandler(this.listboxMeni_SelectedIndexChanged);
            this.listboxMeni.DoubleClick += new System.EventHandler(this.listboxMeni_DoubleClick);
            // 
            // lbRacun
            // 
            this.lbRacun.FormattingEnabled = true;
            this.lbRacun.Location = new System.Drawing.Point(37, 38);
            this.lbRacun.Name = "lbRacun";
            this.lbRacun.Size = new System.Drawing.Size(241, 537);
            this.lbRacun.TabIndex = 7;
            this.lbRacun.SelectedIndexChanged += new System.EventHandler(this.lbRacun_SelectedIndexChanged);
            this.lbRacun.DoubleClick += new System.EventHandler(this.lbRacun_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stavke na racunu";
            // 
            // lbArtikli
            // 
            this.lbArtikli.AutoSize = true;
            this.lbArtikli.Location = new System.Drawing.Point(572, 13);
            this.lbArtikli.Name = "lbArtikli";
            this.lbArtikli.Size = new System.Drawing.Size(64, 13);
            this.lbArtikli.TabIndex = 9;
            this.lbArtikli.Text = "Popis artikla";
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(184, 644);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(75, 23);
            this.btnNaruci.TabIndex = 10;
            this.btnNaruci.Text = "Stavi na stol";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // btnSpremiRacun
            // 
            this.btnSpremiRacun.Location = new System.Drawing.Point(37, 644);
            this.btnSpremiRacun.Name = "btnSpremiRacun";
            this.btnSpremiRacun.Size = new System.Drawing.Size(75, 23);
            this.btnSpremiRacun.TabIndex = 11;
            this.btnSpremiRacun.Text = "Izdaj Racun";
            this.btnSpremiRacun.UseVisualStyleBackColor = true;
            this.btnSpremiRacun.Click += new System.EventHandler(this.btnSpremiRacun_Click);
            // 
            // lblUkupnaCijena
            // 
            this.lblUkupnaCijena.AutoSize = true;
            this.lblUkupnaCijena.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupnaCijena.Location = new System.Drawing.Point(37, 604);
            this.lblUkupnaCijena.Name = "lblUkupnaCijena";
            this.lblUkupnaCijena.Size = new System.Drawing.Size(131, 29);
            this.lblUkupnaCijena.TabIndex = 12;
            this.lblUkupnaCijena.Text = "Ukupna cijena: ";
            // 
            // frmNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 689);
            this.Controls.Add(this.lblUkupnaCijena);
            this.Controls.Add(this.btnSpremiRacun);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.lbArtikli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRacun);
            this.Controls.Add(this.listboxMeni);
            this.Controls.Add(this.pbHladniNapitci);
            this.Controls.Add(this.pbTopliNapitci);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.lblKonobar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNarudzbe";
            this.Text = "Narudzbe";
            this.Load += new System.EventHandler(this.Narudzbe_Load);
            this.Shown += new System.EventHandler(this.Narudzbe_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbHladniNapitci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopliNapitci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKonobar;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pbTopliNapitci;
        private System.Windows.Forms.PictureBox pbHladniNapitci;
        private System.Windows.Forms.ListBox listboxMeni;
        private System.Windows.Forms.ListBox lbRacun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbArtikli;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Button btnSpremiRacun;
        private System.Windows.Forms.Label lblUkupnaCijena;
    }
}