using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspection_app
{
    class Visitor
    {
        public string Name { get; set; }
        public decimal AccountBalance { get; set; }
        public string Status { get; set; }
        public string EntranceFee { get; set; }

        public Visitor(string name, decimal balance, string status, string fee)
        {
            Name = name;
            AccountBalance = balance;
            Status = status;
            EntranceFee = fee;
        }
    }
}
