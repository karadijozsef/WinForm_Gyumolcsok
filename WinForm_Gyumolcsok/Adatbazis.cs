using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinForm_Gyumolcsok
{
    internal class Adatbazis
    {
        MySqlConnection conn;
        MySqlCommand sqlCommand;
        string hibaSzoveg = null;

        public Adatbazis(string server = "localhost", string user = "root", string password = "", string db = "gyumolcsok")
        {
            conn = new MySqlConnection(kapcsolatstring(server, user, password, db));
            if (kapcsolatNyit())
            {
                sqlCommand = conn.CreateCommand();
            }
            else
            {
                MessageBox.Show(hibaSzoveg);
                hibaSzoveg = null;
            }
        }

        public List<gyumolcs> getAllGyumolcs()
        {
            List<gyumolcs> list = new List<gyumolcs>();
            sqlCommand.CommandText = "SELECT `id`,`nev`,`ar`,`db` FROM `gyumolcsok` WHERE 1";
            if (kapcsolatNyit())
            {
                using (MySqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        gyumolcs Gyumolcs = new gyumolcs(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDouble("ar"), dr.GetDouble("db"));
                        list.Add(Gyumolcs);
                    }
                }
                kapcsolatZaras();
            }
            return list;
        }

        private bool kapcsolatNyit()
        {
            //-- A megadott kapcsolati adatok alapján felépíti az adatelérést
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                    
                }
            }
            catch (MySqlException ex)
            {
                hibaSzoveg = ex.Message;
                return false;
            }
            return true;
        }
        private bool kapcsolatZaras()
        {
            //-- A megadott kapcsolati adatok alapján felépíti az adatelérést
            try
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();

                }
            }
            catch (MySqlException ex)
            {
                hibaSzoveg = ex.Message;
                return false;
            }
            return true;
        }

        private string kapcsolatstring(string server, string user, string password, string db)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = server;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = db;
            return builder.ConnectionString;
        }
    }
}
