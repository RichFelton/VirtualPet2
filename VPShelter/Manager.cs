using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager : Employee
    {
        private string managerName = "";

        public string ManagerName { get; set; }

        public void Adopt(VirtualPetShelter virtualPetShelter, VirtualPet petName)
        {
            //virtualPetShelter.RemoveAt(value.ListOfPets);
        }

        public override void ManagerHours()
        {
            throw new NotImplementedException();
        }

        public override void VolunteerHours()
        {
            throw new NotImplementedException();
        }

        public string ManagerPhoneNumber { get; set; }

        public int FeedAllPets { get; set; }
        public int WaterAllPets { get; set; }


                       

    }
}
