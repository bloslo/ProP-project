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
                "Where User_Id IN (select Users_Id From rfid Where RFID_Nr = '" + rfid + "');", connection);

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
                cmd = new MySqlCommand("Update users Set Status = 'CheckedOut' Where User_Id IN " +
                    "(select Users_Id from rfid where RFID_Nr = '" + rfid + "');", connection);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                
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
                cmd = new MySqlCommand("Update users Set status = 'NOT VALID', Balance = 0 where User_Id IN " +
                    "(select Users_Id from rfid where RFID_Nr = '" + rfid + "');", connection);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                
            }
            finally
            {
                connection.Close();
            }
        }

        public List<RentedItem> NotReturnedItems(string rfid)
        {
            MySqlCommand cmd;
            List<RentedItem> items = new List<RentedItem>();

            try
            {
                connection.Open();
                cmd = new MySqlCommand("Select i.Item_Nr, i.ItemName, ri.Quantity, ri.Rent_Date " +
                    "From rented_items ri join items i On ri.Item_nr = i.Item_Nr " +
                "Where ri.User_Id IN (select Users_Id from rfid where RFID_Nr = '" + rfid + "') " +
                "and Return_Date is Null;",
                connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(new RentedItem(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToInt32(reader[2]),
                        Convert.ToDateTime(reader[3])));
                }

                return items;
            }
            catch (MySqlException)
            {
                return items;
            }
            finally
            {
                connection.Close();
            }
        }


    }
}