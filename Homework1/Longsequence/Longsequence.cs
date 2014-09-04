//Problem:
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … You might need to learn how to use loops in C# (search in Internet).

using System;

class Longsequence
{
    static void Main()
    {
        int a = 2;
        Console.WriteLine(a);
        for (int i = 0; i < 999; i++)
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
