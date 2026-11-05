using System;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primes = new int[9];

            int[] prime = new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19 };

            for (int i = 0; i < prime.Length; i++)
            {
                primes[i] = prime[i];
            }

            Console.WriteLine("--- prime dizisi (foreach) ---");
            foreach (int p in prime)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("--- Length ---");
            Console.WriteLine(prime.Length);
            Console.WriteLine(prime[0]);
            Console.WriteLine(prime[prime.Length - 1]);

            Console.WriteLine("--- Bildirim bicimleri ---");
            double[] balance = { 2340.0, 4523.69, 3421.0 };
            int[] marks = new int[5] { 99, 98, 92, 97, 95 };
            int[] notes = new int[] { 70, 80, 90 };

            balance[0] = 4500.0;
            Console.WriteLine(balance[0]);
            Console.WriteLine(marks[2]);
            Console.WriteLine(notes[1]);

            Console.WriteLine("--- Ayni bellek konumu ---");
            int[] score = marks;
            score[0] = 1;
            Console.WriteLine(marks[0]);

            Console.WriteLine("--- Multidimensional ---");
            int[,] grid = new int[3, 3];
            grid[1, 2] = 7;
            Console.WriteLine(grid[1, 2]);
            Console.WriteLine(grid[0, 0]);

            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(matrix[1, 0]);

            Console.WriteLine("--- Jagged ---");
            int[][] jaggedArray = new int[5][];
            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[5];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 3, 5, 7 };
            jaggedArray[1] = new int[] { 1, 0, 2, 4, 6 };

            Console.WriteLine(jaggedArray[0][2]);
            Console.WriteLine(jaggedArray[1][4]);
            Console.WriteLine(jaggedArray[2][0]);
        }
    }
}