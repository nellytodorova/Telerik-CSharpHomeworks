using System;
using System.Numerics;

/*
 * 5. Write a program that calculates N!*K! / (K-N)! for given N and K (1 < N < K).
 */
class CalculateNFaktMultiplyKFact
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
			if (k > n && n > 1)
			{
				for (uint i = 1; i <= k; i++)
				{
					if (i <= n)
					{
						result *= i;
					}

					if (i >= (k - n + 1))
					{
						result *= i;
					}
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