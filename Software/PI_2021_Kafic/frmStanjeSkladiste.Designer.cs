namespace PI_2021_Kafic
{
    partial class frmStanjeSkladiste
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
            this.dgvSkladiste = new System.Windows.Forms.DataGridView();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblArtikl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.nUDStanje = new System.Windows.Forms.NumericUpDown();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.gbDodaj = new System.Windows.Forms.GroupBox();
            this.nUDDodaj = new System.Windows.Forms.NumericUpDown();
            this.btnDodajKolicinu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNamirnica = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladiste)).BeginInit();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDStanje)).BeginInit();
            this.gbDodaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDodaj)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSkladiste
            // 
            this.dgvSkladiste.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSkladiste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSkladiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladiste.Location = new System.Drawing.Point(0, 59);
            this.dgvSkladiste.MultiSelect = false;
            this.dgvSkladiste.Name = "dgvSkladiste";
            this.dgvSkladiste.ReadOnly = true;
            this.dgvSkladiste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkladiste.Size = new System.Drawing.Size(443, 391);
            this.dgvSkladiste.TabIndex = 0;
            this.dgvSkladiste.SelectionChanged += new System.EventHandler(this.dgvSkladiste_SelectionChanged);
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(6, 33);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(105, 13);
            this.lblOd.TabIndex = 1;
            this.lblOd.Text = "Odabrana namirnica:";
            // 
            // lblArtikl
            // 
            this.lblArtikl.AutoSize = true;
            this.lblArtikl.Location = new System.Drawing.Point(110, 33);
            this.lblArtikl.Name = "lblArtikl";
            this.lblArtikl.Size = new System.Drawing.Size(45, 13);
            this.lblArtikl.TabIndex = 2;
            this.lblArtikl.Text = "ARTIKL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trenutno stanje:";
            // 
            // gb
            // 
            this.gb.Controls.Add(this.nUDStanje);
            this.gb.Controls.Add(this.btnSpremi);
            this.gb.Controls.Add(this.lblOd);
            this.gb.Controls.Add(this.label1);
            this.gb.Controls.Add(this.lblArtikl);
            this.gb.Location = new System.Drawing.Point(448, 12);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(238, 172);
            this.gb.TabIndex = 5;
            this.gb.TabStop = false;
            this.gb.Text = "Osvjezi stanje odabrane namirnice";
            // 
            // nUDStanje
            // 
            this.nUDStanje.Location = new System.Drawing.Point(105, 68);
            this.nUDStanje.Name = "nUDStanje";
            this.nUDStanje.Size = new System.Drawing.Size(71, 20);
            this.nUDStanje.TabIndex = 6;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(18, 114);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(195, 23);
            this.btnSpremi.TabIndex = 5;
            this.btnSpremi.Text = "Spremi novo stanje";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // gbDodaj
            // 
            this.gbDodaj.Controls.Add(this.nUDDodaj);
            this.gbDodaj.Controls.Add(this.btnDodajKolicinu);
            this.gbDodaj.Controls.Add(this.label2);
            this.gbDodaj.Controls.Add(this.cmbNamirnica);
            this.gbDodaj.Controls.Add(this.label3);
            this.gbDodaj.Location = new System.Drawing.Point(449, 201);
            this.gbDodaj.Name = "gbDodaj";
            this.gbDodaj.Size = new System.Drawing.Size(229, 180);
            this.gbDodaj.TabIndex = 6;
            this.gbDodaj.TabStop = false;
            this.gbDodaj.Text = "Dodaj količinu namirnice";
            // 
            // nUDDodaj
            // 
            this.nUDDodaj.Location = new System.Drawing.Point(104, 84);
            this.nUDDodaj.Name = "nUDDodaj";
            this.nUDDodaj.Size = new System.Drawing.Size(71, 20);
            this.nUDDodaj.TabIndex = 6;
            // 
            // btnDodajKolicinu
            // 
            this.btnDodajKolicinu.Location = new System.Drawing.Point(17, 131);
            this.btnDodajKolicinu.Name = "btnDodajKolicinu";
            this.btnDodajKolicinu.Size = new System.Drawing.Size(195, 23);
            this.btnDodajKolicinu.TabIndex = 5;
            this.btnDodajKolicinu.Text = "Dodaj kolicinu";
            this.btnDodajKolicinu.UseVisualStyleBackColor = true;
            this.btnDodajKolicinu.Click += new System.EventHandler(this.btnDodajKolicinu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odaberi namirnicu:";
            // 
            // cmbNamirnica
            // 
            this.cmbNamirnica.FormattingEnabled = true;
            this.cmbNamirnica.Location = new System.Drawing.Point(104, 48);
            this.cmbNamirnica.Name = "cmbNamirnica";
            this.cmbNamirnica.Size = new System.Drawing.Size(96, 21);
            this.cmbNamirnica.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dodaj kolicinu";
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(321, 12);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbFilter.TabIndex = 7;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            this.cmbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFilter_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sortiraj:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pretraži: ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(55, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(129, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmStanjeSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.gbDodaj);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.dgvSkladiste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmStanjeSkladiste";
            this.Text = "Stanje na skladištu";
            this.Load += new System.EventHandler(this.frmStanjeSkladiste_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmStanjeSkladiste_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladiste)).EndInit();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDStanje)).EndInit();
            this.gbDodaj.ResumeLayout(false);
            this.gbDodaj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDodaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSkladiste;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblArtikl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.NumericUpDown nUDStanje;
        private System.Windows.Forms.GroupBox gbDodaj;
        private System.Windows.Forms.NumericUpDown nUDDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNamirnica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodajKolicinu;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
    }
}