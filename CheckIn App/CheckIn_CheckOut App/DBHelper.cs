﻿using System;
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
                command = new MySqlCommand("select users.User_Id, users.FirstName, users.LastName, users.Balance, users.Status," +
                " users.Entrance_Fee from users join rfid on users.User_Id = rfid.Users_Id where rfid.RFID_Nr = '" +
                rfidNr + "';", connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    person = new Visitor(Convert.ToInt32(reader[0]), reader[1].ToString(),
                    reader[2].ToString(), Convert.ToDecimal(reader[3]), reader[4].ToString(), reader[5].ToString());
                }

                return person;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Please, connect to the database!");

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
                "from rfid where RFID_Nr = '" + rfid + "');", connection);

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

        public void Pay(string rfid)
        {
            MySqlCommand cmd;

            try
            {
                connection.Open();
                cmd = new MySqlCommand("Update users Set Balance = Balance - 65, Entrance_Fee = 'Paid' " +
                "Where User_Id = (select Users_Id from rfid where RFID_Nr = '" + rfid + "');", connection);

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

    }
}
