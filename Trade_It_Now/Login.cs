using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlassenDLL;
using DatenDLL;

namespace Trade_It_Now
{
    public partial class Login : Form
    {
        DTO dto;
        List<Kunde> kunden;
        MDIParent1 main;
        public Login()
        {
            InitializeComponent();
            dto = new DTO();
            this.Visible = true;
        }
        public Login(MDIParent1 main):this()
        {
            this.main = main;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //main.verbunden();
            //this.Dispose();
            kunden = dto.GetAlleKunden();
            Kunde k = new Kunde(textBoxName.Text, textBoxPW.Text);
            int index = kunden.IndexOf(k);
            if (kunden[index].Passwort.Equals(textBoxPW.Text))
            {
                main.verbunden();
                this.Dispose();
            }
            else MessageBox.Show("Falsches Passwort");
            
        }
        
        private void buttonRegistrieren_Click(object sender, EventArgs e)
        {
           Registrieren r1 =  new Registrieren();
           r1.MdiParent = main;

        }

    }
}
