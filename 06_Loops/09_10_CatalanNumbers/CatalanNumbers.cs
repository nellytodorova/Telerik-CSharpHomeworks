using System;
using System.Numerics;

/*
 * 9. 10. Write a program to calculate the Nth Catalan number by given N.
 */
class CatalanNumbers
{

	static BigInteger Faktorial(BigInteger num)
	{
		BigInteger fakt = 1;

		for (int i = 1; i <= num; i++)
		{
			fakt *= i;
		}

		return fakt;
	}
	
	static void Main()
	{
		BigInteger n;
		BigInteger result;

		Console.Write("N = ");
		string strN = Console.ReadLine();

		if (!BigInteger.TryParse(strN, out n))
		{
			Console.WriteLine("Invalid number: {0}", strN);
		}

		result = Faktorial(2 * n) / (Faktorial(n + 1) * Faktorial(n));

		Console.WriteLine(result);
	}
}