using System;

namespace Test_ForLoop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > maxNum)
                {
                    maxNum = number;
                }
                else
                {
                    sum += number;
                }
            }

            if (maxNum == sum)
            {
                Console.WriteLine($"Yes, sum = {maxNum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(maxNum - sum)}");
            }
        }
    }
}
