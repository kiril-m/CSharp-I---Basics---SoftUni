//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). Examples:
//x	    y	    inside K & outside of R	 
//1	    2	    yes	
//2.5	2	    no	
//0	    1	    no	
//2.5	1	    no	
//2	    0	    no	
//4	    0	    no	
//2.5	1.5	    no	
//2	    1.5	    yes	
//1	    2.5	    yes	
//-100	-100	no	


using System;

class CircleAndRectangle
{
    static void Main()
    {
        //circle
        Console.Write("Please, enter the \"x\" coordinates of the point: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter the \"y\" coordinates of the point: ");
        double y = double.Parse(Console.ReadLine());
        bool insidecircle = false;
        if (Math.Sqrt(x * x + y * y) <= Math.Sqrt(2) + 1.5) //Pythagoras theorem to calculate if the point lays further from the center than the radius
        {
            insidecircle = true;
        }
        Console.WriteLine("Does it lie inside the circle? {0}", insidecircle);

        //rectangle
        bool insiderectangle;
        if (x > 5 || x < -1 || y < -1 || y > 1) //just one of them needs to be wrong for the point to lie outside the rectangle
        {
            insiderectangle = false;
        }
        else insiderectangle = true;
        Console.WriteLine("Does it lie inside the rectangle? {0}", insiderectangle);

        if (insidecircle == true && insiderectangle == false)
        {
            Console.WriteLine("Does it lie inside the triangle and outside the rectangle? Yes");
        }
        else Console.WriteLine("Does it lie inside the triangle and outside the rectangle? No");
        Console.ReadLine();
    }
}

