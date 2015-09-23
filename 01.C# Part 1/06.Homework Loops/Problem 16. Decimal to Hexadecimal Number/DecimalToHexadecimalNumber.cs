using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        // Using loops write a program that converts an integer number to its hexadecimal representation.
        // The input is entered as long. The output should be a variable of type string.
        // Do not use the built-in .NET functionality.

        Console.WriteLine("Enter a decimal number ");
        long number = long.Parse(Console.ReadLine());
        long remainder = 0;
        string digits = "";

        while (number > 0)
        {
            remainder = number % 16;
            number = number / 16;

            switch (remainder)
            {
                case 0: digits = digits + "";
                    break;
                case 10: digits = digits + "A"; 
                    break;
                case 11: digits = digits + "B";
                    break;
                case 12: digits = digits + "C"; 
                    break;
                case 13: digits = digits + "D"; 
                    break;
                case 14: digits = digits + "E";
                    break;
                case 15: digits = digits + "F";
                    break;
                default: digits = digits + Convert.ToString(remainder); 
                    break;
            }
        }

        char[] hexNumber = digits.ToCharArray();
        Array.Reverse(hexNumber);
        Console.WriteLine("The number in hexadecimal is ", hexNumber);
    }
}

