using System;
using System.Text;
using System.Threading;
using System.Globalization;

class Circle
{
	static void Main()
	{
		double r;

		// Change the decimal separator to "."
		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

		Console.Write("Please enter the radius: ");
		string str = Console.ReadLine();

		if (!double.TryParse(str, out r))
		{
			Console.WriteLine("Invalid number: {0}", str);
		}
		else 
		{
			Console.WriteLine("The perimeter of the circle is: " + (2 * Math.PI * r));
			Console.WriteLine("The area of the circle is: " + (Math.PI * r * r));
		}
	}
}