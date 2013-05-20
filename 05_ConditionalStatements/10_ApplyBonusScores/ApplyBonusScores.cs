using System;

class ApplyBonusScores
{
	static void Main()
	{
		int digit;

		Console.Write("Please enter а number into the range [1..9]: ");
		string str = Console.ReadLine();

		if (!int.TryParse(str, out digit))
		{
			Console.WriteLine("Invalid number: {0}", str);
		}
		else
		{
			while (digit <= 1 || digit >= 9)
			{
				Console.WriteLine("Please enter correct number!");
				string strSecond = Console.ReadLine();

				if (!int.TryParse(strSecond, out digit))
				{
					Console.WriteLine("Invalid number: {0}", strSecond);
				}
			}

			switch (digit)
			{
				case 1:
				case 2:
				case 3:
					digit *= 10;
					break;

				case 4:
				case 5:
				case 6:
					digit *= 100;
					break;

				case 7:
				case 8:
				case 9:
					digit *= 1000;
					break;

				default:
					Console.WriteLine("Wrong number entered!");
					break;
			}

			Console.WriteLine("The new value is {0}.", digit);
		}
	}
}