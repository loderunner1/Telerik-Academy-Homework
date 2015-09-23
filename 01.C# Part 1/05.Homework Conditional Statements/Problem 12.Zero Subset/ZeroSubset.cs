using System;

class ZeroSubset
{
    static void Main()
    {
        //   We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
        //   Assume that repeating the same subset several times is not a problem.

        Console.WriteLine("Please enter five numbers");
        string[] numbersToString = Console.ReadLine().Split(' ');

        int[] numbers = new int[numbersToString.Length];
        int sum = 0;
        int counter = 0;

        for (int i = 0; i < numbersToString.Length; i++)
        {
            numbers[i] = int.Parse(numbersToString[i]);

        }

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbersToString.Length; j++)
            {
                sum = numbers[i] + numbers[j];

                if (sum == 0)
                {
                    counter++;
                    Console.WriteLine("{0}+{1}=0", numbers[i], numbers[j]);
                }

                for (int k = j + 1; k < numbers.Length; k++)
                {
                    sum = numbers[i] + numbers[j] + numbers[k];

                    if (sum == 0)
                    {
                        counter++;
                        Console.WriteLine("{0}+{1}+{2}=0", numbers[i], numbers[j], numbers[k]);
                    }

                    for (int l = k + 1; l < numbers.Length; l++)
                    {
                        sum = numbers[i] + numbers[j] + numbers[k] + numbers[l];

                        if (sum == 0)
                        {
                            counter++;
                            Console.WriteLine("{0}+{1}+{2}+{3}=0", numbers[i], numbers[j], numbers[k], numbers[l]);
                        }

                        for (int m = l + 1; m < numbers.Length; m++)
                        {
                            sum = numbers[i] + numbers[j] + numbers[k] + numbers[l] + numbers[m];

                            if (sum == 0)
                            {
                                counter++;
                                Console.WriteLine("{0}+{1}+{2}+{3}+{4}=0", numbers[i], numbers[j], numbers[k], numbers[l], numbers[m]);
                            }
                        }
                    }
                }
            }

        }

        if (counter == 0)
        {
            Console.WriteLine("no zero subset");
        }
    }
}

