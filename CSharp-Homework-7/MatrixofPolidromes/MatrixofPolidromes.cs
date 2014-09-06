//Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:
//Input	Output
//3 6	    aaa aba aca	ada aea afa
//        bbb bcb bdb	beb bfb bgb
//        ccc cec cdc	cfc cgc chc
//2 3	    aaa aba aca
//        bbb bcb bdb
//1 1	    aaa
//1 3	    aaa aba aca


using System;
using System.Collections.Generic;

class MatrixofPolidromes
{
    static void Main()
    {
        Console.WriteLine("Matrix of Poldromes!");
    start:
        Console.Write("Please, enter the number of rows of the matrix: ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the number of columns of the matrix: ");
        int c = int.Parse(Console.ReadLine());

        List<string> listofchars = new List<string>();
        for (int i = 97; i <= 122; i++)
        {
            char mychar = (char)i;
            string mycharstringed = mychar.ToString();
            listofchars.Add(mycharstringed);
        }
        Console.WriteLine();
        string[,] polindromes = new string[r, c];
        string[, ,] polindromemembers = new string[r, r + c, r];
        for (int count = 0, m = 0; count < r; count++)
        {
            for (int i = 0; i < c; i++)
            {
                polindromemembers[count, i, count] = listofchars[count] + listofchars[i + m] + listofchars[count];
            }
            m++;
        }
        int countitemsperrow = 0;
        Console.WriteLine("The matrix of polidromes runs as follows: ");
        foreach (var item in polindromemembers)
        {
            if (item == null)
            {
                continue;
            }
            Console.Write(item + " ");
            countitemsperrow++;
            if (countitemsperrow == c)
            {
                Console.WriteLine();
                countitemsperrow = 0;
            }
        }
        Console.ReadLine();
        goto start;
    }
}

