using System;

class FormattingNumbers
{
    static void Main()
    {
        // Write a program that reads 3 numbers:
        //     integer a (0 <= a <= 500)
        //     floating-point b
        //     floating-point c
        // The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
        //     The number a should be printed in hexadecimal, left aligned
        //     Then the number a should be printed in binary form, padded with zeroes
        //     The number b should be printed with 2 digits after the decimal point, right aligned
        //     The number c should be printed with 3 digits after the decimal point, left aligned.

        Console.WriteLine("Please enter an integer between 0 and 500");
        Console.Write("a=");
        short firstNumber = short.Parse(Console.ReadLine());

        Console.WriteLine("Please enter a floating-point number");
        Console.Write("b=");
        float secondNumber = float.Parse(Console.ReadLine());

        Console.WriteLine("Please enter a floating-point number");
        Console.Write("c=");
        float thirdNumber = float.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("a in hex".PadLeft(6, ' ').PadRight(10, ' ') + "|" + "a - binary".PadLeft(6, ' ').PadRight(10, ' ') + "|" + "b-2 digits".PadLeft(6, ' ').PadRight(10, ' ') + "|" + "b-3 digits".PadLeft(6, ' ').PadRight(10, ' ') + "|");
        Console.WriteLine("{0,-10:X}" + "|" + Convert.ToString(firstNumber, 2).PadLeft(10, '0') + "|" + "{1,10:F2}" + "|" + "{2,-10:F3}" + "|", firstNumber, secondNumber, thirdNumber);
    }
}

