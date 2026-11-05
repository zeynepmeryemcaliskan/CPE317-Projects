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
        public void ShowAverage()
        {
            double average = (midterm * 0.4) + (final * 0.6);
            Console.WriteLine($"{name} average: {average:F2}");
        }
    }
    internal class Program
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

            a.ShowAverage();
            b.ShowAverage();
        }
    }
}
