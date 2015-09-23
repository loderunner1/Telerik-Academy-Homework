using System;

class Rectangles
{
    static void Main()
    {
        // Write an expression that calculates rectangle’s perimeter and area by given width and height.

        Console.WriteLine("Please enter rectangle's width");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter rectangle's height");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;

        Console.WriteLine("Rectangle's perimeter is {0}", perimeter);
        Console.WriteLine("Rectangle's area is {0}", area);
    }
}

