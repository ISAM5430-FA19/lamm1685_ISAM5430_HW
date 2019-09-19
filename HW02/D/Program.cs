using System;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count: ");
            int count = int.Parse(Console.ReadLine());
            int i = 0;
            bool asc = true;
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum0 = 0;
            int evenint = 0;
            while (i < count)
            {
                Console.Write("Enter a number: ");
                int n = int.Parse(Console.ReadLine());
                i++;
                int prev=0;
                if (n == 0) sum0 += 1;
                if (n % 2 == 0) evenint += 1;

                if (n > prev && asc)
                {
                    prev = n;
                }
                else asc = false;

                if (n < min) min = n;
                if (n > max) max = n;
                

            }
            if (asc)
                Console.WriteLine($"The numbers are in increasing order");
            else Console.WriteLine($"The numbers are not in increasing order");
            Console.WriteLine($"Max is {max:N0}");
            Console.WriteLine($"Min is {min:N0}");
            Console.WriteLine($"Total 0 in the series is {sum0}");
            Console.WriteLine($"Total even int in the series is {evenint}");

        }
    }
}
