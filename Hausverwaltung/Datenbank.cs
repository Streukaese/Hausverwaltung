using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hausverwaltung
{
    internal class Datenbank
    {
        static private MySqlConnection conn = null;
        static public void Open()
        {
            conn = new MySqlConnection("Server=localhost;Uid=root;Pwd=;Database=Hausverwaltung;");
            conn.Open();
        }

        static public MySqlCommand CreateCommand()
        {
            return conn.CreateCommand();
        }
        static public void Close()
        {
            conn.Close();
            conn = null;
        }
    }
}
