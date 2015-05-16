using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspection_app
{
    class Camp
    {
        public int CampSpotID { get; set; }
        public int CampSpotSection { get; set; }
        public decimal Price { get; set; }
        public int ResidentsCount { get; set; }
        public string Type { get; set; }

        public Camp(int id, int section, decimal price, int residents, string type)
        {
            CampSpotID = id;
            CampSpotSection = section;
            Price = price;
            ResidentsCount = residents;
            Type = type;
        }

        public string Info()
        {
            string overview;

            overview = "Spot ID: " + CampSpotID + "\nSection ID: " + CampSpotSection +
                "\nType: " + Type + "\nResidents Number: " + ResidentsCount + "\nPrice: " +
                Price;

            return overview;
        }
    }
}
