using System;

namespace Week03Demo
{
    class Car
    {
        public string color = "red";     // field
        public int maxSpeed = 200;       // field

        public void FullThrottle()       // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car();
            Car opel = new Car();

            opel.color = "white";
            opel.maxSpeed = 180;

            Console.WriteLine(ford.color + " " + ford.maxSpeed);
            Console.WriteLine(opel.color + " " + opel.maxSpeed);

            ford.FullThrottle();

            Console.ReadKey();
        }
    }
}