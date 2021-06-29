namespace PI_2021_Kafic
{
    partial class frmNarudzbe
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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Topli Napitci", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Kava s mlijekom");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Kava");
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.listboxMeni = new System.Windows.Forms.ListView();
            this.rtbRačun = new System.Windows.Forms.RichTextBox();
            this.pbHladniNapitci = new System.Windows.Forms.PictureBox();
            this.pbTopliNapitci = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHladniNapitci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopliNapitci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(760, 7);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(28, 25);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // listboxMeni
            // 
            listViewGroup2.Header = "Topli Napitci";
            listViewGroup2.Name = "lvgTopliNapitci";
            listViewGroup2.Tag = "napitci";
            this.listboxMeni.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listboxMeni.HideSelection = false;
            listViewItem3.Group = listViewGroup2;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.Group = listViewGroup2;
            this.listboxMeni.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listboxMeni.Location = new System.Drawing.Point(584, 38);
            this.listboxMeni.Name = "listboxMeni";
            this.listboxMeni.Size = new System.Drawing.Size(204, 400);
            this.listboxMeni.TabIndex = 3;
            this.listboxMeni.UseCompatibleStateImageBehavior = false;
            this.listboxMeni.View = System.Windows.Forms.View.Tile;
            this.listboxMeni.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listboxMeni_MouseDoubleClick);
            // 
            // rtbRačun
            // 
            this.rtbRačun.Location = new System.Drawing.Point(52, 38);
            this.rtbRačun.Name = "rtbRačun";
            this.rtbRačun.Size = new System.Drawing.Size(214, 380);
            this.rtbRačun.TabIndex = 4;
            this.rtbRačun.Text = "";
            // 
            // pbHladniNapitci
            // 
            this.pbHladniNapitci.Image = global::PI_2021_Kafic.Properties.Resources.cola;
            this.pbHladniNapitci.Location = new System.Drawing.Point(168, 446);
            this.pbHladniNapitci.Name = "pbHladniNapitci";
            this.pbHladniNapitci.Size = new System.Drawing.Size(110, 85);
            this.pbHladniNapitci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHladniNapitci.TabIndex = 5;
            this.pbHladniNapitci.TabStop = false;
            this.pbHladniNapitci.Click += new System.EventHandler(this.pbHladniNapitci_Click);
            // 
            // pbTopliNapitci
            // 
            this.pbTopliNapitci.Image = global::PI_2021_Kafic.Properties.Resources.download;
            this.pbTopliNapitci.Location = new System.Drawing.Point(52, 446);
            this.pbTopliNapitci.Name = "pbTopliNapitci";
            this.pbTopliNapitci.Size = new System.Drawing.Size(110, 85);
            this.pbTopliNapitci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTopliNapitci.TabIndex = 5;
            this.pbTopliNapitci.TabStop = false;
            this.pbTopliNapitci.Click += new System.EventHandler(this.pbTopliNapitci_Click);
            // 
            // Narudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 689);
            this.Controls.Add(this.pbHladniNapitci);
            this.Controls.Add(this.pbTopliNapitci);
            this.Controls.Add(this.rtbRačun);
            this.Controls.Add(this.listboxMeni);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Narudzbe";
            this.Text = "Narudzbe";
            this.Load += new System.EventHandler(this.Narudzbe_Load);
            this.Shown += new System.EventHandler(this.Narudzbe_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbHladniNapitci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopliNapitci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ListView listboxMeni;
        private System.Windows.Forms.RichTextBox rtbRačun;
        private System.Windows.Forms.PictureBox pbTopliNapitci;
        private System.Windows.Forms.PictureBox pbHladniNapitci;
    }
}