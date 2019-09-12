using System;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C.1.1");
            for (int i = 20;i> 0; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("C.1.2");
            for (int i = 2; i < 12; i += 2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("C.1.3");
            for (int i = 10; i < 100; i++)
            {
                if (i % 10 == 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine("C.1.4");
            for (int i = 0; i < 20; i++)
            {
                if (i % 3 != 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine("C.1.5");
            for (int i = 4; i < 10; i++)
            {
                int i2 = i * i;
                Console.Write($"{i2} ");
            }
            Console.WriteLine();
            Console.WriteLine("C.1.6");
            int n = 1;
            while (n < 100)
            {
                if (n % 3 != 0 && n % 5 != 0 || (n % 3 == 0 && n % 5 == 0))
                    Console.Write($"{n} ");
                n++;
            }
            Console.WriteLine();
            Console.WriteLine("C.1.7");
            char chr='a';
            while (chr <= 'z')
            {
                Console.Write($"{chr}");
                chr++;
            }
            Console.WriteLine();

            Console.WriteLine("C.2.8");
            int x = 1;
            while (x < 100)
            {
                Console.Write($"{x} ");
                x *=2;
            }
            Console.WriteLine();
            //Console.WriteLine("C.2.9");

            Console.WriteLine("C.3.11");
            int k = 1;
            int fac = 1;
            while (fac < 1000)
            {
                int count = 1;
                fac = k;
                while (count < k)
                {
                    fac *= (k - count);
                    count++;
                }
                if (fac<1000)
                    Console.Write($"{fac} ");
                k++;
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
