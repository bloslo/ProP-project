using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspection_app
{
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int UnitsSold { get; set; }
        public int Stock { get; set; }

        public Product(int id, string name, int sold, int stock)
        {
            ProductId = id;
            Name = name;
            UnitsSold = sold;
            Stock = stock;
        }
    }
}
