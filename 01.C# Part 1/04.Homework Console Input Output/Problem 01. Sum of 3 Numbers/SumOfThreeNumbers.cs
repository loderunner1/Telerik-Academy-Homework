using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        // Write a program that reads 3 real numbers from the console and prints their sum.

        Console.WriteLine("Please enter 3 numbers");
        Console.Write("a=");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("b=");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("c=");
        double thirdNumber = double.Parse(Console.ReadLine());

        double sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum is {0}", sum);
    }
}