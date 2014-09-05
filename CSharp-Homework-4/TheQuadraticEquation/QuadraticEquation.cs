//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). Examples:
//a	    b	    c	    roots
//2	    5	    -3	    x1=-3; x2=0.5
//-1	3	    0	    x1=3; x2=0
//-0.5	4	    -8	    x1=x2=4
//5	    2	    8	    no real roots


using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Please, input a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please, input b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please, input c: ");
        double c = double.Parse(Console.ReadLine());
        if (b * b - 4 * a * c < 0)
        {
            Console.WriteLine("This equation doesn't have real roots!");
            goto outer;
        }
        double sqrt = Math.Sqrt(((b * b) - 4 * a * c));
        double x1 = ((-1) * b + Math.Sqrt(((b * b) - 4 * a * c))) / (2 * a);
        double x2 = ((-1) * b - Math.Sqrt(((b * b) - 4 * a * c))) / (2 * a);
        Console.WriteLine("x1 is: {0}", x1);
        Console.WriteLine("x2 is: {0}", x2);
    outer:
        Console.ReadLine();
    }
}


