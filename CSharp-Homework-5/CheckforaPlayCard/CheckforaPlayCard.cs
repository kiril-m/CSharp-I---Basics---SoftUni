//Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
//character	Valid card sign?
//5	        yes
//1	        no
//Q	        yes
//q	        no
//P	        no
//10	    yes
//500	    no


using System;

class CheckforaPlayCard
{
    static void Main()
    {
        Console.Write("Please, enter a card symbol: ");
        string card = Console.ReadLine();
        if (card == "2" | card == "3" | card == "4" | card == "5" | card == "6" | card == "7" | card == "8" | card == "9" | card == "10" | card == "J" | card == "Q" | card == "K" | card == "A")
        {
            Console.WriteLine("yes");
        }
        else Console.WriteLine("no");
        Console.ReadLine();
    }
}

