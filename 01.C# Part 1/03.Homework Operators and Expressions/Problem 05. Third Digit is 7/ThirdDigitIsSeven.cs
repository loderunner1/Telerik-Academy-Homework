using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        // Write an expression that checks for given integer if its third digit from right-to-left is 7.

        Console.WriteLine("Please enter an integer");
        int number = int.Parse(Console.ReadLine());
        bool thirdDigit = ((number % 1000) / 100) == 7;

        Console.WriteLine("Third digit 7? {0}", thirdDigit);
    }
}

