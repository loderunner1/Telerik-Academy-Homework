using System;

class MultiplicationSign
{
    static void Main()
    {
        //  Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
       
        Console.WriteLine("Please enter three real numbers ");
        Console.Write("a=");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("b=");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("c=");
        double thirdNumber = double.Parse(Console.ReadLine());
        double product = (firstNumber * secondNumber) * thirdNumber;

        if (product < 0)
        {
            Console.WriteLine("-");
        }

        else if (product == 0)
        {
            Console.WriteLine("0");
        }

        else
        {
            Console.WriteLine("+");
        }
    }
}

