using System;
using System.Numerics;

class CalculateNK
{
    static void Main()
    {
        //  Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
        //  Use only one loop.

        Console.WriteLine("Please enter numbers n and k (1 < k < n < 100)");
        Console.Write("n=");
        byte n = byte.Parse(Console.ReadLine());

        Console.Write("k=");
        byte k = byte.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        if (k > n)
        {
            Console.WriteLine("invalid input");
        }

        else
        {
            for (int i = k + 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("The result of the calculation  n! / k! is {0}", factorial);
        }
    }
}

