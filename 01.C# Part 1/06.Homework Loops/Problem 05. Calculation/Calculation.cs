using System;


class Calculation
{
    static void Main()
    {
        //    Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
        //    Use only one loop. Print the result with 5 digits after the decimal point.

        Console.WriteLine("Enter numbers n and x to calculate the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());

        Console.Write("x=");
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
            sum = sum + (factorial / Math.Pow(x, i));
        }

        Console.WriteLine("The sum is {0:F5}", sum);
    }
}