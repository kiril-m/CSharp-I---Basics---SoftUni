//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below. Examples:
//input	 output		
//3      min = 1
//2      max = 5
//5      sum = 8
//1	     avg = 2.67


using System;
using System.Collections.Generic;

class MinMaxSumandAverageofNNumbers
{
    static void Main()
    {
        Console.Write("Please, enter positive integer \"n\": ");
        int n = int.Parse(Console.ReadLine());
        int number = 0;
        double sum = 0;
        double avg = 0;
        List<double> listaaa = new List<double>();
        while (number < n)
        {
            number++;
            double b = double.Parse(Console.ReadLine());
            listaaa.Add(b);
            sum += b;
            avg = sum / n;
            listaaa.Sort();
        }
        Console.WriteLine("The sum of the {1} numbers is: {0}", sum, n);
        double avgrounded = Math.Round(avg, 2);
        Console.WriteLine("The average of the {1} numbers is: {0:0.00}", avgrounded, n);
        Console.WriteLine("The max number is: {0}", listaaa[number - 1]);
        Console.WriteLine("The min number is: {0}", listaaa[0]);
        Console.ReadLine();
    }
}

