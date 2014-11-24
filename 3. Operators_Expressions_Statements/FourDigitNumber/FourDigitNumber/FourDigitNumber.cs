using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a four-digit number: ");
        int num = int.Parse(Console.ReadLine());
        int fourthNum = num % 10;
        int thirdNum = (num / 10) % 10;
        int secondNum = (num / 100) % 10;
        int firstNum = (num / 1000) % 10;
        int sum = firstNum + secondNum + thirdNum + fourthNum;
        string reversedOrder = fourthNum.ToString() + thirdNum.ToString() + secondNum.ToString() + firstNum.ToString();
        string lastOnFirstPos = fourthNum.ToString() + firstNum.ToString() + secondNum.ToString() + thirdNum.ToString();
        string exchangeSecondWithThird = firstNum.ToString() + thirdNum.ToString() + secondNum.ToString() + fourthNum.ToString();
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The reversed order is: " + reversedOrder);
        Console.WriteLine("Last digit in front: " + lastOnFirstPos);
        Console.WriteLine("Second and third digit exchange: " + exchangeSecondWithThird);

    }
}

