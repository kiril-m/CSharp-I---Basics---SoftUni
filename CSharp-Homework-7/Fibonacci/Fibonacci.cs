//Define a method Fib(n) that calculates the nth Fibonacci number. Examples:
//n	    Fib(n)
//0	    1
//1	    1
//2	    2
//3	    3
//4	    5
//5	    8
//6	    13
//11	144
//25	121393


using System;

class Fibonacci
{
    static void Main()
    {
        Console.Write("Please enter which number in the Fibonacci sequence you would like to know: ");
        int input = int.Parse(Console.ReadLine());
        Fib(input); //invoking the Fibonacci method
        Console.ReadLine();
    }

    static void Fib(int n) //the Fibonacci sequence as a method
    {
        int t1 = 0;
        int t2 = 1;
        for (int i = 1; i <= n; i++)
        {

            int t3 = t1 + t2;
            t1 = t2;
            t2 = t3;
            if (i == n)
            {
                Console.WriteLine("The \"{0}\" number in the Fibonacci sequence is {1}.", n, t3);
            }
        }
    }
}


