using System;

namespace EnumDemo
{
    enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday,
        Friday, Saturday, Sunday
    }

    enum Color : byte
    {
        Red = 1,
        Green = 2,
        Blue = 4,
        Black = 0,
        White = Red | Green | Blue
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Friday);

            int day = (int)WeekDays.Friday;
            Console.WriteLine(day);

            var wd = (WeekDays)5;
            Console.WriteLine(wd);

            WeekDays today = WeekDays.Monday;
            int num = (int)today;
            Console.WriteLine(num);

            Color c = Color.Black;
            Console.WriteLine(c);
            Console.WriteLine(Color.White);
            Console.WriteLine((int)Color.White);
        }
    }
}