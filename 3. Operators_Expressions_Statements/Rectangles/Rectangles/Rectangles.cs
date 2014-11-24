using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Rectangles
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the rectangles width: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the rectangles height: ");
        double b = double.Parse(Console.ReadLine());
        double perimeter = 2 * (a + b);
        double area = a * b;
        Console.WriteLine("The perimeter is " + perimeter);
        Console.WriteLine("The area is " + area);
    }
}

