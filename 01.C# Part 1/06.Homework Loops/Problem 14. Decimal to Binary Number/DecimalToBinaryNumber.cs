using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        // Using loops write a program that converts an integer number to its binary representation.
        // The input is entered as long. The output should be a variable of type string.
        // Do not use the built-in .NET functionality.

        Console.WriteLine("Please enter an integer number to convert to its binary form");
        long number = long.Parse(Console.ReadLine());

        string binaryNumber = "";

        if (number == 0)
        {
            binaryNumber = "0";
        }

        else
        {
            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    binaryNumber = binaryNumber + "0";
                }

                else
                {
                    binaryNumber = binaryNumber + "1";
                }

                number = number / 2;
            }
        }

        char[] reverseBinaryNumber = binaryNumber.ToCharArray();
        Array.Reverse(reverseBinaryNumber);
        Console.WriteLine(reverseBinaryNumber);
    }
}

