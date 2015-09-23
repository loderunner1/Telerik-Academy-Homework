using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        // Using loops write a program that converts a binary integer number to its decimal form.
        // The input is entered as string. The output should be a variable of type long.
       
        // Do not use the built-in .NET functionality.
        Console.WriteLine("Please enter a binary integer number to convert to its decimal form");
        string binaryNumber = Console.ReadLine();

        char[] x = binaryNumber.ToCharArray();
        int element = 0;
        long decimalNumber = 0;

        for (int i = binaryNumber.Length; i > 0; i--)
        {
            element = int.Parse(Convert.ToString(x[i - 1]));
            decimalNumber = decimalNumber + (long)(element * Math.Pow(2, binaryNumber.Length - i));
        }

        Console.WriteLine("The decimal number is {0}", decimalNumber);
    }
}

