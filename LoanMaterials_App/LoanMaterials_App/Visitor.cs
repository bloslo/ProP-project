using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanMaterials_App
{
    class Visitor
    {
        public int ID { get; set; }
        public decimal Balance { get; set; }

        public Visitor(int id, decimal balance)
        {
            ID = id;
            Balance = balance;
        }
    }
}
