using System;

class PointInACircle
{
    static void Main()
    {
        // Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

        Console.WriteLine("Please enter point coordinates(x,y)");
        Console.Write("x=");
        double x = double.Parse(Console.ReadLine());

        Console.Write("y=");
        double y = double.Parse(Console.ReadLine());

        double circleCenterX = 0;
        double circleCenterY = 0;
        double radius = 2;
        bool inside = Math.Pow((x - circleCenterX), 2) + Math.Pow((y - circleCenterY), 2) < Math.Pow(radius, 2);
        
        Console.WriteLine("Point coordinates:({0},{1})", x, y);
        Console.WriteLine("The point is inside the circle - {0}", inside);
    }
}

