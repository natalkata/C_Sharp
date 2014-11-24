using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Problem2_PrintCompanyInfo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Company address:");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Phone number:");
        string phoneNum = Console.ReadLine();
        Console.WriteLine("Fax number:");
        string faxNum = Console.ReadLine();
        Console.WriteLine("Web site:");
        string webSite = Console.ReadLine();
        Console.WriteLine("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Manager last name:");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Manager age:");
        int managerAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Manager phone:");
        string managerPhone = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel. " + phoneNum);
        Console.WriteLine("Fax: " + faxNum);
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + "(age: {0}, Tel. {1})", managerAge, managerPhone);
    }
}

