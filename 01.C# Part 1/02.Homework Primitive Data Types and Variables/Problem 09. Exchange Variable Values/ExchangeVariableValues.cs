﻿using System;

class ExchangeVariableValues
{
    static void Main()
    {
        // Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
        // Print the variable values before and after the exchange.

        int a = 5;
        int b = 10;
        Console.WriteLine("a={0}", a);
        Console.WriteLine("b={0}", b);

        b -= a;
        a += b;
        Console.WriteLine("a={0}", a);
        Console.WriteLine("b={0}", b);
    }
}