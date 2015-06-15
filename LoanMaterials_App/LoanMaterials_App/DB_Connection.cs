using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LoanMaterials_App
{
    class DB_Connection
    {
        private MySqlConnection conn;

        public DB_Connection()
        {
            string connStr = "Server=athena01.fhict.local; Database=dbi327800; Uid=dbi327800; Pwd=6ulxOndB9b;";
            conn = new MySqlConnection(connStr);
        }

        public List<Item> GetAllItems()
        {
            List<Item> allItems = new List<Item>();
            MySqlCommand comm;

            try
            {
                conn.Open();
                string query = "Select * From items;";
                comm = new MySqlCommand(query, conn);

                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    allItems.Add(new Item(Convert.ToInt32(reader[0]), reader[1].ToString(),
                        Convert.ToDecimal(reader[2]), Convert.ToInt32(reader[3])));
                }

                return allItems;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public void BorrowItem(int id)
        {
            MySqlCommand comm;

            try
            {
                conn.Open();
                string sql = "Update items Set Quantity = Quantity - 1 Where Item_Nr = '" + id + "';";
                comm = new MySqlCommand(sql, conn);

                comm.ExecuteNonQuery();
            }
            catch (MySqlException)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void DiscardItem(int id, int quantity)
        {
            MySqlCommand comm;

            try
            {
                conn.Open();
                string query = "Update items Set Quantity = Quantity + '" + quantity + "' Where Item_Nr = '" + id + "';";
                comm = new MySqlCommand(query, conn);

                comm.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public decimal Pay(string rfid, decimal total)
        {
            MySqlCommand command;
            decimal balanceLeft = 0;

            try
            {
                conn.Open();
                string query = "Update users Set Balance = Balance - '" + total + "' Where User_Id IN (Select Users_Id " +
                    "From rfid Where RFID_Nr = '" + rfid + "');";
                command = new MySqlCommand(query, conn);

                command.ExecuteNonQuery();

                query = "Select Balance From users Where User_Id IN (Select Users_Id From rfid Where RFID_Nr = '" +
                    rfid + "');";
                command = new MySqlCommand(query, conn);

                balanceLeft = (decimal)command.ExecuteScalar();

                return balanceLeft;
            }
            catch (MySqlException)
            {
                return balanceLeft = 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public void Register(int id, List<Item> loanedItems)
        {
            MySqlCommand command;

            try
            {
                conn.Open();
                DateTime current = DateTime.Now;
                string sql = "INSERT INTO rented_items (User_Id, Rent_Date) VALUES ('" + id + "', '" +
                    current.Date.ToString("yyyy-MM-dd") + "');";
                command = new MySqlCommand(sql, conn);

                command.ExecuteNonQuery();

                foreach (Item item in loanedItems)
                {
                    sql = "INSERT INTO rent_line (Order_Nr, Item_Id, Quantity) " +
                        "Select Order_Nr, " + item.ItemID + ", " + item.Quantity +
                        " From rented_items ORDER BY Order_Nr DESC LIMIT 1;";
                    command = new MySqlCommand(sql, conn);

                    command.ExecuteNonQuery();
                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("Problem registering the order!");
            }
            finally
            {
                conn.Close();
            }
        }

        public Visitor GetVisitor(string rfid)
        {
            Visitor vis = null;
            MySqlCommand cmd;

            try
            {
                conn.Open();
                string query = "Select User_Id, Balance From users Where User_Id IN (Select Users_Id From rfid " +
                    "Where RFID_Nr = '" + rfid + "');";
                cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    vis = new Visitor(Convert.ToInt32(reader[0]), Convert.ToDecimal(reader[1]));
                }

                return vis;
            }
            catch (MySqlException)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Item> LoanedItems(int id)
        {
            List<Item> borrowedItems = new List<Item>();
            MySqlCommand comm;

            try
            {
                conn.Open();
                string query = "Select Item_ID, Quantity, Order_Nr FROM rent_line Where Order_Nr IN (Select Order_Nr From rented_items " +
                "Where Return_Date is null AND User_Id = '" + id + "');";
                comm = new MySqlCommand(query, conn);

                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    borrowedItems.Add(new Item(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]),
                        Convert.ToInt32(reader[2])));
                }

                return borrowedItems;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public void Return(int userId)
        {
            DateTime current = DateTime.Now;
            MySqlCommand comm;

            try
            {
                conn.Open();
                string query = "Update rented_items Set Return_Date = '" + current.Date.ToString("yyyy-MM-dd") +
                    "' Where User_Id = '" + userId + "';";
                comm = new MySqlCommand(query, conn);

                comm.ExecuteNonQuery();
            }
            catch (MySqlException)
            {

            }
            finally
            {
                conn.Close();
            }
        }

    }
}
