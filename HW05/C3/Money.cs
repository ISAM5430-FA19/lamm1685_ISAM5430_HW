using System;
using System.Collections.Generic;
using System.Text;

namespace C3
{
    public class Money
    {
       
        public int Dollars {set;get;}
        public int Cents { set; get; }
        public int Fullamount { set; get; }
        public void IncrementMoney() { }
        public void DecrementMoney() { }
        public Money(int dc) {
            Fullamount = dc;
        }
        public Money(int d, int c) {
            Dollars = d;
            Cents = c;
            Fullamount = d * 100 + c;
        }
        public override string ToString()
        {
            int d = Fullamount / 100;
            int q = d / 25;
            int di = q / 10;
            int n = di / 5;
            int p = Fullamount - (d + q + di + n);

            return $"{Fullamount} cents have {d} dollars, {q} quarters, {di} dimes, {n} nickels, {p} pennies ";
        }


    }
}
