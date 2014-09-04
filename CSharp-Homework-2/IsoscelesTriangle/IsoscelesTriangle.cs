//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//  © ©
// ©   ©
//© © © ©
//Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.


using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        char a = '\u00A9'; //the debugger acknoledges it is the copyright sign!,but the console font do not support the sign for that symbol.
        string b = " ";

        for (int i = 0; i < 3; i++)
        {
            Console.Write(b);
        }
        for (int i = 0; i < 1; i++)
        {
            Console.Write(a);
        }
        Console.WriteLine();

        for (int i = 0; i < 2; i++)
        {
            Console.Write(b);
        }
        for (int i = 0; i < 2; i++)
        {
            Console.Write(a + b);
        }
        Console.WriteLine();

        for (int i = 0; i < 1; i++)
        {
            Console.Write(b);
        }
        for (int i = 0; i < 3; i++)
        {
            Console.Write(a + b);
        }

        Console.WriteLine();
        for (int i = 0; i < 4; i++)
        {
            Console.Write("{0} ", a);
        }
        Console.ReadLine();
    }
}
