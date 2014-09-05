//A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. Note that you may need to learn how to parse dates and times. Examples:
//time	    result
//1:00 PM	beer time
//4:30 PM	beer time
//10:57 PM	beer time
//8:30 AM	non-beer time
//02:59 AM	beer time
//03:00 AM	non-beer time
//03:26 AM	non-beer time


using System;

class BeerTime
{
    static void Main()
    {
        start:
        Console.Write("Please enter the time in the following format hh:mm tt (eg. 8:30 AM): ");
        string stringchars = Console.ReadLine();
        int stringcharslength = stringchars.Length;
        
        //checking for correct input
        if (!stringchars.Contains(":"))
        {
            Console.WriteLine("invalid time");
            goto outer;
        }

        if ((stringchars[1] != ':' && stringchars[2] != ':'))
        {
            Console.WriteLine("invalid time");
            goto outer;
        }

        //hours
        int hoursposition = stringchars.IndexOf(":");
        string inputhourssss = stringchars.Substring(0, hoursposition);
        int hours = int.Parse(inputhourssss);
        if (hours < 1 || hours > 12)
        {
            Console.WriteLine("Wrong time!");
            goto outer;
        }

        //minutes
        string inputminutesss = stringchars.Substring(hoursposition + 1, 2);
        int minutes = int.Parse(inputminutesss);
        if (minutes < 0 || minutes > 59)
        {
            Console.WriteLine("Wrong time!");
            goto outer;
        }
        //AM or PM
        string inputtimeofday = stringchars.Substring(hoursposition + 4, 2);
        if (inputtimeofday != "AM" && inputtimeofday != "PM")
        {
            Console.WriteLine("Wrong time! (Use capital letters.)");
            goto outer;
        }
        int am;

        //check
        if (inputtimeofday == "PM")
        {
            am = 0;
        }
        else am = 1;

        switch (am)
        {
            case 0:
                if (hours >= 1)
                {
                    Console.WriteLine("beer time");
                }
                else Console.WriteLine("non-beer time");
                break;

            case 1:
                if ((hours < 3 && minutes <= 59) || (hours == 12 && minutes <= 59))
                {
                    Console.WriteLine("beer time");
                }
                else Console.WriteLine("non-beer time");
                break;
            default:
                break;
        }

    outer:
        Console.ReadLine();
    goto start;
    }
}
