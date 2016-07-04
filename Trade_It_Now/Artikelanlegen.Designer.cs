namespace Trade_It_Now
{
    partial class Artikelanlegen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Artikelanlegen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.buttonHochladen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelBez = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxBildLink = new System.Windows.Forms.TextBox();
            this.buttonVoraschau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(75, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitte geben sie folgene Daten ein:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilder-Link einfügen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Beschreibung:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(78, 457);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(131, 22);
            this.buttonAbbrechen.TabIndex = 4;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // buttonHochladen
            // 
            this.buttonHochladen.Location = new System.Drawing.Point(576, 457);
            this.buttonHochladen.Name = "buttonHochladen";
            this.buttonHochladen.Size = new System.Drawing.Size(131, 22);
            this.buttonHochladen.TabIndex = 5;
            this.buttonHochladen.Text = "Hochladen";
            this.buttonHochladen.UseVisualStyleBackColor = true;
            this.buttonHochladen.Click += new System.EventHandler(this.buttonHochladen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(464, 186);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 245);
            this.textBox1.TabIndex = 6;
            // 
            // labelBez
            // 
            this.labelBez.AutoSize = true;
            this.labelBez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBez.Location = new System.Drawing.Point(75, 111);
            this.labelBez.Name = "labelBez";
            this.labelBez.Size = new System.Drawing.Size(88, 16);
            this.labelBez.TabIndex = 8;
            this.labelBez.Text = "Bezeichnung:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBoxBildLink
            // 
            this.textBoxBildLink.Location = new System.Drawing.Point(78, 250);
            this.textBoxBildLink.Name = "textBoxBildLink";
            this.textBoxBildLink.Size = new System.Drawing.Size(331, 20);
            this.textBoxBildLink.TabIndex = 10;
            // 
            // buttonVoraschau
            // 
            this.buttonVoraschau.Location = new System.Drawing.Point(464, 457);
            this.buttonVoraschau.Name = "buttonVoraschau";
            this.buttonVoraschau.Size = new System.Drawing.Size(106, 22);
            this.buttonVoraschau.TabIndex = 11;
            this.buttonVoraschau.Text = "Vorschau";
            this.buttonVoraschau.UseVisualStyleBackColor = true;
            this.buttonVoraschau.Click += new System.EventHandler(this.buttonVoraschau_Click);
            // 
            // Artikelanlegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(791, 499);
            this.Controls.Add(this.buttonVoraschau);
            this.Controls.Add(this.textBoxBildLink);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelBez);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonHochladen);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Artikelanlegen";
            this.Text = "Artikel anlegen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Button buttonHochladen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelBez;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxBildLink;
        private System.Windows.Forms.Button buttonVoraschau;
    }
}

