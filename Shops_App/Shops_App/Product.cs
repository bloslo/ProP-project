using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops_App
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(int id, string name, decimal price, int quantity)
        {
            ProductID = id;
            ProductName = name;
            Price = price;
            Quantity = quantity;
        }

        public string DisplayInfo()
        {
            return string.Format("ID: {0} \tName: {1} \tPrice: {2} \tQuantity: {3}", ProductID, ProductName, Price, Quantity);
        }

        public static Product Purchase(Product pro)
        {
            pro.Quantity = 1;

            return pro;
        }
    }
}
