using System;

class BitwiseExtractThirdBit
{
    static void Main()
    {
        //  Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
        //  The bits are counted from right to left, starting from bit #0.
        //  The result of the expression should be either 1 or 0.

        Console.WriteLine("Please enter an integer");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of the number:" + Convert.ToString(number, 2).PadLeft(32, '0'));
        number = number >> 3;
        uint thirdBit = number & 1;
        Console.WriteLine("Third bit is {0} ", thirdBit);
    }
}

