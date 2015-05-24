using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exti_App
{
    class RentedItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public DateTime HireDate { get; set; }

        public RentedItem(int id, string name, int quantity, DateTime hire)
        {
            ItemId = id;
            ItemName = name;
            Quantity = quantity;
            HireDate = hire;
        }

        public string FormatOutput()
        {
            return "Item ID: " + ItemId + ", Item Name: " + ItemName + ", Quantity: " + Quantity + ", Hire Date: " + 
                HireDate.Date.ToString("dd/MMM/yyyy");
        }
    }
}
