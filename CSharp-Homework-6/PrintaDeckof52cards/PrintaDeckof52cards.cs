//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
//output
//2♣ 2♦ 2♥ 2♠
//3♣ 3♦ 3♥ 3♠
//…
//K♣ K♦ K♥ K♠
//A♣ A♦ A♥ A♠


using System;

class PrintaDeckof52cards
{
    static void Main()
    {
        // 2, 3, 4, 5, 6, 7, 8, 9, 10, J, D, K, A
        char clubs = '\u2663';
        char diamonds = '\u2666';
        char hearts = '\u2665';
        char spades = '\u2660';
        for (int i = 2; i < 11; i++)
        {
            switch (i)
            {
                case 2:
                    Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", i, clubs, diamonds, hearts, spades);
                    break;
                case 3:
                    Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", i, clubs, diamonds, hearts, spades);
                    break;
                case 4:
                    Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", i, clubs, diamonds, hearts, spades);
                    break;
                case 5:
                    Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", i, clubs, diamonds, hearts, spades);
                    break;
                case 6:
                    Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", i, clubs, diamonds, hearts, spades);
                    break;
                case 7:
                    Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", i, clubs, diamonds, hearts, spades);
                    break;
                case 8:
                    Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", i, clubs, diamonds, hearts, spades);
                    break;
                case 9:
                    Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", i, clubs, diamonds, hearts, spades);
                    break;
                case 10:
                    Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", i, clubs, diamonds, hearts, spades);
                    break;

            }
        }
        Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", "J", clubs, diamonds, hearts, spades);
        Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", "D", clubs, diamonds, hearts, spades);
        Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", "K", clubs, diamonds, hearts, spades);
        Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", "A", clubs, diamonds, hearts, spades);
        Console.ReadLine();
        //2, 3, 4, 5, 6, 7, 8, 9, 10, J, D, K, A

    }
}

