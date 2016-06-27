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


namespace Trade_It_Now
{
    public partial class Login : Form
    {
        List<Kunde> kunden;
        MDIParent1 main;
        public Login()
        {
            InitializeComponent();
            this.Visible = true;
        }
        public Login(MDIParent1 main):this()
        {
            this.main = main;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            main.verbunden();
            prüfen(textBoxName.Text,textBoxPW.Text);

            this.Dispose();
        }

        private void prüfen()
        {
            throw new NotImplementedException();
        }

        private void buttonRegistrieren_Click(object sender, EventArgs e)
        {
           Registrieren r1 =  new Registrieren();
           r1.MdiParent = main;

        }

        private void prüfen(string bn , String pw)
        {
                //Prüfen des passwortes   
        }
    }
}
