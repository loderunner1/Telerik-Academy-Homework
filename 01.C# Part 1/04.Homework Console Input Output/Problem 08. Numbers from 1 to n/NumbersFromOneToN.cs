using System;

class NumbersFromOneToN
{
    static void Main()
    {
        // Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
       
        Console.WriteLine("Please enter an integer number");
        Console.Write("n=");
        int number = int.Parse(Console.ReadLine());

        if (number > Console.BufferHeight)
        {
            Console.BufferHeight = number + 1;
        }

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("{0}", i);
        }
    }
}

