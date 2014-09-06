//Write a program that reads a number n and a sequence of n integers, sorts them and prints them. Examples:
//Input	
//5
//3
//-3
//2
//122
//0	
//Output
//-3
//0
//2
//3
//122


using System;
using System.Collections.Generic;

class SortingNumbers
{
    static void Main()
    {
    start:
        Console.Write("Please, enter how many numbers you would like to sort: ");
        int n = int.Parse(Console.ReadLine());
        List<int> listofnums = new List<int>();
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please, enter next number: ");
            int b = int.Parse(Console.ReadLine());

            listofnums.Add(b);
        }

        //sorting 
        listofnums.Sort();

        Console.WriteLine("Here are your numbers in a sorted number (lowest to highest): ");
        //printing
        foreach (var item in listofnums)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();

        //restart 
        goto start;
    }
}
