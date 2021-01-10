using System;

namespace _04.EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsPlayerOne = int.Parse(Console.ReadLine()); 
            int eggsPlayerTwo = int.Parse(Console.ReadLine()); 
            
            string command = Console.ReadLine(); 

            while (command != "End of battle")
            {
                if (command == "one")
                {
                    eggsPlayerTwo--;
                }

                else if (command == "two")
                {
                    eggsPlayerOne--;
                }

                if (eggsPlayerOne == 0)
                { 
                    Console.WriteLine($"Player one is out of eggs. Player two has {eggsPlayerTwo} eggs left.");
                    break;
                }
                else if (eggsPlayerTwo == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {eggsPlayerOne} eggs left.");
                    break;
                }
                command = Console.ReadLine();
            }

            if (command == "End of battle")
            {
                Console.WriteLine($"Player one has {eggsPlayerOne} eggs left.");
                Console.WriteLine($"Player two has {eggsPlayerTwo} eggs left.");
            }
        }
    }
}
