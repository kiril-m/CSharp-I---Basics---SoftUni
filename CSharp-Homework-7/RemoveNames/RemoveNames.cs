//Write a program that takes as input two lists of names and removes from the first list all names given in the second list. The input and output lists are given as words, separated by a space, each list at a separate line. Examples:
//Input	                
//Peter Alex Maria Todor Steve Diana Steve
//Todor Steve Nakov	
//Output
//Peter Alex Maria Diana
//Input	                
//Hristo Hristo Nakov Nakov Petya
//Nakov Vanessa Maria	
//Output
//Hristo Hristo Petya


using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {

    start:
        //first set
        Console.Write("Please, enter the first set of names: ");
        string input1 = Console.ReadLine();
        var firstset = new List<string>();
        var output = new List<string>();
        do
        {
            int namelength = input1.IndexOf(' ');
            if (namelength == -1)
            {
                firstset.Add(input1);
                break;
            }
            string inputnames = input1.Substring(0, namelength);
            firstset.Add(inputnames);
            input1 = input1.Substring(namelength + 1, input1.Length - namelength - 1);

        } while (input1.Length != 0);

        string[] names1 = input1.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var l = new List<string>(names1);

        //second set
        Console.Write("Please, enter the second set of names: ");
        string input2 = Console.ReadLine();
        List<string> secondset = new List<string>();
        do
        {
            int namelength = input2.IndexOf(' ');
            if (namelength == -1)
            {
                secondset.Add(input2);
                break;
            }
            string inputnames = input2.Substring(0, namelength);
            secondset.Add(inputnames);
            input2 = input2.Substring(namelength + 1, input2.Length - namelength - 1);
        } while (input2.Length != 0);

        //check
        foreach (var item in secondset)
        {
            firstset.RemoveAll(s => s == item); //lambda expression check
        }

        //print
        foreach (var item in firstset)
        {
            Console.Write(item + ' ');
        }
        Console.ReadLine();
        goto start;
    }
}

