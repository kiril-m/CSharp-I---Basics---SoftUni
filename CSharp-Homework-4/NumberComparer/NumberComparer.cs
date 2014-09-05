//Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. Examples:
//a	    b	greater
//5	    6	6
//10	5	10
//0	    0	0
//-5	-2	-2
//1.5	1.6	1.6


using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Please, enter the first number to compare: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please, enter the second number to compare: ");
        double b = double.Parse(Console.ReadLine());
        while (a > b)
        {
            Console.WriteLine("The bigger number is indeed {0}.", a);
            break;
        }
        while (b > a)
        {
            Console.WriteLine("The bigger number is indeed {0}.", b);
            break;
        }
        while (a == b)
        {
            Console.WriteLine("The numbers are actually of the same value: {0}.", a);
            break;
        }
        Console.ReadLine();
    }
}