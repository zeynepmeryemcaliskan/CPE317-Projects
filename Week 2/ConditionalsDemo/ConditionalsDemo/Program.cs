using System;

namespace ConditionalsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("AA");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("BA");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("BB");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("CC");
            }
            else
            {
                Console.WriteLine("FF");
            }

            string status = (grade >= 60) ? "Passed" : "Failed";
            Console.WriteLine(status);

            if (grade >= 60)
            {
                if (grade >= 90)
                {
                    Console.WriteLine("Excellent");
                }
                else
                {
                    Console.WriteLine("Good");
                }
            }

            Console.Write("Enter day number (1-7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Weekday");
                    break;
            }
        }
    }
}