using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        //Write a program that finds the biggest of three numbers.

        Console.WriteLine("Please enter three numbers");
        Console.Write("a=");
        decimal firstNumber = decimal.Parse(Console.ReadLine());

        Console.Write("b=");
        decimal secondNumber = decimal.Parse(Console.ReadLine());

        Console.Write("c=");
        decimal thirdNumber = decimal.Parse(Console.ReadLine());
        decimal biggestNumber = firstNumber;

        if (secondNumber > firstNumber)
        {
            biggestNumber = secondNumber;
        }

        if (thirdNumber > biggestNumber)
        {
            biggestNumber = thirdNumber;
        }

        Console.WriteLine("The biggest number is {0}", biggestNumber);
    }
}

