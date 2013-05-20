using System;
using System.Globalization;
using System.Threading;

class MathExpression
{
	static void Main()
	{
		// Setting invariant culture to avoid problems with floating point
		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

		decimal N = decimal.Parse(Console.ReadLine());
		decimal M = decimal.Parse(Console.ReadLine());
		decimal P = decimal.Parse(Console.ReadLine());
		decimal constant = 128.523123123m;

		decimal result = ((((N * N) + (1 / (M * P)) + 1337) / (N - constant * P)) + (decimal)Math.Sin((int)M % 180));

		Console.WriteLine("{0:0.000000}", result);
	}
}
