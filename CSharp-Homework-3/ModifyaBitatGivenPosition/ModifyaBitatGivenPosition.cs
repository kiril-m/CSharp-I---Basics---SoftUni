//We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. Examples:
//n	    binary representation of n	    p	    v	    binary result	    result
//5	    00000000 00000101	            2	    0	    00000000 00000001	1
//0	    00000000 00000000	            9	    1	    00000010 00000000	512
//15	00000000 00001111	            1	    1	    00000000 00001111	15
//5343	00010100 11011111	            7	    0	    00010100 01011111	5215
//62241	11110011 00100001	            11	    0	    11110011 00100001	62241


using System;

class ModifyaBitatGivenPosition
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter which bit position from that number we will be modifying: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Should it be 1 or 0 the value of the bit we will put in position number {0}?", p);
        int v = int.Parse(Console.ReadLine());

        if (v == 0)
        {
            int mask = ~(1 << p);  //magic :) or...moving the "1" "p" positions and then inverting the result which will be having a "0" on that position (since the invert value of a 1 is 0)
            int result = mask & a; //magic :) or...adding the result to the original number (0 & 1 = 0 and 0 & 0 = 0 by definition)
            Console.WriteLine("The new integer is now: {0}", result);
        }
        if (v == 1)
        {
            {
                int mask1 = 1 << p;   
                int result1 = mask1 | a; //"or-ing" the result to the original number (1 | 1 = 1 and 1 | 0 = 1 by definition)
                Console.WriteLine("The new integer is now: {0}", result1);
            }
        }
        Console.ReadLine();
    }
}

