using System;

class NumberToPronunciation
{
	static void Main()
	{
		int digit;

		Console.Write("Please enter а number into the range [0..999]: ");
		string str = Console.ReadLine();

		if (!int.TryParse(str, out digit))
		{
			Console.WriteLine("Invalid number: {0}", str);
		}
		else
		{
			while (digit < 0 || digit > 999)
			{
				Console.WriteLine("Please enter correct number!");
				string strSecond = Console.ReadLine();

				if (!int.TryParse(strSecond, out digit))
				{
					Console.WriteLine("Invalid number: {0}", strSecond);
				}
			}

			int hundreds = digit / 100;
			int tens = (digit / 10) % 10;
			int tensBigger = digit % 100; //Tens used to check whether they are more or less than 20
			int units = (tensBigger) % 10;

			string[] numberText = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", 
								"nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", 
								"sixteen", "seventeen", "eitheen", "nineteen" };

			string[] tensText = { "twenty", "thirty", "fourthy", "fifthy", "sixty", "seventy", "eithy", "ninety" };

			string pronunciation = "";
			string andHundreds = "";

			// Get text only for numbers between 0 and 19
			if (digit >= 0 && digit <= 19)
			{
				pronunciation += numberText[digit];
			}
			else
			{
				if (hundreds > 0)
				{
					pronunciation += numberText[hundreds] + " " + "hundred";
					andHundreds = " and ";
				}

				if (tens > 0)
				{
					if (tensBigger > 20)
					{
						// Tens is - 2 because the tensText starts from the text twenty
						pronunciation += andHundreds + tensText[tens - 2];
					}
					else
					{
						pronunciation += andHundreds + numberText[tensBigger];
					}
				}
				else
				{
					// If tens are 0
					pronunciation += " and " + numberText[units];
				}

				if (tensBigger > 20 && units > 0)
				{
					pronunciation += " " + numberText[units];
				}

			}

			Console.WriteLine(char.ToUpper(pronunciation[0]) + pronunciation.Substring(1) + '.');
		}
	}
}