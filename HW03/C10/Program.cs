using System;

namespace C10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" C10");
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            for (i = 0; i < n; i++)
            {   Console.Write('X');
                for (int j = 1; j < n+1; j++)
                {
                    Console.Write('X');
                }
                Console.WriteLine();

            }
        }
    }
}
