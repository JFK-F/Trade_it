using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenDLL
{
     public class Gegenstand
    {
        private String bezeichnung;
        private String link;
        private String beschreibung;

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
            this.Bezeichnung = bez;
            this.Link = link;
            this.Beschreibung = besch;
        }


    }
}
