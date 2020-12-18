using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M=cos^2y+3,6e^x");
            Random rand = new Random();
            int x = rand.Next(0, 99);
            int y = rand.Next(0, 99);
            double e = 2.71;
            Console.WriteLine($"x={x}");
            Console.WriteLine($"y={y}");
            double result = Math.Cos(2*y);
            double result2 = Math.Pow(2.71, x);
            double M = result + 3.6 * result2;
            Console.WriteLine($"M={M}");
            Console.ReadLine();
        }
    }
}
