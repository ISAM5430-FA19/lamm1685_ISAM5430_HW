using System;

namespace B6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B6");
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int countset = 0;
            int min = n;
            while (n>0)
            {
                Console.Write($" {n} ");
                if (min > n) min = n;
                else if (n >= min * min)
                {
                    Console.Write("|");
                    countset++;
                    Console.WriteLine();
                    Console.Write("n= ");
                    n = int.Parse(Console.ReadLine());
                    min = n;
                    continue;
                }
                Console.WriteLine();
                Console.Write("n= ");
                n = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine(" 0");
            Console.WriteLine($"countset = {countset}");
           
        }
    }
}
