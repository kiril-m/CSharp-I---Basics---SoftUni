//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. Note that you may need to use a for-loop. Examples:
//numbers	    result		numbers	            result 		    numbers	result
//3	            |1 2 3|		5	                |1 2 3 4 5|		1	    1


using System;

class Numbersfrom1toN
{
    static void Main()
    {
        Console.Write("Please, enter a number N: ");
        int numbern = int.Parse(Console.ReadLine());
        int start = 1;
        Console.WriteLine("Here are the integers from 1 to N:");
        Console.WriteLine(start);
        for (int i = 0; i < numbern-1; i++)
        {
            start++;
            Console.WriteLine(start);
        }
        Console.ReadLine();
    }
}

