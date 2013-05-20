using System;

/*
 * 1. Write a program that prints all the numbers from 1 to N.
 */
class Numbers1toN
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
				Console.WriteLine(i);
			}
		}	
	}
}