using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trade_It_Now
{
    public partial class Artikelanlegen : Form
    {
        MDIParent1 main;
        public Artikelanlegen()
        {
            InitializeComponent();
            this.Visible = true;
        }
        public Artikelanlegen(MDIParent1 main):this()
        {
            this.main = main;
        }
        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wirklich Abbrechen?", "Warning",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //code for Yes
                this.Dispose();
            }

         }

        private void buttonHochladen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wirklich ohne Vorschau Hochladen?", "Info",
            MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                //code for Ok
                this.Dispose();
                MessageBox.Show("Artikel ist nun Online!");
            }
            
        }

        private void buttonVoraschau_Click(object sender, EventArgs e)
        {
            Vorschau v1 = new Vorschau();
            v1.MdiParent = main;
        }
    }
}
