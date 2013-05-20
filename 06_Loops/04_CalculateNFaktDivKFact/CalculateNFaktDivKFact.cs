using System;
using System.Numerics;

/*
 * 4. Write a program that calculates N!/K! for given N and K (1 < K < N).
 */
class CalculateNFaktDivKFact
{
	static void Main()
	{
		uint n;
		uint k;
		BigInteger result = 1;

		Console.Write("N = ");
		string strN = Console.ReadLine();

		Console.Write("K = ");
		string strK = Console.ReadLine();

		if (!uint.TryParse(strN, out n))
		{
			Console.WriteLine("Invalid number: {0}", strN);
		}
		else if (!uint.TryParse(strK, out k))
		{
			Console.WriteLine("Invalid number: {0}", strK);
		}
		else
		{
			if (k < n && k > 1)
			{
				for (uint i = k + 1; i <= n; i++)
				{
					result *= i;
				}

				Console.WriteLine("The result is: {0}", result);
			}
			else
			{
				Console.WriteLine("Wrong numbers entered!");
			}
		}
	}
}