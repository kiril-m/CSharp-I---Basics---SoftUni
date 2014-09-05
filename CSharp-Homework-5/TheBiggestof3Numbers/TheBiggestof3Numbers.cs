//Write a program that finds the biggest of three numbers. Examples:
//a	        b	    c	    biggest
//5	        2	    2	    5
//-2	    -2	    1	    1
//-2	    4	    3	    4
//0	        -2.5	5	    5
//-0.1	    -0.5	-1.1	-0.1


using System;

class TheBiggestof3Numbers
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double c = double.Parse(Console.ReadLine());


        if ((a >= b && a > c) | (a > b && a >= c)|(a==b && b==c)) 
        {
            Console.WriteLine("The biggest number is {0}.",a);
            goto outer;
        }
        if ((b >= a && b > c) | (b > a && b >= c))
        {
            Console.WriteLine("The biggest number is {0}.", b);
            goto outer;
        }
        if ((c >= a && c > b)| (c > a && c >= b))
        {
            Console.WriteLine("The biggest number is {0}.", c);
            goto outer;
        }
        outer:  
        Console.ReadLine();
    }
}

