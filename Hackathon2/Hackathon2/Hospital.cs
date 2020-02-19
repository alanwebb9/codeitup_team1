using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon2
{
    public class Hospital : Building
    {
        public string Group { get; set; }
        public string Speciality { get; set; }
        public string AdultOrChild { get; set; }
        public string AgeProfile { get; set; }
        public string WaitingTime { get; set; }
        public string Total { get; set; }
        

        public Hospital(string Name, string Address, string Eircode, string Coordinatex, string Coordinatey, string Group, string Speciality, string AdultOrChild, string AgeProfile, string WaitingTime, string Total) : base(Name, Address, Eircode, Coordinatex, Coordinatey)
        {
            this.Group = Group;
            this.Speciality = Speciality;
            this.AdultOrChild = AdultOrChild;
            this.AgeProfile = AgeProfile;
            this.WaitingTime = WaitingTime;
            this.Total = Total;
        }

        public override void SearchByEircode()
        {

        }

        public override void ShowDetails()
        {

        }



    }
}
