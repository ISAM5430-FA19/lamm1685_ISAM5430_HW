using System;
using System.Collections.Generic;
using System.Text;

namespace C4
{
    public class Park
    {
        private int month = 12;
        private decimal cost, revenue;
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public int Staff { get; set; }
        public decimal Fee { get; set; }
        public decimal Budget { get; set; }
        public int Visitor { get; set; }

        public override string ToString()
        {
            return $"{Type} Park {Name} at {Location}";
        }
        public decimal Cost()
        {
            cost = (decimal)Budget / Visitor;
            return cost;
        }
        public decimal Revenue()
        {
            revenue = Fee * Visitor;
            return revenue;
        }

    }
}
