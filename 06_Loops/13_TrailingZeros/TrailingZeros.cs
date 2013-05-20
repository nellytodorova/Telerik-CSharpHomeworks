using System;

/*
 * 13. * Write a program that calculates for given N how many trailing zeros 
 * present at the end of the number N!. 
 * Examples:
 * N = 10 -> N! = 3628800 -> 2
 * N = 20 -> N! = 2432902008176640000 -> 4
 * Does your program work for N = 50 000?
 * Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!
 */
class TrailingZeros
{
	static void Main()
	{
		int n;
		int numZeros = 0;

		Console.Write("N = ");
		string strN = Console.ReadLine();

		if (!int.TryParse(strN, out n))
		{
			Console.WriteLine("Invalid number: {0}", strN);
		}
		else
		{
			for (int i = 5; i <= n; i *= 5)
			{
				numZeros += (n / i);
			}

			Console.WriteLine("The number oz trailing zeros of {0}! are {1}.", n, numZeros);
		}
	}
}