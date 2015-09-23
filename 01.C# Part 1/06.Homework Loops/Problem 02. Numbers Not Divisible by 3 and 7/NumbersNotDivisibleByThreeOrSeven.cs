using System;

class NumbersNotDivisibleByThreeOrSeven
{
    static void Main()
    {
        //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
       
        Console.WriteLine("Please enter a positive integer");
        uint number = uint.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write("{0} ", i);
                Console.WriteLine();
            }
        }
    }
}

