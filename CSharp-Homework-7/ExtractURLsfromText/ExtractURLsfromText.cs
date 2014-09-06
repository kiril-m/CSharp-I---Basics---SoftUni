//Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
//•	http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
//•	www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com
//Examples:
//Input	
//The site nakov.com can be access from http://nakov.com or www.nakov.com. It has subdomains like mail.nakov.com and svetlin.nakov.com. Please check http://blog.nakov.com for more information.	http://nakov.com
//Output
//www.nakov.com
//http://blog.nakov.com


using System;
using System.Collections.Generic;

class ExtractURLsfromText
{
    static void Main()
    {
        Console.WriteLine("Checking the following sentence for links: \nThe site nakov.com can be access from http://nakov.com or www.nakov.com. It has subdomains like mail.nakov.com and svetlin.nakov.com. Please check http://blog.nakov.com for more information.");

        //takes too long time to type the sentence in the console ==> we just take it as given, otherwise we can just take any sentence using Console.ReadLine and parse it from the console. 

        string input = "The site nakov.com can be access from http://nakov.com or www.nakov.com. It has subdomains like mail.nakov.com and svetlin.nakov.com. Please check http://blog.nakov.com for more information.";

        string inputmirror = input;
        List<string> firstset = new List<string>();
        List<string> secondset = new List<string>();

        //for http://
        do
        {


            int namelengthhttp = input.IndexOf("http://");
            if (namelengthhttp == -1)
            {
                break;
            }
            input = input.Substring(namelengthhttp, input.Length - namelengthhttp);

            int spaceposition = input.IndexOf(' ');

            string inputletters = input.Substring(0, spaceposition);
            firstset.Add(inputletters);
            int spacepositionnext = input.IndexOf(' ');
            input = input.Substring(spacepositionnext + 1, input.Length - inputletters.Length - 1);


        } while (input.Length != 0);

        //for www.

        do
        {
            int namelengthhttp = inputmirror.IndexOf("www.");
            if (namelengthhttp == -1)
            {
                break;
            }
            inputmirror = inputmirror.Substring(namelengthhttp, inputmirror.Length - namelengthhttp);

            int spaceposition = inputmirror.IndexOf(' ');

            string inputletters = inputmirror.Substring(0, spaceposition);
            secondset.Add(inputletters);
            int spacepositionnext = inputmirror.IndexOf(' ');
            inputmirror = inputmirror.Substring(spacepositionnext + 1, inputmirror.Length - inputletters.Length - 1);

        } while (inputmirror.Length != 0);


        //removing the punctuation sign from the last string. 
        for (int i = 0; i < firstset.Count; i++)
        {
            if (firstset[i] == firstset[i].Substring(0, firstset[i].Length - 1) + "." || firstset[i] == firstset[i].Substring(0, firstset[i].Length - 1) + "!" || firstset[i] == firstset[i].Substring(0, firstset[i].Length - 1) + "?")
            {
                firstset[i] = firstset[i].Substring(0, firstset[i].Length - 1);
            }
        }

        for (int i = 0; i < secondset.Count; i++)
        {
            if (secondset[i] == secondset[i].Substring(0, secondset[i].Length - 1) + "." || secondset[i] == secondset[i].Substring(0, secondset[i].Length - 1) + "!" || secondset[i] == secondset[i].Substring(0, secondset[i].Length - 1) + "?")
            {
                secondset[i] = secondset[i].Substring(0, secondset[i].Length - 1);
            }
        }

        //printing the results
        Console.WriteLine("The results:");
        foreach (var item in firstset)
        {
            Console.WriteLine(item);
        }

        foreach (var item in secondset)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}

