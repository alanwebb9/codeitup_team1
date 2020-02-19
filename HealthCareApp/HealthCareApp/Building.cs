using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCareApp
{
    public abstract class Building 
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public string Eircode  { get; set; }
        public decimal Coordinates { get; set; }

        public Building(int ID, string Eircode, string Address, decimal Coordinates)
        {
            this.ID = ID;
            this.Address = Address;
            this.Eircode = Eircode;
            this.Coordinates = Coordinates;

        }

    }
}
