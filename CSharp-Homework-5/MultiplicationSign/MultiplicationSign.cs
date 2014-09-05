//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators. Examples:
//a	    b	    c	    result
//5	    2	    2	    +
//-2	-2	    1	    +
//-2	4	    3	    -
//0	    -2.5	4	    0
//-1	-0.5	-5.1	-


using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double c = double.Parse(Console.ReadLine());
        if (a==0 || b == 0 || c==0)
        {
            Console.WriteLine("0");
            goto outer;
        }
        if ((a>0 & b>0 &c<0)|(a>0 & c>0&b<0)|(b>0 & c>0&a<0)|(a<0 & b<0 & c<0))
        {
            Console.WriteLine("The sign of the multiplication of those three numbers is a \"-\".");
        }
        else Console.WriteLine("The sign of the multiplication of those three numbers is a \"+\".");
        outer:
        Console.ReadLine();
    }
}

