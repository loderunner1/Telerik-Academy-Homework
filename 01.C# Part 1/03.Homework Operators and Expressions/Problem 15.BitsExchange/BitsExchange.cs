using System;

class BitsExchange
{
    static void Main()
    {
        //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

        Console.WriteLine("Please enter an integer");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of the number:" + Convert.ToString(number, 2).PadLeft(32, '0'));

        uint mask = ((number >> 21) & 56) | ((number << 21) & (56 << 21)); //Creating a mask number with exchanged 3,4,5 and 24,25,26 bit values and all other bits are set to 0.
        long nulledNeededBits = (number & ~56) & (number & (~(56 << 21))); //Setting 3,4,5 and 24,25,26 values to 0, all other bits keep their values. 
        uint result = mask | (uint)nulledNeededBits; //Combining the two numbers so the exchanged bit values can fit in the bits with value set to 0.

        Console.WriteLine("Binary representation of the result:" + Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine("The result is {0} ", result);
    }
}