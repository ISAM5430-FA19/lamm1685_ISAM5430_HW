using System;
using static System.Console;
namespace C5
{
    public class DateC
    {
        private int date, month, year;
        private bool valid;
        public int Date { set; get; }
        public int Month { set; get; }
        public int Year { set; get; }
        public DateC(int date,int month,int year)
        {
            Date = date;
            Month = month;
            Year = year;
        }
        private bool Validity()
        {
             if (Date>0 && Month>0 && Year > 0){
                if (Month < 8 && Month % 2 == 0 || Month == 9 || Month == 11 && Date <= 30)
                {
                    if (Month == 2 && Date < 29) valid = true;
                    else if (Month!=2)
                        valid = true;
                   
                }
                if (Month < 8 && Month % 2 != 0 || Month == 10 || Month == 12 && Date <= 31) valid = true;
                

            }
            return valid;
            
        }
        public override string ToString()
        {
            if (Validity())
            {
                return $"Today is {Month}/{Date}/{Year}";
            }
            else return "Invalid date";
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateC today = new DateC(9, 10, 2019);
            WriteLine(today.ToString());
        }
    }
}
