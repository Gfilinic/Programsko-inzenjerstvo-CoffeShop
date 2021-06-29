namespace PI_2021_Kafic
{
    partial class frmMainKafic
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
            this.skladišteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stanjeNaSkladištuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeNormativimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeNamirnicamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeArtiklimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginKonobarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviKonobaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moderatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviModeratoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trenutniKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.racuniToolStripMenuItem,
            this.upravaljnjeStolovimaToolStripMenuItem,
            this.skladišteToolStripMenuItem,
            this.loginKonobarToolStripMenuItem,
            this.odjaviKonobaraToolStripMenuItem,
            this.moderatorToolStripMenuItem,
            this.odjaviModeratoraToolStripMenuItem,
            this.trenutniKorisnikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // racuniToolStripMenuItem
            // 
            this.racuniToolStripMenuItem.Name = "racuniToolStripMenuItem";
            this.racuniToolStripMenuItem.Size = new System.Drawing.Size(67, 28);
            this.racuniToolStripMenuItem.Text = "Racuni";
            // 
            // upravaljnjeStolovimaToolStripMenuItem
            // 
            this.upravaljnjeStolovimaToolStripMenuItem.Name = "upravaljnjeStolovimaToolStripMenuItem";
            this.upravaljnjeStolovimaToolStripMenuItem.Size = new System.Drawing.Size(167, 28);
            this.upravaljnjeStolovimaToolStripMenuItem.Text = "Upravaljnje stolovima";
            this.upravaljnjeStolovimaToolStripMenuItem.Click += new System.EventHandler(this.upravaljnjeStolovimaToolStripMenuItem_Click);
            // 
            // skladišteToolStripMenuItem
            // 
            this.skladišteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stanjeNaSkladištuToolStripMenuItem,
            this.upravljanjeNormativimaToolStripMenuItem,
            this.upravljanjeNamirnicamaToolStripMenuItem,
            this.upravljanjeArtiklimaToolStripMenuItem});
            this.skladišteToolStripMenuItem.Name = "skladišteToolStripMenuItem";
            this.skladišteToolStripMenuItem.Size = new System.Drawing.Size(82, 28);
            this.skladišteToolStripMenuItem.Text = "Skladište";
            // 
            // stanjeNaSkladištuToolStripMenuItem
            // 
            this.stanjeNaSkladištuToolStripMenuItem.Name = "stanjeNaSkladištuToolStripMenuItem";
            this.stanjeNaSkladištuToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.stanjeNaSkladištuToolStripMenuItem.Text = "Stanje na skladištu";
            // 
            // upravljanjeNormativimaToolStripMenuItem
            // 
            this.upravljanjeNormativimaToolStripMenuItem.Name = "upravljanjeNormativimaToolStripMenuItem";
            this.upravljanjeNormativimaToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.upravljanjeNormativimaToolStripMenuItem.Text = "Upravljanje normativima";
            this.upravljanjeNormativimaToolStripMenuItem.Click += new System.EventHandler(this.upravljanjeNormativimaToolStripMenuItem_Click);
            // 
            // upravljanjeNamirnicamaToolStripMenuItem
            // 
            this.upravljanjeNamirnicamaToolStripMenuItem.Name = "upravljanjeNamirnicamaToolStripMenuItem";
            this.upravljanjeNamirnicamaToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.upravljanjeNamirnicamaToolStripMenuItem.Text = "Upravljanje namirnicama";
            this.upravljanjeNamirnicamaToolStripMenuItem.Click += new System.EventHandler(this.upravljanjeNamirnicamaToolStripMenuItem_Click);
            // 
            // upravljanjeArtiklimaToolStripMenuItem
            // 
            this.upravljanjeArtiklimaToolStripMenuItem.Name = "upravljanjeArtiklimaToolStripMenuItem";
            this.upravljanjeArtiklimaToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.upravljanjeArtiklimaToolStripMenuItem.Text = "Upravljanje artiklima";
            // 
            // loginKonobarToolStripMenuItem
            // 
            this.loginKonobarToolStripMenuItem.Name = "loginKonobarToolStripMenuItem";
            this.loginKonobarToolStripMenuItem.Size = new System.Drawing.Size(121, 28);
            this.loginKonobarToolStripMenuItem.Text = "Login Konobar";
            this.loginKonobarToolStripMenuItem.Click += new System.EventHandler(this.loginKonobarToolStripMenuItem_Click);
            // 
            // odjaviKonobaraToolStripMenuItem
            // 
            this.odjaviKonobaraToolStripMenuItem.Name = "odjaviKonobaraToolStripMenuItem";
            this.odjaviKonobaraToolStripMenuItem.Size = new System.Drawing.Size(135, 28);
            this.odjaviKonobaraToolStripMenuItem.Text = "Odjavi Konobara";
            this.odjaviKonobaraToolStripMenuItem.Click += new System.EventHandler(this.odjaviKonobaraToolStripMenuItem_Click);
            // 
            // moderatorToolStripMenuItem
            // 
            this.moderatorToolStripMenuItem.Name = "moderatorToolStripMenuItem";
            this.moderatorToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.moderatorToolStripMenuItem.Text = "Moderator";
            this.moderatorToolStripMenuItem.Click += new System.EventHandler(this.moderatorToolStripMenuItem_Click);
            // 
            // odjaviModeratoraToolStripMenuItem
            // 
            this.odjaviModeratoraToolStripMenuItem.Name = "odjaviModeratoraToolStripMenuItem";
            this.odjaviModeratoraToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.odjaviModeratoraToolStripMenuItem.Text = "Odjavi Moderatora";
            this.odjaviModeratoraToolStripMenuItem.Click += new System.EventHandler(this.odjaviModeratoraToolStripMenuItem_Click);
            // 
            // trenutniKorisnikToolStripMenuItem
            // 
            this.trenutniKorisnikToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trenutniKorisnikToolStripMenuItem.Name = "trenutniKorisnikToolStripMenuItem";
            this.trenutniKorisnikToolStripMenuItem.Size = new System.Drawing.Size(217, 28);
            this.trenutniKorisnikToolStripMenuItem.Text = "Trenutni Korisnik : ";
            // 
            // MainKafic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 666);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainKafic";
            this.Text = "MainKafic";
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
        private System.Windows.Forms.ToolStripMenuItem skladišteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stanjeNaSkladištuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeNormativimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeNamirnicamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeArtiklimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginKonobarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviKonobaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moderatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviModeratoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trenutniKorisnikToolStripMenuItem;
    }
}