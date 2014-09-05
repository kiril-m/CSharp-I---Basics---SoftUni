//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. Examples:
//numbers	    sum		numbers	        sum		numbers	            sum
//1 2 3 4 5	    15		10 10 10 10 10	50		1.5 3.14 8.2 -1 0	11.84


using System;

class FivenumbersSum
{
    static void Main()
    {

        Console.Write("Please, enter the list of 5 numbers, separated by blankspace : ");
        string input = Console.ReadLine();
        int numberofchars = input.Length;
        string empty = " ";

        Console.WriteLine("So here are actually the numbers we will be summing up: ");

        int firstnumberlength = input.IndexOf(empty);
        string firstnumber = input.Substring(0, firstnumberlength);
        Console.WriteLine(firstnumber);

        string inputafter1number = input.Substring(firstnumberlength + 1, numberofchars - firstnumberlength - 1);
        int secondnumberlength = inputafter1number.IndexOf(empty);
        int numberofcharssecond = inputafter1number.Length;
        string secondnumber = inputafter1number.Substring(0, secondnumberlength);
        Console.WriteLine(secondnumber);

        string inputafter2number = inputafter1number.Substring(secondnumberlength + 1, numberofcharssecond - secondnumberlength - 1);
        int thirdnumberlength = inputafter2number.IndexOf(empty);
        int numberofcharsthird = inputafter2number.Length;
        string thirdnumber = inputafter2number.Substring(0, thirdnumberlength);
        Console.WriteLine(thirdnumber);

        string inputafter3number = inputafter2number.Substring(thirdnumberlength + 1, numberofcharsthird - thirdnumberlength - 1);
        int fourthnumberlength = inputafter3number.IndexOf(empty);
        int numberofcharsfourth = inputafter3number.Length;
        string fourthnumber = inputafter3number.Substring(0, fourthnumberlength);
        Console.WriteLine(fourthnumber);

        string inputafter4number = inputafter3number.Substring(fourthnumberlength + 1, numberofcharsfourth - fourthnumberlength - 1);
        int fifthnumberlength = inputafter4number.Length;
        int numberofcharsfifth = inputafter4number.Length;
        string fifthnumber = inputafter4number.Substring(0, fifthnumberlength);
        Console.WriteLine(fifthnumber);

        double x1 = double.Parse(firstnumber);
        double x2 = double.Parse(secondnumber);
        double x3 = double.Parse(thirdnumber);
        double x4 = double.Parse(fourthnumber);
        double x5 = double.Parse(fifthnumber);
        double sum = x1 + x2 + x3 + x4 + x5;

        Console.WriteLine("And their sum is: {0}.", sum);

        Console.ReadLine();
    }
}


