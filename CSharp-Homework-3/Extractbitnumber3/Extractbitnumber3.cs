//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. Examples:
//n	    binary representation	    bit #3
//5	    00000000 00000101	        0
//0	    00000000 00000000	        0
//15	00000000 00001111	        1
//5343	00010100 11011111	        1
//62241	11110011 00100001	        0
    

using System;

class Extractbitnumber3
{
    static void Main()
    {
        Console.Write("Please enter an integer number (we will be looking for the bit that stands on the 3rd position in its binary representation): "); 
        int a = int.Parse(Console.ReadLine());
        int p = 3;
        int aRightp = a >> p;
        int position3 = aRightp & 1;
        Console.WriteLine("The bit in position number 3 in the integer \"{0}\" is {1}.", a, position3);
        Console.ReadLine();
    }
}

