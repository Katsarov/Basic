using System;

namespace _05.EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakes = int.Parse(Console.ReadLine());

            int countSugar = 0;
            int countFlour = 0;

            int maxSugar = int.MinValue;
            int maxFlour = int.MinValue;

            for (int i = 0; i < bakes; i++)
            {
                int sugar = int.Parse(Console.ReadLine());
                countSugar += sugar;
                if (sugar > maxSugar)
                {
                    maxSugar = sugar;
                }

                int flour = int.Parse(Console.ReadLine());
                countFlour += flour;
                if (flour > maxFlour)
                {
                    maxFlour = flour;
                }
            }

            double packsSugar = 1.0 * countSugar / 950;
            double packsFlour = 1.0 * countFlour / 750;

            Console.WriteLine($"Sugar: {Math.Ceiling(packsSugar)}");
            Console.WriteLine($"Flour: {Math.Ceiling(packsFlour)}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
