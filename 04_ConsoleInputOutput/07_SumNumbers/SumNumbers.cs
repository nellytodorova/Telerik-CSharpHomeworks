using System;

class SumNumbers
{
	static void Main()
	{
		int n;
		int number;
		int sum = 0;

		Console.Write("Please enter how many numbers do you want to sum: ");
		string str = Console.ReadLine();

		if (!int.TryParse(str, out n))
		{
			Console.WriteLine("Invalid number: {0}", str);
		}
		else
		{
			while (n < 0)
			{
				Console.WriteLine("Please enter positive a number!");
				str = Console.ReadLine();

				if (!int.TryParse(str, out n))
				{
					Console.WriteLine("Invalid number: {0}", str);
				}
			}

			for (int i = 0; i < n; i++)
			{
				Console.Write("Enter the next number: ");
				str = Console.ReadLine();

				if (!int.TryParse(str, out number))
				{
					Console.WriteLine("Invalid number: {0}", str);
				}

				sum += number;
			}

			Console.WriteLine("The sum of the entered numbers is: {0}", sum);
		}
	}
}