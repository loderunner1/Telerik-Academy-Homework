using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        //   Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
        
        Console.WriteLine("Please enter 5 numbers in a single line separated by a space");
        string[] numbers = Console.ReadLine().Split(' ');
        decimal sum = 0m;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum = sum + decimal.Parse(numbers[i]);
        }

        Console.WriteLine("The sum is {0}", sum);
    }
}

