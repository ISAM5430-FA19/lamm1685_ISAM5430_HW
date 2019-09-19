using System;

namespace C14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C14");
            int N = 10;
            int i = 0;
            int j = 0;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (i = N; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (i = N; i > 0; i--)
            {
                Console.Write('*');
                for (j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
