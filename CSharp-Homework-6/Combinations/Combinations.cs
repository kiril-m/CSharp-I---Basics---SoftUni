//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula:(lookup the text file in the parent directory for the image with the formula)
 
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops. Examples:
//n	    k	n! / (k! * (n-k)!)
//3	    2	3
//4	    2	6
//10 	6	210
//52	5	2598960


using System;
using System.Numerics;

class Combinations
{
    static void Main()
    {
        Console.WriteLine("Combinations!");
        Console.Write("Please, enter a value for \"n\": ");
        long n = long.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for \"k\": ");
        long k = long.Parse(Console.ReadLine());

        //restrictions check block
        if (n < k && k > 2 && n < 100)
        {
            Console.WriteLine("N should be bigger than K!");
            goto outer1;
        }
        if (k < 2 || n > 99)
        {
            Console.WriteLine("N and K should be between 2 and 99 and N should be bigger than K!");
            goto outer1;
        }
        //

        long b = (n - k);
        BigInteger factorialk = 1;
        BigInteger factorialn = 1;
        BigInteger factorialnminusk = 1;
        while (true)
        {
            if (b==1)
            {
                break;
            }
            factorialnminusk *= b;
            b--;
        }
        while (true)
        {
            if (k == 1)
            {
                goto outer;
            }
            factorialk *= k;
            k--;
           
        outer:
            factorialn *= n;
            n--;
            if (n == 1)
            {
                break;
            }

        }
       
        Console.WriteLine("The number of combinations of are: {0}", factorialn / (factorialk * factorialnminusk));
        outer1:
        Console.ReadLine();
    }
}

