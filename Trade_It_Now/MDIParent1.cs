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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }
        
        internal void verbunden()
        {
            artikelAnlegenToolStripMenuItem.Enabled = true;
            anfragenToolStripMenuItem.Enabled = true;
            alleVerfügbarenArtikelToolStripMenuItem.Enabled = true;
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            Login log = new Login(this);
            log.MdiParent = this;  
        }

        private void artikelAnlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Artikelanlegen f1 = new Artikelanlegen(this);
            f1.MdiParent = this;
        }

        private void anfragenToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Übersicht üs = new Übersicht();
           üs.MdiParent = this;
        }

        private void alleVerfügbarenArtikelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GegenstandMarkt gm = new GegenstandMarkt();
            gm.MdiParent = this;
        }
    }
}
