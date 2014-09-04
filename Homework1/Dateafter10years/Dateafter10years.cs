//Problem:
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class Dateafter10years
{
    static void Main()
    {
        string mybirthday = Console.ReadLine();
        var Datevaluebirthday = DateTime.Parse(mybirthday);
        var Myage = DateTime.Now - Datevaluebirthday;
        Console.WriteLine(Myage);
        var Myagein10years = DateTime.Now.AddYears(10) - Datevaluebirthday;
        Console.WriteLine(Myagein10years);
        Console.ReadLine();
    }
}

