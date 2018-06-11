using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer : Employee
    {
        public Volunteer()
        {
        }

        public override void ManagerHours()
        {
            throw new NotImplementedException();
        }
        public override void VolunteerHours()
        {
            throw new NotImplementedException();
        }

        public string VolunteerPhoneNumber { get; set; }

        public int FeedAllPets { get; set; }
        public int WaterAllPets { get; set; }


        //private Random foodStatus = new Random();
        //int food = foodStatus.Next(0, 100);

        //Random thirstStatus = new Random();
        //int water = thirstStatus.Next(0, 100);

        //Random toiletStatus = new Random();
        //int peeOrPoop = toiletStatus.Next(0, 100);

        //int careForPet = int.Parse(Console.ReadLine());
        //string foodAndWater = "";

        //if (careForPet == 1)
        //   {
        //   food = food++;
        //   foodAndWater = "feed";
        //   }
        //   if (careForPet == 2)
        //   {
        //   water = water++;
        //   foodAndWater = "give water to";
        //   }
        //   else
        //   Console.WriteLine("You have chosen to " + foodAndWater + " all the pets.");                            


    }
}
