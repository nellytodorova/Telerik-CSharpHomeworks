using System;

class QuadraticEquation
{
	static void Main()
	{
		int a;
		int b;
		int c;
		double x1;
		double x2;

		Console.Write("Please enter the first number: ");
		string firstStr = Console.ReadLine();

		Console.Write("Please enter the second number: ");
		string secondStr = Console.ReadLine();

		Console.Write("Please enter the third number: ");
		string thirdStr = Console.ReadLine();

		if (!int.TryParse(firstStr, out a))
		{
			Console.WriteLine("Invalid number: {0}", firstStr);
		}
		else if (!int.TryParse(secondStr, out b))
		{
			Console.WriteLine("Invalid number: {0}", secondStr);
		}
		else if (!int.TryParse(thirdStr, out c))
		{
			Console.WriteLine("Invalid number: {0}", thirdStr);
		}
		else
		{
			while (a == 0)
			{
				Console.WriteLine("A must be different from 0!");
				string str = Console.ReadLine();

				if (!int.TryParse(str, out a))
				{
					Console.WriteLine("Invalid number: {0}", str);
				}
			}

			// Calculate the discriminant
			double d = b * b - 4 * a * c;

			if (d < 0)
			{
				Console.WriteLine("The equation doesn't have any real roots.");
			}
			else if (d == 0)
			{
				x1 = (-b) / 2 * a;
				Console.WriteLine("The equation have only one real root: {0}", x1);
			}
			else
			{
				x1 = (-b) + Math.Sqrt(d) / 2 * a;
				x2 = (-b) - Math.Sqrt(d) / 2 * a;
				Console.WriteLine("The real roots are:");
				Console.WriteLine("X1 is {0} and X2 is {1}", x1, x2);
			}
		}
	}
}