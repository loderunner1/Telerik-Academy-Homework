using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Please enter your birth date in format:d/m/y");

        DateTime n = DateTime.Parse(Console.ReadLine());
        int count = 0;

        for (DateTime i = n.AddYears(1); i < DateTime.Now; i = i.AddYears(1))
        {

            count++;
        }

        Console.WriteLine("Now you are {0} years old", count);
        Console.WriteLine("After 10 years you will be {0} years old", count + 10);
    }
}

