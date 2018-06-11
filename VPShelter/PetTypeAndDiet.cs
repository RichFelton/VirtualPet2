using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class PetTypeAndDiet : VirtualPet
    {

        private string TypeOfPet { get; set; }
        private string PetDiet { get; set; }

        public PetTypeAndDiet() //default constructor
        {

        }

        public PetTypeAndDiet(string typeOfPet, string petDiet) //loaded constructor
        {
            TypeOfPet = typeOfPet;
            PetDiet = petDiet;
        }
    }
}
