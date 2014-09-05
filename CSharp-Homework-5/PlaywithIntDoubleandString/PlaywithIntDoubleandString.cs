//Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement. Example:
//program	user		program	user
//Please choose a type:
//1 --> int
//2 --> double
//3 --> string	3		
//Please enter a string:	hello		
//hello*	


using System;

class PlaywithIntDoubleandString
{
    static void Main()
    {
        Console.WriteLine("Please, choose a type: ");
        Console.WriteLine("1--> int");
        Console.WriteLine("2--> double");
        Console.WriteLine("3--> string");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Please enter a integer number: ");
                int inputint = int.Parse(Console.ReadLine());
                Console.WriteLine(inputint+1);
                break;
            case 2:
                Console.WriteLine("Please enter a number type double: ");
                double inputdouble = double.Parse(Console.ReadLine());
                Console.WriteLine(inputdouble+1);
                break;
            case 3:
                Console.WriteLine("Please enter a string: ");
                string inputstring = Console.ReadLine();
                Console.WriteLine("{0}*",inputstring);
                break;
            default:
                break;
        }
        Console.ReadLine();
    }
}

