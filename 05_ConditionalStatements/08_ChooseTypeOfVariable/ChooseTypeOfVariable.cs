using System;
using System.Text;
using System.Threading;
using System.Globalization;

class ChooseTypeOfVariable
{
	static void Main()
	{
		int usersChoice;
		int number;
		double realNumber;

		// Change the decimal separator to "."
		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

		Console.WriteLine("Please enter what type of variable you will be entering:");
		Console.WriteLine("0 for an integer number");
		Console.WriteLine("1 for a double number");
		Console.WriteLine("2 for a string");

		string str = Console.ReadLine();

		if (!int.TryParse(str, out usersChoice))
		{
			Console.WriteLine("Invalid number: {0}", str);
		}
		else
		{
			switch (usersChoice)
			{
				case 0:
					Console.Write("Enter the variable: ");

					str = Console.ReadLine();

					if (!int.TryParse(str, out number))
					{
						Console.WriteLine("Invalid number: {0}", str);
					}
					else
					{
						number++;
						Console.WriteLine("The new number is: {0}", number);
					}

					break;

				case 1:
					Console.Write("Enter the variable: ");
					
					str = Console.ReadLine();

					if (!double.TryParse(str, out realNumber))
					{
						Console.WriteLine("Invalid number: {0}", str);
					}
					else
					{
						realNumber++;
						Console.WriteLine("The new number is: {0}", realNumber);
					}

					break;

				case 2:
					Console.Write("Enter the variable: ");
					string text = Console.ReadLine();

					text += '*';
					Console.WriteLine("The new string is: {0}", text);

					break;

				default: Console.WriteLine("Please enter correct number from the list!");
					break;
			}
		}
	}
}