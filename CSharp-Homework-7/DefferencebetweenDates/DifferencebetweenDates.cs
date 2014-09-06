//Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. Examples:
//First date
//Second date	Days between
//17.03.2014
//30.04.2014	44
//17.03.2014
//17.03.2014	0
//14.06.1980
//5.03.2014	    12317
//5.03.2014
//3.03.2014	    -2


using System;
using System.Collections.Generic;

class DifferencebetweenDates
{
    static void Main()
    {
    start:
        //input
        Console.Write("Please enter the first date: ");
        string startdate = Console.ReadLine();
        Console.Write("Please enter the end date: ");
        string enddate = Console.ReadLine();
        
        //parse
        DateTime a = DateTime.Parse(startdate);
        DateTime b = DateTime.Parse(enddate);
        
        //substraction
        TimeSpan substraction = (b - a);

        //to string
        string substractiontostring = substraction.ToString();
        if (substractiontostring == "00:00:00")
        {
            Console.WriteLine("0");
            goto start;
        }
        string toprint = substractiontostring.Substring(0, substractiontostring.IndexOf('.'));
        Console.WriteLine(toprint);
        
        //restart
        goto start;
    }
}
