using System;

namespace Test_ForLoop_2_Trainer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double evenSum = 0;
            double evenMaxNum = double.MinValue;
            double evenMinNum = double.MaxValue;

            double oddSum = 0;
            double oddMaxNum = double.MinValue;
            double oddMinNum = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine()); // прочитаме първото число
                if (i % 2 == 0)
                {
                    evenSum += num;

                    if (num > evenMaxNum)
                    {
                        evenMaxNum = num;
                    }

                    if (num < evenMinNum)
                    {
                        evenMinNum = num;
                    }
                }
                else
                {
                    oddSum += num;

                    if (num > oddMaxNum)
                    {
                        oddMaxNum = num;
                    }

                    if (num < oddMinNum)
                    {
                        oddMinNum = num;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},"); // отпечатваме сумата

            if (oddMinNum != double.MaxValue)  // ако oddMinNum е различно от дефолтната стойност double.MaxValue 
            {
                Console.WriteLine($"OddMin={oddMinNum:f2},");  // отпечатваме минималната стойност
            }
            else  // ако обаче oddMinNum е равна дефолтната стойност double.MaxValue (т.е. нямаме друго число)
            {
                Console.WriteLine($"OddMin=No,");  // отпечатваме No
            }

            if (oddMaxNum != double.MinValue)
            {
                Console.WriteLine($"OddMax={oddMaxNum:f2},");
            }
            else
            {
                Console.WriteLine($"OddMax=No,");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");

            if (evenMinNum != double.MaxValue)
            {
                Console.WriteLine($"EvenMin={evenMinNum:f2},");
            }
            else
            {
                Console.WriteLine($"EvenMin=No,");
            }
            if (evenMaxNum != double.MinValue)
            {
                Console.WriteLine($"EvenMax={evenMaxNum:f2}");
            }
            else
            {
                Console.WriteLine($"EvenMax=No");
            }
            

        }
    }
}
