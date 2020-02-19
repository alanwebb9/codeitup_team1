using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon2
{
    public abstract class Building
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Eircode { get; set; }
        public string Coordinatex { get; set; }
        public string Coordinatey { get; set; }

        public Building(string Name, string Address, string Eircode, string Coordinatex, string Coordinatey)
        {
            this.Name = Name;
            this.Address = Address;
            this.Eircode = Eircode;
            this.Coordinatex = Coordinatex;
            this.Coordinatey = Coordinatey;

        }

        public abstract void SearchByEircode();
        public abstract void ShowDetails();
    }
}
