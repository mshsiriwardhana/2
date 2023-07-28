using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
            //Lab4
            //Q1.2
        {
            Console.Write("Enter the distance in kilometers (km): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double kilometers))
            {
                ConvertValue converter = new ConvertValue();
                converter.KilometerToMeter(kilometers);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");

            }
        }
    }
}
