//Using loops write a program that converts an integer number to its binary representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. Examples:
//decimal	binary
//0	        0
//3	        11
//43691	    1010101010101011
//236476736	1110000110000101100101000000


using System;
using System.Collections.Generic;

class DecimaltoBinary
{
    static void Main()
    {
        Console.WriteLine("Decimal to Binary Conversion!");
        Console.Write("Please, enter a decimal value of the number (e.g. 3242) and press enter to convert to binary: ");

        long inputasdecimal = long.Parse(Console.ReadLine());

        if (inputasdecimal == 0) //checking if the input is not just 0
        {
            Console.WriteLine(0);
            goto outer;
        }
        List<long> listofthenumbers = new List<long>(); //creating a list for storing the values of 1s and 0s
        int step = (int)inputasdecimal;

        do
        {
            long reminder = step % 2;
            listofthenumbers.Add(reminder); //populating the list
            step = (int)(step / 2);

        } while (step != 1);

        listofthenumbers.Reverse();

        Console.Write(1); //this is the reminder 
        foreach (var item in listofthenumbers) //this is the rest of the number in binary code
        {
            Console.Write(item);
        }
    outer:
        Console.ReadLine();
    }
}
