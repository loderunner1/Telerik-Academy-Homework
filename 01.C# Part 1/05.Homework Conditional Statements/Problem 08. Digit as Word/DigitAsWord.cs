using System;

class DigitAsWord
{
    static void Main()
    {
        //  Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
        //  Print “not a digit” in case of invalid input.
        //  Use a switch statement.

        Console.WriteLine("Please enter a digit between 0 and 9");
        byte digit = byte.Parse(Console.ReadLine());

        switch (digit)
        {
            case 0: Console.WriteLine("The digit is zero"); 
                break;
            case 1: Console.WriteLine("The digit is one");
                break;
            case 2: Console.WriteLine("The digit is two"); 
                break;
            case 3: Console.WriteLine("The digit is three"); 
                break;
            case 4: Console.WriteLine("The digit is four");
                break;
            case 5: Console.WriteLine("The digit is five");
                break;
            case 6: Console.WriteLine("The digit is six"); 
                break;
            case 7: Console.WriteLine("The digit is seven"); 
                break;
            case 8: Console.WriteLine("The digit is eight"); 
                break;
            case 9: Console.WriteLine("The digit is nine"); 
                break;
            default: Console.WriteLine("not a digit"); 
                break;
        }
    }
}

