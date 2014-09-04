//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. Examples:
//n	                binary representation of n	            binary result	                            result
//1140867093	    01000100 00000000 01000000 00010101	    01000010 00000000 01000000 00100101	        1107312677
//255406592	        00001111 00111001 00110010 00000000	    00001000 00111001 00110010 00111000	        137966136
//4294901775	    11111111 11111111 00000000 00001111	    11111001 11111111 00000000 00111111	        4194238527
//5351	            00000000 00000000 00010100 11100111	    00000100 00000000 00010100 11000111	        67114183
//2369124121	    10001101 00110101 11110111 00011001	    10001011 00110101 11110111 00101001	        2335569705


using System;

class BitsExchange
{
    //defining a method which takes the initial number, the position to change and what the new value of that position should be

    //Int64 might be unnecessary in this case, a normal "int" might also be enough
    static Int64 SetBit(Int64 number, int position, int bit)
    {
        if (bit == 0)
        {
            Int64 mask = ~((Int64)1 << position);
            return number & mask;
        }
        Int64 shiftedBit = (Int64)1 << position;
        return number | shiftedBit;
    }
    //end defining method

    static void Main()
    {
    start:
        Console.Write("Please, enter the number in which the 3, 4 and 5th position in the binary representation will be exchanged with the 24, 25 and 26th position: ");
        Int64 n = Int64.Parse(Console.ReadLine());

        //reading the values for the 6 positions
        //3, 4 and 5
        byte p3 = (byte)((n >> 3) & 1);
        byte p4 = (byte)((n >> 4) & 1);
        byte p5 = (byte)((n >> 5) & 1);

        //24, 25 and 26
        byte p24 = (byte)((n >> 24) & 1);
        byte p25 = (byte)((n >> 25) & 1);
        byte p26 = (byte)((n >> 26) & 1);

        //exchanging the values using the pre-defined method
        n = SetBit(n, 24, p3);
        n = SetBit(n, 25, p4);
        n = SetBit(n, 26, p5);
        n = SetBit(n, 3, p24);
        n = SetBit(n, 4, p25);
        n = SetBit(n, 5, p26);

        Console.Write("The new number is: ");
        Console.Write(n);
        Console.WriteLine();
        Console.ReadLine();

        //restarting the program
        goto start;
    }
}


