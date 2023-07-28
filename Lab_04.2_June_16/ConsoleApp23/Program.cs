using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab 4
            //Q2
            Console.Write("Enter the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine("area: " + area);
            Console.WriteLine("circumference: " + circumference);

            Console.ReadKey();


        }
    }
}
