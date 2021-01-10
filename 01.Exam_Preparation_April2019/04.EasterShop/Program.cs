using System;

namespace _04.EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int availableEggs = int.Parse(Console.ReadLine());

            int counterSoldEggs = 0;

            string command = Console.ReadLine();

            while (command != "Close")
            {
                if (command == "Fill")
                {
                    int toFill = int.Parse(Console.ReadLine());
                    availableEggs += toFill;
                }

                if (command == "Buy")
                {
                    int toBuy = int.Parse(Console.ReadLine());
                    if (toBuy <= availableEggs)
                    {
                        availableEggs -= toBuy;
                        counterSoldEggs += toBuy;
                    }
                    else
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {availableEggs}.");
                        break;
                    }
                }

                command = Console.ReadLine();
            }

            if (command == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{counterSoldEggs} eggs sold");
            }
        }
    }
}
