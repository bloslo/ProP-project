using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspection_app
{
    class Shop
    {
        public int ShopId { get; set; }
        public decimal Income { get; set; }

        public Shop(int id, decimal income)
        {
            ShopId = id;
            Income = income;
        }
    }
}
