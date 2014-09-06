//Write a program to find the longest word in a text. Examples:
//Input	                                                                            Output
//Welcome to the Software University.	                                            University
//The C# Basics course is awesome start in programming with C# and Visual Studio.	programming


using System;
using System.Collections.Generic;

class LongestWordinaText
{
    static void Main()
    {
    start:
        Console.Write("Please, enter the sentence: ");
        string input = Console.ReadLine();
        List<string> firstset = new List<string>();
        List<string> output = new List<string>();
        do
        {
            int namelength = input.IndexOf(' ');
            if (namelength == -1)
            {
                firstset.Add(input.Substring(0,input.Length-1)); //removing the punctuation sign from the last string. 
                break;
            }
            string inputletters = input.Substring(0, namelength);
            firstset.Add(inputletters);
            input = input.Substring(namelength + 1, input.Length - namelength - 1);

        } while (input.Length != 0);

        List<string> firstsetmirror = new List<string>();   
        for (int i = 0; i < firstset.Count; i++)
        {
            firstsetmirror.Add(firstset[i]);
        }

        List<int> countofletters = new List<int>();
        for (int i = 0; i < firstset.Count; i++)
        {
            int b = firstset[i].Length;
            countofletters.Add(b);
        }
        countofletters.Sort();

        for (int i = 0; i < firstset.Count; i++)
        {
            int lengthoftheindividualmember = firstset[i].Length;
            if (lengthoftheindividualmember==countofletters[countofletters.Count-1])
            {
                Console.WriteLine("This is the longest word: {0}", firstset[i]);
            }
        }
        Console.ReadLine();
        goto start;
    }
}

