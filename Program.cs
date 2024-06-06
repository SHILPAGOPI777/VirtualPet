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


            Console.WriteLine("Please Choose a type of PET\n\n");


            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");

            string input = Console.ReadLine();
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
         
            // THis is main menu and options are listed
            Console.WriteLine("\n Menu:");
            Console.WriteLine("1.Feed " + petName);
            Console.WriteLine("2.Play with  " + petName);
            Console.WriteLine("3.Let " + petName +" Take Rest");
            Console.WriteLine("4.Check " + petName+"'s status");
            Console.WriteLine("5.Exit");
            Console.ReadLine();
        }

    }
}

