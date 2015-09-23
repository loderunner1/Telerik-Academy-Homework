using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        //Write an expression that extracts from given integer n the value of given bit at index p.

        Console.WriteLine("Please enter an integer");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the index of the bit to extract");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation of the number:" + Convert.ToString(number, 2).PadLeft(32, '0'));
        number = number >> index;
        int extractedBit = number & 1;
        Console.WriteLine("The bit at index {0} is {1} ", index, extractedBit);
    }
}

