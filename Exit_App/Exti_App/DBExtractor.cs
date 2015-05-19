using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Exti_App
{
    class DBExtractor
    {
        private MySqlConnection connection;

        public DBExtractor()
        {
            string connectionstr = "Server=athena01.fhict.local; Database=dbi327800; Uid=dbi327800; Pwd=6ulxOndB9b;";
            connection = new MySqlConnection(connectionstr);
        }

        public Visitor GetVisitor(string rfid)
        {
            MySqlCommand cmd;
            Visitor vis = null;

            try
            {
                connection.Open();
                cmd = new MySqlCommand("Select User_Id, FirstName, LastName, Balance, Status From users " +
                "Where User_Id IN (select Users_Id From rifid Where RIFID_Nr = '" + rfid + "');", connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    vis = new Visitor(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), 
                        Convert.ToDecimal(reader[3]), reader[4].ToString());
                }

                return vis;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Please, connect to the database!");

                return vis;
            }
            finally
            {
                connection.Close();
            }
        }

        public void CheckOut(string rfid)
        {
            MySqlCommand cmd;

            try
            {
                connection.Open();
                cmd = new MySqlCommand("Update users Set Status = 'CheckedOut' Where User_Id IN (select Users_Id " +
                "from rifid where RIFID_Nr = '" + rfid + "');", connection);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Please, connect to the database!");
            }
            finally
            {
                connection.Close();
            }
        }

        public void NotValid(string rfid)
        {
            MySqlCommand cmd;


            try
            {
                connection.Open();
                cmd = new MySqlCommand("Update users Set status = 'NOT VALID' where User_Id IN (select User_Id " +
                "from rifid where RIFID_Nr = '" + rfid + "');", connection);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Please, connect to the database!");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
