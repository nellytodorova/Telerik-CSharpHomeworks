using System;
using System.Numerics;

class Tribonacci
{
	static void Main()
	{
		BigInteger a = BigInteger.Parse(Console.ReadLine());
		BigInteger b = BigInteger.Parse(Console.ReadLine());
		BigInteger c = BigInteger.Parse(Console.ReadLine());

		int n = int.Parse(Console.ReadLine());

		if (n >= 4)
		{
			for (int i = 4; i <= n; i++)
			{
				BigInteger newNumber = a + b + c;
				a = b;
				b = c;
				c = newNumber;
			}

			Console.WriteLine(c);
		}
		else
		{
			if (n == 1)
			{
				Console.WriteLine(a);
			}
			else if (n == 2)
			{
				Console.WriteLine(b);
			}
			else if (n == 3)
			{
				Console.WriteLine(c);
			}
		}
	}
}