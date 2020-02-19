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

        public GP(string Eircode, string Address, decimal Coordinatex, decimal Coordinatey, string Name, string Year, string TotalGps, string TotalPatients) : base(Eircode, Address, Name, Coordinatex, Coordinatey)
        { 
            this.TotalPatients = TotalPatients;
            this.Year = Year;
            this.TotalGps = TotalGps;

        }
    }
}
