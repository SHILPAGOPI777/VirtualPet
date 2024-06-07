using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Virtual  Pet Game....!!!!\n\n"); //Welcome Message 


            Console.WriteLine("Please Choose a type of PET\n\n"); // Option to choose pet type


            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");

            string input = Console.ReadLine(); // accepts user's input
            string petName = "";


            switch (input)
            {
                case "1":
                    Console.WriteLine("You selected Cat...!, What would you like to name your Cat?"); // Accepts name for pet
                    petName = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("You selected Dog...! ,  What would you like to name your Dog?");// Accepts name for pet
                    petName = Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("You selected Rabbit...!, What would you like to name your Rabbit?");// Accepts name for pet
                    petName = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid entry. Please enter 1, 2, or 3.");// Validation for invalid entry
                    break;

            }

            Console.WriteLine("\nYour pet's name is :" + petName); // to display pet name
            Console.WriteLine("\n Welcome " + petName + "!" + "" + " Let's take good care of him");

            // declaring hunger,happiness and health values

            int hunger = 5; 
            int happiness = 5;
            int health = 8;

            while (true)

            {
                // THis is main menu and options are listed
                Console.WriteLine("\n Menu:");
                Console.WriteLine("1.Feed " + petName);
                Console.WriteLine("2.Play with  " + petName);
                Console.WriteLine("3.Let " + petName + " Take Rest");
                Console.WriteLine("4.Check " + petName + "'s status");
                Console.WriteLine("5.Exit");
                string menuInput = Console.ReadLine(); // Accepts user's input

                if (menuInput == "1")
                {
                    hunger = hunger + 2;
                    health++;
                    Console.WriteLine("You feed " + petName + ". His hunger decreases and health improve slighlty!!");

                    // Displays feeding related text if user selected option 1


                }

                if (menuInput == "2")
                {
                    happiness = happiness + 2;
                    hunger++;
                    Console.WriteLine("You played with " + petName + ". His happiness increases but he is bit hungry!");

                    // Displays playing related text if user selected option 2




                }

                if (menuInput == "3")
                {
                    health = health + 2;
                    happiness--;
                    Console.WriteLine("Your " + petName + " took rest, His health increases but his happiness decreased!");

                    // Displays restinging related text if user selected option 3


                }


                if (menuInput == "4")
                {
                    Console.WriteLine(petName + "'s status:");
                    Console.WriteLine("-Hunger:" + hunger + "\n-Happiness:" + happiness + "\n-Health:" + health);
                    Console.ReadLine();


                    // Displays restinging related text if user selected option 3
                }

                if (menuInput == "5")
                {
                    Console.WriteLine("Thank you for playing with " + petName + "!!");
                    Console.ReadLine();

                    break;

                    //Option to exit from the game if the user selected option 5.

                }


                // Alert for user to denote the pet is in extreem conditions.
                if (hunger == 2)
                {
                    Console.WriteLine("ALERT: " + petName + " is very hungry! Please feed them soon.");
                }



            }






        }

    }
}

