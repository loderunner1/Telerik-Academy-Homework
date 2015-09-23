using System;

class MinMaxSumAverageOfnNumbers
{
    static void Main()
    {
        // Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
        // The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
        // The output is like in the examples below.
       
        Console.WriteLine("How many numbers do you want to enter ?");
        uint numbersCount = uint.Parse(Console.ReadLine());

        decimal sum = 0;
        decimal average = 0;
        decimal maxNumber = 0;
        decimal minNumber = 0;
        decimal[] numbers = new decimal[numbersCount];

        for (int i = 0; i < numbersCount; i++)
        {
            numbers[i] = decimal.Parse(Console.ReadLine());
            minNumber = numbers[i];
            sum = sum + numbers[i];
            if (maxNumber < numbers[i])
            {
                maxNumber = numbers[i];
            }

            if (i > 0 && minNumber > numbers[i - 1])
            {
                minNumber = numbers[i];
            }
        }

        average = sum / numbersCount;
        Console.WriteLine("The sum is {0}", sum);
        Console.WriteLine("The max number is {0}", maxNumber);
        Console.WriteLine("The min number is {0}", minNumber);
        Console.WriteLine("The average is {0:F2}", average);
    }
}