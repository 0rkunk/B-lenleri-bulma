using System;

namespace NumberPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbersDivisibleBy(1, 20, 44);
            PrintNumbersDivisibleBy(2, 20, 44);
            PrintNumbersDivisibleBy(3, 20, 44);
            PrintNumbersDivisibleBy(4, 20, 44);
            PrintNumbersDivisibleBy(5, 20, 44);
        }

        static void PrintNumbersDivisibleBy(int divisor, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i % divisor == 0)
                {
                    Console.Write(i);
                    if (i + divisor <= end)
                        Console.Write(" - ");
                }
            }
            Console.WriteLine();
        }
    }
}