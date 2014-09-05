//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. Examples:
//r	    perimeter	area
//2	    12.57	    12.57
//3.5	21.99	    38.48


using System;

class CirclePerimeterandArea
{
    static void Main()
    {
        Console.Write("Please, enter the radius of the circle: ");
        double r = double.Parse(Console.ReadLine());
        double Pi = Math.PI;
        double perimeter = 2 * Pi * r;
        double perimetertrunct = Math.Round(perimeter, 2);
        double area = Pi * r * r;
        double areatrunct = Math.Round(area, 2);
        Console.WriteLine("The perimeter of the circle is thus {0} and the area is {1}.", perimetertrunct, areatrunct);
        Console.ReadLine();
    }
}

