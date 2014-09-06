//You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc. Examples:
//numbers	    result
//2 1 1 6 3	    yes
//              product = 6
//3 10 4 6 5 1	yes
//              product = 60
//4 3 2 5 2	    no
//              odd_product = 16
//              even_product = 15


using System;

class OddandEvenProduct
{
    static void Main()
    {
        //to fix the names of the variables, otherwise works fine
        Console.Write("Please enter \"n\" numbers, separated by space and press \"Enter\": ");
        string input = Console.ReadLine();
        int inputlength = input.Length;
        int productodd = 1;
        int producteven = 1;

        int positionofaspace = input.IndexOf(' ');
        string number = input.Substring(0, positionofaspace);
        string newsubstring = input.Substring(number.Length + 1, (input.Length - number.Length) - 1);
        int numberasadigit = int.Parse(number);
        bool isodd = false;
        do
        {
            int secondpositionofaspace = newsubstring.IndexOf(' ');
            if (secondpositionofaspace == -1)
            {
                string lastnumber = newsubstring.Substring(0);
                int lastnumberasdigit = int.Parse(lastnumber);
                if (isodd == true)
                {
                    productodd *= lastnumberasdigit;

                }
                if (isodd != true)
                {
                    producteven *= lastnumberasdigit;
                }
                break;
            }
            string secondnumber = newsubstring.Substring(0, secondpositionofaspace);
            int nextnumberasdigit = int.Parse(secondnumber);
            if (isodd == true)
            {
                productodd *= nextnumberasdigit;
              
            }
            if (isodd != true)
            {
                producteven *= nextnumberasdigit;
            }
            newsubstring = newsubstring.Substring(secondnumber.Length + 1, (newsubstring.Length - secondnumber.Length) - 1);
            isodd = !isodd;

        } while (true);
        if (numberasadigit * productodd == producteven)
        {
            Console.WriteLine("Yes!");
            Console.WriteLine("The product of the two sets of numbers is " + (numberasadigit * productodd) + " each.");
        }
        if (numberasadigit * productodd != producteven)
        {
            Console.WriteLine("No!");
            Console.WriteLine("The product of the odd numbers are: " + numberasadigit*productodd);
            Console.WriteLine("The product of the even numbers are: " + (producteven));
        }
        Console.ReadLine();

  
    }
}

