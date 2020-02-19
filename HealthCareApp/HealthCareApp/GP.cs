using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCareApp
{
    public class GP : Building
    {
        public string Year { get; set; }
        public string TotalGps { get; set; }
        public string TotalPatients { get; set; }

        public GP(int ID, string Eircode, string Address, decimal Coordinates, string Year, string TotalGps, string TotalPatients) : base(ID, Eircode, Address, Coordinates)
        {
            this.TotalGps = TotalGps;
            this.TotalPatients = TotalPatients;
            this.Year = Year;
            
        }
    }
}
