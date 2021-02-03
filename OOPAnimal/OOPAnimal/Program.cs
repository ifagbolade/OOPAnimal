 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Family, genus and species 
            // Make a tiger and a caracl 

            Species tiger = new Species("Tiger","Panthera tigris");
            Species caracal = new Species("Caracal");
            Family Felidae = new Family("Felidae");

            Felidae.numberOfTeeth = 30;
            Felidae.numberOfToes= 5;
            tiger.setAttributes(Felidae);
            caracal.setAttributes(Felidae);

            // to run the species 
            Console.WriteLine("What is the name of the species?:");
            string newSpeciesName = Console.ReadLine();

            // to run legs 
            Console.WriteLine("How many legs does it have?:");
            int numLegs = 0;
            // try catch an error expection when you put a string instead of a number 
            try
            {
               numLegs =  int.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine("couldn't make a number out of that, plese try again, error was " + ex.ToString()); 
                //ex.tostring: show the error

                // if the user keep repeating the error; it will repeat the same code 
                /*
                while (numLegs <= 0)
                {
                  Console.WriteLine("How many legs does it have?:");
                    try
                    {
                        numLegs = int.Parse(Console.ReadLine());

                    }
                    catch (Exception ex2) { }
                    
                }
                */
            }

            Species newObj = new Species(newSpeciesName, numLegs);
            Console.ReadLine();



        }
    }
}
