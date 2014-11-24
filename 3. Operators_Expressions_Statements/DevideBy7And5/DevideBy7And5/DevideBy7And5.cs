using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class DevideBy7And5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer number: ");
        int num = int.Parse(Console.ReadLine());
        bool devidedBy7And5 = (num % 7 == 0) && (num % 5 == 0);
        Console.WriteLine(num + " devided by 7 and 5? -->" + devidedBy7And5);
    }
}

