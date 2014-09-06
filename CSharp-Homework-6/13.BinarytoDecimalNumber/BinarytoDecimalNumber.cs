//Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. Examples:
//binary	                    decimal
//0	                            0
//11	                        3
//1010101010101011	            43691
//1110000110000101100101000000	236476736


using System;

class BinarytoDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Binary to Decimal Conversion!");
        Console.Write("Please, enter a binary value of the number (e.g. 11101001) and press enter to convert to decimal: ");
        string inputasbinary = Console.ReadLine();
        long thedesirednumber = 0;
        long step = 1;
        string firstnumber = inputasbinary.Substring(0, 1);
        int length = inputasbinary.Length;
        int firstdigit = int.Parse(firstnumber);
        int lastdigit = int.Parse(inputasbinary.Substring(inputasbinary.Length - 1, 1));

        if (length == 1 && firstdigit == 0) //checking if the input is not just 0
        {
            Console.WriteLine(0);
            goto outer;
        }

        for (int i = 1; i <= inputasbinary.Length - 1; i++) //algorithm for going through the numbers one by one and saving the result a variable "thedesirednumber"
        {
            int nextdigit = int.Parse(inputasbinary.Substring(i - 1, 1));
            if (nextdigit == 0)
            {
                goto here;
            }
            if (nextdigit == 1)
            {
                step = (long)Math.Pow(2, inputasbinary.Length - i);
                thedesirednumber += step;
            }

        here: ;
        }
        if (lastdigit == 1)
        {
            long thedesirednumberfinal = 1 + thedesirednumber;
            Console.WriteLine(thedesirednumberfinal);
        }
        else Console.WriteLine(thedesirednumber);

    outer:
        Console.ReadLine();
    }
}

