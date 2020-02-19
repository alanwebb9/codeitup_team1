using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon2
{
    public class GP : Building
    {
        public string Year { get; set; }
        public string TotalGps { get; set; }
        public string TotalPatients { get; set; }

        public GP(string Name, string Address, string Eircode, string Coordinatex, string Coordinatey, string Year, string TotalGps, string TotalPatients) : base(Name, Address, Eircode, Coordinatex, Coordinatey)
        { 
            this.TotalPatients = TotalPatients;
            this.Year = Year;
            this.TotalGps = TotalGps;

        }

        public override void SearchByEircode()
        {

        }

        public override void ShowDetails()
        {

        }
    }
}
