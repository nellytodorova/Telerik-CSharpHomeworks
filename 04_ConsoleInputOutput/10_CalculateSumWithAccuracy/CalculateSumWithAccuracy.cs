using System;
using System.Text;
using System.Threading;
using System.Globalization;

class CalculateSumWithAccuracy
{
	static void Main()
	{
		// Change the decimal separator to "."
		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

		double curentSum = 0.00;
		double previousSum = 0.00;

		for (int i = 1; i < 100000; i++)
		{
			if (i == 1)
			{
				curentSum += 1;
			}
			else
			{
				curentSum += (1.00 / i);
			}

			if (i > 2 && (curentSum - previousSum) <= 0.001)
			{
				Console.WriteLine("On the {0} iteration the accuracy is 0.001.", i);
				Console.WriteLine("Previous sum: {0}", previousSum);
				Console.WriteLine("Current sum: {0}", curentSum);
				break;
			}

			// Store the current sum in order to use it when we have the next sum
			previousSum = curentSum;
		}
	}
}