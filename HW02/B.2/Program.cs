using System;

namespace B._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first integer: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter third integer: ");
            int z = int.Parse(Console.ReadLine());
            if (x > y && y < z)
                Console.WriteLine($"{y} is the middle number");
            else if (y > x && x < z)
                Console.WriteLine($"{x} is the middle number");
            else 
                Console.WriteLine($"{z} is the middle number");
        }
    }
}
