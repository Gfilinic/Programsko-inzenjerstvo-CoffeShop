namespace PI_2021_Kafic
{
    partial class frmUpravljanje_Stolovima
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
            this.listboxStol = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNotice = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDodajNoviStol = new System.Windows.Forms.Button();
            this.txtBrMjesta = new System.Windows.Forms.TextBox();
            this.txtOznaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.lblOznaka = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listboxStol
            // 
            this.listboxStol.Dock = System.Windows.Forms.DockStyle.Left;
            this.listboxStol.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxStol.FormattingEnabled = true;
            this.listboxStol.ItemHeight = 21;
            this.listboxStol.Location = new System.Drawing.Point(0, 0);
            this.listboxStol.Name = "listboxStol";
            this.listboxStol.Size = new System.Drawing.Size(120, 450);
            this.listboxStol.TabIndex = 0;
            this.listboxStol.SelectedIndexChanged += new System.EventHandler(this.listboxStol_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbNotice);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDodajNoviStol);
            this.groupBox1.Controls.Add(this.txtBrMjesta);
            this.groupBox1.Controls.Add(this.txtOznaka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBroj);
            this.groupBox1.Controls.Add(this.lblOznaka);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(120, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 285);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj novi stol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mijenjanjem stolova brišu se sve aktivne narudžbe sa stolova";
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotice.ForeColor = System.Drawing.Color.Red;
            this.lbNotice.Location = new System.Drawing.Point(18, 231);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(121, 20);
            this.lbNotice.TabIndex = 5;
            this.lbNotice.Text = "Upozorenje! : ";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(339, 118);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(31, 17);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.Text = "6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(257, 119);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(166, 119);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(166, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(204, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Spremi Promjene";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDodajNoviStol
            // 
            this.btnDodajNoviStol.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNoviStol.Location = new System.Drawing.Point(6, 160);
            this.btnDodajNoviStol.Name = "btnDodajNoviStol";
            this.btnDodajNoviStol.Size = new System.Drawing.Size(149, 52);
            this.btnDodajNoviStol.TabIndex = 3;
            this.btnDodajNoviStol.Text = "Dodaj novi stol";
            this.btnDodajNoviStol.UseVisualStyleBackColor = true;
            this.btnDodajNoviStol.Click += new System.EventHandler(this.btnDodajNoviStol_Click);
            // 
            // txtBrMjesta
            // 
            this.txtBrMjesta.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrMjesta.Location = new System.Drawing.Point(166, 72);
            this.txtBrMjesta.Name = "txtBrMjesta";
            this.txtBrMjesta.Size = new System.Drawing.Size(204, 21);
            this.txtBrMjesta.TabIndex = 2;
            // 
            // txtOznaka
            // 
            this.txtOznaka.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOznaka.Location = new System.Drawing.Point(166, 38);
            this.txtOznaka.Name = "txtOznaka";
            this.txtOznaka.Size = new System.Drawing.Size(204, 21);
            this.txtOznaka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Velicina mjesta:";
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroj.Location = new System.Drawing.Point(19, 72);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(101, 16);
            this.lblBroj.TabIndex = 0;
            this.lblBroj.Text = "Broj mjesta:";
            // 
            // lblOznaka
            // 
            this.lblOznaka.AutoSize = true;
            this.lblOznaka.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOznaka.Location = new System.Drawing.Point(19, 38);
            this.lblOznaka.Name = "lblOznaka";
            this.lblOznaka.Size = new System.Drawing.Size(110, 16);
            this.lblOznaka.TabIndex = 0;
            this.lblOznaka.Text = "Oznaka stola:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(0, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 90);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Obiris odabrani stol";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmUpravljanje_Stolovima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listboxStol);
            this.Name = "frmUpravljanje_Stolovima";
            this.Text = "Upravljanje_Stolovima";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUpravljanje_Stolovima_FormClosed);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.frmUpravljanje_Stolovima_HelpRequested);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxStol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBrMjesta;
        private System.Windows.Forms.TextBox txtOznaka;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Label lblOznaka;
        private System.Windows.Forms.Button btnDodajNoviStol;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNotice;
    }
}