using System;

namespace HW04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A");
            Console.Write("Enter a number: ");
            int n=int.Parse(Console.ReadLine());
            int digit = n%10;
            int stop = n / 10;
            int sum=0;
            sum += digit;
            bool check = true;
            while (stop > 0)
            {
                digit = stop % 10;
                if (digit < 1) sum += stop;
                else sum += digit;
                stop /= 10;
            }
            Console.WriteLine($"Sum of all digits is {sum}");
            if (sum % 3 != 0) check = false;
            Console.WriteLine($"Sum%3? {check}");
        }
    }
}
