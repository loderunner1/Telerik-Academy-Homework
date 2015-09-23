﻿using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        // A beer time is after 1:00 PM and before 3:00 AM.
        // Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed.
        CultureInfo enUS = new CultureInfo("en-US");

        Console.WriteLine("Please enter time in format hh:mm tt");
        DateTime enteredTime;
        DateTime beerHourStart = DateTime.Parse("1:00 PM");
        DateTime beerHourEnd = DateTime.Parse("3:00 AM");
        bool isValidTime = DateTime.TryParseExact(Console.ReadLine(), "h:mm tt", enUS, DateTimeStyles.None, out enteredTime);
       
        if (isValidTime == true)
        {
            if (enteredTime >= beerHourStart || enteredTime < beerHourEnd)
            {
                Console.WriteLine("beer time");
            }

            else
            {
                Console.WriteLine("non-beer time");
            }
        }

        else
        {
            Console.WriteLine("invalid time");
        }
    }
}

