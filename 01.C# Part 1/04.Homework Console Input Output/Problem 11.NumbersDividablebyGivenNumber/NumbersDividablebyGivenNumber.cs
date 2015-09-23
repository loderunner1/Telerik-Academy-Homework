using System;

class NumbersDividablebyGivenNumber
{
    static void Main()
    {
        // Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

        Console.WriteLine("Please enter an integer number for the begining of the interval");
        int startNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter an integer number for the end of the interval");
        int endNumber = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = startNumber; i <= endNumber; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
                Console.Write("{0},", i);
            }
        }

        Console.WriteLine("\n{0} integers dividable by 5 without remainder", counter);
    }
}

