//The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth. Examples:
//weight	weight on the Moon
//86	    14.62
//74.6	    12.682
//53.7	    9.129

using System;

class GravitationontheMoon
{
    static void Main()
    {
        Console.Write("Please, enter your weight on Earth: ");
        int Weight = int.Parse(Console.ReadLine());
        double MoonWeight = (Weight * 0.17);
        Console.WriteLine("Your weight on the Moon would be: {0} kg.", MoonWeight);
        Console.ReadLine();
    }
}

