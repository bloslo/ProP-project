using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campsite_App
{
    class Visitor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SpotNr { get; set; }
        public string SpotSection { get; set; }

        public Visitor(int id, string fname, string lname, string nr, string section)
        {
            ID = id;
            FirstName = fname;
            LastName = lname;
            SpotNr = nr;
            SpotSection = section;
        }
    }
}
