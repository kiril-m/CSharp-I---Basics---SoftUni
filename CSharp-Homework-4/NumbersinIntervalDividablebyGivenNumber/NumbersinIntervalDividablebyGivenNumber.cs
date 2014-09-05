//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0. Examples:
//start	end	    p	comments
//17	25	    2	20, 25
//5	    30	    6	5, 10, 15, 20, 25, 30
//3	    33	    6	5, 10, 15, 20, 25, 30
//3	    4	    0	-
//99	120	    5	100, 105, 110, 115, 120
//107	196	    18	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195

using System;

class NumbersinIntervalDividablebyGivenNumber
{
    static void Main()
    {
        Console.WriteLine("We will try to find how many numbers within a given range of numbers are divisable by 5.");
        Console.Write("Please, enter the lower limit of the range: ");
        int lowerlimit = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the upper limit of the range: ");
        int upperlimit = int.Parse(Console.ReadLine());
        int[] arrayofnumbers = new int[upperlimit - lowerlimit];
        arrayofnumbers[0] = lowerlimit;
        Console.WriteLine("Here are the divisable numbers by 5 in the range between {0} and {1}", lowerlimit,upperlimit);
        for (int i = 0; i < arrayofnumbers.Length; i++)
        {
            arrayofnumbers[i] = lowerlimit++;
            int newnumber = arrayofnumbers[i];
            if (newnumber % 5 == 0)
            {
                Console.WriteLine(newnumber);
            }
        }
        if (upperlimit % 5 == 0)
        {
            Console.WriteLine(upperlimit);
        }
        Console.ReadLine();
    }
}

