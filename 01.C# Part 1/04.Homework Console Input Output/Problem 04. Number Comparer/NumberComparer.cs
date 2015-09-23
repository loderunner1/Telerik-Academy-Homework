using System;

class NumberComparer
{
    static void Main()
    {
        // Write a program that gets two numbers from the console and prints the greater of them.
        // Try to implement this without if statements.

        Console.WriteLine("Please enter first number");
        Console.Write("a=");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second number");
        Console.Write("b=");
        int secondNumber = int.Parse(Console.ReadLine());

        while (firstNumber < secondNumber)
        {
            firstNumber++;
        }

        Console.WriteLine("The greater number is {0}", firstNumber);
    }
}

