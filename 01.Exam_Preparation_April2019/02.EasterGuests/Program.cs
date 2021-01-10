using System;

namespace _02.EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double neededCaces = Math.Ceiling(1.0 * numberOfGuests / 3);
            double neededEggs = numberOfGuests * 2.0;
            double priceOfCaces = neededCaces * 4.0;
            double priceOfEggs = neededEggs * 0.45;

            double totalCost = priceOfCaces + priceOfEggs;

            double diff = budget - totalCost;
            if (budget >= totalCost)
            {
                Console.WriteLine($"Lyubo bought {neededCaces} Easter bread and {neededEggs} eggs.");
                Console.WriteLine($"He has {diff:f2} lv. left");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {Math.Abs(diff):f2} lv. more.");
            }
        }
    }
}
