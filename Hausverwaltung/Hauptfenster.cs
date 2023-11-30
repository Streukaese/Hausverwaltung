using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hausverwaltung
{
    public partial class Hauptfenster : Form
    {
        public Hauptfenster()
        {
            InitializeComponent();
        }

        List <Haus> haeuser = new List<Haus>();
        private void AddHaus(Haus h) 
        {
            haeuser.Add(h);                                             // Dient dazu "Haus h = " zu sparen und "AddHaus" zu nutzen
            listBoxHaeuser.Items.Add(h.ToString());
        }
        private void Hauptfenster_Load(object sender, EventArgs e)
        {
            Datenbank.Open();
            MySqlCommand cmd = Datenbank.CreateCommand();
            cmd.CommandText = "SELECT id, adresse, plz, ort FROM haus;";
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int id = reader.GetInt16(0);
                string adresse = reader.GetString(1);
                string plz = reader.GetString(2);
                string ort = reader.GetString(3);

                AddHaus(new Haus(id, adresse, plz, ort));
                /*                                                      // Die Funktion "AddHaus" übernimmt folgende Zeilen:
                haeuser.Add(h);
                listBoxHaeuser.Items.Add(h.ToString());
                */
            }
            reader.Close();

            Datenbank.Close();
            /* Testdaten
            AddHaus(new Haus(1, "Juliusstr. 2", "12345", "Berlin"));
            AddHaus(new Haus(1, "Juliusstr. 5", "12345", "Berlin"));
            AddHaus(new Haus(1, "Karl-Marx-Str. 27", "12345", "Berlin"));
            */
            // TODO Daten aus der Datenbank laden
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            HausBearbeitungsDialog dialog = new HausBearbeitungsDialog(null);
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            AddHaus(dialog.Haus);
        }

        private void listBoxHaeuser_DoubleClick(object sender, EventArgs e)
        {
            int index = listBoxHaeuser.SelectedIndex;
            if(index < 0 || index >= haeuser.Count)
            {
                listBoxHaeuser.Focus();
                return;
            }
            Haus h = haeuser[index];

            HausBearbeitungsDialog dialog = new HausBearbeitungsDialog(h);
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            // Anzeige aktualisieren
            listBoxHaeuser.Items[index] = h.ToString();

            // Neu - Generatet
            // Aktualisieren Sie das Haus-Objekt in der haeuser-Liste
            haeuser[index] = dialog.Haus;

            // Aktualisieren Sie die Anzeige in der listBoxHaeuser
            listBoxHaeuser.Items[index] = dialog.Haus.ToString();

            // Aktualisieren Sie den Eintrag in der SQL-Datenbank
            Datenbank.Open();
            MySqlCommand command = Datenbank.CreateCommand();
            command.CommandText = "UPDATE haus SET adresse = @adresse, plz = @plz, ort = @ort WHERE id = @id";
            command.Parameters.AddWithValue("adresse", dialog.Haus.Adresse);
            command.Parameters.AddWithValue("plz", dialog.Haus.Plz);
            command.Parameters.AddWithValue("ort", dialog.Haus.Ort);
            command.Parameters.AddWithValue("id", dialog.Haus.Id); // Stellen Sie sicher, dass Ihre Haus-Klasse eine Id-Eigenschaft hat
            command.ExecuteNonQuery();
            Datenbank.Close();
        }

        // Wohnungen des ausgewählten Hauses
        List<Wohnungen> wohnungen = new List<Wohnungen>();
        private void AddWohnung(Wohnungen w)
        {
            wohnungen.Add(w);
            listBoxWohnungen.Items.Clear();
        }
        private void listBoxHaeuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Liste leeren
            wohnungen.Clear();
            listBoxWohnungen.Items.Clear();
            //
            int index = listBoxHaeuser.SelectedIndex;
            if(index < 0 || index >= haeuser.Count)
            {
                return;
            }

            Haus h = haeuser[index];
            Datenbank.Open();
            MySqlCommand cmd = Datenbank.CreateCommand();
            cmd.CommandText = "SELECT id, haus_id, tuer, wohnflaeche FROM wohnungen WHERE haus_id=" + h.Id;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                long id = reader.GetInt64(0);
                long haus_id = reader.GetInt64(1);
                string tuer = reader.GetString(2);
                long wohnflaeche = reader.GetInt64(3);
                AddWohnung(new Haus(id, haus_id, tuer, wohnflaeche));
            }
            reader.Close();

            Datenbank.Close();
        }
    }
}
