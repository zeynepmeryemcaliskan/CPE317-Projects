using System;

namespace StudentGradeAnalyzerApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.Write("How many students?");
            int studentsNumbers = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i <= studentsNumbers;  i++)
            {
                Console.Write($"Enter grade for student {i}: ");
                total += Convert.ToDouble(Console.ReadLine()); 
            }

            double average = (double)total / studentsNumbers;

            Console.WriteLine("Total = {total}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
