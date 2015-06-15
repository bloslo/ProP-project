using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanMaterials_App
{
    class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int OrderID { get; set; }

        public Item(int id, string name, decimal price, int quantity)
        {
            ItemID = id;
            ItemName = name;
            Price = price;
            Quantity = quantity;
        }

        public Item(int id, int quantity, int orderId)
        {
            ItemID = id;
            Quantity = quantity;
            OrderID = orderId;
        }

        public string Info()
        {
            return string.Format("ID: {0} \t{1} \tPrice: {2} \tQuantity: {3}", ItemID, ItemName, Price, Quantity);
        }

        public string ShortInfo()
        {
            return string.Format("ID: {0} \tQuantity: {1} \tOrder ID: {2}", ItemID, Quantity, OrderID);
        }

        public static Item TakeFromStock(Item i)
        {
            i.Quantity = 1;

            return i;
        }


    }
}
