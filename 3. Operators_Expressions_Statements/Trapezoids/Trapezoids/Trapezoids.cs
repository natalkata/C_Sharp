using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Trapezoids
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter h: ");
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2.0) * h;
        Console.WriteLine("The area of the trapezoid is: " + area);
    }
}

