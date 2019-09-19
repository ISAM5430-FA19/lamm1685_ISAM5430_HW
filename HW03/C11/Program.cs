using System;

namespace C11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C11");
            int n = 9;
            for (int i = 1; i < n+1; i++)
            {
                for (int j = 1; j < n+1; j++)
                {
                    int mul = i * j;
                    Console.Write($" {mul} ");
                }
                Console.WriteLine();
            }
        }
    }
}
