using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace Invoice_to_DB
{
    class DBHelper
    {
        private MySqlConnection connection;

        public DBHelper()
        {
            string connect = "Server=athena01.fhict.local; Database=dbi327800; Uid=dbi327800; Pwd=6ulxOndB9b;";
            connection = new MySqlConnection(connect);
        }

        public void InsertDepositsIntoDB(List<Deposit> depositsList)
        {
            MySqlCommand command;

            try
            {
                connection.Open();

                foreach (Deposit dep in depositsList)
                {
                    string query = string.Format("INSERT INTO paypal_deposit (Deposit_ID, User_Id, Amount, Date) " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}');", dep.DepositID, dep.UserID, dep.Amount,
                    dep.DateAndTime.ToString("yyyy-MM-dd HH:mm:ss"));

                    command = new MySqlCommand(query, connection);

                    command.ExecuteNonQuery();
                }
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
