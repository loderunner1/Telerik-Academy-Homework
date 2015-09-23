using System;

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        // Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

        Console.WriteLine("Please enter point coordinates(x,y)");
        Console.Write("x=");
        double x = double.Parse(Console.ReadLine());

        Console.Write("y=");
        double y = double.Parse(Console.ReadLine());

        double circleCenterX = 1;
        double circleCenterY = 1;
        double radius = 1.5;

        int rectangleTop = 1;
        int rectangleLeft = -1;
        int rectangleWidth = 6;
        int rectangleHeight = 2;

        bool insideRectangle = (rectangleLeft <= x && x <= (rectangleLeft + rectangleWidth)) && ((rectangleTop - rectangleHeight) <= y && y <= rectangleTop);
        bool insideCircle = Math.Pow((x - circleCenterX), 2) + Math.Pow((y - circleCenterY), 2) < Math.Pow(radius, 2);
        string insideCircleAndOutsideRectangle = ((insideCircle && !insideRectangle) == true) ? "yes" : "no";

        Console.WriteLine("Point coordinates:({0},{1})", x, y);
        Console.Write("The point is inside the circle K({{1, 1}}, 1.5) and outside the rectangle R(top=1, left=-1, width=6, height=2) - {0} ", insideCircleAndOutsideRectangle);
    }
}

