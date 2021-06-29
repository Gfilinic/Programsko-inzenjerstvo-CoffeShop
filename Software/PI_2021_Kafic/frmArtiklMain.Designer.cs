namespace PI_2021_Kafic
{
    partial class frmArtiklMain
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
            this.lbArtikli = new System.Windows.Forms.ListBox();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbArtikli
            // 
            this.lbArtikli.FormattingEnabled = true;
            this.lbArtikli.Location = new System.Drawing.Point(1, 1);
            this.lbArtikli.Name = "lbArtikli";
            this.lbArtikli.Size = new System.Drawing.Size(129, 446);
            this.lbArtikli.TabIndex = 0;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Items.AddRange(new object[] {
            "Sve"});
            this.cmbKategorija.Location = new System.Drawing.Point(329, 20);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(121, 21);
            this.cmbKategorija.TabIndex = 1;
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.cmbKategorija_SelectedIndexChanged);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(329, 54);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(121, 23);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Prikaži sve artikle";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prikaži artikle po kategoriji";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(172, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Dodaj novi artikl";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(329, 99);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(126, 23);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "Uredi odabrani artikl";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(256, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Obrisi artikl";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmArtiklMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.lbArtikli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmArtiklMain";
            this.Text = "Upravljanje artiklima";
            this.Load += new System.EventHandler(this.frmArtiklMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbArtikli;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
    }
}