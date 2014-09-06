//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. Print the result with 5 digits after the decimal point.
//n	    x	S
//3	    2	2.75000
//4	    3	2.07407
//5	    -4	0.75781


using System;
using System.Collections.Generic;

class Calculate1plus1factorialdividedplus2factorialetc
{
    static void Main()
    {
        Console.Write("Please, enter a value for \"n\": ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Please, enter a value for \"x\": ");
        double x = double.Parse(Console.ReadLine());
        double subsum = 0;
        double m = n;
        double step = 1; //step - upper side of the fraction of the row of numbers
        double lowerside = 1; //lowerside - lower side of the fraction of row of numbers
        do
        {
            lowerside = Math.Pow(x, m); //calculating the lowerside of the fraction
        enter:
            step *= n; // calculating factorial on the upper side of the fraction
            n--;       // calculating factorial on the upper side of the fraction
            if (n > 1)
            {
                goto enter;
            }
            subsum += step / lowerside; //calculating the subsum of the individual member of the row of numbers
            m--;   // reseting the value of n using the supplementary variable "m" which stores the original value of n - 1
            n = m; // reseting the value of n using the supplementary variable "m" which stores the original value of n - 1
            step = 1; //resenting the value for the step
        } while (n > 0);
        double sum = 1 + subsum;
        Console.WriteLine("{0:0.00000}", sum);
        Console.ReadLine();
    }
}

