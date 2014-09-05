//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops. Examples:
//n	    comments
//1	    0
//3	    0 1 1
//10	0 1 1 2 3 5 8 13 21 34


using System;

class FibonacciSequence
{
    static void Main()
    {
        Console.Write("Please, enter a number N: ");
        int numbern = int.Parse(Console.ReadLine());
        int[] fibonacci = new int[numbern];
        int a1 = 0;
        int a2 = 1;
        fibonacci[0] = a1;
        fibonacci[1] = a2;
        Console.Write(fibonacci[0]);
        Console.Write(" ");
        Console.Write(fibonacci[1]);
        for (int i = 2; i < numbern; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            Console.Write(" {0}", fibonacci[i]);
        }
        Console.ReadLine();
    }
}

