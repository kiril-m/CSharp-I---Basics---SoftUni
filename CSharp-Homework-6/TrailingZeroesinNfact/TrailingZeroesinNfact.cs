//Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000. Examples:
//n	        trailing zeroes of n!	explaination
//10	    2	                    3628800
//20	    4	                    2432902008176640000
//100000	24999	                think why


using System;
using System.Numerics;

class TrailingZeroesinNfact
{
    static void Main()
    {
        Console.WriteLine("Trailing zeroes in N!");
        Console.Write("Please, enter a value for \"n\" to calculate the number of zeroes in its factorial: ");
        BigInteger n = int.Parse(Console.ReadLine());
        BigInteger step = 1;
        BigInteger zeros = 0;
        for (int i = 1; i <= n; i++)
        {
            step *= i;
        }
     
        for (BigInteger i = 0; i < step; i++)
        {
            BigInteger b = step % 10;
            if (b == 0)
            {
                zeros++;
            }
            if (b != 0)
            {
                break;
            }
            step = step / 10;
        }
        Console.WriteLine("The number of \"trailing\" zeroes in {0}! is {1}.",n,zeros);
        Console.ReadLine();
    }
}

