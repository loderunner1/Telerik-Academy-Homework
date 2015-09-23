using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        //Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

        Console.WriteLine("Please enter an integer");
        int number = int.Parse(Console.ReadLine());
        bool divided;

        if (number % 5 == 0 && number % 7 == 0)
        {
            divided = true;
        }

        else
        {
            divided = false;
        }

        Console.WriteLine("Divided by 7 and 5? {0}", divided);
    }
}

