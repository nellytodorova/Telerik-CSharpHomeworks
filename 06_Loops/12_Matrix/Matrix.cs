using System;

/*
 * 12. Write a program that reads from the console a positive integer 
 * number N (N < 20) and outputs a matrix.
 */
class Matrix
{
	static void Main()
	{
		uint n;

		Console.Write("N = ");
		string strN = Console.ReadLine();

		if (!uint.TryParse(strN, out n))
		{
			Console.WriteLine("Invalid number: {0}", strN);
		}
		else
		{
			if (n < 20)
			{
				for (int i = 1; i <= n; i++)
				{
					for (int j = i; j <= i + n - 1; j++)
					{
						Console.Write(Convert.ToString(j).PadLeft(3, ' '), j);
					}

					Console.WriteLine();
				}
			}
			else
			{
				Console.WriteLine("The entered number must be less than 20!");
			}
		}
	}
}