//Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, separated by a space, each list at a separate line. Examples:
//Input	    
//20 40 10 10 30 80
//25 20 40 30 10	
//Output
//10 20 25 30 40 80
//Input	    
//5 4 3 2 1
//6 3 2	
//Output
//1 2 3 4 5 6
//Input
//1 1	
//Output
//1


using System;
using System.Collections.Generic;
class JoinLists
{
    static void Main()
    {
        start:
        //first set
        Console.Write("Please, enter the first set of integers: ");
        
        string input1 = Console.ReadLine();
        List<int> firstset = new List<int>();
        List<int> output = new List<int>();
        do
        {
            int namelength = input1.IndexOf(' ');
            if (namelength == -1)
            {
                firstset.Add(int.Parse(input1));
                break;
            }
            string inputintegers = input1.Substring(0, namelength);
            firstset.Add(int.Parse(inputintegers));
            input1 = input1.Substring(namelength + 1, input1.Length - namelength - 1);

        } while (input1.Length != 0);

        //second set
        Console.Write("Please, enter the second set of integers: ");
        string input2 = Console.ReadLine();
        List<int> secondset = new List<int>();
        do
        {
            int namelength = input2.IndexOf(' ');
            if (namelength == -1)
            {
                secondset.Add(int.Parse(input2));
                break;
            }
            string inputintegers = input2.Substring(0, namelength);
            secondset.Add(int.Parse(inputintegers));
            input2 = input2.Substring(namelength + 1, input2.Length - namelength - 1);
        } while (input2.Length != 0);

        //removing repetitive elements from the secondset
        List<int> secondsetmirror = new List<int>();
        for (int i = 0; i < secondset.Count; i++)
        {
            secondsetmirror.Add(secondset[i]);
        }

        foreach (var item in secondsetmirror)
        {
            int repeats = 0;
        checkagain:
            if (firstset.Contains(item) && secondset.Contains(item))
            {
                repeats++;
                secondset.Remove(item);
                if (repeats >= 1)
                {
                    goto checkagain;
                }
            }
        }

        //adding the non-repetitive elements to the first set
        for (int i = 0; i < secondset.Count; i++)
        {
            
            firstset.Add(secondset[i]);
        }

        //sorting
        firstset.Sort();

        //checking for repetitive elements in the new "first set"
        for (int i = 0; i < firstset.Count; i++)
        {
            if (output.Contains(firstset[i])== false)
            {
                output.Add(firstset[i]);
            }
        }

        //printing out the result
        foreach (var item in output)
        {
            Console.Write(item);
            Console.Write(' ');
        }
        Console.ReadLine();

        //restarting the program
        goto start;
    }
}

