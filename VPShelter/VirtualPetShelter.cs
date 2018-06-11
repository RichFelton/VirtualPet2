using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPetShelter
    {

        public string PetName
        {
            get { return this.PetName; }
            set { this.PetName = value; }
        }

        //List<string> petName = new List<string>();

        public string ManagerName
        {
            get { return this.ManagerName; }
            set { this.ManagerName = value; }
        }

        public string VolunteerName
        {
            get { return this.VolunteerName; }
            set { this.VolunteerName = value; }
        }

        //List<string> volunteerName = new List<string>();

        //List<string> managerName = new List<string>();

    }
}
