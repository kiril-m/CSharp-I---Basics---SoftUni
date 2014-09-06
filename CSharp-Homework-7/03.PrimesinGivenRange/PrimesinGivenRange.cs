//Write a method that calculates all prime numbers in given range and returns them as list of integers:
//static List<int> FindPrimesInRange(startNum, endNum)
//{
//    …
//}
//Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line) and prints all primes in their range, separated by a comma.
//Examples:
//Start number
//0
//End number
//10
//Output
//2, 3, 5, 7

//Start number
//5
//End number
//11
//Output
//5, 7, 11

//Start number
//100
//End number
//200
//Output
//101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199

//Start number
//100
//End number
//50
//Output
//(empty list)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class PrimesinGivenRange
{
    static void Main()
    {
    start:
        Console.WriteLine("Please enter the lower limit for the number to check if it is prime: ");
        int inputlower = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the upper limit for the number to check if it is prime: ");
        int inputupper = int.Parse(Console.ReadLine());
        FindPrimesInRange(inputlower, inputupper);
        Console.WriteLine();
        goto start;  //used to make the program run over and over again until terminated
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> result = new List<int>();
        for (int inextnumber = startNum; inextnumber <= endNum; inextnumber++)
        {
            bool isprime = true;
            if (inextnumber < 0)
            {
                isprime = false;
                goto outer;
            }

            if (inextnumber == 0)
            {
                isprime = false;
                goto outer;
            }
            if (inextnumber == 1)
            {
                isprime = false;
                goto outer;
            }

            for (int internalcount = 2; internalcount < inextnumber; internalcount++)
            {
                if (inextnumber % internalcount == 0)
                {
                    isprime = false;
                    break;
                }
            }

        outer:
            if (isprime == true)
            {
                result.Add(inextnumber);
            }
        }

        foreach (var item in result)
        {
            Console.Write("{0}", item);
            int last = result.Last();   //one way of circumventing the last comma in the list
            if (item == last)
            {
                break;
            }
            Console.Write(",");

        }
        return result;
    }
}
