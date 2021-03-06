﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenDLL
{
    public class Kunde
    {
        private int kunden_ID;
        private String benutzername;
        private String vorname;
        private String nachname;
        private String straße;
        private String plz;
        private String ort;
        private String passwort;
        private String eMail;
        private List<Kunde> allekunden;
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;

        public string Benutzername
        {
            get{return benutzername;}
            set{benutzername = value;}
        }
        public string Vorname
        {
            get { return vorname; }
            set { vorname = value; }
        }
        public string Nachname
        {
            get { return Nachname; }
            set { Nachname = value; }
        }
        public string Straße
        {
            get { return Straße; }
            set { Straße = value; }
        }
        public string Plz
        {
            get { return Plz; }
            set { Plz = value; }
        }
        public string Ort
        {
            get { return ort; }
            set { ort = value; }
        }
        public string Passwort
        {
            get { return passwort; }
            set { passwort = value; }
        }
        public string Email
        {
            get { return eMail; }
            set { eMail = value; }
        }
        public int ID {
            get { return kunden_ID; }
            set {kunden_ID = value; }
            }

        public  String getPasswort() { return passwort; }
        
        public Kunde(string bname, string pw, string email, string vor, string nach, string ort, string plz, string strasse)
        {
            this.Benutzername = bname;
            this.passwort = pw;
            this.eMail = email;
            this.Vorname = vor;
            this.Nachname = nach;
            this.ort = ort;
            this.Plz = plz;
            this.Straße = strasse;   
        }

        public Kunde()
        {
        }

        public Kunde(string text1, string text2)
        {
            this.Benutzername = text1;
            this.Passwort = text2;
        }

        public  List<Kunde> getAllekunden()
        {
            return allekunden;
        }
        public void setAllekunden(List<Kunde> list)
        {
            this.allekunden = list;
        }
       
    }
}
