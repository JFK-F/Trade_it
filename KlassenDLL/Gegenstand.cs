using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenDLL
{
     public class Gegenstand
    {
        private static List<Gegenstand> alleGegenstände;
        private String bezeichnung;
        private String link;
        private String beschreibung;
        private int id;
        private int benuz_Id;

        public static List<Gegenstand> AlleGegenstände
        {
            get { return  alleGegenstände; }
        }

        public int Id
        {
            get { return Id; }
            set { id = value; }
        }
        public int Benuz_Id
        {
            get { return benuz_Id; }
            set { benuz_Id = value; }
        }

        public string Bezeichnung
        {
            get { return bezeichnung; }
            set { bezeichnung = value; }
        }

        public string Link
        {
            get { return link; }
            set { link = value; }
        }

        public string Beschreibung
        {
            get { return beschreibung; }
            set { beschreibung = value; }
        }

        public Gegenstand(String bez, String link, String besch)
        {
            this.Id = AlleGegenstände.Count+1;
            this.Benuz_Id = 1;//nicht richtig !!! nur fürn test
            this.Bezeichnung = bez;
            this.Link = link;
            this.Beschreibung = besch;
        }

        public Gegenstand()
        {
        }
    }
}
