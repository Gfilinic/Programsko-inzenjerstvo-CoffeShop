namespace PI_2021_Kafic
{
    partial class frmNamirniceMain
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
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMjera = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblMjera = new System.Windows.Forms.Label();
            this.lblNazivNamirnice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNamirnice
            // 
            this.lbNamirnice.FormattingEnabled = true;
            this.lbNamirnice.ItemHeight = 16;
            this.lbNamirnice.Location = new System.Drawing.Point(17, 16);
            this.lbNamirnice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbNamirnice.Name = "lbNamirnice";
            this.lbNamirnice.Size = new System.Drawing.Size(255, 452);
            this.lbNamirnice.TabIndex = 4;
            this.lbNamirnice.SelectedIndexChanged += new System.EventHandler(this.lbNamirnice_SelectedIndexChanged);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(81, 171);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(125, 28);
            this.btnUredi.TabIndex = 5;
            this.btnUredi.Text = "Uredi namirnicu";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(281, 27);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Dodaj namirnicu";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(281, 81);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 28);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Obrisi namirnicu";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMjera);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.lblMjera);
            this.groupBox1.Controls.Add(this.lblNazivNamirnice);
            this.groupBox1.Controls.Add(this.btnUredi);
            this.groupBox1.Location = new System.Drawing.Point(283, 160);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(312, 217);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uredi odabranu Namirnicu";
            // 
            // cmbMjera
            // 
            this.cmbMjera.FormattingEnabled = true;
            this.cmbMjera.Items.AddRange(new object[] {
            "l",
            "ml",
            "dl",
            "g",
            "kg"});
            this.cmbMjera.Location = new System.Drawing.Point(160, 114);
            this.cmbMjera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMjera.Name = "cmbMjera";
            this.cmbMjera.Size = new System.Drawing.Size(132, 24);
            this.cmbMjera.TabIndex = 9;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(160, 55);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(132, 22);
            this.txtNaziv.TabIndex = 8;
            // 
            // lblMjera
            // 
            this.lblMjera.AutoSize = true;
            this.lblMjera.Location = new System.Drawing.Point(15, 118);
            this.lblMjera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMjera.Name = "lblMjera";
            this.lblMjera.Size = new System.Drawing.Size(108, 17);
            this.lblMjera.TabIndex = 6;
            this.lblMjera.Text = "Mjera namirnice";
            // 
            // lblNazivNamirnice
            // 
            this.lblNazivNamirnice.AutoSize = true;
            this.lblNazivNamirnice.Location = new System.Drawing.Point(15, 55);
            this.lblNazivNamirnice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazivNamirnice.Name = "lblNazivNamirnice";
            this.lblNazivNamirnice.Size = new System.Drawing.Size(108, 17);
            this.lblNazivNamirnice.TabIndex = 7;
            this.lblNazivNamirnice.Text = "Naziv namirnice";
            // 
            // frmNamirniceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbNamirnice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNamirniceMain";
            this.Text = "Upravljanje Namirnicama";
            this.Load += new System.EventHandler(this.frmNamirniceMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbNamirnice;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMjera;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblMjera;
        private System.Windows.Forms.Label lblNazivNamirnice;
    }
}