using System;

namespace _03.PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int series = int.Parse(Console.ReadLine());

            double totalIncome = 0;

            if (size == "Large")
            {
                if (color == "Red")
                {
                    totalIncome = series * 16.0;
                }
                else if (color == "Green")
                {
                    totalIncome = series * 12.0;
                }
                else if (color == "Yellow")
                {
                    totalIncome = series * 9.0;
                }
            }
            else if (size == "Medium")
            {
                if (color == "Red")
                {
                    totalIncome = series * 13.0;
                }
                else if (color == "Green")
                {
                    totalIncome = series * 9.0;
                }
                else if (color == "Yellow")
                {
                    totalIncome = series * 7.0;
                }
            }
            else if (size == "Small")
            {
                if (color == "Red")
                {
                    totalIncome = series * 9.0;
                }
                else if (color == "Green")
                {
                    totalIncome = series * 9.0;
                }
                else if (color == "Yellow")
                {
                    totalIncome = series * 5.0;
                }
            }

            double netIncome = totalIncome * 0.65;

            Console.WriteLine($"{netIncome:f2} leva.");
        }
    }
}
