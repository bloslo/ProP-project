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
        public decimal Price { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public RentedItem(int id, string name, decimal price, DateTime hire, DateTime reDate)
        {
            ItemId = id;
            ItemName = name;
            Price = price;
            HireDate = hire;
            ReturnDate = reDate;
        }
    }
}
