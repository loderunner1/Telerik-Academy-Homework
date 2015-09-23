using System;

class LongSequence
{
    static void Main()
    {
        Console.BufferHeight = 1001;

        for (int i = 2; i < 1002; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine("{0}", i * -1);
            }

            else
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
