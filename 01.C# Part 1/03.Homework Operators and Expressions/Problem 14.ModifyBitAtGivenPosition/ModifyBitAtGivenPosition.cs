using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        //  We are given an integer number n, a bit value v (v=0 or 1) and a position p.
        //  Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

        Console.WriteLine("Please enter an integer");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of the number:" + Convert.ToString(number, 2).PadLeft(32, '0'));
       
        Console.WriteLine("Please enter bit value to assign(0 or 1)");
        int value = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the index of the bit to modify");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of the number:" + Convert.ToString(number, 2).PadLeft(32, '0'));
       
        if (value == 1)
        {
            number = (1 << index) | number;
        }

        else
        {
            number = ~(1 << index) & number;
        }

        Console.WriteLine("Binary representation of the result:" + Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("The result is {0}", number);
    }
}

