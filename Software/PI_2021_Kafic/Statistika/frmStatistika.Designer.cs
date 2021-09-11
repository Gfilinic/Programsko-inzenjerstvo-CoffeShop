
namespace PI_2021_Kafic.Statistika
{
    partial class frmStatistika
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.cmbKonobar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnArtikl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnZ);
            this.groupBox1.Controls.Add(this.btnX);
            this.groupBox1.Controls.Add(this.cmbKonobar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dnevni Izvještaj";
            // 
            // btnZ
            // 
            this.btnZ.Location = new System.Drawing.Point(10, 105);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(172, 23);
            this.btnZ.TabIndex = 3;
            this.btnZ.Text = "Generiraj dnevni izvještaj (Z)";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(10, 75);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(172, 23);
            this.btnX.TabIndex = 2;
            this.btnX.Text = "Generiraj izvještaj za konobara";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // cmbKonobar
            // 
            this.cmbKonobar.FormattingEnabled = true;
            this.cmbKonobar.Location = new System.Drawing.Point(10, 47);
            this.cmbKonobar.Name = "cmbKonobar";
            this.cmbKonobar.Size = new System.Drawing.Size(121, 21);
            this.cmbKonobar.TabIndex = 1;
            this.cmbKonobar.SelectedIndexChanged += new System.EventHandler(this.cmbKonobar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Po konobaru:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnArtikl);
            this.groupBox2.Controls.Add(this.btnPeriod);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(258, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pregled Prometa u danom periodu";
            // 
            // btnPeriod
            // 
            this.btnPeriod.Location = new System.Drawing.Point(9, 104);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(332, 23);
            this.btnPeriod.TabIndex = 2;
            this.btnPeriod.Text = "Generiraj Izvještaj za dani period";
            this.btnPeriod.UseVisualStyleBackColor = true;
            this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Odaberi krajnji datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odaberi pocetni datum:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(135, 75);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnArtikl
            // 
            this.btnArtikl.Location = new System.Drawing.Point(9, 133);
            this.btnArtikl.Name = "btnArtikl";
            this.btnArtikl.Size = new System.Drawing.Size(332, 23);
            this.btnArtikl.TabIndex = 2;
            this.btnArtikl.Text = "Generiraj Izvještaj po artiklima za dani period";
            this.btnArtikl.UseVisualStyleBackColor = true;
            this.btnArtikl.Click += new System.EventHandler(this.btnArtikl_Click);
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStatistika";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.frmStatistika_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.ComboBox cmbKonobar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnArtikl;
    }
}