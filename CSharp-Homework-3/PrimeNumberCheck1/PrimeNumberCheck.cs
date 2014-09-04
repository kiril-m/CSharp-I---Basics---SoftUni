//Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). Examples:
//n	    Prime?
//1	    false
//2	    true
//3	    true
//4	    false
//9	    false
//97	true
//51	false
//-3	false
//0	    false


using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Please, enter a number to check if it is prime: ");
        int a = int.Parse(Console.ReadLine());
        int divider = 1;

        //The following block of lines sets a restiction for the number to be less than 100, if deleted the program will work for every positive integer in the range 2-->int.MaxValue.

        //restriction block start
        if (a > 100)
        {
            Console.WriteLine("Please try again and specify a number less than 100 (or simply remove this \"if\" construction to lift this restiction :))");
            goto outer;
        }
        //restriction block end

        if (a < 0) //checking if the number is not negative
        {
            Console.WriteLine(false);
            goto outer;
        }
        if (a == 0) //checking if the input is not zero
        {
            Console.WriteLine(false);
            goto outer;
        }
        if (a / divider == 1) //checking if the input is not 1
        {
            Console.WriteLine(false);
            goto outer;
        }
        bool prime = true;
        if (a % a == 0 && a % 1 == 0) //checking for being prime
        {
            for (int i = 1; i < a - 1; i++)
            {
                divider++;
                if (a % divider == 0)
                {
                    prime = false;
                    break;
                }
            }
        }
        Console.WriteLine(prime);
    outer:
        Console.ReadLine();
    }
}
