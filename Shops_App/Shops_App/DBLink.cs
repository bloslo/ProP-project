using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Shops_App
{
    class DBLink
    {
        private MySqlConnection connection;

        public DBLink()
        {
            string connstring = "Server=athena01.fhict.local; Database=dbi327800; Uid=dbi327800; Pwd=6ulxOndB9b;";
            connection = new MySqlConnection(connstring);
        }

        public List<Product> AllProducts()
        {
            MySqlCommand command;
            List<Product> allProducts = new List<Product>();

            try
            {
                connection.Open();
                string query = "Select * From product;";
                command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    allProducts.Add(new Product(Convert.ToInt32(reader[0]), reader[1].ToString(),
                        Convert.ToDecimal(reader[2]), Convert.ToInt32(reader[3])));
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Connect to the database!");
            }
            finally
            {
                connection.Close();
            }

            return allProducts;
        }

        public void DecreaseQuantity(int id)
        {
            MySqlCommand cmd;

            try
            {
                connection.Open();
                cmd = new MySqlCommand("Update product  Set Amount = Amount - 1 Where Product_Nr = '" +
                id + "';", connection);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
                
            }
            finally
            {
                connection.Close();
            }
        }

        public Visitor FindVisitor(string rfid)
        {
            MySqlCommand command;
            Visitor vis = null;

            try
            {
                connection.Open();
                command = new MySqlCommand("Select User_Id, Balance From users Where User_Id IN " +
                    "(Select Users_Id From rfid Where RFID_Nr = '" + rfid + "');", connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    vis = new Visitor(Convert.ToInt32(reader[0]), Convert.ToDecimal(reader[1]));
                }

                return vis;

            }
            catch (MySqlException)
            {
                return vis;
            }
            finally
            {
                connection.Close();
            }
        }

        public decimal Buy(string rfid, decimal total)
        {
            MySqlCommand command;
            decimal balanceLeft = 0;

            try
            {
                connection.Open();
                command = new MySqlCommand("Update users Set Balance = Balance - " + total + " Where User_Id IN " +
                    "(select Users_Id From rfid Where RFID_Nr = '" + rfid + "');", connection);

                command.ExecuteNonQuery();

                command = new MySqlCommand("Select Balance From users Where User_Id IN (Select Users_Id From rfid " +
                    "Where RFID_Nr = '" + rfid + "');", connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    balanceLeft = Convert.ToDecimal(reader[0]);
                }

                return balanceLeft;
            }
            catch (MySqlException)
            {
                return balanceLeft;
            }
            finally
            {
                connection.Close();
            }
        }

        public void RegisterPurchase(int userId, int shopId, List<Product> consumptions)
        {
            MySqlCommand comm = null;

            try
            {
                connection.Open();

                string sql = string.Empty;
                DateTime current = DateTime.Now;

                sql = "INSERT INTO order_header (User_Id, Shop_ID, Date) Values ('" + userId +
                    "', '" + shopId + "', '" + current.Date.ToString("yyyy-MM-dd") + "');";
                comm = new MySqlCommand(sql, connection);

                comm.ExecuteNonQuery();

                foreach (Product cons in consumptions)
                {
                    sql = "Insert Into order_line (Order_Num, Product_Nr, Amount) " +
                        "SELECT Order_Num, " + cons.ProductID + ", " + cons.Quantity + 
                        " FROM order_header ORDER BY Order_Num DESC LIMIT 1;";
                    comm = new MySqlCommand(sql, connection);

                    comm.ExecuteNonQuery();
                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("Failed to register the purchase!");
            }
            finally
            {
                connection.Close();
            }
        }

        public void RestoreQuantity(int id, int quantity)
        {
            MySqlCommand command;

            try
            {
                connection.Open();
                string sql = "Update product  Set Amount = Amount + '" + quantity + "' Where Product_Nr = '" +
                id + "';";
                command = new MySqlCommand(sql, connection);

                command.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Check if you are connected to the database!");
            }
            finally
            {
                connection.Close();
            }
        }


    }
}
