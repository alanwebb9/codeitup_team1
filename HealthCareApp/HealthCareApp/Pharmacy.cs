using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCareApp
{
    public class Pharmacy : Building
    {

        public string PerscriptionAmount { get; set; }
        public int TotalClaim { get; set; }
        public string Percentage{ get; set; }
        public string Year { get; set; }
        public string Name { get; set; }

        public Pharmacy(int ID, string Eircode, string Address, decimal Coordinates, string PerscriptionAmount, int TotalClaim, string Percentage, string Year, string Name) : base(ID, Eircode, Address, Coordinates)
        {
            this.PerscriptionAmount = PerscriptionAmount;
            this.TotalClaim = TotalClaim;
            this.Percentage = Percentage;
            this.Year = Year;
            this.Name = Name;
        }

    }
}
