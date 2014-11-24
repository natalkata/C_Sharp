using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ThirdDigitIs7
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer number: ");
        int num = int.Parse(Console.ReadLine());
        int devidedByHundred = num / 100;
        bool isSeven = (devidedByHundred % 10) == 7;
        Console.WriteLine("Is the third digit 7? --> " + isSeven);
    }
}

