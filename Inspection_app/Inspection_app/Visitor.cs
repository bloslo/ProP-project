using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspection_app
{
    class Visitor
    {
        public int VisitorID { get; set; }
        public string Name { get; set; }
        public decimal AccountBalance { get; set; }
        public bool Present { get; set; }
        public bool EntranceFee { get; set; }
        public decimal FoodExpences { get; set; }
        public decimal TransferedMoney { get; set; }

        public Visitor(int id, string name, decimal balance, bool present, bool fee, decimal food, decimal transfered)
        {
            VisitorID = id;
            Name = name;
            AccountBalance = balance;
            Present = present;
            EntranceFee = fee;
            FoodExpences = food;
            TransferedMoney = transfered;
        }

        public string Status()
        {
            string status;

            if (Present == true)
            {
                status = "At the event";
            }
            else
            {
                status = "Not at the event";
            }

            return status;
        }

        public string Info()
        {
            string overview;
            string paid;

            if (EntranceFee == true)
            {
                paid = "Paid";
            }
            else
            {
                paid = "Not paid";
            }

            overview = "ID: " + VisitorID + "\nName: " + Name + "\nEntrance fee: " + paid +
                "\nOrdered food for: " + FoodExpences + "\nMoney transfered to the account: " + TransferedMoney;

            return overview;
        }
    }
}
