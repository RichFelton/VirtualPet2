using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        private static int menuChoice;

        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            string petName = "";

            Console.Write("Welcome to the We Can Code IT Virtual Pet Shelter \n");

            Random foodStatus = new Random();
            int food = foodStatus.Next(0, 100);

            Random thirstStatus = new Random();
            int water = thirstStatus.Next(0, 100);

            Random toiletStatus = new Random();
            int peeOrPoop = toiletStatus.Next(0, 100);

            Console.WriteLine("THIS IS THE CURRENT STATUS OF THE PETS AT THE VIRTUAL PET SHELTER: \n");

            //Console.WriteLine(/*petName[0]*/ + food + water + peeOrPoop);
            //Console.WriteLine(petName[1] + food + water + peeOrPoop);
            //Console.WriteLine(petName[2] + food + water + peeOrPoop);
            //Console.WriteLine(petName[3] + food + water + peeOrPoop);

            Console.Write("Please select the number associated with your employee type: \n");

            //int menuChoice;

            do
            {
                //Console.Clear();
                Console.WriteLine("[1] Manager");
                Console.WriteLine("[2] Volunteer");
                Console.WriteLine("[3] Exit");

                int userInput;
                int menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {

                    case 1:
                        //Console.Clear();
                        Console.Write("Manager, please enter your first name: \n");
                        string managerName = Console.ReadLine();
                        Console.Write(managerName + ", please select the number of the activity you would like to perform: ");
                        Console.WriteLine("[1] Feed the pets.");
                        Console.WriteLine("[2] Play with a pet.");
                        Console.WriteLine("[3] Remove a pet for adoption.");
                        Console.WriteLine("[4] Pay the bills.");
                        Console.WriteLine("[5] return");
                        Console.ReadLine();
                        do
                        {
                            userInput = 0;
                            userInput = int.Parse(Console.ReadLine());

                            switch (userInput)
                            {
                                case 1: //Feed the pets.
                                    Console.Write(managerName + ", please choose to either feed or water all the pets: \n ");
                                    Console.ReadLine();
                                    Console.WriteLine("[1] Feed all the pets.");
                                    Console.WriteLine("[2] Give water to all the pets.");
                                    Console.WriteLine("[3] return");
                                    int careForPet = int.Parse(Console.ReadLine());
                                    string foodAndWater = "";

                                    if (careForPet == 1)
                                    {
                                        food = food++;
                                        foodAndWater = "feed";
                                    }
                                    if (careForPet == 2)
                                    {
                                        water = water++;
                                        foodAndWater = "give water to";
                                    }
                                    else
                                        Console.WriteLine("You have chosen to " + foodAndWater + " all the pets.");

                                    break;
                                case 2: //Play with a pet. 
                                    Console.Write(managerName + ", please select the number of the name of the pet you want to play with: ");
                                    Console.ReadLine();
                                    //string petName = "";
                                    Console.WriteLine("[1] Matrix");
                                    Console.WriteLine("[2] Ally");
                                    Console.WriteLine("[3] Rickie");
                                    Console.WriteLine("[4] Carrie");
                                    Console.WriteLine("[5] return");
                                    Console.ReadLine();
                                    Console.WriteLine("You played with {0} .", petName);

                                    break;
                                case 3: //Remove a pet for adoption. 
                                    Console.WriteLine(managerName + ", Select the number of the name of the pet that is being adopted: ");
                                    Console.WriteLine("[1] Matrix");
                                    Console.WriteLine("[2] Ally");
                                    Console.WriteLine("[3] Rickie");
                                    Console.WriteLine("[4] Carrie");
                                    Console.WriteLine("[5] return");
                                    int index = int.Parse(Console.ReadLine());
                                    index = index - 1;
                                    //Console.WriteLine(" {0} is leaving the virtual shelter to be adopted by a wonderful human!", VirtualPetShelter.listOfPets.ElementAt(index));
                                    //VirtualPetShelter.listOfPets.RemoveAt(index);
                                    //Console.WriteLine("Press enter to continue");
                                    //Console.ReadLine();

                                    break;
                                case 4: //Pay the bills. 
                                    Console.WriteLine(managerName + ", you have chosen to pay this month's outstanding bills. \n");
                                    Console.WriteLine("All bills have been paid. All accounts are now current.");
                                    Console.ReadLine();

                                    break;
                                case 5: //leave the switch
                                    userInput = 0;
                                    break;

                                default:
                                    Console.WriteLine("Invalid response!");
                                    break;

                            }

                        }
                        while (userInput == 0);
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Volunteer, please type your first name: ");
                        string volunteerName = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("STATUS OF THE PETS MATRIX");
                        Console.WriteLine();
                        Console.WriteLine(volunteerName + ", please select the number of the activity you wish to perform:");
                        Console.WriteLine("[1] Give food or water to all the pets.");
                        Console.WriteLine("[2] Play with an individual pet.");
                        Console.WriteLine("[3] return");

                        do
                        {
                            userInput = 0;
                            userInput = int.Parse(Console.ReadLine());

                            switch (userInput)
                            {
                                case 1: //Feed the pets.
                                    Console.Write(volunteerName + ", please choose to either feed or water all the pets: ");
                                    Console.ReadLine();
                                    Console.WriteLine("[1] Feed all the pets.");
                                    Console.WriteLine("[2] Give water to all the pets.");
                                    Console.WriteLine("[3] return");
                                    Console.ReadLine();
                                    Console.WriteLine("You have chosen to " + food + " all the pets.");

                                    break;
                                case 2: //Play with a pet. 
                                    Console.Write(volunteerName + ", please select the number of the name of the pet you want to play with: ");
                                    //string petName = "";
                                    Console.WriteLine("[1] Matrix");
                                    Console.WriteLine("[2] Ally");
                                    Console.WriteLine("[3] Rickie");
                                    Console.WriteLine("[4] Carrie");
                                    Console.WriteLine("[5] return");
                                    Console.ReadLine();
                                    Console.WriteLine("You played with {0} .", petName);

                                    break;
                                case 3: //leave the switch
                                    break;

                                default:
                                    Console.WriteLine("Invalid response!");
                                    break;

                            }

                        }
                        while (userInput == 0);
                        break;

                    case 3: //leave the switch
                        break;

                    default:
                        do
                        {
                            userInput = 0;
                            userInput = int.Parse(Console.ReadLine());

                            switch (userInput)
                            {

                                case 3: //leave the switch
                                    break;

                                default:
                                    Console.WriteLine("Invalid response!");
                                    break;

                            }

                        }
                        while (userInput == 0);
                        break;

                    //case 4:
                    //    menuChoice = 0;
                    //    break;
                    //default:
                    //    break;

                }// end menu switch
            } while (menuChoice > 0);

            {

            }

        }
    }
}
