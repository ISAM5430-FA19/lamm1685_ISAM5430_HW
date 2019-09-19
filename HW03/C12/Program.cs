using System;

namespace C12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C12");
            Console.Write("number= ");
            int n = int.Parse(Console.ReadLine());
            int p = 1;
            bool primecheck = true;
           for (p = 1; p < n; p++)
            {
                for (int i = 2; i < 10; i++)
                {
                    primecheck = true;
                    if (p % i == 0 && p != i)
                    {
                        primecheck = false;
                        break;
                    }
                    
                }
                if (primecheck) Console.Write($" {p} ");
            }
        }
    }
}
