using System;

class ExchangeIfGreater
{
    static void Main()
    {
        // Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
       
        Console.WriteLine("Please enter first floating-point number");
        Console.Write("a=");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second floating-point number");
        Console.Write("b=");
        double secondNumber = double.Parse(Console.ReadLine());
        double greater=0;

        if (firstNumber > secondNumber)
        {
            greater = firstNumber;
            firstNumber = secondNumber;
            secondNumber = greater;
        }

        Console.WriteLine("a={0} b={1}", firstNumber, secondNumber);
    }
}