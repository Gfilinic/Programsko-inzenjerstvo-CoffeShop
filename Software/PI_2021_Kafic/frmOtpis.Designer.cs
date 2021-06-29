namespace PI_2021_Kafic
{
    partial class frmOtpis
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
            this.lbNamirnice = new System.Windows.Forms.ListBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nUDKolicina = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOtpisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDKolicina)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNamirnice
            // 
            this.lbNamirnice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNamirnice.FormattingEnabled = true;
            this.lbNamirnice.Location = new System.Drawing.Point(0, 0);
            this.lbNamirnice.Name = "lbNamirnice";
            this.lbNamirnice.Size = new System.Drawing.Size(168, 450);
            this.lbNamirnice.TabIndex = 0;
            this.lbNamirnice.SelectedIndexChanged += new System.EventHandler(this.lbNamirnice_SelectedIndexChanged);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(146, 76);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(121, 23);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "Prikazi sve namirnice";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(146, 40);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(121, 21);
            this.cmbKategorija.TabIndex = 2;
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.cmbKategorija_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtriraj po kategoriji Artikla: \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Artikl";
            // 
            // nUDKolicina
            // 
            this.nUDKolicina.Location = new System.Drawing.Point(100, 60);
            this.nUDKolicina.Name = "nUDKolicina";
            this.nUDKolicina.Size = new System.Drawing.Size(40, 20);
            this.nUDKolicina.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kolicina za otpis:\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbKategorija);
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(183, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 158);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtriraj Prikaz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOtpisi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nUDKolicina);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(183, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 141);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otpisi";
            // 
            // btnOtpisi
            // 
            this.btnOtpisi.Location = new System.Drawing.Point(19, 112);
            this.btnOtpisi.Name = "btnOtpisi";
            this.btnOtpisi.Size = new System.Drawing.Size(121, 23);
            this.btnOtpisi.TabIndex = 7;
            this.btnOtpisi.Text = "Otpisi";
            this.btnOtpisi.UseVisualStyleBackColor = true;
            this.btnOtpisi.Click += new System.EventHandler(this.btnOtpisi_Click);
            // 
            // frmOtpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbNamirnice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOtpis";
            this.Text = "Otpis";
            this.Load += new System.EventHandler(this.frmOtpis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDKolicina)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNamirnice;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDKolicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOtpisi;
    }
}