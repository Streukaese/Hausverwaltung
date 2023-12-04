using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hausverwaltung
{
    public partial class HausBearbeitungsDialog : Form
    {
        public HausBearbeitungsDialog(Haus haus)
        {
            Haus = haus;
            InitializeComponent();
            if(haus != null)
            {
                textBoxAdresse.Text= haus.Adresse;
                textBoxPlz.Text = haus.Plz;
                textBoxOrt.Text = haus.Ort;
            }
        }
        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            string adresse = textBoxAdresse.Text;
            if (adresse.Length == 0)
            {
                textBoxAdresse.Focus();
                return;
            }
            string plz = textBoxPlz.Text;
            if (plz.Length != 5)
            {
                textBoxPlz.Focus();
                return;
            }
            string ort = textBoxOrt.Text;
            if (ort.Length == 0)
            {
                textBoxOrt.Focus();
                return;
            }

            if(Haus == null)
            {
                Datenbank.Open();
                MySqlCommand command = Datenbank.CreateCommand();
                command.CommandText = "INSERT INTO haus (id, adresse, plz, ort) VALUES (NULL, @adresse, @plz, @ort)";
                command.Parameters.AddWithValue("adresse", adresse);
                command.Parameters.AddWithValue("plz", plz);
                command.Parameters.AddWithValue("ort", ort);
                command.ExecuteNonQuery();
                long id = command.LastInsertedId;
                Datenbank.Close();

                Haus = new Haus(id, adresse, plz, ort);
            }
            else
            {
                Datenbank.Open();
                MySqlCommand cmd = Datenbank.CreateCommand();
                cmd.CommandText = "UPDATE `haus` SET `adresse` = @adresse, `plz` = @plz, `ort` = @ort WHERE `haus`.`id` = @id";
                cmd.Parameters.AddWithValue("adresse", adresse);
                cmd.Parameters.AddWithValue("plz", plz);
                cmd.Parameters.AddWithValue("ort", ort);
                cmd.Parameters.AddWithValue("id", Haus.Id);
                cmd.Prepare();          
                cmd.ExecuteNonQuery();
                // TODO "UPDATE haus SET ... WHERE id =" + Haus.id
                Haus.Adresse= adresse;
                Haus.Plz= plz;
                Haus.Ort = ort;
            }
            /* TODO INSERT in die DB, id daraus bekommen
            long id = 0;

            Haus = new Haus(id, adresse, plz, ort);
            DialogResult = DialogResult.OK;
            */
            DialogResult = DialogResult.OK;
            Close();
        }
        
        public Haus Haus { get; set; }
        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
