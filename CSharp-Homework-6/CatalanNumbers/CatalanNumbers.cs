//In combinatorics, the Catalan numbers are calculated by the following formula: (lookup the text file in the parent directory for the image with the formula)
  
//Write a program to calculate the nth Catalan number by given n (1 < n < 100). Examples:
//n	    Catalan(n)
//0	    1
//5	    42
//10	16796
//15	9694845


using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Catalan Numbers!");
        Console.Write("Please, enter a value for \"n\": ");
        long n = long.Parse(Console.ReadLine());
        BigInteger b = 2 * n;
        BigInteger c = n + 1;

        //restrictions check block
        if (n < 0)
        {
            Console.WriteLine("N should be bigger than 1!");
            goto outer1;
        }
        if (n > 99)
        {
            Console.WriteLine("N should be between 1 and 99!");
            goto outer1;
        }
        //

        BigInteger factorialn = 1;
        BigInteger factorial2n = 1;
        BigInteger factorialnplus1 = 1;
        
        while (true)
        {
            if (n == 1)
            {
                goto out1;
            }
            factorialn *= n;
            n--;

        out1:
            if (c == 1)
            {
                goto out2;
            }
            factorialnplus1 *= c;
            c--;

        out2:
            if (b == 1)
            {
                break;
            }
            factorial2n *= b;
            b--;
        }

        Console.WriteLine("The Catalan number for this position has a value of: {0}", factorial2n / (factorialnplus1 * factorialn));

        outer1:
        Console.ReadLine();
    }
}


