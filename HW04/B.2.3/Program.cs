using System;
using static System.Console;
namespace B._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B.2.3.a");

            char ch, ch2 = 'A';
            bool vowel = false;
            bool vowel2 = false;
            WriteLine("at least 1 vowel");
            for (ch = 'A'; ch <= 'H'; ch++)
            {
                if (ch == 'A' || ch == 'E') vowel = true;
             
                for (ch2 = 'A'; ch2 <= 'H'; ch2++)
                {
                    
                    if (ch=='A' || ch=='E' || ch2=='A' || ch2 == 'E')
                    {
                        Write($"{ch}{ch2} ");
                    }
                   
                    
                }
            }
            WriteLine();
            WriteLine("1 consonant, 1 vowel");
            for (ch = 'A'; ch <= 'H'; ch++)
            {
                if (ch == 'A' || ch == 'E') vowel = true;

                for (ch2 = 'A'; ch2 <= 'H'; ch2++)
                {
                    if (ch2 == 'A' || ch2 == 'E') vowel2 = true;
                    if ((vowel == false && vowel2 == true) || (vowel == true && vowel2 == false))
                    {
                        Write($"{ch}{ch2} ");
                        
                    }
                    vowel2 = false;
                }
                vowel = false;
            }
            WriteLine();
            WriteLine("Begin Consonant, End Vowel");
            for (ch = 'A'; ch <= 'H'; ch++)
            {
                if (ch != 'A' && ch != 'E')
                {

                    for (ch2 = 'A'; ch2 <= 'H'; ch2++)
                    {
                        if (ch2 == 'A' || ch2 == 'E') 
                        
                        {
                            Write($"{ch}{ch2} ");

                        }
                        
                    }
                   
                }
            }




        }
    }
}
