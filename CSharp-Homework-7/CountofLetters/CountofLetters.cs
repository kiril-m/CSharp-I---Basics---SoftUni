//Write a program that reads a list of letters and prints for each letter how many times it appears in the list. The letters should be listed in alphabetical order. Use the input and output format from the examples below. Examples:
//Input	    Output
//b b a a b	a -> 2
//            b -> 3
//Input
//h d h a a a s d f d a d j d s h a a	
//Output
//a -> 6
//d -> 5
//f -> 1
//h -> 3
//j -> 1
//s -> 2


using System;
using System.Collections.Generic;

class CountofLetters
{
    static void Main()
    {
    start:
        Console.Write("Please, enter the set of letters: ");
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

        //sorting (there is a mistake in the second example given - the names are actually sorted alphabetically-reverse :)) 
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
    }
}

