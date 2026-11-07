using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Demo2
{
    class Student
    {
        public string name;
        public double midterm;
        public double final;
        
        public double CalculateAverage()
        {
            return (midterm * 0.4 + final * 0.6);
        }

        public string GetLetterGrade()
        {
            double average = CalculateAverage();

            if(average >= 90)
            {
                return "A";
            }
            else if(average >= 80)
            {
                return "B";
            }
            else if(average >= 70)
            {
                return "C";
            }
            else if(average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        public void Describe()
        {
            Console.WriteLine($"{name} - average: {CalculateAverage():F2} - grade: {GetLetterGrade()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            Student b = new Student();

            a.name = "Marilyn";
            a.midterm = 85;
            a.final = 74;

            b.name = "Kerim";
            b.midterm = 80;
            b.final = 65;

            a.Describe();
            b.Describe();

            Console.ReadKey();
        }
    }
}
