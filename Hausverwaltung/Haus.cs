using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Hausverwaltung
{
    public class Haus
    {
        internal static long id;

        public long Id { get; }
        public string Adresse { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }


        public Haus(long id, string adresse, string plz, string ort)
        {
            this.Id = id;
            this.Adresse = adresse;
            this.Plz = plz;
            this.Ort = ort;
        }

        public override string ToString()
        {
            return Adresse + " " + Plz;
        }

        public List<Wohnung> WohnungenLaden()
        {
            List<Wohnung> wohnungen = new List<Wohnung>();
            Datenbank.Open();
            MySqlCommand cmd = Datenbank.CreateCommand();
            cmd.CommandText = "SELECT id, haus_id, tuer, wohnflaeche FROM wohnungen WHERE haus_id=" + Id;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                long id = reader.GetInt64(0);
                long haus_id = reader.GetInt64(1);
                string tuer = reader.GetString(2);
                long wohnflaeche = reader.GetInt64(3);
                wohnungen.Add(new Wohnung(id, haus_id, tuer, wohnflaeche));
            }
            reader.Close();

            Datenbank.Close();
            return wohnungen;
        }
    }
}
