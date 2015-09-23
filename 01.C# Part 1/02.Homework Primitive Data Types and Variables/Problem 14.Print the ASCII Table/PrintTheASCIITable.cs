using System;
using System.Text;

class PrintTheASCIITable
{
    static void Main()
    {
        // Problem 14.* Print the ASCII Table
        // Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
        // Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

        Console.OutputEncoding = System.Text.Encoding.Unicode;

        int symbol;
        Console.WriteLine("ASCII".PadRight(7, ' ') + "SYMBOL".PadRight(7, ' ') + "ASCII".PadRight(7, ' ') + "SYMBOL".PadRight(7, ' ') + "ASCII".PadRight(7, ' ') + "SYMBOL".PadRight(7, ' ') + "ASCII".PadRight(7, ' ') + "SYMBOL".PadRight(7, ' '));
      
        for (int i = 0; i <= 63; i++)
        {
            symbol = i;

            switch (i)
            {
                case 0: Console.Write(" " + Convert.ToString(symbol).PadLeft(3, '0') + "NULL".PadLeft(8, ' ').PadRight(10, ' ')); break;
                case 7: Console.Write(" " + Convert.ToString(symbol).PadLeft(3, '0') + "BEl".PadLeft(7, ' ').PadRight(10, ' ')); break;
                case 8: Console.Write(" " + Convert.ToString(symbol).PadLeft(3, '0') + "BS".PadLeft(7, ' ').PadRight(10, ' ')); break;
                case 9: Console.Write(" " + Convert.ToString(symbol).PadLeft(3, '0') + "Tab".PadLeft(7, ' ').PadRight(10, ' ')); break;
                case 10: Console.Write(" " + Convert.ToString(symbol).PadLeft(3, '0') + "LF".PadLeft(7, ' ').PadRight(10, ' ')); break;
                case 13: Console.Write(" " + Convert.ToString(symbol).PadLeft(3, '0') + "CR".PadLeft(7, ' ').PadRight(10, ' ')); break;
                case 32: Console.Write(" " + Convert.ToString(symbol).PadLeft(3, '0') + "SPACE".PadLeft(9, ' ').PadRight(10, ' ')); break;
                default: Console.Write(" " + Convert.ToString(symbol).PadLeft(3, '0') + "".PadLeft(5, ' ') + (char)i + "".PadRight(4, ' ')); break;
            }

            for (int j = 0; j < 3; j++)
            {
                symbol = symbol + 64;
                Console.Write(" " + Convert.ToString(symbol).PadLeft(3, '0') + "".PadLeft(5, ' ') + (char)symbol + "".PadRight(4, ' '));
            }

            Console.WriteLine();
        }
    }
}