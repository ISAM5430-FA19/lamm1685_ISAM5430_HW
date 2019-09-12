using System;

namespace HW02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first integer: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int y = int.Parse(Console.ReadLine());
            if (x > y)
                Console.WriteLine($"{x} is larger than {y}");
            else if (x < y)
                Console.WriteLine($"{y} is larger than {x}");
            else
                Console.WriteLine($"{x} is the same as {y}");

        }
    }
}
