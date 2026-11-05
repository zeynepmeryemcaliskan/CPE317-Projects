using System;

namespace Week02Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("GPA: ");
            double gpa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hello {0}, your age is {1}", name, age);
            Console.WriteLine($"GPA: {gpa}");
            Console.WriteLine("Sum: " + (age + gpa));

            Console.WriteLine("Line1\nLine2\tTabbed");
            Console.WriteLine("Quote: \"hello\"  Backslash: \\");

            char letter = 'A';
            char unicode = '\u0041';
            Console.WriteLine(letter);
            Console.WriteLine(unicode);
            Console.WriteLine((int)letter);

            {
                int inner = 10;
                Console.WriteLine(inner);
            }
        }
    }
}