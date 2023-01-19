using System;

namespace Milestone2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] rollRecord = new int[11];

            //Intro message
            Console.Write("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate? ");

            //Read user response, store it as an int
            string response = Console.ReadLine();
            int rollCount = Convert.ToInt32(response);

            //Loop the number of times the user specified, rolling two dice, adding them, and incrementing the total
            for (int i = 0; i < rollCount; i++)
            {
                int roll1 = r.Next(1, 7);
                int roll2 = r.Next(1, 7);

                rollRecord[(roll1 + roll2) - 2]++;
            }

            //Print histogram explanation and roll count
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + rollCount + ".\n");

            //Print out the results from the array
            for (int i = 0; i < rollRecord.Length; i++)
            {
                //Create a string that contains the correct number of asterisks for the histogram
                string asterisks = "";
                for (int j = 0; j < ((float)rollRecord[i] / rollCount) * 100; j++)
                {
                    asterisks = asterisks + "*";
                }

                //Print the number and the asterisks
                Console.WriteLine((i + 2) + ": " + asterisks);
            }

            //Print outro
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
