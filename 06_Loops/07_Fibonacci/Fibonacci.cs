using System;
using System.Numerics;

/*
 * 7. Write a program that reads a number N and calculates the sum of the first N members 
 * of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 */
class Fibonacci
{
	static void Main()
	{
		int n;
		BigInteger first = 0;
		BigInteger second = 1;
		BigInteger tmp = 0;
		BigInteger sum = 0;

		Console.Write("N = ");
		string strN = Console.ReadLine();

		if (!int.TryParse(strN, out n))
		{
			Console.WriteLine("Invalid number: {0}", strN);
		}
		else
		{
			for (int i = 0; i < n; i++)
			{
				tmp = first;
				first = second;
				second += tmp;

				sum += tmp;
			}

			Console.WriteLine("The sum of the element to N is {0}.", sum);
		}
	}
}