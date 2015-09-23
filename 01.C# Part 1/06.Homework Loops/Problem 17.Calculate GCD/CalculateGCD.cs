using System;

class CalculateGCD
{
    static void Main()
    {
        // Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
        // Use the Euclidean algorithm (find it in Internet).

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int gcd = 0;

        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                a %= b;
            }
            else
            {
                b %= a;
            }
        }

        if (a == 0)
        {
            gcd = b;
        }
        else
        {
            gcd = a;
        }

        Console.WriteLine("The GCD is {0}", gcd);
    }
}

