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

        Haus ausgewaehltesHaus = null;

        List <Haus> haeuser = new List<Haus>();
        // Wohnungen des ausgewählten Hauses
        List<Wohnung> wohnungen = new List<Wohnung>();
        private void AddHaus(Haus h) 
        {
            haeuser.Add(h);                                             // Dient dazu "Haus h = " zu sparen und "AddHaus" zu nutzen
            listBoxHaeuser.Items.Add(h.ToString());
        }
        private void AddWohnung(Wohnung w)
        {
            wohnungen.Add(w);
            listBoxWohnungen.Items.Add(w.ToString());
        }
        private void Hauptfenster_Load(object sender, EventArgs e)
        {
            Datenbank.Open();
            MySqlCommand cmdHaus = Datenbank.CreateCommand();
            cmdHaus.CommandText = "SELECT id, adresse, plz, ort FROM haus;";
            MySqlDataReader readerHaus = cmdHaus.ExecuteReader();
            while(readerHaus.Read())
            {
                int id = readerHaus.GetInt16(0);
                string adresse = readerHaus.GetString(1);
                string plz = readerHaus.GetString(2);
                string ort = readerHaus.GetString(3);

                AddHaus(new Haus(id, adresse, plz, ort));
                                                                            /* Die Funktion "AddHaus" übernimmt folgende Zeilen:
                                                                            haeuser.Add(h);
                                                                            listBoxHaeuser.Items.Add(h.ToString());
                                                                             */
            }
            readerHaus.Close();

            MySqlCommand cmdWohnung = Datenbank.CreateCommand();
            cmdWohnung.CommandText = "SELECT id, haus_id, tuer, wohnflaeche FROM wohnungen;";
            MySqlDataReader readerWohnung = cmdWohnung.ExecuteReader();
            while (readerWohnung.Read())
            {
                long id = readerWohnung.GetInt64(0);
                long hausId = readerWohnung.GetInt64(1);
                string tuer = readerWohnung.GetString(2);
                long wohnflaeche = readerWohnung.GetInt64(3);

                AddWohnung(new Wohnung(id, hausId, tuer, wohnflaeche));
            }
            readerWohnung.Close();

            Datenbank.Close();
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
        private void buttonNeuWohnung_Click(object sender, EventArgs e)
        {
            if(ausgewaehltesHaus == null)
            {
                listBoxHaeuser.Focus();
                return;
            }
            WohnungBearbeiten dialog = new WohnungBearbeiten(ausgewaehltesHaus, null);
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Wohnung neueWohnung = dialog.Wohnung;
            wohnungen.Add(neueWohnung);
            listBoxWohnungen.Items.Add(neueWohnung.ToString());
            /* TODO - Versuch Label
            int index = listBoxHaeuser.SelectedIndex;
            if (index > 0)
            {
                WohnungBearbeiten.labelHaus.Text = "" + punkte + " Punkte";
            }
            */
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

        private void listBoxHaeuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Liste leeren
            wohnungen.Clear();
            listBoxWohnungen.Items.Clear();
            //
            int index = listBoxHaeuser.SelectedIndex;
            if(index < 0 || index >= haeuser.Count)
            {
                labelWohnungen.Text = "(Kein haus ausgewählt)";
                wohnungen = new List<Wohnung>();
                return;
            }

            Haus h = haeuser[index];
            ausgewaehltesHaus = h;
            labelWohnungen.Text = "Wohnungen der" + h.Adresse;
            wohnungen = h.WohnungenLaden();
            foreach(Wohnung w in wohnungen)
            {
                listBoxWohnungen.Items.Add(w.ToString());
            }

            /*                                                  // In "WohnungenLaden" ausgelagern in Klasse "Haus"
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
                AddWohnung(new Wohnung(id, haus_id, tuer, wohnflaeche));
            }
            reader.Close();

            Datenbank.Close();
                              */
        }

        private void listBoxWohnungen_DoubleClick(object sender, EventArgs e)
        {
            int index = listBoxWohnungen.SelectedIndex;
            if(index < 0 || index >= wohnungen.Count)
            {
                listBoxWohnungen.Focus();
                return;
            }
            Wohnung w = wohnungen[index];
            WohnungBearbeiten dialog = new WohnungBearbeiten(ausgewaehltesHaus, w);
            if(dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            listBoxWohnungen.Items[index] = w.ToString();
        }
    }
}
