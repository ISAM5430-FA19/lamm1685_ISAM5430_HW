using System;
using System.Collections.Generic;
using System.Text;

namespace C2
{
    public class Motorway
    {
        
        public string Name { get; set; }
        public string Type { get; set; }
        public string Direction { get; set; }
        public string Surface { get; set; }
        public int Lane { get; set; }
        public string Party { get; set; }
        public bool Toll { get; set; }
        public Motorway(string name, string type, string direction, string surface, int lane, string party, bool toll)
        {
            Name = name;
            Type = type;
            Direction = direction;
            Surface = surface;
            Lane = lane;
            Party = party;
            Toll = toll;
        }
        public string Tostring()
        {

            return $"{Name} {Type} {Direction} has {Lane} lanes and made out of {Surface}.\n " +
                $"It is {(Toll?"a toll":"not a toll")} way\n" +
                $"{Party} maintains it.\n";
        }
    }
}
