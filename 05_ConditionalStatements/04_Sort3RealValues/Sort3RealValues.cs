using System;
using System.Text;
using System.Threading;
using System.Globalization;

class Sort3RealValues
{
	static void Main()
	{
		double a;
		double b;
		double c;
		double tmp;

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
			if (b < a && b < c)
			{
				tmp = a;
				a = b;
				b = tmp;
			}
			else if (c < a && c < b)
			{
				tmp = a;
				a = c;
				c = tmp;
			}

			if (c < b)
			{
				tmp = c;
				c = b;
				b = tmp;
			}

			Console.WriteLine("{0}, {1}, {2}", c, b, a);
		}	
	}
}