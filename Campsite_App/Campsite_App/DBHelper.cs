using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Campsite_App
{
    class DBHelper
    {
        private MySqlConnection connection;

        public DBHelper()
        {
            string connstr = "Server=athena01.fhict.local; Database=dbi327800; Uid=dbi327800; Pwd=6ulxOndB9b;";
            connection = new MySqlConnection(connstr);
        }

        public Visitor GetVisitor(string rfid)
        {
            MySqlCommand command;
            Visitor person = null;

            try
            {
                connection.Open();
                string sql = "Select User_Id, FirstName, LastName, Camp_Nr, Camp_Section From users " +
                    "Where User_Id IN (select Users_Id from rfid where RFID_Nr = '" + rfid + "');";
                command = new MySqlCommand(sql, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    person = new Visitor(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(),
                        reader[3].ToString(), reader[4].ToString());
                }

                return person;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Connect to the database!");
                return person;
            }
            finally
            {
                connection.Close();
            }
        }



    }
}