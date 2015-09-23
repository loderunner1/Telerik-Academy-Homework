using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
        
        Console.WriteLine("Please enter circle radius");
        Console.Write("r=");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = 2 * radius * Math.PI;
        double area = Math.PI * radius * radius;
        Console.WriteLine("Circle perimeter is {0:F2}", perimeter);
        Console.WriteLine("Circle area is {0:F2}", area);
    }
}

