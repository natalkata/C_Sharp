using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class GravitationOntheMoon
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your weight: ");
        double weight = double.Parse(Console.ReadLine());
        double weightOnTheMoon = weight * 0.17;
        Console.WriteLine("Your weight on the Moon will be " + weightOnTheMoon);
    }
}

