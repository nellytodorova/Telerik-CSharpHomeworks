using System;

class PrintNumbersToN
{
	static void Main()
	{
		Console.Write("Please enter N: ");
		int n = Int32.Parse(Console.ReadLine());

		while (n < 0)
		{
			Console.WriteLine("Please enter positive a number!");
			n = int.Parse(Console.ReadLine());
		}

		for (int i = 1; i <= n; i++)
		{
			Console.WriteLine(i);
		}
	}
}