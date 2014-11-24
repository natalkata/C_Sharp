using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Problem6_QuadraticEquation
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double D = (b * b) - (4 * a * c);
        if (D < 0)
        {
            Console.WriteLine("{0} < 0 --> no solution", D);
        }
        else if (D == 0)
        {
            Console.WriteLine("One solution --> x = {0}", (-b / (2 * a)));
        }
        else
        {
            Console.WriteLine("First solution --> x1 = {0}", ((-b - Math.Sqrt(D)) / (2 * a)));
            Console.WriteLine("Second solution --> x2 = {0}", ((-b + Math.Sqrt(D)) / (2 * a)));
        }

    }
}

