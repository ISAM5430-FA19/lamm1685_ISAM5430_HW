using System;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B3");
            Console.Write("Enter side1: ");
            int s1 = int.Parse(Console.ReadLine());
            Console.Write("Enter side2: ");
            int s2 = int.Parse(Console.ReadLine());
            Console.Write("Enter side3: ");
            int s3 = int.Parse(Console.ReadLine());
            while (s1 > 0 && s2 > 0 && s3 > 0)
            {
                if (s1 + s2 <= s3 || s1 + s3 <= s2 || s2 + s3 <= s1)
                    Console.WriteLine("Not a valid triangle");
                Console.Write("Enter side1: ");
                s1 = int.Parse(Console.ReadLine());
                Console.Write("Enter side2: ");
                s2 = int.Parse(Console.ReadLine());
                Console.Write("Enter side3: ");
                s3 = int.Parse(Console.ReadLine());
                if (!(s1 > 0 && s2 > 0 && s3 > 0))
                    Console.WriteLine("Invalid");
            }
    }
}
