//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. Use the Euclidean algorithm (find it in Internet). Examples:
//a	    b	    GCD(a, b)
//3	    2	    1
//60	40	    20
//5	    -15	    5


using System;

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("Great Common Divisor!");
        Console.Write("Please, enter positive integer \"a\" to find the Greatest Common Divisor between it and the next variable \"b\": ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please, enter positive integer \"b\" to find the Greatest Common Divisor between it and the previous variable \"a\": ");
        int b = int.Parse(Console.ReadLine());
        int r; //the remainer of the division between a and b
        int q; //the whole part of the division between a and b
        for (int i = 0; i < int.MaxValue; i++) // the logic in the loop follows the way the Eucledian algorithm is defined
        {
            q = (int)a / b;
            r = a % b;
            if (r == 0)
            {
                Console.WriteLine("The Greatest Common {0}", b);
                break;
            }
            a = b;
            b = r;
        }
        Console.ReadLine();
    }
}

