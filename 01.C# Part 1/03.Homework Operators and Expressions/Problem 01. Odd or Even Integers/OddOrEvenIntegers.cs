using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        // Write an expression that checks if given integer is odd or even.

        Console.WriteLine("Please enter a number");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Odd? - false");

        }

        else
        {
            Console.WriteLine("Odd? - true");
        }
    }
}