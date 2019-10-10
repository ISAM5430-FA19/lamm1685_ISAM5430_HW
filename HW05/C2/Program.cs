using System;
using static System.Console;

namespace C2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //string name, string type, string direction, string surface, int lane, string party, bool toll
            Motorway nasa = new Motorway("Nasa", "Parkway", "E", "concrete", 6, "Harris County", false);
            WriteLine(nasa.Tostring());

        }
    }
}
