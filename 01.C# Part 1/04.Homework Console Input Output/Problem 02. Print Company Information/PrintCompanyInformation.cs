using System;

class PrintCompanyInformation
{
    static void Main()
    {
        //  A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
        //  Write a program that reads the information about a company and its manager and prints it back on the console.
        Console.WriteLine("Please enter company name");
        string companyName = Console.ReadLine();

        Console.WriteLine("Please enter company address");
        string companyAddress = Console.ReadLine();

        Console.WriteLine("Please enter company phone number");
        string companyPhoneNumber = Console.ReadLine();

        Console.WriteLine("Please enter company fax number");
        string companyFaxNumber = Console.ReadLine();

        Console.WriteLine("Please enter company web site");
        string companyWebSite = Console.ReadLine();

        Console.WriteLine("Please enter manager first name");
        string managerFirstName = Console.ReadLine();

        Console.WriteLine("Please enter manager last name");
        string managerLastName = Console.ReadLine();

        Console.WriteLine("Please enter manager age");
        byte managerAge = byte.Parse(Console.ReadLine());

        Console.WriteLine("Please enter manager phone number");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine("Company information");
        Console.WriteLine("{0}", companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhoneNumber);

        if (companyFaxNumber.Length == companyPhoneNumber.Length)
        {
            Console.WriteLine("Fax: {0}", companyFaxNumber);
        }

        else
        {
            Console.WriteLine("Fax: (no fax)");
        }

        Console.WriteLine("Web site: {0}", companyWebSite);
        Console.WriteLine("Manager: {0} {1} (age:{2}, tel.{3})", managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}

