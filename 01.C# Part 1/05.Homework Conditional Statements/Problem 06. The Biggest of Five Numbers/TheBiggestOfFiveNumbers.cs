using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        //Write a program that finds the biggest of five numbers by using only five if statements.
       
        Console.WriteLine("Please enter five numbers");
        Console.Write("a=");
        decimal firstNumber = decimal.Parse(Console.ReadLine());

        Console.Write("b=");
        decimal secondNumber = decimal.Parse(Console.ReadLine());

        Console.Write("c=");
        decimal thirdNumber = decimal.Parse(Console.ReadLine());

        Console.Write("d=");
        decimal fourthNumber = decimal.Parse(Console.ReadLine());

        Console.Write("e=");
        decimal fifthNumber = decimal.Parse(Console.ReadLine());
        decimal biggestNumber = firstNumber;

        if (secondNumber > firstNumber)
        {
            biggestNumber = secondNumber;
        }

        if (thirdNumber > biggestNumber)
        {
            biggestNumber = thirdNumber;
        }

        if (fourthNumber > biggestNumber)
        {
            biggestNumber = fourthNumber;
        }

        if (fifthNumber > biggestNumber)
        {
            biggestNumber = fifthNumber;
        }

        Console.WriteLine("The biggest number is {0}", biggestNumber);
    }
}

