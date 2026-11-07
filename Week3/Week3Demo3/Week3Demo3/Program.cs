using System;

namespace Week3Demo2
{
    class Program
    {
        static void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        static double CalculateArea(double side)
        {
            return side * side;
        }

        static bool IsPassed(double grade)
        {
            return grade >= 60;
        }

        static int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return Factorial(num - 1) * num;
            }
        }

        static void Main(string[] args)
        {
            Greet("Ahmed");

            double area = CalculateArea(10, 5);
            double square = CalculateArea(4);
            Console.WriteLine($"{area} and {square}");

            if (IsPassed(75))
            {
                Console.WriteLine("Pass");
            }

            Console.WriteLine($"6! = {Factorial(6)}");

            Console.ReadKey();
        }
    }
}