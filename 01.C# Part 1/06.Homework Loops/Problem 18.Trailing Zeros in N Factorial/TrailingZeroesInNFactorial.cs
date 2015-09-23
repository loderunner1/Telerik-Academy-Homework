using System;
using System.Numerics;

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        ////  Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
        ////  Your program should work well for very big numbers, e.g. n=100000.

        Console.WriteLine("Please enter number n");
        long n = long.Parse(Console.ReadLine());

        BigInteger factorial = 1;
        int zeroCount = 0;

        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
        }

        while (factorial % 10 == 0)
        {
            factorial = factorial / 10;
            zeroCount++;
        }

        Console.WriteLine("{0} trailing zeros", zeroCount);
    }
}

