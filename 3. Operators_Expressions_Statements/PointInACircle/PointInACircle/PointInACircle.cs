using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class PointInACircle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y:");
        double y = double.Parse(Console.ReadLine());
        bool insideCircle = (x * x + y * y) <= 2 * 2;
        Console.WriteLine("The point is inside the circle: " + insideCircle);
    }
}

