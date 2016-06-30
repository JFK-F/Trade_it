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
        public  Vorschau(String s):this()
        {
            try {
                Image image = Image.FromFile(s);
                pictureBox1.Image = image;
            }catch(Exception e)
            {
                MessageBox.Show("Bild-Pfad nicht korreckt");
                 
            }
        }
        private void Initialize()
        {
        }
    }
}
