using System;

class PrimeNumberCheck
{
    static void Main()
    {
        //Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

        Console.WriteLine("Please enter a positive integer");
        int number = int.Parse(Console.ReadLine());
        bool prime = number > 1;

        for (int i = 2; i < number; i++)
        {
            bool checker = (number % i) != 0;
            prime = prime && checker;
        }

        Console.WriteLine("The number is prime - {0}", prime);
    }
}

