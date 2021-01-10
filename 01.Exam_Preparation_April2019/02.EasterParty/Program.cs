using System;

namespace _02.EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double cuvert = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double totalSum = 0;
            if (guests < 10)
            {
                double sumCash = 1.0 * guests * cuvert;
                double cace = budget * 0.1;
                totalSum = sumCash + cace;
            }
            else if (guests >= 10 && guests <=15)
            {
                double rabat = cuvert * 0.85;
                double sumCash = guests * rabat;
                double cace = budget * 0.1;
                totalSum = sumCash + cace;
            }
            else if (guests > 15 && guests <= 20)
            {
                double rabat = cuvert * 0.8;
                double sumCash = guests * rabat;
                double cace = budget * 0.1;
                totalSum = sumCash + cace;
            }
            else if (guests > 20)
            {
                double rabat = cuvert * 0.75;
                double sumCash = guests * rabat;
                double cace = budget * 0.1;
                totalSum = sumCash + cace;
            }

            double diffMoney = budget - totalSum;
            if (budget >= totalSum)
            {
                Console.WriteLine($"It is party time! {diffMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {Math.Abs(diffMoney):f2} leva needed.");
            }
        }
    }
}
