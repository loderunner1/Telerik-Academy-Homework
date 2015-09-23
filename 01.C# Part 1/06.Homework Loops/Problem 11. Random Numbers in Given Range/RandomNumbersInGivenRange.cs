using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        //  Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
        Console.WriteLine("Please enter how many numbers do you want to print");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the range");
        Console.Write("min=");
        int min = int.Parse(Console.ReadLine());

        Console.Write("max=");
        int max = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        int randomNumber;

        for (int i = 0; i < n; i++)
        {
            randomNumber = rnd.Next(min, max);
            Console.Write("{0} ", randomNumber);
        }
    }
}

