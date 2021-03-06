﻿using DatenDLL;
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
    public partial class Registrieren : Form
    {
        DTO dto = new DTO();
        MDIParent1 main;
        private List<Kunde> neueKunden;
        private Boolean prüfstatus = false;
        public Registrieren()
        {
            InitializeComponent();
            Initialize();
            this.Visible = true;
        }
        public void Initialize()
        {
            textBoxPw.MaxLength = 8;
            textBoxPw.PasswordChar = '•';
            textBoxPw.CharacterCasing = CharacterCasing.Lower;
        }
        public Registrieren(MDIParent1 main):this()
        {
            this.main = main;
        }

        private void buttonBnprüfen_Click(object sender, EventArgs e)
        {
           // prüfenStatus();            Auskommentiert wegen fehlender Übergabeparameter
        }

        private void buttonFertigstellen_Click(object sender, EventArgs e)
        {
            Kunde k = new Kunde(
                    textBoxBenutzername.Text,
                    textBoxPw.Text,
                    textBoxMail.Text,
                    textBoxvorname.Text,
                    textBoxNachname.Text,
                    textBoxOrt.Text,
                    textBoxPlz.Text,
                    textBoxStraße.Text
                    );

            prüfenStatus(k);
            if (prüfstatus == true)
            {
                neueKunden.Add(k);
                main.verbunden();
                this.Dispose();
                

                //k.setAllekunden(neueKunden);

            }
            else
            {
                
            }            
        }

        private void prüfenStatus(Kunde k )
        {
            // schauen ob bereits in der liste 
            if (textBoxBenutzername.Text=="")
            {
                
                prüfstatus = false;
                textBoxBenutzername.ForeColor = Color.Red;
                labelVergeben.ForeColor = Color.Red;
                labelVergeben.Text = "Bitte Benutzernamen eingeben!";
            }
            else if (textBoxBenutzername.Text == "")//Prüfung, ob Name vorhanden & Bedingung nicht richtig (nur zum Test des folgenden Ablaufs)
            {

            //foreach (k in dto.GetAlleKunden()) //nicht korrekt
            //{
                //!ok
                prüfstatus = false;
                textBoxBenutzername.ForeColor = Color.Red;
                labelVergeben.ForeColor = Color.Red;
                labelVergeben.Text = "Benutzername vergeben!";

            }
            else
            {
                //ok
                textBoxBenutzername.ForeColor = Color.Green;
                prüfstatus = true;
                
            }
        }

        private void textBoxBenutzername_TextChanged(object sender, EventArgs e)
        {
            textBoxBenutzername.ForeColor = Color.Black;
            labelVergeben.Text = "";
        }
    }
}
