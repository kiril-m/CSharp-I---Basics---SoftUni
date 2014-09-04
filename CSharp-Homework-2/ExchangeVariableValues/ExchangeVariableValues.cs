//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values.
//Print the variable values before and after the exchange.

using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        Console.WriteLine(a);
        int b = 10;
        Console.WriteLine(b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

