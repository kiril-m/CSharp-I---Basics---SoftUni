//Problem:
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class AleternateRowofNumbers
{
    static void Main()
    {
        int a = 2;
        Console.WriteLine(a);
        for (int i = 0; i < 9; i++)
        {
            a++;
            if (a % 2 != 0)
            {
                Console.WriteLine(a * (-1));
            }
            else Console.WriteLine(a);
        }
        Console.ReadLine();
    }
}

