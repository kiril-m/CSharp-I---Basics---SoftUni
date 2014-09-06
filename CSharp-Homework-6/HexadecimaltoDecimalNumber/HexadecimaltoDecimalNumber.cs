//Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. Examples:
//hexadecimal	decimal
//FE	        254
//1AE3	        6883
//4ED528CBB4	338583669684


using System;
using System.Collections.Generic;

class HexadecimaltoDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Hexadecimal to Decimal Conversion!");

        int a = 10;
        int b = 11;
        int c = 12;
        int d = 13;
        int e = 14;
        int f = 15;

        Console.Write("Please, enter a hexadecimal value of the number (e.g. 2AF3) and press enter to convert to decimal: ");
        string input = Console.ReadLine();
        int inputlength = input.Length;
        List<string> inputlist = new List<string>(); //create a list to store the value of each letter
        for (int i = 0; i < inputlength; i++)
        {
            string currentnumber = input.Substring(i, 1); //populating the list
            inputlist.Add(currentnumber);
        }
        inputlist.Reverse(); //reversing the order of the list

        long subvalue = 0; //a variable to store the true decimal value

        for (int i = 0; i < input.Length; i++) //calculations
        {
            string currentnumber = inputlist[i];
            try
            {
                long currentdigit = long.Parse(currentnumber);
                subvalue += currentdigit * (long)Math.Pow(16, i);
            }
            catch
            {
                if (currentnumber == "A" || currentnumber == "a")
                {
                    subvalue += a * (long)Math.Pow(16, i);
                }
                if (currentnumber == "B" || currentnumber == "b")
                {
                    subvalue += b * (long)Math.Pow(16, i);
                }
                if (currentnumber == "C" || currentnumber == "c")
                {
                    subvalue += c * (long)Math.Pow(16, i);
                }
                if (currentnumber == "D" || currentnumber == "d")
                {
                    subvalue += d * (long)Math.Pow(16, i);
                }
                if (currentnumber == "E" || currentnumber == "e")
                {
                    subvalue += e * (long)Math.Pow(16, i);
                }
                if (currentnumber == "F" || currentnumber == "f")
                {
                    subvalue += f * (long)Math.Pow(16, i);
                }
            }

        }
        Console.WriteLine(subvalue); //result
        Console.ReadLine();

    }
}


