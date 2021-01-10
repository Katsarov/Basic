using System;

namespace Test_ForLoop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double maxNumEven = double.MinValue;
            double minNumEven = double.MaxValue;
            double sumEven = 0;

            double maxNumOdd = double.MinValue;
            double minNumOdd = double.MaxValue;
            double sumOdd = 0;

            for (int i = 1; i <= n; i++)
            {


                if (i % 2 == 0)
                {
                    double number = double.Parse(Console.ReadLine());
                    sumEven += number;
                    if (number > maxNumEven)
                    {
                        maxNumEven = number;
                    }
                    if (number < minNumEven)
                    {
                        minNumEven = number;
                    }

                }

                else if (i % 2 != 0)
                {
                    double number = double.Parse(Console.ReadLine());
                    sumOdd += number;
                    if (number > maxNumOdd)
                    {
                        maxNumOdd = number;
                    }
                    if(number < minNumOdd)
                    {
                        minNumOdd = number;
                    }
                }
            }

            Console.WriteLine($"OddSum={sumOdd:f2},");
            if (minNumOdd == double.MaxValue)
            {
                Console.WriteLine($"OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={minNumOdd:f2},");
            }



            if (n == 1)
            {
                Console.WriteLine($"OddSum={n:f2},");
                Console.WriteLine($"OddMin={n:f2},");
                Console.WriteLine($"OddMax={n:f2},");
                Console.WriteLine($"EvenSum={0:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else if (n == 0)
            {
                Console.WriteLine($"OddSum={n:f2},");
                
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={0:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            
            
            Console.WriteLine($"OddMax={maxNumOdd:f2},");
            Console.WriteLine($"EvenSum={sumEven:f2},");
            Console.WriteLine($"EvenMin={minNumEven:f2},");
            Console.WriteLine($"EvenMax={maxNumEven:f2}");
        }
    }
}

