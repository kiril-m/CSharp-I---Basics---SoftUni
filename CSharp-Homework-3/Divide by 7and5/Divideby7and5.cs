//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. Examples:
//n	Divided by 7 and 5?
//3	false
//0	false
//5	false
//7	false
//35	true
//140	true


using System;

class Divideby7and5
{
    static void Main()
    {
        Console.Write("Please, enter a number to check if divisible by 7 and 5: ");
        int a = int.Parse(Console.ReadLine());
        if (a % 5 == 0 && a % 7 == 0)
        {
            if (a == 0)
            {
                Console.WriteLine(false);
            }
            else Console.WriteLine(true);
        }
        else Console.WriteLine(false);
        Console.ReadLine();
    }
}

