using System;

class PrintDeckOfCards
{
    static void Main()
    {
        // Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
        // The card faces should start from 2 to A.
        // Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement
       
        string cardFace = "";
        string cardSuit = "";

        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (j)
                {
                    case 1: cardSuit = "of spades,";
                        break;
                    case 2: cardSuit = "of clubs,"; 
                        break;
                    case 3: cardSuit = "of hearts,";
                        break;
                    case 4: cardSuit = "of diamonds"; 
                        break;
                }

                cardFace = i.ToString();
                switch (i)
                {
                    case 11: cardFace = "J"; 
                        break;
                    case 12: cardFace = "Q"; 
                        break;
                    case 13: cardFace = "K"; 
                        break;
                    case 14: cardFace = "A"; 
                        break;
                }

                Console.Write("{0} {1}", cardFace, cardSuit);
            }

            Console.WriteLine();
        }
    }
}