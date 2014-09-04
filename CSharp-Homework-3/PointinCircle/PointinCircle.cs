//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples:
//  x	    y	    inside	 
//  0	    1	    true	
//  -2	    0	    true	
//  -1	    2	    false	
//  1.5	    -1	    true	
//  -1.5	-1.5	false	
//  100	    -30	    false	
//  0	    0	    true	
//  0.2	    -0.8	true	
//  0.9	    -1.93	false	
//  1	    1.655	true	


using System;

class PointinCircle
{
    static void Main()
    {
        Console.Write("Please, enter the \"x\" coordinates of the point: ");
        double x = double.Parse(Console.ReadLine()); //note if the number is a fraction you may need to use "," instead if a "." in order to parse variable correctly! 
        Console.Write("Please enter the \"y\" coordinates of the point: ");
        double y = double.Parse(Console.ReadLine()); //note if the number is a fraction you may need to use "," instead if a "." in order to parse variable correctly! 
        if (Math.Sqrt(x * x + y * y) > 2) //Pythagoras theorem to calculate if the point lays further from the center than the radius.
        {
            Console.WriteLine("Is it inside the circle? " + false);
        }
        else Console.WriteLine("Is it inside the circle? " + true);
        Console.ReadLine();
    }
}

