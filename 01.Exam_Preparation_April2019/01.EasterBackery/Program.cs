using System;

namespace _01.EasterBackery
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceMeal = double.Parse(Console.ReadLine());
            double kilosMeal = double.Parse(Console.ReadLine());
            double kilosSugar = double.Parse(Console.ReadLine());
            int cratesWithEggs = int.Parse(Console.ReadLine());
            int pacYeast = int.Parse(Console.ReadLine());

            double priceSugar = priceMeal * 0.75;
            double priceEggs = priceMeal * 1.1;
            double priceYeast = priceSugar * 0.20;

            double sumMeal = priceMeal * kilosMeal;
            double sumSugar = kilosSugar * priceSugar;
            double sumEggs = cratesWithEggs * priceEggs;
            double sumYeast = pacYeast * priceYeast;

            double totalSumproducts = sumMeal + sumSugar + sumEggs + sumYeast;

            Console.WriteLine($"{totalSumproducts:f2}");
        }
    }
}
