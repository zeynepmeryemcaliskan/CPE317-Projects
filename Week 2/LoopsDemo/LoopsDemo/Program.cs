using System;

namespace LoopsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine(j);
                j++;
            }

            int k = 10;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k <= 5);

            for (int i = 0; i < 10; i++)
            {
                if (i == 4) { break; }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4) { continue; }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 2; i++)
            {
                for (int m = 0; m < 2; m++)
                {
                    Console.WriteLine($"{i} {m}");
                }
            }

            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            while (age < 0)
            {
                Console.Write("Enter a valid age: ");
                age = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Age accepted: {age}");

            Console.Write("How many numbers? ");
            int n = Convert.ToInt32(Console.ReadLine());

            double total = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter number {i}: ");
                double number = Convert.ToDouble(Console.ReadLine());
                total += number;
            }

            double average = total / n;
            Console.WriteLine($"Total = {total}");
            Console.WriteLine($"Average = {average}");
        }
    }
}