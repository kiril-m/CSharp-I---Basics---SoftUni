//Write an expression that extracts from given integer n the value of given bit at index p. Examples:
//n	    binary representation	    p	    bit @ p
//5	    00000000 00000101	        2	    1
//0	    00000000 00000000	        9	    0
//15	00000000 00001111	        1	    1
//5343	00010100 11011111	        7	    1
//62241	11110011 00100001	        11	    0


using System;

class ExtractaBitfromaInteger
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter which bit position from that number we will be looking for: ");
        int p = int.Parse(Console.ReadLine());
        int aRightp = a >> p;
        int positionp = aRightp & 1;
        Console.WriteLine("The bit in position number {2} in \"{0}\" is {1}.", a, positionp, p);
        Console.ReadLine();
    }
}
