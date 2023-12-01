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
        public WohnungBearbeiten(Wohnung wohnung)
        {
            Wohnung = wohnung;
            InitializeComponent();
            if (wohnung != null)
            {
                textBoxTuer.Text = wohnung.Tuer;
                textBoxWohnflaeche.Text = wohnung.Wohnflaeche.ToString();
            }
        }
        
        public Wohnung Wohnung {  get; set; }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            string tuer = textBoxTuer.Text;
            if(string.IsNullOrEmpty(tuer))
            {
                textBoxTuer.Focus();
                return;
            }
            long wohnflaeche;
            if(!long.TryParse(textBoxWohnflaeche.Text, out wohnflaeche))
            {
                textBoxWohnflaeche.Focus();
                return;
            }

            if (Wohnung == null)
            {
                Datenbank.Open();
                MySqlCommand command = Datenbank.CreateCommand();
                //  command.Parameters.AddWithValue("haus_id", Haus.id);
                command.CommandText = "INSERT INTO wohnungen (id, haus_id, tuer, wohnflaeche) VALUES (NULL, @haus_id, @tuer, @wohnflaeche)";
                command.Parameters.AddWithValue("tuer", tuer);
                command.Parameters.AddWithValue("wohnflaeche", wohnflaeche);
                command.ExecuteNonQuery();
                long id = command.LastInsertedId;
                long hausId = id;
                Datenbank.Close();

                Wohnung = new Wohnung(id, hausId, tuer, wohnflaeche);
            }
            else
            {
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
