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
            Initialize();
            dto = new DTO();
            this.Visible = true;
        }

        private void Initialize()
        {
            textBoxPW.MaxLength = 8;
            textBoxPW.PasswordChar = '•';
            textBoxPW.CharacterCasing = CharacterCasing.Lower;
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

            try
            {
                int i = 0;
                while (true)
                {
                    if (kunden[i].Benutzername.Equals(textBoxName.Text))
                    {

                        if (kunden[i].Passwort.Equals(textBoxPW.Text))
                        {
                            break;
                            main.verbunden();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Falsches Passwort");
                            DialogResult result = MessageBox.Show("Falsches Passwort", "Warning",
                            MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                            if (result == DialogResult.Retry)
                            {
                                textBoxPW.Clear();
                            }
                            else
                            {
                                textBoxName.Clear();
                                textBoxPW.Clear();
                            }
                        }
                    }
                    else i++;

               }
                 
            }
            catch(Exception)
            {
                DialogResult result = MessageBox.Show("Benutzer nicht vorhanden zur Registrierung?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    Registrieren r1 = new Registrieren();
                    r1.MdiParent = main;
                    this.Dispose();
                }
            }
         }
        
        private void buttonRegistrieren_Click(object sender, EventArgs e)
        {
           Registrieren r1 =  new Registrieren();
           r1.MdiParent = main;

        }

    }
}
