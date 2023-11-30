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
    }
}
