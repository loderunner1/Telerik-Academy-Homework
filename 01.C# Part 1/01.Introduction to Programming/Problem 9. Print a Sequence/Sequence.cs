using System;

class Sequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)
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

