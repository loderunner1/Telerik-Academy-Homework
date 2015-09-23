using System;

class ComparingFloats
{
    static void Main()
    {
        //Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
        
        Console.WriteLine("Enter first floating-point number");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second floating-point number");
        double secondNumber = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        double difference = Math.Abs(firstNumber - secondNumber);
        bool equal;

        if (difference >= eps)
        {
            equal = false;
        }

        else
        {
            equal = true;
        }

        Console.WriteLine("Equal (with precision eps=0.000001)-{0}", equal);
    }
}