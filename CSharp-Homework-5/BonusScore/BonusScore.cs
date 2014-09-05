//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//•	If the score is between 1 and 3, the program multiplies it by 10.
//•	If the score is between 4 and 6, the program multiplies it by 100.
//•	If the score is between 7 and 9, the program multiplies it by 1000.
//•	If the score is 0 or more than 9, the program prints “invalid score”.
//Examples:
//score	result
//2	    20
//4	    400
//9	    9000
//-1	invalid score
//10	invalid score


using System;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Please, input initial value to apply bonus: ");
        int a = int.Parse(Console.ReadLine());
        int bonus;
        if (a <= 0 | a >= 9)
        {
            Console.WriteLine("Invalid score!");
            goto outer;
        }
        Console.WriteLine("Your bonus score is: ");
        if (a >= 1 && a <= 3)
        {
            bonus = a * 10;
            Console.WriteLine(bonus);
        }
        if (a >= 4 && a <= 6)
        {
            bonus = a * 100;
            Console.WriteLine(bonus);
        }
        if (a >= 7 && a <= 9)
        {
            bonus = a * 1000;
            Console.WriteLine(bonus);
        }
        outer:
        Console.ReadLine();
    }
}

