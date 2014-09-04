//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Prints on the console the number in reversed order: dcba (in our example 1102).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0. Examples:
//  n	sum of digits	    reversed	last digit in front	    second and third digits exchanged
//2011	4	                1102	    1201	                2101
//3333	12	                3333	    3333	                3333
//9876	30	                6789	    6987	                9786


using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Please, enter a four digit number: ");
        int a = int.Parse(Console.ReadLine());
        string workingstring = a.ToString();
        char firstnumber = workingstring[0];
        char secondnumber = workingstring[1];
        char thirdnumber = workingstring[2];
        char forthnumber = workingstring[3];
        int firstnumberint = (int)char.GetNumericValue(firstnumber);
        int secondnumberint = (int)char.GetNumericValue(secondnumber);
        int thirdnumberint = (int)char.GetNumericValue(thirdnumber);
        int forthnumberint = (int)char.GetNumericValue(forthnumber);

        //sum
        Console.WriteLine("The sum of the digits is: {0}", (firstnumberint + secondnumberint + thirdnumberint + forthnumberint));

        //reverse
        Console.WriteLine("In reverse: {0}{1}{2}{3}", forthnumberint, thirdnumberint, secondnumberint, firstnumberint);

        //last becomes first
        Console.WriteLine("Last becomes first: {0}{1}{2}{3}", forthnumberint, firstnumberint, secondnumberint, thirdnumberint);

        //switch second and third
        Console.WriteLine("Switch the second with the third digit: {0}{1}{2}{3}", firstnumberint, thirdnumberint, secondnumberint, forthnumberint);

        Console.ReadLine();
    }
}

