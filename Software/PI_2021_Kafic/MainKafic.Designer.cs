namespace PI_2021_Kafic
{
    partial class MainKafic
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.racuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravaljnjeStolovimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.racuniToolStripMenuItem,
            this.upravaljnjeStolovimaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // racuniToolStripMenuItem
            // 
            this.racuniToolStripMenuItem.Name = "racuniToolStripMenuItem";
            this.racuniToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.racuniToolStripMenuItem.Text = "Racuni";
            // 
            // upravaljnjeStolovimaToolStripMenuItem
            // 
            this.upravaljnjeStolovimaToolStripMenuItem.Name = "upravaljnjeStolovimaToolStripMenuItem";
            this.upravaljnjeStolovimaToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.upravaljnjeStolovimaToolStripMenuItem.Text = "Upravaljnje stolovima";
            this.upravaljnjeStolovimaToolStripMenuItem.Click += new System.EventHandler(this.upravaljnjeStolovimaToolStripMenuItem_Click);
            // 
            // MainKafic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainKafic";
            this.Text = "MainKafic";
            this.Activated += new System.EventHandler(this.MainKafic_Activated);
            this.Load += new System.EventHandler(this.MainKafic_Load);
            this.ResizeEnd += new System.EventHandler(this.MainKafic_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem racuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravaljnjeStolovimaToolStripMenuItem;
    }
}