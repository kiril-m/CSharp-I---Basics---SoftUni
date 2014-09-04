//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullArithmetics
{
    static void Main()
    {
        int a = 0;
        double b = 0;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(a + 5);
        Console.WriteLine(b + 6);
        Console.WriteLine(a + null);
        Console.WriteLine(b + null);
    }
}

