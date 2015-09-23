using System;
using System.Globalization;

class NumberAsWords
{
    static void Main()
    {
        //Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
       
        Console.WriteLine("Please enter a number");
        int number = int.Parse(Console.ReadLine());

        string hundreds = "";
        string tens = "";
        string ones = "";
        string numberAsWord;
        string upperCaseNumberAsWord;

        int onesCounter = (number % 100) % 10;
        int tensCounter = (number % 100) / 10;
        int hundredsCounter = number / 100;

        if (number < 0 || number > 999)
        {
            Console.WriteLine("number out of range");
        }

        else
        {
            switch (onesCounter)
            {
                case 1: ones = "one"; 
                    break;
                case 2: ones = "two"; 
                    break;
                case 3: ones = "three"; 
                    break;
                case 4: ones = "four";
                    break;
                case 5: ones = "five"; 
                    break;
                case 6: ones = "six"; 
                    break;
                case 7: ones = "seven";
                    break;
                case 8: ones = "eight"; 
                    break;
                case 9: ones = "nine"; 
                    break;
                default: ones = (tensCounter > 1) ? "" : "Zero";
                    break;
            }
            switch (tensCounter)
            {
                case 1: switch (onesCounter)
                    {
                        case 0: tens = "ten"; ones = "";
                            break;
                        case 1: tens = "eleven"; ones = "";
                            break;
                        case 2: tens = "twelve"; ones = ""; 
                            break;
                        case 3: tens = "thirteen"; ones = "";
                            break;
                        case 4: tens = "fourteen"; ones = "";
                            break;
                        case 5: tens = "fifteen"; ones = ""; 
                            break;
                        case 6: tens = "sixteen"; ones = ""; 
                            break;
                        case 7: tens = "seventeen"; ones = ""; 
                            break;
                        case 8: tens = "eighteen"; ones = ""; 
                            break;
                        case 9: tens = "nineteen"; ones = ""; 
                            break;
                        default: tens = "";
                            break;
                    };
                    break;
                case 2: tens = "twenty ";
                    break;
                case 3: tens = "thirty "; 
                    break;
                case 4: tens = "fourty "; 
                    break;
                case 5: tens = "fifty ";
                    break;
                case 6: tens = "sixty "; 
                    break;
                case 7: tens = "seventy "; 
                    break;
                case 8: tens = "eighty ";
                    break;
                case 9: tens = "ninety "; 
                    break;
                default: tens = ""; 
                    break;
            }

            switch (hundredsCounter)
            {
                case 1: hundreds = "one hundred "; 
                    break;
                case 2: hundreds = "two hundred ";
                    break;
                case 3: hundreds = "three hundred "; 
                    break;
                case 4: hundreds = "four hundred "; 
                    break;
                case 5: hundreds = "five hundred ";
                    break;
                case 6: hundreds = "six hundred "; 
                    break;
                case 7: hundreds = "seven hundred "; 
                    break;
                case 8: hundreds = "eight hundred "; 
                    break;
                case 9: hundreds = "nine hundred ";
                    break;
                default: hundreds = "";
                    break;
            }

            if (hundredsCounter > 0)
            {
                hundreds = hundreds + "and ";
            }

            numberAsWord = hundreds + tens + ones;
            upperCaseNumberAsWord = char.ToUpper(numberAsWord[0]) + numberAsWord.Substring(1);

            Console.WriteLine("{0}", upperCaseNumberAsWord);
        }
    }
}

