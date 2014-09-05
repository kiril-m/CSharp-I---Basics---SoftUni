//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:
//numbers	number as words
//0	Zero
//9	Nine
//10	Ten
//12	Twelve
//19	Nineteen
//25	Twenty five
//98	Ninety eight
//273	Two hundred and seventy three
//400	Four hundred
//501	Five hundred and one
//617	Six hundred and seventeen
//711	Seven hundred and eleven
//999	Nine hundred and ninety nine

//pretty sure there is a much smarter way of doing this - but this one is only one I could come up with :)

using System;

class NumberasWords
{
    static void Main()
    {
  
    start:
        Console.Write("Please, enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 999 || number < 0)
        {
            Console.WriteLine("The number needs to be between 0 and 999. Try again!");
            goto start;
        }

        string input = number.ToString();
        string[] number0to9 = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] number10to19 = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] number20to90 = new string[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };
        string[] number100to900 = new string[] { "one hundred", "two hundred", "three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred" };


        int cases0to9 = number;
        switch (cases0to9)
        {
            case 0:
                Console.WriteLine(number0to9[0]);
                break;
            case 1:
                Console.WriteLine(number0to9[1]);
                break;
            case 2:
                Console.WriteLine(number0to9[2]);
                break;
            case 3:
                Console.WriteLine(number0to9[3]);
                break;
            case 4:
                Console.WriteLine(number0to9[4]);
                break;
            case 5:
                Console.WriteLine(number0to9[5]);
                break;
            case 6:
                Console.WriteLine(number0to9[6]);
                break;
            case 7:
                Console.WriteLine(number0to9[7]);
                break;
            case 8:
                Console.WriteLine(number0to9[8]);
                break;
            case 9:
                Console.WriteLine(number0to9[9]);
                break;
        }



        if (number > 9 && number < 20)
        {
            int cases10to19 = number;

            switch (cases10to19)
            {
                case 10:
                    Console.WriteLine(number10to19[0]);
                    break;
                case 11:
                    Console.WriteLine(number10to19[1]);
                    break;
                case 12:
                    Console.WriteLine(number10to19[2]);
                    break;
                case 13:
                    Console.WriteLine(number10to19[3]);
                    break;
                case 14:
                    Console.WriteLine(number10to19[4]);
                    break;
                case 15:
                    Console.WriteLine(number10to19[5]);
                    break;
                case 16:
                    Console.WriteLine(number10to19[6]);
                    break;
                case 17:
                    Console.WriteLine(number10to19[7]);
                    break;
                case 18:
                    Console.WriteLine(number10to19[8]);
                    break;
                case 19:
                    Console.WriteLine(number10to19[9]);
                    break;
            }
        }

