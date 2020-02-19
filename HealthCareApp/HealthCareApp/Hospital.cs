using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCareApp
{
   public class Hospital : Building
    {
        public string Group { get; set; }
        public string Speciality { get; set; }
        public string AdultOrChild { get; set; }
        public string AgeProfile { get; set; }
        public string WaitingTime { get; set; }
        public string name{ get; set; }

        public Hospital(int ID, string Eircode, string Address, decimal Coordinates, string Group, string Speciality, string AdultOrChild, string AgeProfile, string WaitingTime,string Name) : base(ID, Eircode, Address, Coordinates)
        {
            this.Group = Group;
            this.Speciality = Speciality;
            this.AdultOrChild = AdultOrChild;
            this.AgeProfile = AgeProfile;
            this.WaitingTime = WaitingTime;
            this.name = name;
        }
    }
}
