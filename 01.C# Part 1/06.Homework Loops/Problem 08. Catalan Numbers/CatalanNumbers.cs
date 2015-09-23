using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        //  Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
       
        Console.WriteLine("Please enter number n (n>=0)");
        Console.Write("n=");
        byte n = byte.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        if (n < 0)
        {
            Console.WriteLine("invalid input");
        }

        else
        {
            for (int i = n + 1; i <= 2 * n; i++)
            {
                factorial = factorial * i;

            }

            for (int i = 1; i <= n + 1; i++)
            {
                factorial = factorial / i;
            }

            Console.WriteLine("The n-th Catalan number is {0}", factorial);
        }
    }
}

