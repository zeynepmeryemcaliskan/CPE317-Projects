using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalPowerCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many devices?");
            int n = Convert.ToInt32(Console.ReadLine());

           
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Device{i}-Voltage: ");
                double voltage = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Device{i}-Current: ");
                double current = Convert.ToDouble(Console.ReadLine());

                double power = voltage * current;

                if (power < 100)
                {
                    Console.WriteLine($"Device {i} power = {power} -> Low");
                }
                else if (power <= 500)
                {
                    Console.WriteLine($"Device {i} power = {power} -> Meidum");
                }
                else
                {
                    Console.WriteLine($"Device {i} power = {power} -> High");
                }
            }

            
        }
    }
}
