using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hausverwaltung
{
    public class Wohnung
    {
        public long Id { get; }
        public long HausId { get; }
        public string Tuer { get; set; }
        public long Wohnflaeche { get; set; }

        public Wohnung(long id, long hausId, string tuer, long wohnflaeche)
        {
            Id = id;
            HausId = hausId;
            Tuer = tuer;
            Wohnflaeche = wohnflaeche;
        }

        public override string ToString()
        {
            return Tuer + " (" + Wohnflaeche + "qm)";
        }
    }
}
