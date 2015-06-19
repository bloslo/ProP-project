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

        public Camp(int id, int section)
        {
            CampSpotID = id;
            CampSpotSection = section;
        }

        public string Info()
        {
            return string.Format("Camp Spot ID: {0} \nCamp Spot Section: {1}", CampSpotID, CampSpotSection);
        }
    }
}
