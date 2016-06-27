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
    public partial class Vorschau : Form
    {
        public Vorschau()
        {
            InitializeComponent();
            this.Visible = true;
            Initialize();
        }

        private void Initialize()
        {
            //funktioniert noch nicht ganz wird nur nen roten X angezeigt
            pictureBox1.ImageLocation= "H:\ball.jpg";
            pictureBox1.Show();
        }
    }
}
