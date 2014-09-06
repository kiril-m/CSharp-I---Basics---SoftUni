//Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. Examples:
//n	            IsPrime(n)
//0	            false
//1	            false
//2	            true
//3	            true
//4	            false
//5	            true
//323	        false
//337	        true
//6737626471	true
//117342557809	false


using System;
using System.Numerics;

class PrimeChecker
{
    static void Main()
    {
    start:
        Console.Write("Please enter a number to check if it is prime: ");
        BigInteger input = BigInteger.Parse(Console.ReadLine());
        IsPrime(input);
        goto start;
    }

    static void IsPrime(BigInteger n)
    {
        Console.WriteLine(DateTime.Now); //setting a timer: start
        bool isprime = true;
        if (n < 0)
        {
            isprime = false;
            Console.WriteLine(isprime);
            Console.ReadLine();
            goto outer;
        }
        if (n == 0)
        {
            isprime = false;
            Console.WriteLine(isprime);
            Console.ReadLine();
            goto outer;
        }
        if (n == 1)
        {
            isprime = false;
            Console.WriteLine(isprime);
            Console.ReadLine();
            goto outer;
        }
        //checking
        for (BigInteger i = 2; i < n; i++) // Big numbers require more time to validate (for example 457,410,277 took 1 min 30 seconds). 
        {

            if (n % i == 0)
            {
                isprime = false;
                break;
            }
        }
        Console.WriteLine(DateTime.Now); //stopping the timer
        Console.Write(isprime);
        Console.ReadLine();
    outer:
        Console.ReadLine();
    }
}
