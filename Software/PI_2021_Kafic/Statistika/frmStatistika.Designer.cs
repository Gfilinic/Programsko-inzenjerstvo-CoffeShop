
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
            this.btnKonobar = new System.Windows.Forms.Button();
            this.btnArtikl = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnZalihe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnZ);
            this.groupBox1.Controls.Add(this.btnX);
            this.groupBox1.Controls.Add(this.cmbKonobar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dnevni Izvještaj";
            // 
            // btnZ
            // 
            this.btnZ.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnZ.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.ForeColor = System.Drawing.Color.White;
            this.btnZ.Location = new System.Drawing.Point(10, 105);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(281, 32);
            this.btnZ.TabIndex = 3;
            this.btnZ.Text = "Generiraj dnevni izvještaj (Z)";
            this.btnZ.UseVisualStyleBackColor = false;
            this.btnZ.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnX.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(10, 66);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(281, 32);
            this.btnX.TabIndex = 2;
            this.btnX.Text = "Generiraj izvještaj za konobara";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // cmbKonobar
            // 
            this.cmbKonobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKonobar.FormattingEnabled = true;
            this.cmbKonobar.Location = new System.Drawing.Point(141, 27);
            this.cmbKonobar.Name = "cmbKonobar";
            this.cmbKonobar.Size = new System.Drawing.Size(150, 28);
            this.cmbKonobar.TabIndex = 1;
            this.cmbKonobar.SelectedIndexChanged += new System.EventHandler(this.cmbKonobar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Po konobaru:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKonobar);
            this.groupBox2.Controls.Add(this.btnArtikl);
            this.groupBox2.Controls.Add(this.btnPeriod);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pregled Prometa u danom periodu";
            // 
            // btnKonobar
            // 
            this.btnKonobar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnKonobar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKonobar.ForeColor = System.Drawing.Color.White;
            this.btnKonobar.Location = new System.Drawing.Point(10, 205);
            this.btnKonobar.Name = "btnKonobar";
            this.btnKonobar.Size = new System.Drawing.Size(379, 41);
            this.btnKonobar.TabIndex = 2;
            this.btnKonobar.Text = "Generiraj Izvještaj po konobarima za dani period";
            this.btnKonobar.UseVisualStyleBackColor = false;
            this.btnKonobar.Click += new System.EventHandler(this.btnKonobar_Click);
            // 
            // btnArtikl
            // 
            this.btnArtikl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnArtikl.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtikl.ForeColor = System.Drawing.Color.White;
            this.btnArtikl.Location = new System.Drawing.Point(9, 158);
            this.btnArtikl.Name = "btnArtikl";
            this.btnArtikl.Size = new System.Drawing.Size(379, 41);
            this.btnArtikl.TabIndex = 2;
            this.btnArtikl.Text = "Generiraj Izvještaj po artiklima za dani period";
            this.btnArtikl.UseVisualStyleBackColor = false;
            this.btnArtikl.Click += new System.EventHandler(this.btnArtikl_Click);
            // 
            // btnPeriod
            // 
            this.btnPeriod.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPeriod.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriod.ForeColor = System.Drawing.Color.White;
            this.btnPeriod.Location = new System.Drawing.Point(9, 104);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(379, 48);
            this.btnPeriod.TabIndex = 2;
            this.btnPeriod.Text = "Generiraj Izvještaj za dani period";
            this.btnPeriod.UseVisualStyleBackColor = false;
            this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Odaberi krajnji datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odaberi pocetni datum:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(186, 64);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(203, 26);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnZalihe);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 428);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 61);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stanje zaliha";
            // 
            // btnZalihe
            // 
            this.btnZalihe.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnZalihe.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZalihe.ForeColor = System.Drawing.Color.White;
            this.btnZalihe.Location = new System.Drawing.Point(10, 25);
            this.btnZalihe.Name = "btnZalihe";
            this.btnZalihe.Size = new System.Drawing.Size(281, 32);
            this.btnZalihe.TabIndex = 2;
            this.btnZalihe.Text = "Generiraj stanje zaliha";
            this.btnZalihe.UseVisualStyleBackColor = false;
            this.btnZalihe.Click += new System.EventHandler(this.btnZalihe_Click);
            // 
            // frmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 499);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStatistika";
            this.Text = "Statistika";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnKonobar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnZalihe;
    }
}