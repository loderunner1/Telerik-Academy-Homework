using System;

class NullValuesArithmetic
{
    static void Main()
    {   
        // Create a program that assigns null values to an integer and to a double variable.
        // Try to print these variables at the console.
        // Try to add some number or the null literal to these variables and print the result.

        int? a = null;
        double? b = null;
        Console.WriteLine(a);
        Console.WriteLine(b);

        a += 2;
        b += null;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}