using System;

class Trapezoids
{
    static void Main()
    {
        // Write an expression that calculates trapezoid's area by given sides a and b and height h.
        Console.WriteLine("Please enter trapezoid's sides ");
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter trapezoid's height ");
        Console.Write("h=");
        double h = double.Parse(Console.ReadLine());

        double area = h * ((a + b) / 2);
        Console.WriteLine("The trapezoid's area is {0}", area);
    }
}

