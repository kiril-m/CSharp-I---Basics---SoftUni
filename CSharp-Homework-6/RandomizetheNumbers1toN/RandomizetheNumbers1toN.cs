//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. Examples:
//n	    randomized numbers 1…n
//3	    2 1 3
//10	3 4 8 2 6 7 9 1 10 5 
//Note that the above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.


using System;

class RandomizetheNumbers1toN
{
    static void Main()
    {
        Console.WriteLine("Randomize the Numbers from 1 to N!");
    start:
        Console.Write("Please, enter a value for \"n\": ");
        int n = int.Parse(Console.ReadLine());
        int[] arrayofnums = new int[n];
        int[] arrayofrandoms = new int[n];
        Random randompick = new Random();

        for (int i = 0; i <= n; i++) //filling the array of numbers in their initial order
        {
            if (i == n)
            {
                break;
            }
            arrayofnums[i] = i + 1;
        }

        for (int i = 0; i < n; i++)
        {
        enter:
            int[] x = new int[] { randompick.Next(arrayofnums[0], arrayofnums[n - 1] + 1) }; //generate a random number between the allowed min and max;
            for (int j = 0; j < arrayofrandoms.Length; j++) //checking if the generated random number is not already saved as part of the separate array allocated for the numbers in their random order
            {
                if (arrayofrandoms[j] == x[0])
                {
                    goto enter;
                }
            }
            arrayofrandoms[i] = x[0]; //if it is not then we save it in the new "random" array
            if (i == n)
            {
                break; //if we reach the last number we exit 
            }
        }
        string thewholestring = string.Join(" ", arrayofrandoms); //coverting the random array into string and adding "spaces" between the items
        Console.WriteLine(thewholestring); //printing the result
        Console.ReadLine();
        goto start;
    }
}
