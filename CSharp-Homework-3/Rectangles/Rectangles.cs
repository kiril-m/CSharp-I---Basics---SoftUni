//Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:
//width	height	perimeter	area
//3	    4	    14	        12
//2.5	3	    11	        7.5
//5	    5	    20	        25
    
using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter width of the rectangle: ");
        double width = double.Parse(Console.ReadLine()); //note if the number is a fraction you may need to use "," instead if a "." in order to parse variable correctly! 
        Console.Write("Enter height of the rectangle: ");
        double height = double.Parse(Console.ReadLine()); //note if the number is a fraction you may need to use "," instead if a "." in order to parse variable correctly!
        double perimeter = (double)(2 * (width + height));
        double area = (double)(width * height);
        Console.Write("The perimeter of the rectangle is: ");
        Console.WriteLine(perimeter);
        Console.Write("The area of the rectangle is: ");
        Console.WriteLine(area);
        Console.ReadLine();
    }
}

