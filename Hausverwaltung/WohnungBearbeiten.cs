using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hausverwaltung
{
    public partial class WohnungBearbeiten : Form
    {
        Haus Haus { get; }
        public Wohnung Wohnung { get; set; }
        public WohnungBearbeiten(Haus haus, Wohnung wohnung)
        {
            Haus = haus;
            //labelHaus.Text = haus.ToString();
            Wohnung = wohnung;
            InitializeComponent();
            if (wohnung != null)
            {
                textBoxTuer.Text = wohnung.Tuer;
                numericUpDownWohnflaeche.Value = wohnung.Wohnflaeche; 
                //textBoxWohnflaeche.Text = wohnung.Wohnflaeche.ToString();
            }
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            string tuer = textBoxTuer.Text;
            if(tuer.Length == 0)                //(string.IsNullOrEmpty(tuer))
            {
                textBoxTuer.Focus();
                return;
            }

            // long wohnflaeche;
            long wohnflaeche = (long)numericUpDownWohnflaeche.Value;
            if(wohnflaeche <= 0)//(!long.TryParse(textBoxWohnflaeche.Text, out wohnflaeche))
            {
                //textBoxWohnflaeche.Focus();
                numericUpDownWohnflaeche.Focus();
                return;
            }
            if (Wohnung == null)
            {
                Datenbank.Open();
                MySqlCommand command = Datenbank.CreateCommand();
                command.CommandText = "INSERT INTO wohnungen (id, haus_id, tuer, wohnflaeche) VALUES (NULL, @haus_id, @tuer, @wohnflaeche)";
                command.Parameters.AddWithValue("haus_id", Haus.Id);
                command.Parameters.AddWithValue("tuer", tuer);
                command.Parameters.AddWithValue("wohnflaeche", wohnflaeche);
                command.Prepare();          // 
                command.ExecuteNonQuery();
                long id = command.LastInsertedId;
                //long hausId = id;
                Datenbank.Close();

                Wohnung = new Wohnung(id, Haus.Id, tuer, wohnflaeche);
            }
            else
            {
                Datenbank.Open();
                MySqlCommand cmd = Datenbank.CreateCommand();
                cmd.CommandText = "";
                cmd.Parameters.AddWithValue("tuer", tuer);
                cmd.Parameters.AddWithValue("wohnflaeche", wohnflaeche);
                cmd.Parameters.AddWithValue("id", Wohnung.Id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                Datenbank.Close();
                // TODO "UPDATE haus SET ... WHERE id =" + Haus.id
                Wohnung.Tuer = tuer;
                Wohnung.Wohnflaeche = wohnflaeche;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
