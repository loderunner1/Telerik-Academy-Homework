using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        //   Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
        //   The first and the second sequence of bits may not overlap.

        Console.WriteLine("Please enter an integer");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of the number:" + Convert.ToString(number, 2).PadLeft(32, '0'));

        Console.WriteLine("Please enter the start position(p) of the first bit sequence");
        int firstStartPosition = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the start position(q) of the second bit sequence");
        int secondStartPosition = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the length(k) of the sequences");
        int lengthOfSequence = int.Parse(Console.ReadLine());

        uint maskForSequence=0;
        uint firstSequence = 0;
        uint secondSequence = 0;
        uint nullSequence = number;
        uint nulledNumber = number;
        uint switchedPositions=0;
        uint result=0;

        if ((firstStartPosition > 0 && secondStartPosition > 0) && ((firstStartPosition + lengthOfSequence < 32) || (secondStartPosition + lengthOfSequence < 32)))
        {
            if (Math.Abs(firstStartPosition - secondStartPosition) < lengthOfSequence)
            {
                Console.WriteLine("overlapping");
            }

            else
            {
                for (int i = firstStartPosition; i < firstStartPosition + lengthOfSequence; i++)
                {
                    maskForSequence = (uint)(1 << i) & number;
                    firstSequence = firstSequence | maskForSequence;
                    nullSequence = (uint)(1 << i);
                    nulledNumber = (~nullSequence) & nulledNumber;

                }

                for (int i = secondStartPosition; i < secondStartPosition + lengthOfSequence; i++)
                {
                    maskForSequence = (uint)(1 << i) & number;
                    secondSequence = secondSequence | maskForSequence;
                    nullSequence = (uint)(1 << i);
                    nulledNumber = (~nullSequence) & nulledNumber;

                }

                if (firstStartPosition < secondStartPosition)
                {

                    firstSequence = firstSequence << secondStartPosition - firstStartPosition;
                    secondSequence = secondSequence >> secondStartPosition - firstStartPosition;

                }

                else
                {
                    firstSequence = firstSequence >> firstStartPosition - secondStartPosition;
                    secondSequence = secondSequence << firstStartPosition - secondStartPosition;
                }

                switchedPositions = firstSequence | secondSequence;
                result = switchedPositions | nulledNumber;
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
                Console.WriteLine(result);
            }
        }

        else
        {
            Console.WriteLine("out of range");
        }
    }
}