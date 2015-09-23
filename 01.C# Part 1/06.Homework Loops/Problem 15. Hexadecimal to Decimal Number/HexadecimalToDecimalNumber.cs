using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        // Using loops write a program that converts a hexadecimal integer number to its decimal form.
        // The input is entered as string. The output should be a variable of type long.
        // Do not use the built-in .NET functionality.

        Console.WriteLine("Enter number in hex");
        string hexString = Console.ReadLine();

        char[] hexChar = hexString.ToCharArray();
        string number = "";
        int power;
        long numberInDecimal = 0;

        for (int i = 0; i < hexChar.Length; i++)
        {
            switch (hexChar[i])
            {
                case 'A': number = number + "10 "; 
                    break;
                case 'B': number = number + "11 ";
                    break;
                case 'C': number = number + "12 "; 
                    break;
                case 'D': number = number + "13 "; 
                    break;
                case 'E': number = number + "14 "; 
                    break;
                case 'F': number = number + "15 "; 
                    break;
                default: number = number + hexChar[i].ToString() + " "; 
                    break;
            }
        }

        string[] digitsAsString = number.Split(' ');
        int[] digits = new int[digitsAsString.Length - 1];

        for (int i = 0; i < digitsAsString.Length - 1; i++)
        {
            digits[i] = int.Parse(digitsAsString[i]);
            power = Math.Abs(i - (digitsAsString.Length - 2));
            numberInDecimal = numberInDecimal + digits[i] * (long)Math.Pow(16, power);
        }

        Console.WriteLine("The number in decimal is {0}", numberInDecimal);
    }
}

