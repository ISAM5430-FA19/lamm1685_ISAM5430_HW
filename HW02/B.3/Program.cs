using System;

namespace B._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter GPA (0-4): ");
            decimal gpa = decimal.Parse(Console.ReadLine());
            int gpa3 = (int)(3 * gpa + 0.5m);
            string lgrade;
            if (gpa <= 4 && gpa >= 0)
            {
                if (gpa3 >= 11)
                {
                    lgrade = "A";

                }
                else if (gpa3 >= 8)
                {
                    lgrade = "B";
                }
                else if (gpa3 >= 5)
                {
                    lgrade = "C";
                }
                else if (gpa3 >= 3)
                {
                    lgrade = "D";
                }
                else lgrade = "F";
                if (gpa3 == 11 || gpa3 == 8 || gpa3 == 5) lgrade += "-";
                if (gpa3 == 7 || gpa3 == 10 || gpa3 == 4) lgrade += "+";
                Console.WriteLine($"Your letter grade is {lgrade}");
            }
            else Console.WriteLine("Invalid GPA");
            
        }
    }
}
