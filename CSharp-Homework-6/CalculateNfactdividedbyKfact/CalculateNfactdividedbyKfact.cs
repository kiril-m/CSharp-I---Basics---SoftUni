//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. Examples:
//n	    k	n! / k!
//5	    2	60
//6	    5	6
//8	    3	6720


using System;
using System.Numerics;

class CalculateNfactdividedbyKfact
{
    static void Main()
    {
        Console.Write("Please, enter \"N\": ");
        long n = long.Parse(Console.ReadLine());
        Console.Write("Please, enter \"K\": ");
        long k = long.Parse(Console.ReadLine());
        if (n < k && k > 2 && n < 99)
        {
            Console.WriteLine("N should be bigger than K!");
            goto outer;
        }
        if (k<2 || n>99)
        {
            Console.WriteLine("N and K should be between 1 and 100 and N should be bigger than K!");
            goto outer;
        }
        BigInteger factn = 1;
        BigInteger factk = 1;

        //Biginteger is needed because in bigger values for N and K (fx 50 and 43) an "exception - divided by zero occurs"! 
        
        while (k < n)
        {
            if (k == 1)
            {
                goto newer;
            }
            factk *= k;
            k--;
        newer:
            factn *= n;
            n--;

            if (n == 1)
            {
                break;
            }
        }
        Console.WriteLine("N factorial divided by K factorial equals: {0}", (factn / factk));
        outer:
        Console.ReadLine();
    }
}

