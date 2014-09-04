//Write an expression that checks if given integer is odd or even. Examples:
//n	Odd?
//3	true
//2	false
//-2	false
//-1	true
//0	false


using System;

class OddorEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Is the following number odd?");
        string a = Console.ReadLine();
        int b = int.Parse(a);
        if (b % 2 == 0)
        {
            Console.WriteLine(false);
        }
        else Console.WriteLine(true);
        Console.ReadLine();
    }
}

