using System;

class SumOfnNumbers
{
    static void Main()
    {
        // Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
        
        Console.WriteLine("How many numbers do you want to enter");
        int n = int.Parse(Console.ReadLine());
        decimal sum = 0m;

        for (int i = 0; i < n; i++)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            sum = sum + number;
        }

        Console.WriteLine("The sum is {0}", sum);
    }
}

