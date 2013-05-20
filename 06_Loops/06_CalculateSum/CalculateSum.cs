using System;

/*
 * 6. Write a program that, for a given two integer numbers N and X, 
 * calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
 */
class CalculateSum
{
	static void Main()
	{
		decimal n;
		decimal x;
		decimal sum = 0.00m;
		decimal factoriel = 1.00m;
		decimal power = 1.00m;

		Console.Write("N = ");
		string strN = Console.ReadLine();

		Console.Write("X = ");
		string strX = Console.ReadLine();

		if (!decimal.TryParse(strN, out n))
		{
			Console.WriteLine("Invalid number: {0}", strN);
		}
		else if (!decimal.TryParse(strX, out x))
		{
			Console.WriteLine("Invalid number: {0}", strX);
		}
		else
		{
			for (int i = 1; i <= n; i++)
			{
				factoriel *= i;
				power *= x;

				sum += factoriel / power;
			}

			Console.WriteLine("The sum is: {0}", 1 + sum);
		}
	}
}