using System;
using System.Text;
using System.Threading;
using System.Globalization;

class ThreeRealNumbers
{
	static void Main()
	{
		double a;
		double b;
		double c;
		int countPositive = 0;
		int countNegative = 0;

		// Change the decimal separator to "."
		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

		Console.Write("Please enter the first number: ");
		string firstStr = Console.ReadLine();

		Console.Write("Please enter the second number: ");
		string secondStr = Console.ReadLine();

		Console.Write("Please enter the third number: ");
		string thirdStr = Console.ReadLine();

		if (!double.TryParse(firstStr, out a))
		{
			Console.WriteLine("Invalid number: {0}", firstStr);
		}
		else if (!double.TryParse(secondStr, out b))
		{
			Console.WriteLine("Invalid number: {0}", secondStr);
		}
		else if (!double.TryParse(thirdStr, out c))
		{
			Console.WriteLine("Invalid number: {0}", thirdStr);
		}
		else
		{
			if (a == 0 || b == 0 || c == 0)
			{
				Console.WriteLine("The product is 0.");
			}
			else
			{
				if (a > 0)
				{
					countPositive++;
				}
				else
				{
					countNegative++;
				}

				if (b > 0)
				{
					countPositive++;
				}
				else
				{
					countNegative++;
				}

				if (c > 0)
				{
					countPositive++;
				}
				else
				{
					countNegative++;
				}

				if (countNegative % 2 == 0)
				{
					Console.WriteLine("The sign of product is +.");
				}
				else
				{
					Console.WriteLine("The sign of product is -.");
				}
			}
		}
	}
}