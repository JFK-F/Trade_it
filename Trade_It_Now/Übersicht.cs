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
    public partial class Übersicht : Form
    {
        public Übersicht()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void dataGridView1_CellStyleChanged(object sender, DataGridViewCellEventArgs e)
        {
            buttonAngebotAnfrage.Enabled = true;
        }

        private void buttonAngebotAnnehmen_Click(object sender, EventArgs e)
        {

        }
    }
}
