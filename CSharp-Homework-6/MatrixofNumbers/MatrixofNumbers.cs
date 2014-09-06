//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. Examples:
//n	    matrix	
//2	    1 2
//      2 3

//n	    matrix
//3     1 2 3
//      2 3 4
//      3 4 5		



using System;

class MatrixofNumbers
{
    static void Main()
    {
        Console.WriteLine("Matrix!");
        Console.Write("Please, enter a value for \"n\" between 1 and 20 (the height/width of the matrix): ");
        int n = int.Parse(Console.ReadLine());
        int m = n; //a serarate variable used in the internal calculations for the "next line" of the matrix
        int v = n; //saving the initial value of "n"
        for (int i = 1; i <= n; i++) //first loop
        {
            Console.Write("{0,3} ", i); //0,3 adjustments corrects the output visualization on the console when entering values higher than 5 for n
            if (i == n) 
            {
            repeat:
                Console.WriteLine();
                m++;
                if (m == 2 * v) //checking if we have reached the end of the matrix height
                {
                    break;
                }
                for (int internalcount = m - n + 1; internalcount <= m + n; internalcount++) //"next line" of the matrix - the only nested loop
                {
                    Console.Write("{0,3} ", internalcount);
                    if (internalcount == m)
                    {
                        goto repeat;
                    }
                }
            }
        }
        Console.ReadLine();
    }
}

