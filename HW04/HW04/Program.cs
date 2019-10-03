using System;
using static System.Console;
namespace HW04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B1 Permutation");
            int i,j,k = 0;
            int sump = 0;
            Write("Enter number of each permutation set: ");
            int count = int.Parse(ReadLine());
            for (i = 1; i <= 5; i++)
            {
                if (count==1)
                {
                    Write(i + "; ");
                    sump += i;
                }
                else if (count== 2)
                {
                    for (j = 1; j <= 5; j++)
                    {
                        if (j != i)
                        {
                            Write(i + ", " + j +"; ");
                            sump += j * i;
                        }
                        
                    }
                   

                }
                
                else if (count == 3)
                {
                    for (j = 1; j <= 5; j++)
                    {
                        if (j != i)
                        {
                            for (k = 1; k <= 5; k++)
                            {
                                if (k!=j && k!=i)
                                {
                                    Write(i + ", " + j + ", "+k+"; ");
                                    sump += i * j * k;
                                }
                            }
                        }

                    }
                    
                }
                


            }
            WriteLine();
            WriteLine($"sump= {sump}");

        }
    }
}
