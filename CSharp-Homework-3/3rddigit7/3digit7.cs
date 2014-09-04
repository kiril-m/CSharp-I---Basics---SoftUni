//Write an expression that checks for given integer if its third digit from right-to-left is 7. Examples:
//n	        Third digit 7?
//5	        false
//701	    true
//9703	    true
//877	    false
//777877	false
//9999799	true


using System;

class thirddigit7
{
    static void Main()
    {
        Console.Write("Enter a number to check: ");
        int a = int.Parse(Console.ReadLine());
        if (a < 700) //the program only makes sense for numbers >= 700, so we check the input data! :) 
        {
            Console.WriteLine(false);
        }
        if (a >= 700)
        {
            string b = a.ToString();
            int numberofchars = b.Length;
            string btrimmed = b.Substring(0, numberofchars - 2);
            int aafterconversion = int.Parse(btrimmed);
            if ((aafterconversion + 3) % 10 == 0) //one way to do it(more complicated), easier would be to just check if aafterconversion%7==0 :). This is just another way to look at the problem... 
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
        }
        Console.ReadLine();
    }
}


