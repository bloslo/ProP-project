using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Inspection_app
{
    class DB_Connector
    {
        private MySqlConnection connection;

        public DB_Connector()
        {
            string connectionString = "Server=athena01.fhict.local; Database=dbi327800; Uid=dbi327800; Pwd=6ulxOndB9b;";
            connection = new MySqlConnection(connectionString);
        }

        public List<int> GetAllVisitorsID()
        {
            MySqlCommand cmd;
            List<int> idsList = new List<int>();

            try
            {
                connection.Open();
                string query = "Select User_Id From users;";
                cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    idsList.Add(Convert.ToInt32(reader[0]));
                }

                return idsList;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public Visitor GetVisitor(int id)
        {
            MySqlCommand comm;
            Visitor vis = null;

            try
            {
                connection.Open();
                string query = "Select Concat_Ws(' ', FirstName, LastName), Balance, Status, Entrance_Fee " +
                    "From users Where User_Id = " + id + ";";
                comm = new MySqlCommand(query, connection);

                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    vis = new Visitor(reader[0].ToString(), Convert.ToDecimal(reader[1]), reader[2].ToString(),
                        reader[3].ToString());
                }

                return vis;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public decimal FoodExpenses(int id)
        {
            decimal total;
            MySqlCommand cmd;

            try
            {
                connection.Open();
                string query = "Select sum(Total) From order_header Where User_ID = '" + id + "';";
                cmd = new MySqlCommand(query, connection);

                if (cmd.ExecuteScalar() is DBNull)
                {
                    total = 0.00M;
                }
                else
                    total = Convert.ToDecimal(cmd.ExecuteScalar());

                return total;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public decimal TransferedMoney(int id)
        {
            decimal money = 0;
            MySqlCommand comm;

            try
            {
                connection.Open();
                string query = "Select sum(Amount) From paypal_deposit Where User_Id = '" + id + "';";
                comm = new MySqlCommand(query, connection);

                if (comm.ExecuteScalar() is DBNull)
                {
                    money = 0.00m;
                }
                else
                    money = Convert.ToDecimal(comm.ExecuteScalar());

                return money;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public decimal ShopProfit(int shopId)
        {
            decimal revenue = 0;
            MySqlCommand command;

            try
            {
                connection.Open();
                string query = "Select sum(Total) From order_header Where Shop_ID = '" + shopId + "';";
                command = new MySqlCommand(query, connection);

                if (command.ExecuteScalar() is DBNull)
                {
                    revenue = 0.00m;
                }
                else
                {
                    revenue = Convert.ToDecimal(command.ExecuteScalar());
                }

                return revenue;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<int> ProductsIDs()
        {
            MySqlCommand command;
            List<int> products = new List<int>();

            try
            {
                connection.Open();
                string query = "Select Product_Nr From product;";
                command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(Convert.ToInt32(reader[0]));
                }

                return products;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public Product ProductOverview(int proId)
        {
            Product prod = null;
            MySqlCommand command;

            try
            {
                connection.Open();
                string query = "Select pr.ProductName, sum(ol.Amount), pr.Amount From product pr join order_line ol " +
                    "On pr.Product_Nr = ol.Product_Nr " +
                    "Where pr.Product_Nr = '" + proId + "' AND ol.Product_Nr = " +
                    "'" + proId + "' Group By pr.ProductName, pr.Amount;";
                command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    prod = new Product(reader[0].ToString(), Convert.ToInt32(reader[1]), Convert.ToInt32(reader[2]));
                }

                return prod;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public int FutureVisitors()
        {
            MySqlCommand comm;
            int count = 0;

            try
            {
                connection.Open();
                string query = "Select count(*) From users Where Status = 'Out';";
                comm = new MySqlCommand(query, connection);

                if (comm.ExecuteScalar() is DBNull)
                {
                    return count;
                }
                else
                {
                    count = Convert.ToInt32(comm.ExecuteScalar());
                }

                return count;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public int PresentVisitors()
        {
            MySqlCommand cmd;
            int countPresent = 0;

            try
            {
                connection.Open();
                string query = "Select count(*) From users Where Status = 'CheckedIn';";
                cmd = new MySqlCommand(query, connection);

                if (cmd.ExecuteScalar() is DBNull)
                {
                    return countPresent;
                }
                else
                {
                    countPresent = Convert.ToInt32(cmd.ExecuteScalar());
                }

                return countPresent;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public int LeftVisitors()
        {
            MySqlCommand command;
            int leftVis = 0;

            try
            {
                connection.Open();
                string query = "Select count(*) From users Where Status = 'CheckedOut' OR Status = 'NOT VALID';";
                command = new MySqlCommand(query, connection);

                if (command.ExecuteScalar() is DBNull)
                {
                    return leftVis;
                }
                else
                {
                    leftVis = Convert.ToInt32(command.ExecuteScalar());
                }

                return leftVis;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public decimal TotalAllEventAcc()
        {
            decimal total = 0.00m;
            MySqlCommand command;

            try
            {
                connection.Open();
                string query = "Select sum(Balance) From users;";
                command = new MySqlCommand(query, connection);

                if (command.ExecuteScalar() is DBNull)
                {
                    return total;
                }
                else
                {
                    total = Convert.ToDecimal(command.ExecuteScalar());
                }

                return total;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public decimal RevenueRentedItems()
        {
            MySqlCommand comm;
            decimal revenue = 0.00m;

            try
            {
                connection.Open();

                string query = "Select sum(Total) From rented_items;";
                comm = new MySqlCommand(query, connection);

                if (comm.ExecuteScalar() is DBNull)
                {
                    return revenue;
                }
                else
                {
                    revenue = Convert.ToDecimal(comm.ExecuteScalar());
                }

                return revenue;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public decimal AllShopsRevenue()
        {
            MySqlCommand cmd;
            decimal shopRevenue = 0.00m;

            try
            {
                connection.Open();

                string query = "Select sum(Total) From order_header;";
                cmd = new MySqlCommand(query, connection);

                if (cmd.ExecuteScalar() is DBNull)
                {
                    return shopRevenue;
                }
                else
                {
                    shopRevenue = Convert.ToDecimal(cmd.ExecuteScalar());
                }

                return shopRevenue;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Camp> FreeCampSpots()
        {
            List<Camp> freeSpots = new List<Camp>();
            MySqlCommand command;

            try
            {
                connection.Open();

                string query = "Select Camp_Nr, Section From camp c Where Not Exists " +
                    "(Select 1 From users u Where c.Camp_Nr = u.Camp_Nr AND c.Section = u.Camp_Section)";
                command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    freeSpots.Add(new Camp(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1])));
                }

                return freeSpots;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
