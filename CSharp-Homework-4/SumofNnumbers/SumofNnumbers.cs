//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop. 
//Examples:
//numbers	sum		
//3
//20
//60
//10	    90		



using System;

class SumofNnumbers
{
    static void Main()
    {
        Console.Write("Please, enter a number N: ");
        int numbern = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter those {0} numbers. ", numbern);
        double sum=0;
        for (int i = 0; i < numbern; i++)
        {
            for (int count = 1; count < numbern+1; count++)
            {
                Console.Write("Number {0}: ",count);
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            break; 
        }
        Console.Write("The sum of the those {0} numbers is: ", numbern);
        Console.Write(sum);
        Console.ReadLine();
    }
}

