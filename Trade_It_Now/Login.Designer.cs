namespace Trade_It_Now
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelWilkommen = new System.Windows.Forms.Label();
            this.labelPw = new System.Windows.Forms.Label();
            this.LabelKundennummer = new System.Windows.Forms.Label();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegistrieren = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWilkommen
            // 
            this.labelWilkommen.AutoSize = true;
            this.labelWilkommen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWilkommen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelWilkommen.Location = new System.Drawing.Point(81, 50);
            this.labelWilkommen.Name = "labelWilkommen";
            this.labelWilkommen.Size = new System.Drawing.Size(243, 20);
            this.labelWilkommen.TabIndex = 13;
            this.labelWilkommen.Text = "Wilkommen bei  Trade-It-Now";
            // 
            // labelPw
            // 
            this.labelPw.AutoSize = true;
            this.labelPw.Location = new System.Drawing.Point(82, 167);
            this.labelPw.Name = "labelPw";
            this.labelPw.Size = new System.Drawing.Size(50, 13);
            this.labelPw.TabIndex = 12;
            this.labelPw.Text = "Passwort";
            // 
            // LabelKundennummer
            // 
            this.LabelKundennummer.AutoSize = true;
            this.LabelKundennummer.Location = new System.Drawing.Point(82, 127);
            this.LabelKundennummer.Name = "LabelKundennummer";
            this.LabelKundennummer.Size = new System.Drawing.Size(75, 13);
            this.LabelKundennummer.TabIndex = 11;
            this.LabelKundennummer.Text = "Benutzername";
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(185, 164);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.Size = new System.Drawing.Size(100, 20);
            this.textBoxPW.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(185, 124);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(331, 122);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(77, 22);
            this.buttonLogin.TabIndex = 14;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegistrieren
            // 
            this.buttonRegistrieren.Location = new System.Drawing.Point(331, 162);
            this.buttonRegistrieren.Name = "buttonRegistrieren";
            this.buttonRegistrieren.Size = new System.Drawing.Size(77, 22);
            this.buttonRegistrieren.TabIndex = 15;
            this.buttonRegistrieren.Text = "Registrieren";
            this.buttonRegistrieren.UseVisualStyleBackColor = true;
            this.buttonRegistrieren.Click += new System.EventHandler(this.buttonRegistrieren_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trade_It_Now.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(489, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 116);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(988, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRegistrieren);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelWilkommen);
            this.Controls.Add(this.labelPw);
            this.Controls.Add(this.LabelKundennummer);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.textBoxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWilkommen;
        private System.Windows.Forms.Label labelPw;
        private System.Windows.Forms.Label LabelKundennummer;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegistrieren;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}