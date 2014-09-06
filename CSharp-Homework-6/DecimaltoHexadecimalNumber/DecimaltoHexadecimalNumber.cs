//Using loops write a program that converts an integer number to its hexadecimal representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. Examples:
//decimal	    hexadecimal
//254	        FE
//6883	        1AE3
//338583669684	4ED528CBB4


using System;
using System.Collections.Generic;

class DecimaltoHexadecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Decimal to Hexadecimal Conversion!");
        Console.Write("Please, enter a decimal value of the number (e.g. 12345) and press enter to convert to hexadecimal: ");
        long input = long.Parse(Console.ReadLine());

        long remainer; //a variable holding the remains of the division between the current subnumber and 16
        List<string> inputlist = new List<string>(); //list to store those remains

        for (int i = 0; i < int.MaxValue; i++) //populating the list using a calculation (sub)number/16 
        {
            remainer = input % 16;
            if (remainer > -1 && remainer < 10)
            {
                inputlist.Add(remainer.ToString());
            }

            if (remainer == 10)
            {
                inputlist.Add("A");
            }
            if (remainer == 11)
            {
                inputlist.Add("B");
            }
            if (remainer == 12)
            {
                inputlist.Add("C");
            }
            if (remainer == 13)
            {
                inputlist.Add("D");
            }
            if (remainer == 14)
            {
                inputlist.Add("E");
            }
            if (remainer == 15)
            {
                inputlist.Add("F");
            }
            input = input / 16;
            if (input < 16)
            {
                if (input > -1 && input < 10)
                {
                    inputlist.Add(input.ToString());
                }
                if (input == 10)
                {
                    inputlist.Add("A");
                }
                if (input == 11)
                {
                    inputlist.Add("B");
                }
                if (input == 12)
                {
                    inputlist.Add("C");
                }
                if (input == 13)
                {
                    inputlist.Add("D");
                }
                if (input == 14)
                {
                    inputlist.Add("E");
                }
                if (input == 15)
                {
                    inputlist.Add("F");
                }
                break;
            }
        }
        inputlist.Reverse(); //reversing the order of the numbers
        foreach (var item in inputlist) //printing them out which is actually the number in a hexadecimal representation
        {
            Console.Write(item);
        }
        Console.ReadLine();

    }
}
