using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Inspection_app
{
    class DBExtractor
    {
        private MySqlConnection connection;

        public DBExtractor()
        {
            string connectionString = "Server=athena01.fhict.local; Database=dbi327800; Uid=dbi327800; Pwd=6ulxOndB9b;";
            connection = new MySqlConnection(connectionString);
        }

        public int Test()
        {
            MySqlCommand cmd;
            int result;

            using (cmd = new MySqlCommand("select count(*) from camp", connection))
            {
                connection.Open();
                result = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return result;
        }

        //public Camp CampSpotInfo()
        //{
        //    Camp
        //}
    }
}
