//Write a program that finds the biggest of five numbers by using only five if statements. Examples:
//a	        b	        c	        d	        e	        biggest
//5	        2	        2	        4	        1	        5
//-2	    -22	        1	        0	        0	        1
//-2	    4	        3	        2	        0	        4
//0	        -2.5	    0	        5	        5	        5
//-3	    -0.5	    -1.1	    -2	        -0.1	    -0.1


using System;

class TheBiggestofFiveNumbers
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Please enter the fourth number: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Please enter the fifth number: ");
        double e = double.Parse(Console.ReadLine());

        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine(a);
            goto outer;
        }
        if (b >= a && b >= c && b >= d && b >= e)
        {
            Console.WriteLine(b);
            goto outer;
        }
        if (c >= a && c >= b && c >= d && c >= e)
        {
            Console.WriteLine(c);
            goto outer;
        }
        if (d >= a && d >= b && d >= c && d >= e)
        {
            Console.WriteLine(d);
            goto outer;
        }
        if (e >= a && e >= b && e >= c && e >= d)
        {
            Console.WriteLine(e);
            goto outer;
        }

    outer:
        Console.ReadLine();

    }
}

