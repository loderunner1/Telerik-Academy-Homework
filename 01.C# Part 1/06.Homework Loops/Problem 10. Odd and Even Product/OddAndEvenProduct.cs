using System;

class OddAndEvenProduct
{
    static void Main()
    {

        //  You are given n integers (given in a single line, separated by a space).
        //  Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
        //  Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

        Console.WriteLine("Please enter integers separated by a space");
        string[] numbersToString = Console.ReadLine().Split(' ');

        int[] n = new int[numbersToString.Length];
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < numbersToString.Length; i++)
        {
            n[i] = int.Parse(numbersToString[i]);

            if (i % 2 == 0)
            {
                oddProduct = oddProduct * n[i];
            }

            else
            {
                evenProduct = evenProduct * n[i];
            }
        }

        Console.WriteLine("Is The product of the even elements equal to the product of the odd elements?\n" + (evenProduct == oddProduct ? "yes" : "no"));
    }
}

