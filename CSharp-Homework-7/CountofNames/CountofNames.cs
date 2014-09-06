//Write a program that reads a list of names and prints for each name how many times it appears in the list. The names should be listed in alphabetical order. Use the input and output format from the examples below. Examples:
//Input	
//Peter Steve Nakov Steve Alex Nakov	
//Output
//Alex -> 1
//Nakov -> 2
//Peter -> 1
//Steve -> 2
//Input
//Nakov Nakov Nakov SoftUni Nakov	
//Output
//SoftUni -> 1
//Nakov -> 5


using System;
using System.Collections.Generic;

class CountofNames
{
    static void Main()
    {
        //NB. Absolutely the same program as the one in task 10. Only difference is in the first line after the label "start". Works just as fine! :)

        start:
        Console.Write("Please, enter the set of names: ");
        string input = Console.ReadLine();
        List<string> firstset = new List<string>();
        List<string> output = new List<string>();
        do
        {
            int namelength = input.IndexOf(' ');
            if (namelength == -1)
            {
                firstset.Add(input);
                break;
            }
            string inputletters = input.Substring(0, namelength);
            firstset.Add(inputletters);
            input = input.Substring(namelength + 1, input.Length - namelength - 1);

        } while (input.Length != 0);

        //removing repetitive elements
        for (int i = 0; i < firstset.Count; i++)
        {
            if (output.Contains(firstset[i]) == false)
            {
                output.Add(firstset[i]);
            }
        }

        //sorting
        output.Sort();

        //counting the number of times an element appears in the list
        List<int> numbercounts = new List<int>();
        for (int i = 0, m = 0; i < output.Count; i++)
        {
            int currentcount = 0;
            for (int anotheri = 0; anotheri < firstset.Count; anotheri++)
            {
                if (firstset[anotheri] == output[i])
                {
                    currentcount++;
                    m++;
                }
            }
            numbercounts.Add(currentcount);
        }

        //printing the result as a combination of the two lists - list of non-repetitive elements in the initial input & a list of counts which share the same indices in their own respective lists  - the index "i" 
        for (int i = 0; i < numbercounts.Count; i++)
        {
            Console.WriteLine("{0} --> {1}", output[i], numbercounts[i]);
        }
        Console.ReadLine();

        //restarting the program
        goto start;

        //for (int i = 0; i < firstsetmirror.Count+1; i++)
        //{
        //    if (firstset[i]==firstset[i+1])
        //    {
        //        firstset.Remove(firstset[i + 1]);
        //    }
        //}

        //for (int i = 0; i < firstset.Count; i++)
        //{
        //    string check = firstset[i];

        //    if (firstset.GetRange(i + 1, firstset.Count - i - 1).Contains(check) == true)
        //    {
        //        foreach (var item in firstset)
        //        {
        //            if (item == check)
        //            {
        //                continue;

        //            }


        //        }
        //        continue;
        //    }
        //    else { output.Add(check); }

        //if (output.Contains(check) == false)
        //{
        //    output.Add(check);
        //}



        //}
        //foreach (var item in output)
        //{
        //    Console.Write(item + ' ');
        //}
    }
}

