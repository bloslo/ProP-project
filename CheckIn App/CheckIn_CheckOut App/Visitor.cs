using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIn_CheckOut_App
{
    class Visitor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
        public string Status { get; set; }

        public Visitor(int id, string fname, string lname, decimal balance, string status)
        {
            ID = id;
            FirstName = fname;
            LastName = lname;
            Balance = balance;
            Status = status;
        }
    }
}
