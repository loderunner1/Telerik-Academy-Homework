using System;

class RandomizeTheNumbersOneToN
{
    static void Main()
    {
        // Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
        
        Console.WriteLine("Please enter an integer");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        int[] randomNumbers = new int[n];
        int count = 0;
        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }

        for (int i = 0; i < randomNumbers.Length; i++)
        {
            count++;
            randomNumbers[i] = random.Next(numbers[0], numbers[n - 1]);

            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    while (randomNumbers[j] == randomNumbers[i])
                    {
                        randomNumbers[i] = random.Next(numbers[0], n + 1);
                        j = 0;
                    }
                }
            }

            Console.Write("{0} ", randomNumbers[i]);
        }
    }
}

