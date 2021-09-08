
namespace PI_2021
{
    partial class frmDodajNoviStol
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
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnDodajNoviStol = new System.Windows.Forms.Button();
            this.txtBrMjesta = new System.Windows.Forms.TextBox();
            this.txtOznaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.lblOznaka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(332, 98);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(31, 17);
            this.radioButton6.TabIndex = 20;
            this.radioButton6.Text = "6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(250, 99);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 21;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(159, 99);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnDodajNoviStol
            // 
            this.btnDodajNoviStol.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNoviStol.Location = new System.Drawing.Point(183, 138);
            this.btnDodajNoviStol.Name = "btnDodajNoviStol";
            this.btnDodajNoviStol.Size = new System.Drawing.Size(149, 52);
            this.btnDodajNoviStol.TabIndex = 19;
            this.btnDodajNoviStol.Text = "Dodaj novi stol";
            this.btnDodajNoviStol.UseVisualStyleBackColor = true;
            this.btnDodajNoviStol.Click += new System.EventHandler(this.btnDodajNoviStol_Click);
            // 
            // txtBrMjesta
            // 
            this.txtBrMjesta.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrMjesta.Location = new System.Drawing.Point(159, 52);
            this.txtBrMjesta.Name = "txtBrMjesta";
            this.txtBrMjesta.Size = new System.Drawing.Size(204, 21);
            this.txtBrMjesta.TabIndex = 18;
            // 
            // txtOznaka
            // 
            this.txtOznaka.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOznaka.Location = new System.Drawing.Point(159, 18);
            this.txtOznaka.Name = "txtOznaka";
            this.txtOznaka.Size = new System.Drawing.Size(204, 21);
            this.txtOznaka.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Velicina mjesta:";
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroj.Location = new System.Drawing.Point(12, 52);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(101, 16);
            this.lblBroj.TabIndex = 15;
            this.lblBroj.Text = "Broj mjesta:";
            // 
            // lblOznaka
            // 
            this.lblOznaka.AutoSize = true;
            this.lblOznaka.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOznaka.Location = new System.Drawing.Point(12, 18);
            this.lblOznaka.Name = "lblOznaka";
            this.lblOznaka.Size = new System.Drawing.Size(110, 16);
            this.lblOznaka.TabIndex = 16;
            this.lblOznaka.Text = "Oznaka stola:";
            // 
            // frmDodajNoviStol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 237);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.btnDodajNoviStol);
            this.Controls.Add(this.txtBrMjesta);
            this.Controls.Add(this.txtOznaka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.lblOznaka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDodajNoviStol";
            this.Text = "Dodaj novi stol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnDodajNoviStol;
        private System.Windows.Forms.TextBox txtBrMjesta;
        private System.Windows.Forms.TextBox txtOznaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Label lblOznaka;
    }
}