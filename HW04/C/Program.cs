using System;
using static System.Console;
namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C");
            int count = 0;
            int conso = 0;
            int vowel = 0;
            int syl = 0;
            bool asc = true;
            bool vowelconso = true;
            while (true)
            {
                WriteLine();
                Write("Enter a letter: ");
                var key = ReadKey();
                char letter = char.ToUpperInvariant(key.KeyChar);
                if (!char.IsLetter(letter)) break;
                else count++;

                while (asc)
                {
                    char ll = letter;
                    WriteLine();
                    Write("Check ASC. Enter a letter: ");
                    key = ReadKey();
                    letter = char.ToUpperInvariant(key.KeyChar);
                    if (!char.IsLetter(letter)) break;
                    if (ll > letter)
                    {
                        WriteLine();
                        WriteLine("Sequence is not ascending");
                        asc = false;
                    }
                }
                while (vowelconso)
                {

                    char ll = letter;
                    bool vowelcheck0 = ll == 'A' || ll == 'E' | ll == 'U' || ll == 'I' ||
                    ll == 'O' || ll == 'Y';
                    WriteLine();
                    Write("Check vowelconso. Enter a letter: ");
                    key = ReadKey();
                    letter = char.ToUpperInvariant(key.KeyChar);
                    if (!char.IsLetter(letter)) break;
                    bool vowelcheck = letter == 'A' || letter == 'E' | letter == 'U' || letter == 'I' ||
                    letter == 'O' || letter == 'Y';
                    int voweladjc = (vowelcheck0 ? 1 : 0) + (vowelcheck ? 1 : 0);
                    if (voweladjc == 0 || voweladjc == 2)
                    {
                        WriteLine();
                        WriteLine("Vowels and Consonants do not alternate");
                        vowelconso = false;
                    }
                }

                //a syllable begins with a vowel and ends with a consonant, or it reaches the end of the word.
                bool vowelcheck2 = letter == 'A' || letter == 'E' | letter == 'U' || letter == 'I' ||
                    letter == 'O' || letter == 'Y';
                while (vowelcheck2)
                {
                    Write("Enter next letter: ");
                    key = ReadKey();
                    char letter2 = char.ToUpperInvariant(key.KeyChar);
                    if (!char.IsLetter(letter2)) break;
                    vowelcheck2 = letter2 == 'A' || letter2 == 'E' | letter2 == 'U' || letter2 == 'I' ||
                    letter2 == 'O' || letter2 == 'Y';
                    if (vowelcheck2 == false) { syl++; }

                }

            }
            WriteLine();
            WriteLine($"Number of letters:{count} ");
            WriteLine($"Number of consonants:{conso} ");
            WriteLine($"Number of vowels:{vowel} ");
            WriteLine($"Number of syllables:{syl} ");
            if (asc) WriteLine("Sequence is ascending");
            if (vowelconso) WriteLine("Vowels and Consonants do alternate");

        }
    }
}
