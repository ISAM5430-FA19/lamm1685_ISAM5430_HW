using System;
using static System.Console;
namespace B._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B.2.4");
            char ch, ch2,ch3 = 'A';
            bool vowel,vowel2,vowel3 = false;
            int vowels = 0;
            WriteLine("At least 1 vowel");
            for (ch = 'A'; ch <= 'H'; ch++)
            {
                vowel = ch == 'A' || ch == 'E';

                for (ch2 = 'A'; ch2 <= 'H'; ch2++)
                {
                    vowel2 = ch2 == 'A' || ch2 == 'E';
                    for (ch3 = 'A'; ch3 <= 'H'; ch3++)
                    {
                        vowel3 = ch3 == 'A' || ch3 == 'E';
                        vowels = (vowel ? 1 : 0) + (vowel2 ? 1 : 0) + (vowel3 ? 1 : 0);
                        if (vowels>=1)
                            Write($"{ch}{ch2}{ch3} ");
                    }

                    

                }

                
            }
            WriteLine();
            WriteLine("Middle vowel");
            for (ch = 'A'; ch <= 'H'; ch++)
            {
               
                for (ch2 = 'A'; ch2 <= 'H'; ch2++)
                {
                    vowel2 = ch2 == 'A' || ch2 == 'E';
                    for (ch3 = 'A'; ch3 <= 'H'; ch3++)
                    {
                        
                        if (vowel2)
                            Write($"{ch}{ch2}{ch3} ");
                    }



                }


            }
            WriteLine();
            WriteLine("At least 1 consonant, 1 vowel");
            for (ch = 'A'; ch <= 'H'; ch++)
            {
                vowel = ch == 'A' || ch == 'E';

                for (ch2 = 'A'; ch2 <= 'H'; ch2++)
                {
                    vowel2 = ch2 == 'A' || ch2 == 'E';
                    for (ch3 = 'A'; ch3 <= 'H'; ch3++)
                    {
                        vowel3 = ch3 == 'A' || ch3 == 'E';
                        vowels = (vowel ? 1 : 0) + (vowel2 ? 1 : 0) + (vowel3 ? 1 : 0);
                        if (vowels == 1 || vowels==2)
                            Write($"{ch}{ch2}{ch3} ");
                    }



                }


            }
            WriteLine();
            WriteLine("Unique letters, Middle vowel");
            for (ch = 'A'; ch <= 'H'; ch++)
            {

                for (ch2 = 'A'; ch2 <= 'H'; ch2++)
                {
                    vowel2 = ch2 == 'A' || ch2 == 'E';
                    for (ch3 = 'A'; ch3 <= 'H'; ch3++)
                    {
                        bool uniquecheck = ch != ch2 && ch2 != ch3 && ch3 != ch;
                        if (vowel2 && uniquecheck)
                            Write($"{ch}{ch2}{ch3} ");
                    }



                }


            }
        }
    }
}
