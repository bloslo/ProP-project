using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CheckIn_CheckOut_App
{
    class DBHelper
    {
        private MySqlConnection connection;

        public DBHelper()
        {
            string connstr = "Server=athena01.fhict.local; Database=dbi327800; Uid=dbi327800; Pwd=6ulxOndB9b;";
            connection = new MySqlConnection(connstr);
        }

        public Visitor GetVisitor(string rfidNr)
        {
            MySqlCommand command;
            Visitor person = null;

            try
            {
                connection.Open();
                command = new MySqlCommand("select users.User_Id, users.FirstName, users.LastName, users.Balance, users.Status " +
                "from users join rifid on users.User_Id = rifid.Users_Id where rifid.RIFID_Nr = '" + rfidNr + "';", connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    person = new Visitor(Convert.ToInt32(reader[0]), reader[1].ToString(),
                    reader[2].ToString(), Convert.ToDecimal(reader[3]), reader[4].ToString());
                }

                return person;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connect to the database!");

                return person;
            }
            finally
            {
                connection.Close();
            }
        }

        public void CheckVisitor(string rfid)
        {
            MySqlCommand cmd;

            try
            {
                connection.Open();
                cmd = new MySqlCommand("Update users Set status = 'CheckedIn' Where User_Id = (select Users_Id " +
                "from rifid where RIFID_Nr = '" + rfid + "');", connection);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Please, connect to the database.");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
