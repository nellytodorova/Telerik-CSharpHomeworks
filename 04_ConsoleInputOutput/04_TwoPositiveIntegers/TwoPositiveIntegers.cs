using System;

class TwoPositiveIntegers
{
	static void Main()
	{
		uint a;
		uint b;
		uint count = 0;

		Console.Write("Please enter a number: ");
		string firstStr = Console.ReadLine();

		Console.Write("Please enter a number: ");
		string secondStr = Console.ReadLine();

		if (!uint.TryParse(firstStr, out a))
		{
			Console.WriteLine("Invalid number: {0}", firstStr);
		}
		else if (!uint.TryParse(secondStr, out b))
		{
			Console.WriteLine("Invalid number: {0}", secondStr);
		}
		else
		{
			for (uint i = a; i <= b; i++)
			{
				if (i % 5 == 0)
				{
					count++;
				}
			}

			Console.WriteLine("There are {0} numbers that can be divided to 5 with remainder 0.", count);
		}
	}
}