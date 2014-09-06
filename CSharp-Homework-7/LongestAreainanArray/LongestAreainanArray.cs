//Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them. Examples:
//Input	
//6
//hi
//hi
//hello
//ok
//ok
//ok
//Output
//3
//ok
//ok
//ok
//2
//SoftUni
//Hello	
//Output
//1
//SoftUni
//4
//hi
//hi
//hi
//hi	
//Output
//4
//hi
//hi
//hi
//hi
//5
//wow
//hi
//hi
//ok
//ok	
//Output
//2
//hi
//hi


using System;
using System.Collections.Generic;
using System.Linq;

class LongestAreainanArray
{
    static void Main()
    {
    start:
        Console.Write("Please, enter the number of strings to follow: ");
        int n = int.Parse(Console.ReadLine());
        int counterofsameelements = 0;
        List<string> arrayofstrings = new List<string>();
        List<string> leftmost = new List<string>();
        string[] stringosano = new string[0];
        string toprint = "";
        string toprintfirst = "";
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            if (i == 0)
            {
                arrayofstrings.Add(input);
                toprintfirst = input;
                continue;
            }
            if (arrayofstrings.Last() != input)
            {
                if (i == 1)
                { goto here; }
                stringosano = arrayofstrings.ToArray();
                leftmost = arrayofstrings.GetRange(stringosano.Length - counterofsameelements - 1, counterofsameelements + 1);
            }

        here:
            if (arrayofstrings.Last() == input)
            {
                counterofsameelements++;
                toprint = input;
            }
            arrayofstrings.Add(input);
        }


        if (counterofsameelements == 0)
        {
            Console.WriteLine(counterofsameelements + 1);
            Console.WriteLine(toprintfirst);
            goto outer;
        }
        string[] leftmosttostring = new string[leftmost.Count];
        if (leftmosttostring.Length == counterofsameelements)
        {
            Console.WriteLine("{0}", leftmosttostring.Length);
            foreach (var item in leftmost)
            {
                Console.WriteLine(item);
            }
            goto outer;
        }

      
        if (toprint == toprintfirst)
        {
            if (counterofsameelements != 0)
            {
                Console.WriteLine(counterofsameelements + 1);
            }

            Console.WriteLine(toprintfirst);
            for (int i = 0; i < counterofsameelements; i++)
            {
                Console.WriteLine(toprint);
            }
        }
        if (toprint != toprintfirst)
        {
            if (counterofsameelements != 0)
            {
                Console.WriteLine(counterofsameelements);
            }
            for (int i = 0; i < counterofsameelements; i++)
            {
                Console.WriteLine(toprint);
            }
        }

    outer:
        Console.ReadLine();
        goto start;

    }
}