        if (number > 19 && number < 100 && number % 10 != 0)
        {
            int seconddigit = int.Parse(input.Substring(input.Length - 2, 1));
            int firstdigit = int.Parse(input.Substring(input.Length - 1, 1));
            switch (seconddigit)
            {
                case 2:
                    Console.Write(number20to90[0]);
                    switch (firstdigit)
                    {
                        case 1:
                            Console.Write(" {0}", number0to9[1]);
                            break;
                        case 2:
                            Console.Write(" {0}", number0to9[2]);
                            break;
                        case 3:
                            Console.Write(" {0}", number0to9[3]);
                            break;
                        case 4:
                            Console.Write(" {0}", number0to9[4]);
                            break;
                        case 5:
                            Console.Write(" {0}", number0to9[5]);
                            break;
                        case 6:
                            Console.Write(" {0}", number0to9[6]);
                            break;
                        case 7:
                            Console.Write(" {0}", number0to9[7]);
                            break;
                        case 8:
                            Console.Write(" {0}", number0to9[8]);
                            break;
                        case 9:
                            Console.Write(" {0}", number0to9[9]);
                            break;

                        default:
                            break;
                    }
                    break;
                case 3:
                    Console.Write(number20to90[1]);
                    switch (firstdigit)
                    {
                        case 1:
                            Console.Write(" {0}", number0to9[1]);
                            break;
                        case 2:
                            Console.Write(" {0}", number0to9[2]);
                            break;
                        case 3:
                            Console.Write(" {0}", number0to9[3]);
                            break;
                        case 4:
                            Console.Write(" {0}", number0to9[4]);
                            break;
                        case 5:
                            Console.Write(" {0}", number0to9[5]);
                            break;
                        case 6:
                            Console.Write(" {0}", number0to9[6]);
                            break;
                        case 7:
                            Console.Write(" {0}", number0to9[7]);
                            break;
                        case 8:
                            Console.Write(" {0}", number0to9[8]);
                            break;
                        case 9:
                            Console.Write(" {0}", number0to9[9]);
                            break;

                        default:
                            break;
                    }
                    break;
                case 4:
                    Console.Write(number20to90[2]);
                    switch (firstdigit)
                    {
                        case 1:
                            Console.Write(" {0}", number0to9[1]);
                            break;
                        case 2:
                            Console.Write(" {0}", number0to9[2]);
                            break;
                        case 3:
                            Console.Write(" {0}", number0to9[3]);
                            break;
                        case 4:
                            Console.Write(" {0}", number0to9[4]);
                            break;
                        case 5:
                            Console.Write(" {0}", number0to9[5]);
                            break;
                        case 6:
                            Console.Write(" {0}", number0to9[6]);
                            break;
                        case 7:
                            Console.Write(" {0}", number0to9[7]);
                            break;
                        case 8:
                            Console.Write(" {0}", number0to9[8]);
                            break;
                        case 9:
                            Console.Write(" {0}", number0to9[9]);
                            break;

                        default:
                            break;
                    }
                    break;
                case 5:
                    Console.Write(number20to90[3]);
                    switch (firstdigit)
                    {
                        case 1:
                            Console.Write(" {0}", number0to9[1]);
                            break;
                        case 2:
                            Console.Write(" {0}", number0to9[2]);
                            break;
                        case 3:
                            Console.Write(" {0}", number0to9[3]);
                            break;
                        case 4:
                            Console.Write(" {0}", number0to9[4]);
                            break;
                        case 5:
                            Console.Write(" {0}", number0to9[5]);
                            break;
                        case 6:
                            Console.Write(" {0}", number0to9[6]);
                            break;
                        case 7:
                            Console.Write(" {0}", number0to9[7]);
                            break;
                        case 8:
                            Console.Write(" {0}", number0to9[8]);
                            break;
                        case 9:
                            Console.Write(" {0}", number0to9[9]);
                            break;

                        default:
                            break;
                    }
                    break;
                case 6:
                    Console.Write(number20to90[4]);
                    switch (firstdigit)
                    {
                        case 1:
                            Console.Write(" {0}", number0to9[1]);
                            break;
                        case 2:
                            Console.Write(" {0}", number0to9[2]);
                            break;
                        case 3:
                            Console.Write(" {0}", number0to9[3]);
                            break;
                        case 4:
                            Console.Write(" {0}", number0to9[4]);
                            break;
                        case 5:
                            Console.Write(" {0}", number0to9[5]);
                            break;
                        case 6:
                            Console.Write(" {0}", number0to9[6]);
                            break;
                        case 7:
                            Console.Write(" {0}", number0to9[7]);
                            break;
                        case 8:
                            Console.Write(" {0}", number0to9[8]);
                            break;
                        case 9:
                            Console.Write(" {0}", number0to9[9]);
                            break;

                        default:
                            break;
                    }
                    break;
                case 7:
                    Console.Write(number20to90[5]);
                    switch (firstdigit)
                    {
                        case 1:
                            Console.Write(" {0}", number0to9[1]);
                            break;
                        case 2:
                            Console.Write(" {0}", number0to9[2]);
                            break;
                        case 3:
                            Console.Write(" {0}", number0to9[3]);
                            break;
                        case 4:
                            Console.Write(" {0}", number0to9[4]);
                            break;
                        case 5:
                            Console.Write(" {0}", number0to9[5]);
                            break;
                        case 6:
                            Console.Write(" {0}", number0to9[6]);
                            break;
                        case 7:
                            Console.Write(" {0}", number0to9[7]);
                            break;
                        case 8:
                            Console.Write(" {0}", number0to9[8]);
                            break;
                        case 9:
                            Console.Write(" {0}", number0to9[9]);
                            break;

                        default:
                            break;
                    }
                    break;
                case 8:
                    Console.Write(number20to90[6]);
                    switch (firstdigit)
                    {
                        case 1:
                            Console.Write(" {0}", number0to9[1]);
                            break;
                        case 2:
                            Console.Write(" {0}", number0to9[2]);
                            break;
                        case 3:
                            Console.Write(" {0}", number0to9[3]);
                            break;
                        case 4:
                            Console.Write(" {0}", number0to9[4]);
                            break;
                        case 5:
                            Console.Write(" {0}", number0to9[5]);
                            break;
                        case 6:
                            Console.Write(" {0}", number0to9[6]);
                            break;
                        case 7:
                            Console.Write(" {0}", number0to9[7]);
                            break;
                        case 8:
                            Console.Write(" {0}", number0to9[8]);
                            break;
                        case 9:
                            Console.Write(" {0}", number0to9[9]);
                            break;

                        default:
                            break;
                    }
                    break;
                case 9:
                    Console.Write(number20to90[7]);
                    switch (firstdigit)
                    {
                        case 1:
                            Console.Write(" {0}", number0to9[1]);
                            break;
                        case 2:
                            Console.Write(" {0}", number0to9[2]);
                            break;
                        case 3:
                            Console.Write(" {0}", number0to9[3]);
                            break;
                        case 4:
                            Console.Write(" {0}", number0to9[4]);
                            break;
                        case 5:
                            Console.Write(" {0}", number0to9[5]);
                            break;
                        case 6:
                            Console.Write(" {0}", number0to9[6]);
                            break;
                        case 7:
                            Console.Write(" {0}", number0to9[7]);
                            break;
                        case 8:
                            Console.Write(" {0}", number0to9[8]);
                            break;
                        case 9:
                            Console.Write(" {0}", number0to9[9]);
                            break;

                        default:
                            break;
                    }
                    break;
                default:
                    break;

            }
        }
        if (number > 99 && number < 999 && number % 100 == 0)
        {
            int cases100to900 = number;

            switch (cases100to900)
            {
                case 100:
                    Console.WriteLine(number100to900[0]);
                    break;
                case 200:
                    Console.WriteLine(number100to900[1]);
                    break;
                case 300:
                    Console.WriteLine(number100to900[2]);
                    break;
                case 400:
                    Console.WriteLine(number100to900[3]);
                    break;
                case 500:
                    Console.WriteLine(number100to900[4]);
                    break;
                case 600:
                    Console.WriteLine(number100to900[5]);
                    break;
                case 700:
                    Console.WriteLine(number100to900[6]);
                    break;
                case 800:
                    Console.WriteLine(number100to900[7]);
                    break;
                case 900:
                    Console.WriteLine(number100to900[8]);
                    break;
            }
        }
        if (number > 100 && number < 999 && number % 100 != 0)
        {
            int thirddigit = int.Parse(input.Substring(input.Length - 3, 1));
            int seconddigit = int.Parse(input.Substring(input.Length - 2, 1));
            int firstdigit = int.Parse(input.Substring(input.Length - 1, 1));
            if (thirddigit == 1)
            {
                Console.Write("{0} and ", number100to900[0]);
                if (number % 100 > 0 && number % 100 < 10)
                {
                    int cases0to9forhundreds = number % 100;
                    switch (cases0to9forhundreds)
                    {

                        case 1:
                            Console.WriteLine(number0to9[1]);
                            break;
                        case 2:
                            Console.WriteLine(number0to9[2]);
                            break;
                        case 3:
                            Console.WriteLine(number0to9[3]);
                            break;
                        case 4:
                            Console.WriteLine(number0to9[4]);
                            break;
                        case 5:
                            Console.WriteLine(number0to9[5]);
                            break;
                        case 6:
                            Console.WriteLine(number0to9[6]);
                            break;
                        case 7:
                            Console.WriteLine(number0to9[7]);
                            break;
                        case 8:
                            Console.WriteLine(number0to9[8]);
                            break;
                        case 9:
                            Console.WriteLine(number0to9[9]);
                            break;
                    }
                }
                if (number % 100 > 10 && number % 100 < 20)
                {
                    int cases10to19 = number % 100;

                    switch (cases10to19)
                    {
                        case 10:
                            Console.WriteLine(number10to19[0]);
                            break;
                        case 11:
                            Console.WriteLine(number10to19[1]);
                            break;
                        case 12:
                            Console.WriteLine(number10to19[2]);
                            break;
                        case 13:
                            Console.WriteLine(number10to19[3]);
                            break;
                        case 14:
                            Console.WriteLine(number10to19[4]);
                            break;
                        case 15:
                            Console.WriteLine(number10to19[5]);
                            break;
                        case 16:
                            Console.WriteLine(number10to19[6]);
                            break;
                        case 17:
                            Console.WriteLine(number10to19[7]);
                            break;
                        case 18:
                            Console.WriteLine(number10to19[8]);
                            break;
                        case 19:
                            Console.WriteLine(number10to19[9]);
                            break;
                    }
                }
                if (number % 100 > 20 && number % 100 < 100)
                {
                    switch (seconddigit)
                    {
                        case 2:
                            Console.Write(number20to90[0]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write(number20to90[1]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 4:
                            Console.Write(number20to90[2]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 5:
                            Console.Write(number20to90[3]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 6:
                            Console.Write(number20to90[4]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 7:
                            Console.Write(number20to90[5]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 8:
                            Console.Write(number20to90[6]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 9:
                            Console.Write(number20to90[7]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;

                    }
                }
            }

        }

        if (number > 100 && number < 999 && number % 100 != 0)
        {
            int thirddigit = int.Parse(input.Substring(input.Length - 3, 1));
            int seconddigit = int.Parse(input.Substring(input.Length - 2, 1));
            int firstdigit = int.Parse(input.Substring(input.Length - 1, 1));
            if (thirddigit == 2)
            {
                Console.Write("{0} and ", number100to900[1]);
                if (number % 100 > 0 && number % 100 < 10)
                {
                    int cases0to9forhundreds = number % 100;
                    switch (cases0to9forhundreds)
                    {

                        case 1:
                            Console.WriteLine(number0to9[1]);
                            break;
                        case 2:
                            Console.WriteLine(number0to9[2]);
                            break;
                        case 3:
                            Console.WriteLine(number0to9[3]);
                            break;
                        case 4:
                            Console.WriteLine(number0to9[4]);
                            break;
                        case 5:
                            Console.WriteLine(number0to9[5]);
                            break;
                        case 6:
                            Console.WriteLine(number0to9[6]);
                            break;
                        case 7:
                            Console.WriteLine(number0to9[7]);
                            break;
                        case 8:
                            Console.WriteLine(number0to9[8]);
                            break;
                        case 9:
                            Console.WriteLine(number0to9[9]);
                            break;
                    }
                }
                if (number % 100 > 10 && number % 100 < 20)
                {
                    int cases10to19 = number % 100;

                    switch (cases10to19)
                    {
                        case 10:
                            Console.WriteLine(number10to19[0]);
                            break;
                        case 11:
                            Console.WriteLine(number10to19[1]);
                            break;
                        case 12:
                            Console.WriteLine(number10to19[2]);
                            break;
                        case 13:
                            Console.WriteLine(number10to19[3]);
                            break;
                        case 14:
                            Console.WriteLine(number10to19[4]);
                            break;
                        case 15:
                            Console.WriteLine(number10to19[5]);
                            break;
                        case 16:
                            Console.WriteLine(number10to19[6]);
                            break;
                        case 17:
                            Console.WriteLine(number10to19[7]);
                            break;
                        case 18:
                            Console.WriteLine(number10to19[8]);
                            break;
                        case 19:
                            Console.WriteLine(number10to19[9]);
                            break;
                    }
                }
                if (number % 100 > 20 && number % 100 < 100)
                {
                    switch (seconddigit)
                    {
                        case 2:
                            Console.Write(number20to90[0]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write(number20to90[1]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 4:
                            Console.Write(number20to90[2]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 5:
                            Console.Write(number20to90[3]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 6:
                            Console.Write(number20to90[4]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 7:
                            Console.Write(number20to90[5]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 8:
                            Console.Write(number20to90[6]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 9:
                            Console.Write(number20to90[7]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;

                    }
                }
            }

        }


        if (number > 100 && number < 999 && number % 100 != 0)
        {
            int thirddigit = int.Parse(input.Substring(input.Length - 3, 1));
            int seconddigit = int.Parse(input.Substring(input.Length - 2, 1));
            int firstdigit = int.Parse(input.Substring(input.Length - 1, 1));
            if (thirddigit == 3)
            {
                Console.Write("{0} and ", number100to900[2]);
                if (number % 100 > 0 && number % 100 < 10)
                {
                    int cases0to9forhundreds = number % 100;
                    switch (cases0to9forhundreds)
                    {

                        case 1:
                            Console.WriteLine(number0to9[1]);
                            break;
                        case 2:
                            Console.WriteLine(number0to9[2]);
                            break;
                        case 3:
                            Console.WriteLine(number0to9[3]);
                            break;
                        case 4:
                            Console.WriteLine(number0to9[4]);
                            break;
                        case 5:
                            Console.WriteLine(number0to9[5]);
                            break;
                        case 6:
                            Console.WriteLine(number0to9[6]);
                            break;
                        case 7:
                            Console.WriteLine(number0to9[7]);
                            break;
                        case 8:
                            Console.WriteLine(number0to9[8]);
                            break;
                        case 9:
                            Console.WriteLine(number0to9[9]);
                            break;
                    }
                }
                if (number % 100 > 10 && number % 100 < 20)
                {
                    int cases10to19 = number % 100;

                    switch (cases10to19)
                    {
                        case 10:
                            Console.WriteLine(number10to19[0]);
                            break;
                        case 11:
                            Console.WriteLine(number10to19[1]);
                            break;
                        case 12:
                            Console.WriteLine(number10to19[2]);
                            break;
                        case 13:
                            Console.WriteLine(number10to19[3]);
                            break;
                        case 14:
                            Console.WriteLine(number10to19[4]);
                            break;
                        case 15:
                            Console.WriteLine(number10to19[5]);
                            break;
                        case 16:
                            Console.WriteLine(number10to19[6]);
                            break;
                        case 17:
                            Console.WriteLine(number10to19[7]);
                            break;
                        case 18:
                            Console.WriteLine(number10to19[8]);
                            break;
                        case 19:
                            Console.WriteLine(number10to19[9]);
                            break;
                    }
                }
                if (number % 100 > 20 && number % 100 < 100)
                {
                    switch (seconddigit)
                    {
                        case 2:
                            Console.Write(number20to90[0]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write(number20to90[1]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 4:
                            Console.Write(number20to90[2]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 5:
                            Console.Write(number20to90[3]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 6:
                            Console.Write(number20to90[4]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 7:
                            Console.Write(number20to90[5]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 8:
                            Console.Write(number20to90[6]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 9:
                            Console.Write(number20to90[7]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;

                    }
                }
            }

        }


        if (number > 100 && number < 999 && number % 100 != 0)
        {
            int thirddigit = int.Parse(input.Substring(input.Length - 3, 1));
            int seconddigit = int.Parse(input.Substring(input.Length - 2, 1));
            int firstdigit = int.Parse(input.Substring(input.Length - 1, 1));
            if (thirddigit == 4)
            {
                Console.Write("{0} and ", number100to900[3]);
                if (number % 100 > 0 && number % 100 < 10)
                {
                    int cases0to9forhundreds = number % 100;
                    switch (cases0to9forhundreds)
                    {

                        case 1:
                            Console.WriteLine(number0to9[1]);
                            break;
                        case 2:
                            Console.WriteLine(number0to9[2]);
                            break;
                        case 3:
                            Console.WriteLine(number0to9[3]);
                            break;
                        case 4:
                            Console.WriteLine(number0to9[4]);
                            break;
                        case 5:
                            Console.WriteLine(number0to9[5]);
                            break;
                        case 6:
                            Console.WriteLine(number0to9[6]);
                            break;
                        case 7:
                            Console.WriteLine(number0to9[7]);
                            break;
                        case 8:
                            Console.WriteLine(number0to9[8]);
                            break;
                        case 9:
                            Console.WriteLine(number0to9[9]);
                            break;
                    }
                }
                if (number % 100 > 10 && number % 100 < 20)
                {
                    int cases10to19 = number % 100;

                    switch (cases10to19)
                    {
                        case 10:
                            Console.WriteLine(number10to19[0]);
                            break;
                        case 11:
                            Console.WriteLine(number10to19[1]);
                            break;
                        case 12:
                            Console.WriteLine(number10to19[2]);
                            break;
                        case 13:
                            Console.WriteLine(number10to19[3]);
                            break;
                        case 14:
                            Console.WriteLine(number10to19[4]);
                            break;
                        case 15:
                            Console.WriteLine(number10to19[5]);
                            break;
                        case 16:
                            Console.WriteLine(number10to19[6]);
                            break;
                        case 17:
                            Console.WriteLine(number10to19[7]);
                            break;
                        case 18:
                            Console.WriteLine(number10to19[8]);
                            break;
                        case 19:
                            Console.WriteLine(number10to19[9]);
                            break;
                    }
                }
                if (number % 100 > 20 && number % 100 < 100)
                {
                    switch (seconddigit)
                    {
                        case 2:
                            Console.Write(number20to90[0]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write(number20to90[1]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 4:
                            Console.Write(number20to90[2]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 5:
                            Console.Write(number20to90[3]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 6:
                            Console.Write(number20to90[4]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 7:
                            Console.Write(number20to90[5]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 8:
                            Console.Write(number20to90[6]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 9:
                            Console.Write(number20to90[7]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;

                    }
                }
            }

        }


        if (number > 100 && number < 999 && number % 100 != 0)
        {
            int thirddigit = int.Parse(input.Substring(input.Length - 3, 1));
            int seconddigit = int.Parse(input.Substring(input.Length - 2, 1));
            int firstdigit = int.Parse(input.Substring(input.Length - 1, 1));
            if (thirddigit == 5)
            {
                Console.Write("{0} and ", number100to900[4]);
                if (number % 100 > 0 && number % 100 < 10)
                {
                    int cases0to9forhundreds = number % 100;
                    switch (cases0to9forhundreds)
                    {

                        case 1:
                            Console.WriteLine(number0to9[1]);
                            break;
                        case 2:
                            Console.WriteLine(number0to9[2]);
                            break;
                        case 3:
                            Console.WriteLine(number0to9[3]);
                            break;
                        case 4:
                            Console.WriteLine(number0to9[4]);
                            break;
                        case 5:
                            Console.WriteLine(number0to9[5]);
                            break;
                        case 6:
                            Console.WriteLine(number0to9[6]);
                            break;
                        case 7:
                            Console.WriteLine(number0to9[7]);
                            break;
                        case 8:
                            Console.WriteLine(number0to9[8]);
                            break;
                        case 9:
                            Console.WriteLine(number0to9[9]);
                            break;
                    }
                }
                if (number % 100 > 10 && number % 100 < 20)
                {
                    int cases10to19 = number % 100;

                    switch (cases10to19)
                    {
                        case 10:
                            Console.WriteLine(number10to19[0]);
                            break;
                        case 11:
                            Console.WriteLine(number10to19[1]);
                            break;
                        case 12:
                            Console.WriteLine(number10to19[2]);
                            break;
                        case 13:
                            Console.WriteLine(number10to19[3]);
                            break;
                        case 14:
                            Console.WriteLine(number10to19[4]);
                            break;
                        case 15:
                            Console.WriteLine(number10to19[5]);
                            break;
                        case 16:
                            Console.WriteLine(number10to19[6]);
                            break;
                        case 17:
                            Console.WriteLine(number10to19[7]);
                            break;
                        case 18:
                            Console.WriteLine(number10to19[8]);
                            break;
                        case 19:
                            Console.WriteLine(number10to19[9]);
                            break;
                    }
                }
                if (number % 100 > 20 && number % 100 < 100)
                {
                    switch (seconddigit)
                    {
                        case 2:
                            Console.Write(number20to90[0]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write(number20to90[1]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 4:
                            Console.Write(number20to90[2]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 5:
                            Console.Write(number20to90[3]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 6:
                            Console.Write(number20to90[4]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 7:
                            Console.Write(number20to90[5]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 8:
                            Console.Write(number20to90[6]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 9:
                            Console.Write(number20to90[7]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;

                    }
                }
            }

        }


        if (number > 100 && number < 999 && number % 100 != 0)
        {
            int thirddigit = int.Parse(input.Substring(input.Length - 3, 1));
            int seconddigit = int.Parse(input.Substring(input.Length - 2, 1));
            int firstdigit = int.Parse(input.Substring(input.Length - 1, 1));
            if (thirddigit == 6)
            {
                Console.Write("{0} and ", number100to900[5]);
                if (number % 100 > 0 && number % 100 < 10)
                {
                    int cases0to9forhundreds = number % 100;
                    switch (cases0to9forhundreds)
                    {

                        case 1:
                            Console.WriteLine(number0to9[1]);
                            break;
                        case 2:
                            Console.WriteLine(number0to9[2]);
                            break;
                        case 3:
                            Console.WriteLine(number0to9[3]);
                            break;
                        case 4:
                            Console.WriteLine(number0to9[4]);
                            break;
                        case 5:
                            Console.WriteLine(number0to9[5]);
                            break;
                        case 6:
                            Console.WriteLine(number0to9[6]);
                            break;
                        case 7:
                            Console.WriteLine(number0to9[7]);
                            break;
                        case 8:
                            Console.WriteLine(number0to9[8]);
                            break;
                        case 9:
                            Console.WriteLine(number0to9[9]);
                            break;
                    }
                }
                if (number % 100 > 10 && number % 100 < 20)
                {
                    int cases10to19 = number % 100;

                    switch (cases10to19)
                    {
                        case 10:
                            Console.WriteLine(number10to19[0]);
                            break;
                        case 11:
                            Console.WriteLine(number10to19[1]);
                            break;
                        case 12:
                            Console.WriteLine(number10to19[2]);
                            break;
                        case 13:
                            Console.WriteLine(number10to19[3]);
                            break;
                        case 14:
                            Console.WriteLine(number10to19[4]);
                            break;
                        case 15:
                            Console.WriteLine(number10to19[5]);
                            break;
                        case 16:
                            Console.WriteLine(number10to19[6]);
                            break;
                        case 17:
                            Console.WriteLine(number10to19[7]);
                            break;
                        case 18:
                            Console.WriteLine(number10to19[8]);
                            break;
                        case 19:
                            Console.WriteLine(number10to19[9]);
                            break;
                    }
                }
                if (number % 100 > 20 && number % 100 < 100)
                {
                    switch (seconddigit)
                    {
                        case 2:
                            Console.Write(number20to90[0]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write(number20to90[1]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 4:
                            Console.Write(number20to90[2]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 5:
                            Console.Write(number20to90[3]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 6:
                            Console.Write(number20to90[4]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 7:
                            Console.Write(number20to90[5]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 8:
                            Console.Write(number20to90[6]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 9:
                            Console.Write(number20to90[7]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;

                    }
                }
            }

        }


        if (number > 100 && number < 999 && number % 100 != 0)
        {
            int thirddigit = int.Parse(input.Substring(input.Length - 3, 1));
            int seconddigit = int.Parse(input.Substring(input.Length - 2, 1));
            int firstdigit = int.Parse(input.Substring(input.Length - 1, 1));
            if (thirddigit == 7)
            {
                Console.Write("{0} and ", number100to900[6]);
                if (number % 100 > 0 && number % 100 < 10)
                {
                    int cases0to9forhundreds = number % 100;
                    switch (cases0to9forhundreds)
                    {

                        case 1:
                            Console.WriteLine(number0to9[1]);
                            break;
                        case 2:
                            Console.WriteLine(number0to9[2]);
                            break;
                        case 3:
                            Console.WriteLine(number0to9[3]);
                            break;
                        case 4:
                            Console.WriteLine(number0to9[4]);
                            break;
                        case 5:
                            Console.WriteLine(number0to9[5]);
                            break;
                        case 6:
                            Console.WriteLine(number0to9[6]);
                            break;
                        case 7:
                            Console.WriteLine(number0to9[7]);
                            break;
                        case 8:
                            Console.WriteLine(number0to9[8]);
                            break;
                        case 9:
                            Console.WriteLine(number0to9[9]);
                            break;
                    }
                }
                if (number % 100 > 10 && number % 100 < 20)
                {
                    int cases10to19 = number % 100;

                    switch (cases10to19)
                    {
                        case 10:
                            Console.WriteLine(number10to19[0]);
                            break;
                        case 11:
                            Console.WriteLine(number10to19[1]);
                            break;
                        case 12:
                            Console.WriteLine(number10to19[2]);
                            break;
                        case 13:
                            Console.WriteLine(number10to19[3]);
                            break;
                        case 14:
                            Console.WriteLine(number10to19[4]);
                            break;
                        case 15:
                            Console.WriteLine(number10to19[5]);
                            break;
                        case 16:
                            Console.WriteLine(number10to19[6]);
                            break;
                        case 17:
                            Console.WriteLine(number10to19[7]);
                            break;
                        case 18:
                            Console.WriteLine(number10to19[8]);
                            break;
                        case 19:
                            Console.WriteLine(number10to19[9]);
                            break;
                    }
                }
                if (number % 100 > 20 && number % 100 < 100)
                {
                    switch (seconddigit)
                    {
                        case 2:
                            Console.Write(number20to90[0]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write(number20to90[1]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 4:
                            Console.Write(number20to90[2]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 5:
                            Console.Write(number20to90[3]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 6:
                            Console.Write(number20to90[4]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 7:
                            Console.Write(number20to90[5]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 8:
                            Console.Write(number20to90[6]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 9:
                            Console.Write(number20to90[7]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;

                    }
                }
            }

        }


        if (number > 100 && number < 999 && number % 100 != 0)
        {
            int thirddigit = int.Parse(input.Substring(input.Length - 3, 1));
            int seconddigit = int.Parse(input.Substring(input.Length - 2, 1));
            int firstdigit = int.Parse(input.Substring(input.Length - 1, 1));
            if (thirddigit == 8)
            {
                Console.Write("{0} and ", number100to900[7]);
                if (number % 100 > 0 && number % 100 < 10)
                {
                    int cases0to9forhundreds = number % 100;
                    switch (cases0to9forhundreds)
                    {

                        case 1:
                            Console.WriteLine(number0to9[1]);
                            break;
                        case 2:
                            Console.WriteLine(number0to9[2]);
                            break;
                        case 3:
                            Console.WriteLine(number0to9[3]);
                            break;
                        case 4:
                            Console.WriteLine(number0to9[4]);
                            break;
                        case 5:
                            Console.WriteLine(number0to9[5]);
                            break;
                        case 6:
                            Console.WriteLine(number0to9[6]);
                            break;
                        case 7:
                            Console.WriteLine(number0to9[7]);
                            break;
                        case 8:
                            Console.WriteLine(number0to9[8]);
                            break;
                        case 9:
                            Console.WriteLine(number0to9[9]);
                            break;
                    }
                }
                if (number % 100 > 10 && number % 100 < 20)
                {
                    int cases10to19 = number % 100;

                    switch (cases10to19)
                    {
                        case 10:
                            Console.WriteLine(number10to19[0]);
                            break;
                        case 11:
                            Console.WriteLine(number10to19[1]);
                            break;
                        case 12:
                            Console.WriteLine(number10to19[2]);
                            break;
                        case 13:
                            Console.WriteLine(number10to19[3]);
                            break;
                        case 14:
                            Console.WriteLine(number10to19[4]);
                            break;
                        case 15:
                            Console.WriteLine(number10to19[5]);
                            break;
                        case 16:
                            Console.WriteLine(number10to19[6]);
                            break;
                        case 17:
                            Console.WriteLine(number10to19[7]);
                            break;
                        case 18:
                            Console.WriteLine(number10to19[8]);
                            break;
                        case 19:
                            Console.WriteLine(number10to19[9]);
                            break;
                    }
                }
                if (number % 100 > 20 && number % 100 < 100)
                {
                    switch (seconddigit)
                    {
                        case 2:
                            Console.Write(number20to90[0]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write(number20to90[1]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 4:
                            Console.Write(number20to90[2]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 5:
                            Console.Write(number20to90[3]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 6:
                            Console.Write(number20to90[4]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 7:
                            Console.Write(number20to90[5]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 8:
                            Console.Write(number20to90[6]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 9:
                            Console.Write(number20to90[7]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;

                    }
                }
            }

        }


        if (number > 100 && number < 1000 && number % 100 != 0)
        {
            int thirddigit = int.Parse(input.Substring(input.Length - 3, 1));
            int seconddigit = int.Parse(input.Substring(input.Length - 2, 1));
            int firstdigit = int.Parse(input.Substring(input.Length - 1, 1));
            if (thirddigit == 9)
            {
                Console.Write("{0} and ", number100to900[8]);
                if (number % 100 > 0 && number % 100 < 10)
                {
                    int cases0to9forhundreds = number % 100;
                    switch (cases0to9forhundreds)
                    {

                        case 1:
                            Console.WriteLine(number0to9[1]);
                            break;
                        case 2:
                            Console.WriteLine(number0to9[2]);
                            break;
                        case 3:
                            Console.WriteLine(number0to9[3]);
                            break;
                        case 4:
                            Console.WriteLine(number0to9[4]);
                            break;
                        case 5:
                            Console.WriteLine(number0to9[5]);
                            break;
                        case 6:
                            Console.WriteLine(number0to9[6]);
                            break;
                        case 7:
                            Console.WriteLine(number0to9[7]);
                            break;
                        case 8:
                            Console.WriteLine(number0to9[8]);
                            break;
                        case 9:
                            Console.WriteLine(number0to9[9]);
                            break;
                    }
                }
                if (number % 100 > 10 && number % 100 < 20)
                {
                    int cases10to19 = number % 100;

                    switch (cases10to19)
                    {
                        case 10:
                            Console.WriteLine(number10to19[0]);
                            break;
                        case 11:
                            Console.WriteLine(number10to19[1]);
                            break;
                        case 12:
                            Console.WriteLine(number10to19[2]);
                            break;
                        case 13:
                            Console.WriteLine(number10to19[3]);
                            break;
                        case 14:
                            Console.WriteLine(number10to19[4]);
                            break;
                        case 15:
                            Console.WriteLine(number10to19[5]);
                            break;
                        case 16:
                            Console.WriteLine(number10to19[6]);
                            break;
                        case 17:
                            Console.WriteLine(number10to19[7]);
                            break;
                        case 18:
                            Console.WriteLine(number10to19[8]);
                            break;
                        case 19:
                            Console.WriteLine(number10to19[9]);
                            break;
                    }
                }
                if (number % 100 > 20 && number % 100 < 100)
                {
                    switch (seconddigit)
                    {
                        case 2:
                            Console.Write(number20to90[0]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write(number20to90[1]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 4:
                            Console.Write(number20to90[2]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 5:
                            Console.Write(number20to90[3]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 6:
                            Console.Write(number20to90[4]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 7:
                            Console.Write(number20to90[5]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 8:
                            Console.Write(number20to90[6]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                        case 9:
                            Console.Write(number20to90[7]);
                            switch (firstdigit)
                            {
                                case 1:
                                    Console.Write(" {0}", number0to9[1]);
                                    break;
                                case 2:
                                    Console.Write(" {0}", number0to9[2]);
                                    break;
                                case 3:
                                    Console.Write(" {0}", number0to9[3]);
                                    break;
                                case 4:
                                    Console.Write(" {0}", number0to9[4]);
                                    break;
                                case 5:
                                    Console.Write(" {0}", number0to9[5]);
                                    break;
                                case 6:
                                    Console.Write(" {0}", number0to9[6]);
                                    break;
                                case 7:
                                    Console.Write(" {0}", number0to9[7]);
                                    break;
                                case 8:
                                    Console.Write(" {0}", number0to9[8]);
                                    break;
                                case 9:
                                    Console.Write(" {0}", number0to9[9]);
                                    break;

                                default:
                                    break;
                            }
                            break;
                    }
                }
            }

        }

        Console.ReadLine();
        goto start;
    }
}

