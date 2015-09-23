using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        //   Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        //       If the variable is int or double, the program increases it by one.
        //       If the variable is a string, the program appends * at the end.
        //   Print the result at the console. Use switch statement.

        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        byte chosenType = byte.Parse(Console.ReadLine());

        switch (chosenType)
        {
            case 1: Console.WriteLine("Please enter an int");
                int enteredInt = int.Parse(Console.ReadLine()) + 1;
                Console.WriteLine("The result is {0}", enteredInt);
                break;
            case 2: Console.WriteLine("Please enter a double");
                double enteredDouble = double.Parse(Console.ReadLine()) + 1;
                Console.WriteLine("The result is {0}", enteredDouble);
                break;
            case 3: Console.WriteLine("Please enter a string");
                string enteredString = Console.ReadLine() + "*";
                Console.WriteLine("The result is {0}", enteredString); 
                break;
        }
    }
}

