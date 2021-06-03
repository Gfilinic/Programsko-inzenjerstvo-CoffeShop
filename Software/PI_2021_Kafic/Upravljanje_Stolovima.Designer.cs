namespace PI_2021_Kafic
{
    partial class Upravljanje_Stolovima
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
            this.btnDodajNoviStol = new System.Windows.Forms.Button();
            this.txtBrMjesta = new System.Windows.Forms.TextBox();
            this.txtOznaka = new System.Windows.Forms.TextBox();
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodajNoviStol);
            this.groupBox1.Controls.Add(this.txtBrMjesta);
            this.groupBox1.Controls.Add(this.txtOznaka);
            this.groupBox1.Controls.Add(this.lblBroj);
            this.groupBox1.Controls.Add(this.lblOznaka);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(120, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj novi stol";
            // 
            // btnDodajNoviStol
            // 
            this.btnDodajNoviStol.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNoviStol.Location = new System.Drawing.Point(22, 109);
            this.btnDodajNoviStol.Name = "btnDodajNoviStol";
            this.btnDodajNoviStol.Size = new System.Drawing.Size(204, 52);
            this.btnDodajNoviStol.TabIndex = 3;
            this.btnDodajNoviStol.Text = "Dodaj novi stol";
            this.btnDodajNoviStol.UseVisualStyleBackColor = true;
            this.btnDodajNoviStol.Click += new System.EventHandler(this.btnDodajNoviStol_Click);
            // 
            // txtBrMjesta
            // 
            this.txtBrMjesta.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrMjesta.Location = new System.Drawing.Point(135, 71);
            this.txtBrMjesta.Name = "txtBrMjesta";
            this.txtBrMjesta.Size = new System.Drawing.Size(204, 21);
            this.txtBrMjesta.TabIndex = 2;
            // 
            // txtOznaka
            // 
            this.txtOznaka.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOznaka.Location = new System.Drawing.Point(135, 33);
            this.txtOznaka.Name = "txtOznaka";
            this.txtOznaka.Size = new System.Drawing.Size(204, 21);
            this.txtOznaka.TabIndex = 1;
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
            // Upravljanje_Stolovima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listboxStol);
            this.Name = "Upravljanje_Stolovima";
            this.Text = "Upravljanje_Stolovima";
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
    }
}