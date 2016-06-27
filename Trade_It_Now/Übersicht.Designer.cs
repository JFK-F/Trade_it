namespace Trade_It_Now
{
    partial class Übersicht
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
            this.labelWilkommen = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAngebotAnnehmen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWilkommen
            // 
            this.labelWilkommen.AutoSize = true;
            this.labelWilkommen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWilkommen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelWilkommen.Location = new System.Drawing.Point(64, 86);
            this.labelWilkommen.Name = "labelWilkommen";
            this.labelWilkommen.Size = new System.Drawing.Size(168, 20);
            this.labelWilkommen.TabIndex = 14;
            this.labelWilkommen.Text = "Angebotene Artikel:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 436);
            this.dataGridView1.TabIndex = 15;
            // 
            // buttonAngebotAnnehmen
            // 
            this.buttonAngebotAnnehmen.Location = new System.Drawing.Point(793, 580);
            this.buttonAngebotAnnehmen.Name = "buttonAngebotAnnehmen";
            this.buttonAngebotAnnehmen.Size = new System.Drawing.Size(124, 23);
            this.buttonAngebotAnnehmen.TabIndex = 16;
            this.buttonAngebotAnnehmen.Text = "Angebot annehmen";
            this.buttonAngebotAnnehmen.UseVisualStyleBackColor = true;
            // 
            // Übersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(988, 632);
            this.Controls.Add(this.buttonAngebotAnnehmen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelWilkommen);
            this.Name = "Übersicht";
            this.Text = "Übersicht";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWilkommen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAngebotAnnehmen;
    }
}