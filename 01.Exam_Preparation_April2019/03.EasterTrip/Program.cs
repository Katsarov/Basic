using System;

namespace _03.EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double totalSum = 0;

            if (country == "France")
            {
                switch (dates)
                {
                    case "21-23": totalSum = nights * 30.0; break;

                    case "24-27": totalSum = nights * 35.0; break;

                    case "28-31": totalSum = nights * 40.0; break;
                }
            }
            else if (country == "Italy")
            {
                switch (dates)
                {
                    case "21-23": totalSum = nights * 28.0; break;

                    case "24-27": totalSum = nights * 32.0; break;

                    case "28-31": totalSum = nights * 39.0; break;
                }
            }
            else if (country == "Germany")
            {
                switch (dates)
                {
                    case "21-23": totalSum = nights * 32.0; break;

                    case "24-27": totalSum = nights * 37.0; break;

                    case "28-31": totalSum = nights * 43.0; break;
                }
            }

            Console.WriteLine($"Easter trip to {country} : {totalSum:f2} leva.");
        }
    }
}
