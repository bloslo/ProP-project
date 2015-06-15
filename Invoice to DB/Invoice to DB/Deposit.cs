using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_to_DB
{
    class Deposit
    {
        public int DepositID { get; set; }
        public int UserID { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateAndTime { get; set; }

        public Deposit(int depId, int userId, decimal amount, DateTime date)
        {
            DepositID = depId;
            UserID = userId;
            Amount = amount;
            DateAndTime = date;
        }
    }
}
