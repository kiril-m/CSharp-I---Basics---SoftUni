//Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality. Examples:
//a	        b	        c	        result
//5	        1	        2	        5 2 1
//-2	    -2	        1	        1 -2 -2
//-2	    4	        3	        4 3 -2
//0	        -2.5	    5	        5 0 -2.5
//-1.1	    -0.5	    -0.1	    -0.1 -0.5 -1.1
//10	    20	        30	        30 20 10
//1	        1	        1	        1 1 1


using System;

class Sort3NumberswithNestedIfs
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Sorting by value: ");
        if (a==b && b==c)
        {
            Console.WriteLine("{0} {1} {2}", a, b,c);
        }
        if (a>b && a>c)
        {
            Console.Write("{0}",a);
            if (b>c)
            {
                Console.Write(" {0} {1}", b,c);
            }
            else Console.Write(" {0} {1}", c, b);
        }
        if (b > a && b > c)
        {
            Console.Write(b);
            if (a > c)
            {
                Console.Write(" {0} {1}", a, c);
            }
            else Console.Write(" {0} {1}", c, a);
        }
        if (c > a && c > b)
        {
            Console.Write(c);
            if (a > b)
            {
                Console.WriteLine(" {0} {1}", a, b);
            }
            else Console.Write(" {0} {1}", b, a);
            
        }
        Console.ReadLine();
    }
}

