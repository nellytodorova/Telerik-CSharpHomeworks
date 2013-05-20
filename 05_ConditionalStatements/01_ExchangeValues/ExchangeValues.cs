using System;

class ExchangeValues
{
	static void Main()
	{
		int firstInt;
		int secondInt;

		Console.Write("Please enter the first number: ");
		string firstStr = Console.ReadLine();

		Console.Write("Please enter the second number: ");
		string secondStr = Console.ReadLine();

		if (!int.TryParse(firstStr, out firstInt))
		{
			Console.WriteLine("Invalid number: {0}", firstStr);
		}
		else if (!int.TryParse(secondStr, out secondInt))
		{
			Console.WriteLine("Invalid number: {0}", secondStr);
		}
		else
		{
			int smaller = firstInt;

			if (firstInt > secondInt)
			{
				firstInt = secondInt;
				secondInt = smaller;
			}

			Console.WriteLine("The first number is: {0}", firstInt);
			Console.WriteLine("The second number is: {0}", secondInt);
		}
	}
}