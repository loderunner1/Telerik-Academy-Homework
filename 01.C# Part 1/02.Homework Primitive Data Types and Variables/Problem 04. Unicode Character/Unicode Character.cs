﻿using System;

class UnicodeCharacter
{
    static void Main()
    {
        //  Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
        //  Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.

        char unicodeChar = '\u002A';
        Console.WriteLine("{0}", unicodeChar);
    }
}
