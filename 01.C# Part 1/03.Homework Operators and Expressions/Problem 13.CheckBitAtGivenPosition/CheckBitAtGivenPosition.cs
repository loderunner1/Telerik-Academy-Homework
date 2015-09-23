using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        //Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

        Console.WriteLine("Please enter an integer");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of the number:" + Convert.ToString(number, 2).PadLeft(32, '0'));
       
        Console.WriteLine("Please enter the index of the bit to check if its value is 1");
        int index = int.Parse(Console.ReadLine());

        number = number >> index;
        bool bitValueIsOne = (number & 1) == 1;
        Console.WriteLine("The bit at index {0} has value of 1 - {1} ", index, bitValueIsOne);
    }
}


