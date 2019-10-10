using System;
using static System.Console;
namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            Money pocket = new Money(5, 55);
            Money change = new Money(375);
            WriteLine($"pocket: {pocket.ToString()}");
            WriteLine($"change: {change.ToString()}");
        }
    }
}
