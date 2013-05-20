using System;

/*
 * 8. Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
 * Use the Euclidean algorithm.
 */
class GreatestCommonDivisor
{
	static void Main()
	{
		uint a;
		uint b;
		uint tmp;
		uint gcd;

		Console.Write("A = ");
		string strA = Console.ReadLine();

		Console.Write("B = ");
		string strB = Console.ReadLine();

		if (!uint.TryParse(strA, out a))
		{
			Console.WriteLine("Invalid number: {0}", strA);
		}
		else if (!uint.TryParse(strB, out b))
		{
			Console.WriteLine("Invalid number: {0}", strB);
		}
		else
		{
			if (a == 0 && b > 0)
			{
				gcd = b;
			}
			else if (b == 0 && a > 0)
			{
				gcd = a;
			}
			else if (a > 0 && b > 0)
			{
				while (b > 0)
				{
					tmp = b;
					b = a % b;
					a = tmp;
				}

				gcd = a;

				Console.WriteLine("The GCD is {0}.", gcd);
			}
		}
	}
}