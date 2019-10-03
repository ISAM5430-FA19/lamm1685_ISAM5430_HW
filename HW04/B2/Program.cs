using System;
using static System.Console;
namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B2 Combination");
            int i, j, k,z,y = 0;
            int sumc = 0;
            Write("Enter number in a combination set");
            int count = int.Parse(ReadLine());
            for (i = 1; i <= 5; i++)
            {
                if (count == 1)
                {
                    Write(i + "; ");
                    sumc += i;
                }
                else if (count == 2)
                {
                    for (j = i + 1; j <= 5; j++)
                    {
                        Write(i + ", " + j + "; ");
                        sumc += i * j;
                    }
                }
                else if (count == 3)
                {
                    for (j = i + 1; j <= 5; j++)
                    {
                        for (k = j + 1; k <= 5; k++)
                        {
                            Write(i + ", " + j + "; ");
                            sumc += i * j * k;
                        }
                    }


                }
                else if (count == 4)
                {
                    for (j = i + 1; j <= 5; j++)
                    {
                        for (k = j + 1; k <= 5; k++)
                        {
                            for (z = k + 1; z <= 5; z++)
                            {
                                Write(i + ", " + j + "; ");
                                sumc += i * j * k * z;
                            }
                        }
                    }

                }
                else if (count == 5)
                {
                    for (j = i + 1; j <= 5; j++)
                    {
                        for (k = j + 1; k <= 5; k++)
                        {
                            for (z = k + 1; z <= 5; z++)
                            {
                                for (y = z + 1; y <= 5; y++)
                                {
                                    Write(i + ", " + j + "; ");
                                    sumc += i * j * k * z * y;
                                }
                            }
                        }
                    }
                }
                
                
            }
            WriteLine();
            WriteLine($"Sumc= {sumc}");
        }
    }
}
