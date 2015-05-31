using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops_App
{
    class Visitor
    {
        public int UserID { get; set; }
        public decimal Balance { get; set; }

        public Visitor(int id, decimal balance)
        {
            UserID = id;
            Balance = balance;
        }
    }
}
