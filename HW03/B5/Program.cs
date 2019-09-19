using System;

namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B5");
            Console.Write("item = ");
            int item = int.Parse(Console.ReadLine());
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int d = 0;
            int nclose = n;
            

            if (n == item)
            {
                Console.WriteLine("Matched X");
            }
            else if (n < item) d = item - n;
            else d = n - item;
            int dmin = d;
            while (n != item)
            {
                if (n > item) d = n - item;
                else d = item - d;
                if (dmin > d)
                {
                    dmin = d;
                    nclose = n;
                }
                Console.WriteLine($"nclose = {nclose} dmin = {dmin}");
                Console.Write("n = ");
                n = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
