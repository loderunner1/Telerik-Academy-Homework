using System;

class FibonacciNumbers
{
    static void Main()
    {
        //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233,

        Console.WriteLine("Please enter how many members of the Fibonacci sequence you want to print");
        int n = int.Parse(Console.ReadLine());
        int[] fibonacci = new int[n];

        if (n <= 1)
        {
            fibonacci[0] = 0;
        }

        else
        {
            fibonacci[0] = 0;
            fibonacci[1] = 1;
        }

        for (int i = 0; i < n; i++)
        {
            if (i > 1)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            Console.Write((i < n - 1) ? fibonacci[i] + "," : fibonacci[i] + "\n");
        }
    }
}

