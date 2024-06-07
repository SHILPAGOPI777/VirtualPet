using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VirtualPet
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("------------------------------------------\n\n");

            Console.WriteLine("Welcome to Virtual  Pet Game....!!!!\n\n"); //Welcome Message 


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Please Choose a type of PET\n\n"); // Option to choose pet type

            // Displays each pet line by line 
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");

            string input = Console.ReadLine(); // accepts user's input
            string petName = "";


            switch (input) // On giving pets name, name appear here with Pet type. 
            {
                case "1":
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("You selected Cat...!, What would you like to name your Cat?"); // Accepts name for pet
                    petName = Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("You selected Dog...! ,  What would you like to name your Dog?");// Accepts name for pet
                    petName = Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("You selected Rabbit...!, What would you like to name your Rabbit?");// Accepts name for pet
                    petName = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Invalid entry. Please enter 1, 2, or 3.");// Validation for invalid entry
                    break;

            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("\nYour pet's name is :" + petName); // to display pet name
            Console.WriteLine("\nWelcome " + petName + ":)" + " Let's take good care of him!");

            // declaring hunger,happiness and health values

            int hunger = 5;
            int happiness = 5;
            int health = 8;

            while (true)

            {
                // This is main menu and options are listed
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1.Feed " + petName); // To feed pet
                Console.WriteLine("2.Play with  " + petName); // To play with pet
                Console.WriteLine("3.Let " + petName + " Take Rest"); //To rest
                Console.WriteLine("4.Check " + petName + "'s status"); // Checking status of the pet 
                Console.WriteLine("5.Exit"); // exits user from the application
                string menuInput = Console.ReadLine(); // Accepts user's input

                // If user chooses option 1

                if (menuInput == "1")
                {
                    hunger -= 2;// decreases hunger on playing
                    health++; // health increases slightly
                    Console.WriteLine("You feed " + petName + ". His hunger decreases and health improve slighlty!!"); // response message


                    // Displays feeding related text if user selected option
                }
                // If user chooses option 2

                if (menuInput == "2")
                {
                    happiness = happiness + 2; // happiness increases
                    hunger++; // Hunger slightly increases
                    Console.WriteLine("You played with " + petName + ". His happiness increases but he is bit hungry!");

                    // Displays playing related text if user selected option 2

                }
                // If user chooses option 3
                if (menuInput == "3")
                {
                    health = health + 2; // Health increases
                    happiness--; // Happiness slightly decreases
                    hunger++;  // Hunger slightly increases
                    Console.WriteLine("Your " + petName + " took rest, His health increases but his happiness decreased & he needs to eat!");


                    // Displays resting related text if user selected option 3


                }
                // If user chooses option 4

                if (menuInput == "4")
                {
                    Console.WriteLine(petName + "'s status:");
                    Console.WriteLine("-Hunger:" + hunger + "\n-Happiness:" + happiness + "\n-Health:" + health);

                    if (hunger > 6) // if hunger is greater than 6 then message to feed the pet
                    {
                        Console.WriteLine("Alert!!!: " + petName + " is hungry, pet is refusing to play! Please feed " + petName);
                    }
                    
                    
                    if (hunger == 1) // Alerting to stop feeding if hunger is 1
                        Console.WriteLine("Alert!!!: " + petName + " is full.Stop Feeding to proceed...!!");

                    if (health < 6)
                    {
                        Console.WriteLine("Alert!" + petName + "'s health is decreasing, please give him some rest");

                        //If health decreases , giving alert to user asking for REST


                    }


                    // Displays restinging related text if user selected option 3
                }
                // If user chooses option 5
                if (menuInput == "5")
                {
                    Console.WriteLine("Thank you for playing with " + petName + "!!"); //Option to exit from the game if the user selected option 5.
                    Thread.Sleep(3000); // Hold for 3 seconds

                    break;



                }






            }






        }

    }
}


