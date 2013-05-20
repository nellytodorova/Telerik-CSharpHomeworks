using System;
using System.Numerics;

class Fibonacci
{
	static void Main()
	{
		int n = 100;
		BigInteger first = 0;
		BigInteger second = 1;
		BigInteger sum = 0;

		for (int i = 0; i < n; i++)
		{
			sum = first;
			first = second;
			second += sum;

			Console.WriteLine(sum);
		}
	}
}