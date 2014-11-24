using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Problem3_CirclePerimeterArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the radius of the circle:");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * r * r;
        Console.WriteLine("The perimeter is {0:F2} ", perimeter);
        Console.WriteLine("The area is {0:F2} ", area);

    }
}

