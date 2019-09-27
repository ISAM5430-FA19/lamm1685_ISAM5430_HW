using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B");
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int digit = n % 10;
            int stop = n / 10;
            int sum = 0;
            int sum2 = 0;
            int count = 0;
            if (count%2==0) sum += digit;
            bool check = true;
            
            while (stop > 0)
            {
                count++;
                digit = stop % 10;
                if (count % 2 == 0) sum += digit;
                else sum2 += digit;
                stop /= 10;
               
            }
            Console.WriteLine($"Sum of all odd digits is {sum2}");
            Console.WriteLine($"Sum of all even digits is {sum}");
            int dif = sum-sum2;
            Console.WriteLine($"Dif of all digits is {dif}");
            if (dif % 11 != 0) check = false;
            Console.WriteLine($"Dif%11? {check}");
        }
    }
}
