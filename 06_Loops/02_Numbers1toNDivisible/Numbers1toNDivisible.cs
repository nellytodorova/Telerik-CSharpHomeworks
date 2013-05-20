using System;

/*
 * 2. Write a program that prints all the numbers from 1 to N, 
 * that are not divisible by 3 and 7 at the same time.
 */
class Numbers1toNDivisible
{
	static void Main()
	{
		int n;

		Console.Write("Please enter N: ");
		string str = Console.ReadLine();

		if (!int.TryParse(str, out n))
		{
			Console.WriteLine("Invalid number: {0}", str);
		}
		else
		{
			for (int i = 1; i <= n; i++)
			{
				if (i % (3 * 7) != 0)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}