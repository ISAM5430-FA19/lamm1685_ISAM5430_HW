using System;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B2");
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int p = 0;
            int index = 0;
            while (index==0 || p != n)
            {
                p = n;
                sum += p;
                Console.Write("Enter a number: ");
                n = int.Parse(Console.ReadLine());
                index++;
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
