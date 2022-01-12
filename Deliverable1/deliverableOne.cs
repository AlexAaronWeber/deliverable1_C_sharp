using System;

namespace Deliverable1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            decimal totalLoaves = 0;
            decimal totalJarJelly = 0;
            decimal totalJarPB = 0;
            decimal slices = 0;
            decimal tbspPB = 0;
            decimal tspJelly = 0;
            decimal slicesPerLoaf = 28;
            decimal tspPerJarJelly = 48;
            decimal tbspPerJarPB = 32;
            bool restart = true;
            string loopChoice = "";

          while (restart) { 

            Console.Write("It's Peanut Butter Jelly TIME!! How many people are we feeding?");
            string input = Console.ReadLine();
            ulong numSandwich = ulong.Parse(input);

            if (numSandwich >= 1)
            {
                slices = numSandwich * 2;
                tbspPB = numSandwich * 2;
                tspJelly = numSandwich * 4;
                totalLoaves = Math.Ceiling (slices/slicesPerLoaf);
                totalJarPB = Math.Ceiling(tbspPB / tbspPerJarPB);
                totalJarJelly = Math.Ceiling(tspJelly / tspPerJarJelly);
                Console.WriteLine("You need:"); 
                Console.WriteLine(slices + " slices of Bread");
                Console.WriteLine(tbspPB + " tablespoons of Peanut Butter");
                Console.WriteLine(tspJelly + " teaspoons of Jelly");  
                Console.WriteLine("Which is...");
                Console.WriteLine(totalLoaves + " loaf(s) of Bread");
                Console.WriteLine(totalJarPB + " jar(s) of Peanut Butter");
                Console.WriteLine(totalJarJelly + " jar(s) of Jelly");
            }
                    Console.Write("Would you like to start over?");
                    loopChoice = Console.ReadLine();

                    if (loopChoice == "y")
                    {
                        restart = true;
                    }
                    else if (loopChoice == "yes")
                    {
                        restart = true;
                    } else
                    {
                        restart = false;
                        Console.WriteLine("Goodbye!");
                    }
               
            } 
            
        }
    }
}