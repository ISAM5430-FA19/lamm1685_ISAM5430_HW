using System;

namespace HW03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B1");
            Console.Write("Enter a score: ");
            string s = Console.ReadLine();
            if (s != null)
            {
                int n = Convert.ToInt32(s);
                int best = n;
                int sum = 0;
                int count = 0;
                while (n >= 0 && n <= 100)
                {
                    count++;
                    sum += n;
                    if (best < n) best = n;
                    Console.Write("Enter a score: ");
                    n = int.Parse(Console.ReadLine());
                  
                }
                double avg = sum / count;
                Console.WriteLine($"Best score is {best}");
                Console.WriteLine($"Average is {avg}");
            }
            else
                Console.WriteLine("No value entered");

            
            }
            

        }
    }
}
