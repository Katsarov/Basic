using System;

namespace _05.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintedEggs = int.Parse(Console.ReadLine());

            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
         
            int maxEggsOneColor = int.MinValue;
            string maxEggs = "";

            for (int i = 0; i < paintedEggs; i++)
            {
                string colorEgg = Console.ReadLine();
                if (colorEgg == "red")
                {
                    redEggs++;
                }
                else if (colorEgg == "orange")
                {
                    orangeEggs++; ;
                }
                else if (colorEgg == "blue")
                {
                    blueEggs++;
                }
                else if (colorEgg == "green")
                {
                    greenEggs++;
                }
            }
            if (redEggs > maxEggsOneColor)
            {
                maxEggsOneColor = redEggs;
                maxEggs = "red";
            }
            if (orangeEggs > maxEggsOneColor)
            {
                maxEggsOneColor = orangeEggs;
                maxEggs = "orange";
            }
            if (blueEggs > maxEggsOneColor)
            {
                maxEggsOneColor = blueEggs;
                maxEggs = "blue";
            }
            if (greenEggs > maxEggsOneColor)
            {
                maxEggsOneColor = greenEggs;
                maxEggs = "green";
            }

            Console.WriteLine($"Red eggs:{redEggs}");
            Console.WriteLine($"Orange eggs:{orangeEggs}");
            Console.WriteLine($"Blue eggs:{blueEggs}");
            Console.WriteLine($"Green eggs:{greenEggs}");
            Console.WriteLine($"Max eggs:{maxEggsOneColor} -> {maxEggs}");
        }
    }
}
