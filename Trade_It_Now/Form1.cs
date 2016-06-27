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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Visible = true;
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
            MessageBox.Show("Artikel ist nun Online!");
            this.Dispose();
        }
    }
}
