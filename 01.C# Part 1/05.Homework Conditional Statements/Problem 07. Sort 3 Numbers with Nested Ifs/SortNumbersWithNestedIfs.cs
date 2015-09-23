using System;

class SortNumbersWithNestedIfs
{
    static void Main()
    {
        //Write a program that enters 3 real numbers and prints them sorted in descending order.
        // Use nested if statements.

        Console.WriteLine("Please enter three numbers");
        Console.Write("a=");
        decimal firstNumber = decimal.Parse(Console.ReadLine());

        Console.Write("b=");
        decimal secondNumber = decimal.Parse(Console.ReadLine());

        Console.Write("c=");
        decimal thirdNumber = decimal.Parse(Console.ReadLine());

        decimal biggestNumber=0;
        decimal middleNumber=0;
        decimal lastNumber=0;

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            biggestNumber = firstNumber;

            if (secondNumber > thirdNumber)
            {
                middleNumber = secondNumber;
                lastNumber = thirdNumber;
            }

            else
            {
                middleNumber = thirdNumber;
                lastNumber = secondNumber;
            }
        }

        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            biggestNumber = secondNumber;

            if (firstNumber > thirdNumber)
            {
                middleNumber = firstNumber;
                lastNumber = thirdNumber;
            }
            else
            {
                middleNumber = thirdNumber;
                lastNumber = firstNumber;
            }
        }
        else
        {
            biggestNumber = thirdNumber;

            if (firstNumber > secondNumber)
            {
                middleNumber = firstNumber;
                lastNumber = secondNumber;
            }

            else
            {
                middleNumber = secondNumber;
                lastNumber = firstNumber;
            }

        }

        Console.WriteLine("The numbers sorted in descending order {0} {1} {2}", biggestNumber, middleNumber, lastNumber);
    }
}

