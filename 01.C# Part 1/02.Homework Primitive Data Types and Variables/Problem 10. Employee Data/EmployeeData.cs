﻿using System;

class EmployeeData
{
    static void Main()
    {
        //  A marketing company wants to keep record of its employees. Each record would have the following characteristics:
        //    First name
        //    Last name
        //    Age (0...100)
        //    Gender (m or f)
        //    Personal ID number (e.g. 8306112507)
        //    Unique employee number (27560000…27569999)
        //  Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

        Console.WriteLine("Enter employee first name and press enter");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter employee last name and press enter");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter employee age(range 0-100) and press enter");
        byte age = byte.Parse(Console.ReadLine());

        Console.WriteLine("Enter employee gender(m or f) and press enter");
        string gender = Console.ReadLine();

        Console.WriteLine("Enter employee Personal ID number(e.g. 8306112507) and press enter");
        long personalIdNumber = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter unique employee number(range 27560000 - 27569999) and press enter");
        int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("First name : {0}", firstName);
        Console.WriteLine("Last name : {0}", lastName);
        Console.WriteLine("Age : {0}", age);
        Console.WriteLine("Gender : {0}", gender);
        Console.WriteLine("Personal ID number : {0}", personalIdNumber);
        Console.WriteLine("Unique employee number : {0}", uniqueEmployeeNumber);
    }
}

