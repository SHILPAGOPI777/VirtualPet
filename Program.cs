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
                    Console.WriteLine("You selected Cat...!, What would you like to name your Cat?");
                    petName = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("You selected Dog...! ,  What would you like to name your Dog?");
                    petName = Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("You selected Rabbit...!, What would you like to name your Rabbit?");
                    petName = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid entry. Please enter 1, 2, or 3.");
                    break;

            }

            Console.WriteLine("\nYour pet's name is :" + petName); // to display pet name
            Console.WriteLine("\n Welcome " + petName + "!" + "" + " Let's take good care of him");

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
                string menuInput = Console.ReadLine();

                if (menuInput == "1")
                {
                    hunger = hunger + 2;
                    health++;
                    Console.WriteLine("You feed " + petName + ". His hunger decreases and health improve slighlty!!");




                }

                if (menuInput == "2")
                {
                    happiness = happiness + 2;
                    hunger++;
                    Console.WriteLine("You played with " + petName + ". His happiness increases but he is bit hungry!");




                }

                if (menuInput == "3")
                {
                    health = health + 2;
                    happiness--;
                    Console.WriteLine("Your " + petName + " took rest, His health increases but his happiness decreased!");


                }


                if (menuInput == "4")
                {
                    Console.WriteLine(petName + "'s status:");
                    Console.WriteLine("-Hunger:" + hunger + "\n-Happiness:" + happiness + "\n-Health:" + health);
                    Console.ReadLine();

                }

                if (menuInput == "5")
                {
                    Console.WriteLine("Thank you for playing with " + petName +"!!");
                    Console.ReadLine();

                    break;

                }




            }






        }

    }
}

