using System;

class BankAccountData
{
    static void Main()
    {
        // A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
        // Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

        Console.WriteLine("Enter first name of the account holder and press enter");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter middle name of the account holder and press enter");
        string middleName = Console.ReadLine();

        Console.WriteLine("Enter last name of the account holder and press enter");
        string lastName = Console.ReadLine();
        string holderName = firstName + " " + middleName + " " + lastName;

        Console.WriteLine("Enter balance and press enter");
        decimal balance = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter bank name and press enter");
        string bankName = Console.ReadLine();

        Console.WriteLine("Enter IBAN and press enter (example  BG80 BNBG 9661 1020 3456 78)");
        string iban = Console.ReadLine();

        Console.WriteLine("Enter first credit card number and press enter  (max 15 digits example 372377592965562) ");
        long firstCardNumber = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter second credit card number and press enter (max 15 digits example 372377592965562)");
        long secondCardNumber = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter third credit card number and press enter (max 15 digits example 372377592965562)");
        long thirdCardNumber = long.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Bank account data");
        Console.WriteLine("Holder name : {0}", holderName);
        Console.WriteLine("Balance : BGN {0}", balance);
        Console.WriteLine("Bank name : {0}", bankName);
        Console.WriteLine("IBAN : {0}", iban);
        Console.WriteLine("First credit card number : {0}", firstCardNumber);
        Console.WriteLine("Second credit card number : {0}", secondCardNumber);
        Console.WriteLine("Third credit card number : {0}", thirdCardNumber);
    }
}