using KlassenDLL;
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
    public partial class GegenstandMarkt : Form
    {
        public GegenstandMarkt()
        {
            InitializeComponent();
            Initialize();
            this.Visible = true;
        }

        private void Initialize()
        {
            dataGridView1.DataSource = Gegenstand.AlleGegenstände;
        }
        
        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            buttonAngebotAnnehmen.Enabled = true;
        }

        private void buttonAngebotAnnehmen_Click(object sender, EventArgs e)
        {
            //Item in gegenstand casten 
            //und anfrage an den anbieter senden 
            //hinzufügen bei angebotenen artikeln (sicht vom anbieter des Artikels)
        }
    }
}
