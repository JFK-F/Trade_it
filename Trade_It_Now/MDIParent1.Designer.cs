using System;

namespace Trade_It_Now
{
    partial class MDIParent1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.artikelAnlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anfragenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artikelAnlegenToolStripMenuItem,
            this.anfragenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // artikelAnlegenToolStripMenuItem
            // 
            this.artikelAnlegenToolStripMenuItem.Enabled = false;
            this.artikelAnlegenToolStripMenuItem.Name = "artikelAnlegenToolStripMenuItem";
            this.artikelAnlegenToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.artikelAnlegenToolStripMenuItem.Text = "Artikel anlegen";
            this.artikelAnlegenToolStripMenuItem.Click += new System.EventHandler(this.artikelAnlegenToolStripMenuItem_Click);
            // 
            // anfragenToolStripMenuItem
            // 
            this.anfragenToolStripMenuItem.Enabled = false;
            this.anfragenToolStripMenuItem.Name = "anfragenToolStripMenuItem";
            this.anfragenToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.anfragenToolStripMenuItem.Text = "Anfragen";
            this.anfragenToolStripMenuItem.Click += new System.EventHandler(this.anfragenToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 632);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artikelAnlegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anfragenToolStripMenuItem;
    }
}



