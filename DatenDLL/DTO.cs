using KlassenDLL;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenDLL
{
    public class DTO
    {
        OleDbConnection con = null;
        public DTO()
        {
            OleDbConnectionStringBuilder bld = new OleDbConnectionStringBuilder();
            bld.Provider = "Microsoft.ACE.OLEDB.12.0";
            bld.DataSource = "H:\\2.jahr\\C#\\Trade_It_Now\\Tauschportal.accsb";
            con = new OleDbConnection(bld.ConnectionString);

        }
        public bool DeleteKunde(Kunde k)
        {
            if (openConnection())
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE * FROM Kunde WHERE Benutzername = " + k.Benutzername;
                cmd.ExecuteNonQuery();

                return true;
            }

            return false;
        }

        public List<Kunde> GetAlleKunden()
        {
            List<Kunde> lKunde = new List<Kunde>();
            if (openConnection())
            {
                //Code Tabelle auslesen und LIST<> füllen
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from Kunden";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Kunde k = mkKunde(reader);
                    lKunde.Add(k);
                }
            }
            return lKunde;
        }

        private Kunde mkKunde(OleDbDataReader reader)
        {
            Kunde k = new Kunde();
            int i = 0;
            k.ID = reader.GetInt32(i++);
            k.Benutzername = reader.GetString(i++);
            k.Vorname = reader.GetString(i++);
            k.Nachname = reader.GetString(i++);
            k.Straße = reader.GetDateTime(i++).ToShortDateString();
            k.Plz = reader.GetString(i++);
            k.Ort = reader.GetInt32(i++).ToString();
            k.Passwort = reader.GetString(i++);
            k.Email = reader.GetString(i++);
            return k;
        }

        public bool InsertKunde(Kunde kunde)
        {
            Boolean result = true;
            OleDbCommand cmd = con.CreateCommand();
            cmd.Parameters.AddWithValue("id", Convert.ToInt32(kunde.ID));
            cmd.Parameters.AddWithValue("bnam", kunde.Benutzername);
            cmd.Parameters.AddWithValue("pw", kunde.Passwort);
            cmd.Parameters.AddWithValue("vor", kunde.Vorname);
            cmd.Parameters.AddWithValue("nach", kunde.Nachname);
            cmd.Parameters.AddWithValue("mail", kunde.Email);
            cmd.Parameters.AddWithValue("str", kunde.Straße);
            cmd.Parameters.AddWithValue("plz", Convert.ToInt32(kunde.Plz));
            cmd.Parameters.AddWithValue("ort", kunde.Ort);
            cmd.CommandText = "Insert into Kunden values(id,bnam,vor,nach,str,plz,ort,pw,mail)";
            openConnection();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        private Boolean openConnection()
        {
            Boolean result = true;
            if (con.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
}
