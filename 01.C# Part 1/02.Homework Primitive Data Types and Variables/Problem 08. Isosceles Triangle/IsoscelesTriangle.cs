using System;

class IsoscelesTriangle
{
    static void Main()
    {
        //  Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
        //                             
        //                                  ©
        //                               
        //                                 © ©
        //                               
        //                                ©   ©
        //                               
        //                               © © © ©
        // Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.
        //
        // Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.


        Console.OutputEncoding = System.Text.Encoding.UTF8;

        char copyright = '\u00A9';
        string copyrightline = Convert.ToString(copyright) + " ";

        Console.WriteLine("{0}".PadLeft(6, ' '), copyright);
        Console.WriteLine();
        Console.WriteLine("{0}".PadLeft(5, ' ') + "{1}".PadLeft(4, ' '), copyright, copyright);
        Console.WriteLine();
        Console.WriteLine("{0}".PadLeft(4, ' ') + "{1}".PadLeft(6, ' '), copyright, copyright);
        Console.WriteLine();
        Console.WriteLine(copyrightline.PadRight(3, copyright) + copyrightline.PadRight(3, copyright).PadLeft(4, ' '));
    }
}

