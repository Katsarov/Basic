using System;
using System.Diagnostics;

namespace _06.EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBakes = int.Parse(Console.ReadLine());
            string bestBakerName = "";
            int bestBakerPoints = int.MinValue;

            for (int i = 0; i < numberOfBakes; i++)
            {
                string bakerName = Console.ReadLine();
                int points = 0;

                string command = Console.ReadLine();
                while (command != "Stop")
                {
                    points += int.Parse(command);
                    command = Console.ReadLine();
                }

                Console.WriteLine($"{bakerName} has {points} points.");

                if (points > bestBakerPoints)
                {
                    bestBakerPoints = points;
                    bestBakerName = bakerName;
                    Console.WriteLine($"{bakerName} is the new number 1!");
                }
            }

            Console.WriteLine($"{bestBakerName} won competition with {bestBakerPoints} points!");
        }
    }
}
