//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned. Examples:
//a	    b	        c	        result
//254	11.6	    0.5	        |FE        |0011111110|     11.60|0.500     |
//499	-0.5559	    10000	    |1F3       |0111110011|     -0.56|10000     |
//0	    3	        -0.1234     |0         |0000000000|         3|-0.123    |


using System;

class FormatingNumbers
{
    static void Main()
    {
        string emptyspaces = " ";

        //number #1
        Console.Write("Please, enter the first number to format: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the second number to format: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please, enter the third number to format: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("And here is the output: ");
        string ahexa = a.ToString("X");
        int numberofchars = ahexa.Length;
        string abinary = Convert.ToString(a, 2);
        Console.Write("|{0}", ahexa);
        for (int i = 0; i < 10 - numberofchars + 1; i++)
        {
            Console.Write(emptyspaces);
        }
        int numberofcharsbinary = abinary.Length;
        Console.Write("|");
        for (int i = 0; i < 10 - numberofcharsbinary; i++)
        {
            Console.Write(0);
        }
        Console.Write(abinary);

        //number #2 
        double btrunct = Math.Round(b, 2);
        string btrunctstring = btrunct.ToString();
        int numberofcharsbtruct = btrunctstring.Length;
        Console.Write("|");
        for (int i = 0; i < 10 - numberofcharsbtruct + 1; i++)
        {
            Console.Write(emptyspaces);
        }
        if ((b / b) != 1)
        {
            Console.Write("{0:0.00}", btrunct);
        }
        else Console.Write("{0}", btrunct);

        //number #3
        double ctrunct = Math.Round(c, 3);
        string ctrunctstring = ctrunct.ToString();
        int numberofcharsctruct = ctrunctstring.Length;

        if ((c / c) != 1)
        {
            Console.Write("|{0:0.000}", ctrunct);
        }
        else Console.Write("|{0}", ctrunct);
        for (int i = 0; i < 10 - numberofcharsctruct + 1; i++)
        {
            Console.Write(emptyspaces);
        }
        Console.Write("|");

        Console.ReadLine();
    }
}


