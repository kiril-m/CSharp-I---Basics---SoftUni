//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. Examples:
//n	    binary representation of n	    p	bit @ p == 1
//5	    00000000 00000101	            2	true
//0	    00000000 00000000	            9	false
//15	00000000 00001111	            1	true
//5343	00010100 11011111	            7	true
//62241	11110011 00100001	            11	false


using System;

class CheckaBitataGivenPosition
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter which bit position from that number we will be looking for: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Would it be 1?");
        int aRightp = a >> p;
        int positionp = aRightp & 1;
        bool isone = false;
        if (positionp == 1)
        {
            isone = true;
            Console.WriteLine("{0}.The bit in position {1} is indeed 1.", isone,p);
        }
        else Console.WriteLine("{0}.The bit in position {1} is actually 0.", isone,p);

        Console.ReadLine();
    }
}

