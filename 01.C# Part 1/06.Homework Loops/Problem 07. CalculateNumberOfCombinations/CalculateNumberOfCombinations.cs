using System;
using System.Numerics;

class CalculateNumberOfCombinations
{
    static void Main()
    {
        //  In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
        //  Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

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
            for (int i = n - k + 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            for (int i = 1; i <= k; i++)
            {
                factorial = factorial / i;
            }

            Console.WriteLine("The result of the calculation n! / (k! * (n-k)!) is {0}", factorial);
        }
    }
}

