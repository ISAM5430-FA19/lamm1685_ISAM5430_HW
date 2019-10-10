using System;
using static System.Console;
namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            Park bayou = new Park();
            Write("Name of Park: ");
            bayou.Name = ReadLine();
            WriteLine();
            Write("Type of Park: ");
            bayou.Type = ReadLine();
            WriteLine();
            Write("Location of Park: ");
            bayou.Location = ReadLine();
            WriteLine();
            Write("Number of employees: ");
            bayou.Staff = int.Parse(ReadLine());
            WriteLine();
            Write("Number of visitors: ");
            bayou.Visitor = int.Parse(ReadLine());
            WriteLine();
            Write("Fee per visitor: ");
            bayou.Fee = decimal.Parse(ReadLine());
            WriteLine();
            Write("Annual Budget: ");
            bayou.Budget = decimal.Parse(ReadLine());
            WriteLine();
            
            WriteLine(bayou.ToString());
            WriteLine($"Park's Cost per visitor: ${bayou.Cost():f2}");
            WriteLine($"Park's Revenue: ${bayou.Revenue():f2}");

        }
    }
}
