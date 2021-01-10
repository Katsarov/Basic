using System;

namespace _01.EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int caces = int.Parse(Console.ReadLine());
            int cratesEggs = int.Parse(Console.ReadLine());
            int smallCaces = int.Parse(Console.ReadLine());

            double totalCaces = caces * 3.2;
            double totalEggs = cratesEggs * 4.35;
            double totalSmallCaces = smallCaces * 5.4;
            double colorForEggs = cratesEggs * 12 * 0.15;

            double totalSum = totalCaces + totalEggs + totalSmallCaces + colorForEggs;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
