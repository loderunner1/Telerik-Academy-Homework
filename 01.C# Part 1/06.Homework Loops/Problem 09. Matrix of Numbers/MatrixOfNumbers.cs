using System;

class MatrixOfNumbers
{
    static void Main()
    {
        // Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix
       
        Console.WriteLine("Please enter number n (1<=n<=20)");
        Console.Write("n=");
        byte n = byte.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n + i; j++)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
}

