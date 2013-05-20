using System;

/*
 * 11. Write a program that prints all possible cards from a standard deck of 
 * 52 cards (without jokers). The cards should be printed with their English names. 
 * Use nested for loops and switch-case.
 */
class Cards
{
	static void Main()
	{
		string[] cards = {"Two of", "Three of", "Four of", "Five of", "Six of", "Seven of", 
						  "Eight of", "Nine of", "Ten of", "King of", "Queen of", "Knave of", "Ace of"};

		for (int i = 0; i < cards.Length; i++)
		{
			for (int j = 1; j < 5; j++)
			{
				Console.Write(cards[i]);

				switch (j)
				{
					case 1:
						Console.WriteLine(" Spades");
						break;

					case 2:
						Console.WriteLine(" Hearts");
						break;

					case 3:
						Console.WriteLine(" Diamonds");
						break;

					case 4:
						Console.WriteLine(" Clubs");
						break;

					default:
						Console.WriteLine("Error!");
						break;
				}
			}
		}
	}
}